using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateUser
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new UsersContext();
            using (context)
            {
                context.Database.Initialize(true);
                SeedData(context);
                context.SaveChanges();
            }
        }

        private static void SeedData(UsersContext context)
        {
            context.Users.Add(new User()
            {
                Username = "user",
                Password = "iferb^4Sdftrh",
                Email = "user1@mail.bg",
                RegisteredOn = new DateTime(2015, 10, 11),
                Age = 10,
                IsDeleted = false
            });

            context.Users.Add(new User()
            {
                Username = "user1",
                Password = "dfhrt5$6FGy",
                Email = "user1@mail.ro",
                RegisteredOn = new DateTime(2016, 10, 11),
                Age = 17,
                IsDeleted = true
            });
            context.Users.Add(new User()
            {
                Username = "user2",
                Password = "sdhfgGHF^77y",
                Email = "user2@mail.bg",
                RegisteredOn = new DateTime(2013, 10, 11),
                Age = 37,
                IsDeleted = false
            });
        }
    }
}
