using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GetVillainsName
{
    class GetVillainsName
    {
        static void Main()
        {
            SqlConnection connection =
                new SqlConnection("Server=MARTIN;Database=MinionsDB;Integrated Security=true;");
            connection.Open();
            string query = File.ReadAllText("../../VillainNames.sql");
            SqlCommand command = new SqlCommand(query, connection);

            using (connection)
            {
                var reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        string villiamName = (string)reader["name"];
                        int countSubordinates = (int)reader["MinionCount"];
                        Console.WriteLine($"{villiamName} {countSubordinates}");
                    }
                }

            }
        }
    }
}
