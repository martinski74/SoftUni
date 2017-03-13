using BankSysytem.Data;
using BankSysytem.Models;
using BankSysytem.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BankSysytem.Core
{
    public class CommandExecutor
    {
        public string Execute(string input)
        {
            string[] inputArgs = input.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string commandName = input.Length != 0 ? inputArgs[0].ToLower() : string.Empty;

            inputArgs = inputArgs.Skip(1).ToArray();
            string output;
            switch (commandName)
            {
                case "register":
                    // Validation
                    output = this.RegisterUser(inputArgs);
                    break;
                case "login":
                    output = this.LoginUser(inputArgs);
                    break;
                case "logout":
                    output = this.Logout();
                    break;
                case "exit":
                    output = this.Exit();
                    break;
                case "add":
                    output = this.AddAccount(inputArgs);
                    break;
                case "deposit":
                    output = this.DepositMoney(inputArgs);
                    break;
                case "withdraw":
                    output = this.WithdrawMoney(inputArgs);
                    break;

                // List Accounts
                case "listaccounts":
                    output = this.ListAccounts();
                    break;

                // Deduct Fee
                case "deductfee":
                    output = this.DeductFee(inputArgs);
                    break;

                // Add Interest
                case "addinterest":
                    output = this.AddInterest(inputArgs);
                    break;
                default:
                    throw new ArgumentException($"Command \"{commandName}\" not supported!");
            }

            return output;
        }

        private string RegisterUser(string[] input)
        {
            if (input.Length != 3)
            {
                throw new ArgumentException("Input is not valid!");
            }

            if (AuthenticationManager.IsAuthenticated())
            {
                throw new InvalidOperationException("You should log out before log in another user!");
            }

            // Register <username> <password> <email>
            string username = input[0];
            string password = input[1];
            string email = input[2];

            User user = new User()
            {
                Username = username,
                Password = password,
                Email = email
            };

            this.ValidateUser(user);

            using (BankSystemContext context = new BankSystemContext())
            {
                if (context.Users.Any(u => u.Username == username))
                {
                    throw new ArgumentException("Username already taken!");
                }

                if (context.Users.Any(u => u.Email == email))
                {
                    throw new ArgumentException("Email already taken!");
                }

                context.Users.Add(user);
                context.SaveChanges();
            }

            return $"User {username} registered successfully!";
        }

        private string LoginUser(string[] input)
        {
            if (input.Length != 2)
            {
                throw new ArgumentException("Input is not valid!");
            }

            if (AuthenticationManager.IsAuthenticated())
            {
                throw new InvalidOperationException("You should logout first!");
            }

            // Login <username> <password> 
            string username = input[0];
            string password = input[1];

            using (BankSystemContext context = new BankSystemContext())
            {
                User user = context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

                if (user == null)
                {
                    throw new ArgumentException("Invalid username/password!");
                }

                AuthenticationManager.Login(user);
            }

            return $"User {username} logged in successfully!";
        }

        private string Logout()
        {
            if (!AuthenticationManager.IsAuthenticated())
            {
                throw new InvalidOperationException("You should log in first!");
            }

            User user = AuthenticationManager.GetCurrentUser();
            AuthenticationManager.Logout();

            return $"User {user.Username} successfully logged out!";
        }

        private string AddAccount(string[] input)
        {
            if (input.Length != 3)
            {
                throw new ArgumentException("Input is not valid!");
            }

            // Add SavingAccount <initial balance> <interest rate>
            if (!AuthenticationManager.IsAuthenticated())
            {
                throw new InvalidOperationException("You should log in first!");
            }

            string accountType = input[0];

            string accountNumber = AccountNumberGenerator.GenerateAccountNumber();
            decimal balance = decimal.Parse(input[1]);
            decimal rateOrFee = decimal.Parse(input[2]);

            // Check type of account to add and throw exception if type is not valid.
            if (accountType.Equals("CheckingAccount", StringComparison.OrdinalIgnoreCase))
            {
                CheckingAccount checkingAccount = new CheckingAccount()
                {
                    AccountNumber = accountNumber,
                    Balance = balance,
                    Fee = rateOrFee
                };

                this.ValidateCheckingAccount(checkingAccount);

                using (BankSystemContext context = new BankSystemContext())
                {
                    // Attaching currently logged-in user means that we are working with the same user entity as in our database.
                    User user = AuthenticationManager.GetCurrentUser();
                    context.Users.Attach(user);
                    checkingAccount.User = user;

                    context.CheckingAccounts.Add(checkingAccount);
                    context.SaveChanges();
                }
            }
            else if (accountType.Equals("SavingAccount", StringComparison.OrdinalIgnoreCase))
            {
                SavingAccount savingAccount = new SavingAccount()
                {
                    AccountNumber = accountNumber,
                    Balance = balance,
                    InterestRate = rateOrFee
                };

                this.ValidateSavingAccount(savingAccount);

                using (BankSystemContext context = new BankSystemContext())
                {
                    User user = AuthenticationManager.GetCurrentUser();
                    context.Users.Attach(user);
                    savingAccount.User = user;

                    context.SavingAccounts.Add(savingAccount);
                    context.SaveChanges();
                }
            }
            else
            {
                throw new ArgumentException($"Invalid account type {accountType}!");
            }

            return $"Account with number {accountNumber} successfully added.";
        }

        private string DepositMoney(string[] input)
        {
            if (input.Length != 2)
            {
                throw new ArgumentException("Input is not valid!");
            }

            if (!AuthenticationManager.IsAuthenticated())
            {
                throw new InvalidOperationException("You should log in first!");
            }

            // Deposit <Account number> <money> 
            string accountNumber = input[0];
            decimal amount = decimal.Parse(input[1]);
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount should be positive!");
            }

            decimal currentBalance;

            using (BankSystemContext context = new BankSystemContext())
            {
                // Try to find the account specified.
                User user = context.Users.Attach(AuthenticationManager.GetCurrentUser());
                SavingAccount savingAccount = user.SavingAccounts.FirstOrDefault(a => a.AccountNumber == accountNumber);

                CheckingAccount checkingAccount = user.CheckingAccounts.FirstOrDefault(a => a.AccountNumber == accountNumber);

                // If not any accounts were not found throw exception. 
                if (savingAccount == null && checkingAccount == null)
                {
                    throw new ArgumentException($"Account {accountNumber} does not exist!");
                }

                if (savingAccount != null)
                {
                    savingAccount.Balance += amount;
                    currentBalance = savingAccount.Balance;
                }
                else
                {
                    // NOTE: What about if we have both saving and checking account?
                    checkingAccount.Balance += amount;
                    currentBalance = checkingAccount.Balance;
                }

                context.SaveChanges();
            }

            return $"Account {accountNumber} - ${currentBalance}";
        }

        private string WithdrawMoney(string[] input)
        {
            if (input.Length != 2)
            {
                throw new ArgumentException("Input is not valid!");
            }

            if (!AuthenticationManager.IsAuthenticated())
            {
                throw new InvalidOperationException("You should log in first!");
            }

            // withdraw <Account number> <money> 
            string accountNumber = input[0];
            decimal amount = decimal.Parse(input[1]);
            if (amount <= 0)
            {
                throw new ArgumentException("Withdraw amount should be positive!");
            }

            decimal currentBalance;

            using (BankSystemContext context = new BankSystemContext())
            {
                User user = context.Users.Attach(AuthenticationManager.GetCurrentUser());
                SavingAccount savingAccount = user.SavingAccounts.FirstOrDefault(a => a.AccountNumber == accountNumber);

                CheckingAccount checkingAccount = user.CheckingAccounts.FirstOrDefault(a => a.AccountNumber == accountNumber);

                if (savingAccount == null && checkingAccount == null)
                {
                    throw new ArgumentException($"Account {accountNumber} does not exist!");
                }

                if (savingAccount != null)
                {
                    savingAccount.Balance -= amount;
                    currentBalance = savingAccount.Balance;
                }
                else
                {
                    checkingAccount.Balance -= amount;
                    currentBalance = checkingAccount.Balance;
                }

                context.SaveChanges();
            }

            return $"Account {accountNumber} - ${currentBalance}";
        }

        private string ListAccounts()
        {
            if (!AuthenticationManager.IsAuthenticated())
            {
                throw new InvalidOperationException("You should log in first!");
            }

            StringBuilder builder = new StringBuilder();
            using (BankSystemContext context = new BankSystemContext())
            {
                User user = context.Users.Attach(AuthenticationManager.GetCurrentUser());

                builder.AppendLine("Saving Accounts:");
                foreach (SavingAccount userSavingAccount in user.SavingAccounts)
                {
                    builder.AppendLine($"--{userSavingAccount.AccountNumber} {userSavingAccount.Balance}");
                }

                builder.AppendLine("Checking Accounts:");
                foreach (CheckingAccount checkingAccount in user.CheckingAccounts)
                {
                    builder.AppendLine($"--{checkingAccount.AccountNumber} {checkingAccount.Balance}");
                }
            }

            return builder.ToString().Trim();
        }

        private string DeductFee(string[] input)
        {
            if (input.Length != 1)
            {
                throw new ArgumentException("Input is not valid!");
            }

            if (!AuthenticationManager.IsAuthenticated())
            {
                throw new InvalidOperationException("You should log in first!");
            }

            // DeductFee <Account number> 
            string accountNumber = input[0];

            decimal currentBalance;

            using (BankSystemContext context = new BankSystemContext())
            {
                User user = context.Users.Attach(AuthenticationManager.GetCurrentUser());

                CheckingAccount checkingAccount = user.CheckingAccounts.FirstOrDefault(a => a.AccountNumber == accountNumber);

                if (checkingAccount == null)
                {
                    throw new ArgumentException($"Account {accountNumber} does not exist!");
                }

                checkingAccount.Balance -= checkingAccount.Fee;
                currentBalance = checkingAccount.Balance;

                context.SaveChanges();
            }

            return $"Account fee deducted {accountNumber} - ${currentBalance}";
        }

        private string AddInterest(string[] input)
        {
            if (input.Length != 1)
            {
                throw new ArgumentException("Input is not valid!");
            }

            if (!AuthenticationManager.IsAuthenticated())
            {
                throw new InvalidOperationException("You should log in first!");
            }

            // AddInterest <Account number> 
            string accountNumber = input[0];

            decimal currentBalance;

            using (BankSystemContext context = new BankSystemContext())
            {
                User user = context.Users.Attach(AuthenticationManager.GetCurrentUser());
                SavingAccount savingAccount = user.SavingAccounts.FirstOrDefault(a => a.AccountNumber == accountNumber);

                if (savingAccount == null)
                {
                    throw new ArgumentException($"Account {accountNumber} does not exist!");
                }

                savingAccount.Balance += savingAccount.Balance * savingAccount.InterestRate;
                currentBalance = savingAccount.Balance;

                context.SaveChanges();
            }

            return $"Account interest added {accountNumber} - ${currentBalance}";
        }

        private string Exit()
        {
            Environment.Exit(0);

            return string.Empty;
        }

        private void ValidateUser(User user)
        {
            bool isValid = true;
            string errors = string.Empty;
            if (user == null)
            {
                errors = "User cannot be null!";

                // If user is null there is no way that we cant it's username or password
                // (they simply ain't set) so we return directly our result.
                throw new ArgumentException(errors);
            }

            Regex usernameRegex = new Regex(@"^[a-zA-Z]+[a-zA-Z0-9]{2,}$");
            if (!usernameRegex.IsMatch(user.Username))
            {
                isValid = false;
                errors += "Username not valid!\n";
            }

            // For this regex check this article: http://stackoverflow.com/questions/1559751/regex-to-make-sure-that-the-string-contains-at-least-one-lower-case-char-upper.
            Regex passwordRegex = new Regex(@"^(?=[a-zA-Z0-9]*[A-Z])(?=[a-zA-Z0-9]*[a-z])(?=[a-zA-Z0-9]*[0-9])[a-zA-Z0-9]{6,}$");
            if (!passwordRegex.IsMatch(user.Password))
            {
                isValid = false;
                errors += "Password not valid!\n";
            }

            // Regex explanation:
            // ^ - string should start with
            // [a-zA-Z0-9]+[-|_|\.]? - any alphanumeric group (longer than 1 symbol) followed by "-" or "_" or "." exactly one time. Will match: "Dash1-"
            // ({upperPartHere})* - the upper match may happen zero or more times. Will match: "Dash1-Dot1-Hyphen1-"
            // [a-zA-Z0-9]+ - after upper match should follow at least one alphanumeric character. Will match: "Dash1-Dot1-Hyphen1".
            // The rest of the regex follows the same logic.
            Regex emailRegex = new Regex(@"^([a-zA-Z0-9]+[-|_|\.]?)*[a-zA-Z0-9]+@([a-zA-Z0-9]+[-]?)*[a-zA-Z0-9]+\.([a-zA-Z0-9]+[-]?)*[a-zA-Z0-9]+$");
            if (!emailRegex.IsMatch(user.Email))
            {
                isValid = false;
                errors += "Email not valid!\n";
            }

            if (!isValid)
            {
                // Trim new lines left after string concatenation.
                throw new ArgumentException(errors.Trim());
            }
        }

        private void ValidateSavingAccount(SavingAccount account)
        {
            string errors = string.Empty;
            bool isValid = true;

            if (account == null)
            {
                errors = "Account cant be null!";
                throw new ArgumentException(errors);
            }

            if (account.AccountNumber.Length != 10)
            {
                isValid = false;
                errors += "Account number length should be exactly 10 symbols!\n";
            }

            if (account.Balance < 0)
            {
                isValid = false;
                errors += "Account balance should be non-negative!\n";
            }

            if (account.InterestRate < 0)
            {
                isValid = false;
                errors += "Account interest rate should be non-negative!\n";
            }

            if (!isValid)
            {
                throw new ArgumentException(errors.Trim());
            }
        }

        private void ValidateCheckingAccount(CheckingAccount account)
        {
            string errors = string.Empty;
            bool isValid = true;

            if (account == null)
            {
                errors = "Account cant be null!";
                throw new ArgumentException(errors);
            }

            if (account.AccountNumber.Length != 10)
            {
                isValid = false;
                errors += "Account number length should be exactly 10 symbols!\n";
            }

            if (account.Balance < 0)
            {
                isValid = false;
                errors += "Account balance should be non-negative!\n";
            }

            if (account.Fee < 0)
            {
                isValid = false;
                errors += "Account fee should be non-negative!\n";
            }

            if (!isValid)
            {
                throw new ArgumentException(errors.Trim());
            }
        }
    }
}

