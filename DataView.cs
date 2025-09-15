//using Microsoft.Data.SqlClient;
//using System;
//using System.Data;

//class DataSetExample
//{
//    static void Main(string[] args)
//    {
//         string connstr = "Server=RINSHAD\\SQLEXPRESS; Database=ADO_DOTNET; Integrated Security=True; TrustServerCertificate=True;";


//        using (SqlConnection conn = new SqlConnection(connstr))

//        {
//            SqlDataAdapter da = new SqlDataAdapter("SELECT StudentId,FirstName,Age FROM Students", conn);

//            DataSet ds = new DataSet();
//            da.Fill(ds, "Students");
//            DataTable dt = ds.Tables["Students"];
//            DataView dv = new DataView(dt);

//            dv.RowFilter = "Age >20";
//            dv.Sort = "FirstName ASC";


//            foreach(DataRowView Row in dv)
//            {
//                Console.WriteLine($"{Row["StudentId"]},{Row["FirstName"]},{Row["Age"]}");

//            }

//        }
//    }
//}