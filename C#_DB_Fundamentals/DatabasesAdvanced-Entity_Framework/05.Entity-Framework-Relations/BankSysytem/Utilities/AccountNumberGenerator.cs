using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSysytem.Utilities
{
    public class AccountNumberGenerator
    {
        public static string GenerateAccountNumber()
        {
            return Guid.NewGuid().ToString().Replace("-", string.Empty).Substring(0, 10).ToUpper();
        }
    }
}
