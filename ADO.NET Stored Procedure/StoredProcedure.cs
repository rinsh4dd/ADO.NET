using System;
using Microsoft.Data.SqlClient;
using System.Data;

class ADOStoredProcedure
{
    static void Main(string[] args)
    {
        string connStr = "Server=RINSHAD\\SQLEXPRESS; Database=ADO_DOTNET; Integrated Security=True; TrustServerCertificate=True";

        //using (SqlConnection conn = new SqlConnection(connStr))
        //{
        //    //SqlCommand cmd = new SqlCommand("GetAllStudents", conn);
        //    //cmd.CommandType = System.Data.CommandType.StoredProcedure;

        //    //conn.Open();
        //    //SqlDataReader reader = cmd.ExecuteReader();

        //    //while (reader.Read())
        //    //{
        //    //    Console.WriteLine($"{reader["StudentID"]},{reader ["FirstName"]}, {reader["LastName"]},{reader["Age"]}");
        //    //}

        //    SqlDataAdapter adapter = new SqlDataAdapter("GetAllStudents", conn);
        //    adapter.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

        //    DataSet ds = new DataSet();
        //    adapter.Fill(ds, "Students");

        //    foreach(DataRow row in ds.Tables["Students"].Rows)
        //    {
        //        Console.WriteLine($"{row["StudentID"]},{row["FirstName"]}, {row["LastName"]},{row["Age"]}");
        //    }
        //}



        //using (SqlConnection conn = new SqlConnection(connStr))
        //{
        //    SqlCommand cmd = new SqlCommand("GetStudentById", conn);
        //    cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@Id", 10);

        //    conn.Open();
        //    SqlDataReader reader = cmd.ExecuteReader();

        //    while (reader.Read())
        //    {
        //                       Console.WriteLine($"{reader["StudentID"]},{reader["FirstName"]}, {reader["LastName"]},{reader["Age"]}");
        //    }
        //}

        using (SqlConnection conn = new SqlConnection(connStr))
        {
            SqlDataAdapter da = new SqlDataAdapter("GetStudentById", conn);
            da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@Id",11 );

            DataSet ds = new DataSet();
            da.Fill(ds, "Students");

            Console.WriteLine("Data From DataBase");

            foreach(DataRow row in ds.Tables["Students"].Rows)
            {
                Console.WriteLine($"{row["StudentID"]},{row["FirstName"]} - {row["LastName"]} - {row["Age"]}");
            }
        }
    }
}