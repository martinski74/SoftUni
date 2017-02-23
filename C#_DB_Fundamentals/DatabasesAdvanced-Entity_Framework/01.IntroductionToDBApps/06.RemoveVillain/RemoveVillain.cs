namespace _06.RemoveVillain
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;

    class RemoveVillain
    {
        public static string ConnectionString = "Server=.;Database=MinionsDB;Integrated Security=true";

        static void Main(string[] args)
        {
            int villainId = int.Parse(Console.ReadLine());
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlTransaction delete = connection.BeginTransaction();
                SqlCommand villains = new SqlCommand("SELECT Id, Name FROM villains WHERE Id = @villainId", connection);
                villains.Parameters.AddWithValue("@villainId", villainId);

                SqlCommand deleteVillain = new SqlCommand("DELETE FROM Villains WHERE Id = @villainId", connection);
                deleteVillain.Parameters.AddWithValue("@villainId", villainId);

                SqlCommand releaseMinions = new SqlCommand("DELETE FROM VillainsMinions WHERE VillainId = @villainId", connection);
                releaseMinions.Parameters.AddWithValue("@villainId", villainId);

                villains.Transaction = delete;
                SqlDataReader reader = villains.ExecuteReader();
                try
                {
                    reader.Read();
                    var villainName = (string)reader["Name"];
                    reader.Close();

                    releaseMinions.Transaction = delete;
                    var releasedMinions = releaseMinions.ExecuteNonQuery();

                    deleteVillain.Transaction = delete;
                    deleteVillain.ExecuteNonQuery();

                    delete.Commit();
                    Console.WriteLine("{0} was deleted", villainName);
                    Console.WriteLine("{0} were released", releasedMinions);
                }
                catch (InvalidOperationException e)
                {
                    reader.Close();
                    delete.Rollback();
                    Console.WriteLine("No such villain was found");
                }
            }
        }
    }
}
