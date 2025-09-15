using System;
using Microsoft.Data.SqlClient;


class Program
{
    static void Main(string[] args)
    {
        string connstr = "Server=RINSHAD\\SQLEXPRESS; Database=ADO_DOTNET; Integrated Security=True; TrustServerCertificate=True;";

        //using (SqlConnection conn = new SqlConnection(connstr))
        //{
        //    conn.Open();
        //    Console.WriteLine("Connect ADO.NET To Data Source Successfully");

        //    String sql = "SELECT * FROM Students";
        //    SqlCommand cmd = new SqlCommand(sql, conn);

        //    SqlDataReader reader = cmd.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        Console.WriteLine($"{reader["StudentId"]}, {reader["FirstName"]},{reader["LastName"]}");
        //    }
        //}


        //using (SqlConnection conn = new SqlConnection(connstr))
        //{
        //    SqlCommand cmd = new SqlCommand("InsertStudent", conn);
        //    cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@FirstName", "Rinshad");
        //    cmd.Parameters.AddWithValue("@LastName", "Chirakkal");
        //    cmd.Parameters.AddWithValue("@Age", 21);

        //    conn.Open();
        //    cmd.ExecuteNonQuery();
        //    conn.Close();
        //    Console.WriteLine("Data Inserted Successfully");
        //}

        //using (SqlConnection conn = new SqlConnection(connstr))
        //{

        //    SqlCommand updateCmd = new SqlCommand("UpdateStudent", conn);
        //    updateCmd.CommandType = System.Data.CommandType.StoredProcedure;
        //    updateCmd.Parameters.AddWithValue("@StudentId", 1);
        //    updateCmd.Parameters.AddWithValue("@FirstName", "Mohammed");
        //    updateCmd.Parameters.AddWithValue("@LastName", "Rinshad");
        //    updateCmd.Parameters.AddWithValue("@Age", 21);

        //    conn.Open();
        //    updateCmd.ExecuteNonQuery();
        //    conn.Close();
        //    Console.WriteLine("Data Updated Successfully");
        //}

        //using (SqlConnection conn = new SqlConnection(connstr))
        //{
        //    SqlCommand deleteCmd = new SqlCommand("DeleteStudent", conn);
        //    deleteCmd.CommandType = System.Data.CommandType.StoredProcedure;
        //    deleteCmd.Parameters.AddWithValue("@StudentId", 2);

        //    conn.Open();
        //    deleteCmd.ExecuteNonQuery();
        //    conn.Close();
        //    Console.WriteLine("Data Deleted SUCCESSFULLY");
        //}

        using (SqlConnection conn = new SqlConnection(connstr))
        {
            SqlCommand getAll = new SqlCommand("GetAllStudents",conn);
            getAll.CommandType = System.Data.CommandType.StoredProcedure;

            conn.Open();
            SqlDataReader  reader = getAll.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($"{reader["StudentId"]},{reader["FirstName"]},{reader["LastName"]},{reader["Age"]}");
            }
            conn.Close();
            Console.WriteLine("Fetched All Students Successfully");
        }

    }
}