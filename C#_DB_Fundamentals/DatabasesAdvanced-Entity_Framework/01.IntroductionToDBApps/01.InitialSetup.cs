using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToDBApps
{
    class InitialSetup
    {
        static void Main()
        {
            string query = File.ReadAllText(@"../../Test.sql");
            SqlConnection connection = new SqlConnection("Server=MARTIN;Database=MinionsDB;Integrated Security=true;");
            connection.Open();
            
            SqlCommand createTableCmd = new SqlCommand(query, connection);
            using (connection)
            {
                Console.WriteLine(createTableCmd.ExecuteNonQuery()); 
            }
        }
    }
}
