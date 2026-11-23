using System.Data.SqlClient;

namespace Student_Management_System
{
    public class Database
    {
        public static SqlConnection GetConnection()
        {
            string connectionString =
                @"Data Source=.\SQLEXPRESS;Initial Catalog=StudentManagementDB;Integrated Security=True";

            return new SqlConnection(connectionString);
        }
    }
}