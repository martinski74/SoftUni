using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gringotts
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new GringottsContext();

            //19.Deposit Sum for Ollivander family
            //DepositsSumByOliverFamily(context);

            //20.Deposit Filter
            //DepositFilter(context);
        }

        private static void DepositFilter(GringottsContext context)
        {
            var filtered = new Dictionary<string, decimal?>();
            var groups = context.WizzardDeposits.Select(x => x.DepositGroup).Distinct();
            foreach (var g in groups)
            {
                filtered[g] = context.WizzardDeposits
                    .Where(x => x.DepositGroup == g)
                    .Where(x => x.MagicWandCreator == "Ollivander family")
                    .Sum(s => s.DepositAmount);
            }
            foreach (var f in filtered.Where(x => x.Value < 150000m).OrderByDescending(g => g.Value))
            {
                Console.WriteLine($"{f.Key} - {f.Value}");
            }
        }

        private static void DepositsSumByOliverFamily(GringottsContext context)
        {
            var groups = context.WizzardDeposits.Select(x => x.DepositGroup).Distinct();

            foreach (var g in groups)
            {
                Console.WriteLine($@"{g} - {context.WizzardDeposits
                    .Where(d => d.DepositGroup == g)
                    .Where(x => x.MagicWandCreator == "Ollivander family")
                    .Sum(s => s.DepositAmount)}");
            }

        }
    }
}
