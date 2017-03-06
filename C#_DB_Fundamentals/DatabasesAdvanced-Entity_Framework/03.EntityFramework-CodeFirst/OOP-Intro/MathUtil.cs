using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_CodeFirst
{
    class MathUtil
    {
        public static double Sum(double firstNumm, double secondNum)
        {
            return firstNumm + secondNum;
        }
        public static double Subtract(double firstNumm, double secondNum)
        {
            return firstNumm - secondNum;
        }

        public static double Multiply(double firstNumm, double secondNum)
        {
            return firstNumm * secondNum;
        }

        public static double Divide(double firstNumm, double secondNum)
        {
            return firstNumm / secondNum;
        }
        public static double Percantige(double total, double percentage)
        {
            return Divide(Multiply(total, percentage), 100);
        }
    }
}
