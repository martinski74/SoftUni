using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;

namespace _03.GetMinionNames
{
    class GetMinionNames
    {
        static void Main()
        {
            SqlConnection connection =
              new SqlConnection("Server=.;Database=MinionsDB;Integrated Security=true;");
            connection.Open();
            using (connection)
            {
                int villainId = int.Parse(Console.ReadLine());
                string findNameQuery = File.ReadAllText("../../VillainNameById.sql");
                SqlCommand findVillainNameComand = new SqlCommand(findNameQuery,connection);
                SqlParameter villainParam = new SqlParameter("@villainId",villainId);
                findVillainNameComand.Parameters.Add(villainParam);

                var reader = findVillainNameComand.ExecuteReader();

                if (reader.Read())
                {
                    string villName = (string)reader["name"];
                    Console.WriteLine($"Villain: {villName}");

                    string findMinQuey = File.ReadAllText("../../MinionsName.sql");
                    SqlCommand findMinionCommand = new SqlCommand(findMinQuey, connection);
                    SqlParameter param = new SqlParameter("@villainId",villainId);
                    findMinionCommand.Parameters.Add(param);
                    reader.Close();

                    SqlDataReader minionsReader = findMinionCommand.ExecuteReader();
                    int index = 1;
                    while (minionsReader.Read())
                    {
                        string minionName = (string)minionsReader["name"];
                        int minionAge = (int)minionsReader["Age"];

                        Console.WriteLine($"{index}. {minionName} {minionAge}");
                        index++;
                    }
                }
                else
                {
                    Console.WriteLine($"No villain with ID {villainId} exists in the database.");
                }
            }
           

        }
    }
}
