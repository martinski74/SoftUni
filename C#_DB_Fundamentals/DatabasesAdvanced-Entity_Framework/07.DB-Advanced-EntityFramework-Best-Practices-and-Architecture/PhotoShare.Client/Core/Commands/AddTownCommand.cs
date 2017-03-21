using System;
using System.Linq;

namespace PhotoShare.Client.Core.Commands
{
    using Models;

    public class AddTownCommand
    {
        // AddTown <townName> <countryName>
        public string Execute(string[] data)
        {
            string townName = data[0];
            string country = data[1];

            using (PhotoShareContext context = new PhotoShareContext())
            {
                Town town = new Town
                {
                    Name = townName,
                    Country = country
                };

                var inDataBase = context.Towns.FirstOrDefault(t => t.Name == townName);

                if (inDataBase != null)
                {
                    throw  new ArgumentException($"Town {townName} was already added!");
                }

                context.Towns.Add(town);
                context.SaveChanges();

                return townName + " was added to database!";
            }
        }
    }
}
