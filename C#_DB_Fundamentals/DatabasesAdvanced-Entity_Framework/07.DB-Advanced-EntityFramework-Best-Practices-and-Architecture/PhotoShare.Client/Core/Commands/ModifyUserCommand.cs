using System.Linq;

namespace PhotoShare.Client.Core.Commands
{
    using System;

    public class ModifyUserCommand
    {
        // ModifyUser<property> <new value>
        // For example:
        // ModifyUserPassword <NewPassword>
        // ModifyUserBornTown <newBornTownName>
        // ModifyUserCurrentTown <newCurrentTownName>
        // !!! Cannot change username
        public string Execute(string[] data)
        {

            string userName = UserControl.LoggedUser.Username;;
            string property = data[0];
            string propertyValue = data[1];

            using (var context = new PhotoShareContext())
            {
                var user = UserControl.LoggedUser;

                if (user != null)
                {
                    switch (property)
                    {
                        case "Password":
                            if (propertyValue.Any(char.IsDigit) && propertyValue.Any(char.IsUpper))
                            {
                                user.Password = propertyValue;
                            }
                            else
                            {
                                throw new ArgumentException($"Invalid Password");
                            }
                            break;
                        case "BornTown":
                            var bornTown = context.Towns.FirstOrDefault(t => t.Name == propertyValue);
                            if (bornTown != null)
                            {
                                user.BornTown = bornTown;
                                }
                            else
                            {
                                throw new ArgumentException($"Town {propertyValue} not found!");
                            }
                            break;
                        case "CurrentTown":
                            var currentTown = context.Towns.FirstOrDefault(t => t.Name == propertyValue);
                            if (currentTown != null)
                            {
                                user.CurrentTown = currentTown;
                            }
                            else
                            {
                                throw new ArgumentException($"Town {propertyValue} not found!");
                            }
                            break;
                        default:
                            throw new ArgumentException($"Property {property} not supported!");
                    }
                }
                else
                {
                    throw new ArgumentException($"User {userName} not found!");
                }

                context.SaveChanges();
                return $"User {user.Username} {property} is {propertyValue}.";
            }

        }
    }
}
