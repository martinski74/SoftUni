using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gringotts
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var ctx = new GringottsContext();
            ctx.Database.Initialize(true);

            Models.WizardDeposits dumbledore =
                new Models.WizardDeposits()
                {
                    FirstName = "Albus",
                    LastName = "Dumbledore",
                    Age = 150,
                    MagicWandCreator = "Antioch Peverell",
                    MagicWandSize = 15,
                    DepositStartDate = new DateTime(2016, 10, 20),
                    DepositExpirationDate = new DateTime(2020, 10, 20),
                    DepositAmount = 20000.24m,
                    DepositCharge = 0.2m,
                    IsDepositExpired = false,
                };

            ctx.Deposits.Add(dumbledore);

            try
            {
                ctx.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var entityvalidationError in
                    ex.EntityValidationErrors)
                {
                    foreach (var validatioError in
                        entityvalidationError
                        .ValidationErrors)
                    {
                        System.Diagnostics.Debug.Write("Property: " +
                            validatioError.PropertyName +
                            "Error: " + validatioError
                            .ErrorMessage);
                    }
                }
            }


            Console.WriteLine("Added WizardDeposits:");
            ctx.Deposits.Select(d => d.LastName).ToList()
.ForEach(Console.WriteLine);

        }
    }
}
