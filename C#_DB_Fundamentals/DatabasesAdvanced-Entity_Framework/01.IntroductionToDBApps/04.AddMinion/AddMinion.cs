using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;


class AddMinion
{
    public static SqlConnection connection = new SqlConnection("Server=.; " +
                                                    "Database=MinionsDB; " +
                                                    "Integrated Security=true");
    static void Main()
    {
        //read input 


        Console.Write("Minion: ");
        string[] input = Console.ReadLine().Split(' ');
        string minionName = input[0];
        int minionAge = int.Parse(input[1]);
        string minionTown = input[2];
        Console.Write("Minion: ");
        string villainName = Console.ReadLine();


        string townSQL = "SELECT Id FROM towns WHERE name = @townName";
        SqlCommand cmd = new SqlCommand(townSQL, connection);
        cmd.Parameters.AddWithValue("@townName", minionTown);
        connection.Open();
        SqlDataReader reader = cmd.ExecuteReader();

        if (!reader.HasRows)
        {
            //add town to db
            reader.Close();
            string addTownSQL = "INSERT INTO towns (name, country) VALUES (@townName, NULL)";
            SqlCommand addTown = new SqlCommand(addTownSQL, connection);
            addTown.Parameters.AddWithValue("@townName", minionTown);
            addTown.ExecuteNonQuery();
            Console.WriteLine("Town {0} was added to the database.", minionTown);
        }
        reader.Close();

        int townId = (int)cmd.ExecuteScalar();
        reader.Close();

        string villainSQL = "SELECT * FROM villains WHERE name = @villainName";
        SqlCommand getVillain = new SqlCommand(villainSQL, connection);
        getVillain.Parameters.AddWithValue("@villainName", villainName);
        reader = getVillain.ExecuteReader();
        if (!reader.HasRows)
        {
            reader.Close();
            string addVillainSQL = "INSERT INTO villains (name, EvilnessFactor) VALUES (@villainName, 'evil')";
            SqlCommand addVillain = new SqlCommand(addVillainSQL, connection);
            addVillain.Parameters.AddWithValue("@villainName", villainName);
            addVillain.ExecuteNonQuery();
            Console.WriteLine("Villain {0} was added to the database.", villainName);
        }
        reader.Close();

        int villainId = (int)getVillain.ExecuteScalar();
        reader.Close();

        //add minion
        string addMinionSQL = "INSERT INTO minions (Name, Age, TownId) VALUES (@name, @age, @townId)";
        SqlCommand addMinion = new SqlCommand(addMinionSQL, connection);
        addMinion.Parameters.AddWithValue("@name", minionName);
        addMinion.Parameters.AddWithValue("@age", minionAge);
        addMinion.Parameters.AddWithValue("@townId", townId);
        addMinion.ExecuteNonQuery();

        //get minion id
        string getMinionIdSQL = "SELECT id FROM minions where name = @minionName";
        SqlCommand getMinion = new SqlCommand(getMinionIdSQL, connection);
        getMinion.Parameters.AddWithValue("@minionName", minionName);
        int minionId = (int)getMinion.ExecuteScalar();


        //add record in MinionsVillains table
        string addMinionToVillainSQL = "INSERT INTO VillainsMinions (VillainId,MinionId) VALUES (@villainId,@minionId)";
        SqlCommand addMinionToVillain = new SqlCommand(addMinionToVillainSQL, connection);
        addMinionToVillain.Parameters.AddWithValue("@villainId", villainId);
        addMinionToVillain.Parameters.AddWithValue("@minionId", minionId);
        addMinionToVillain.ExecuteNonQuery();

        Console.WriteLine("Successfully added {0} to be minion of {1}", minionName, villainName);

    }
}

