using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EnrollmentSystemProject.EnrollmentSystem.Classes
{
    public class LoginAuthentication
    {
        public UserLogin AuthenticationUser(string UserName, string Password)
        {
            SqlCommand cmd;
            SqlConnection conn;

            using (conn = new SqlConnection(AddConnection.GetConnection()))
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                string query = "SELECT UserName, UserRole FROM UserLogin " + "WHERE UserName = @UserName And Userpassword = @Userpassword";
                using (cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserName", UserName);
                    cmd.Parameters.AddWithValue("@Userpassword", Password);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            UserLogin user = new UserLogin
                            {
                                UserName = reader.GetString(0),
                                Role = reader.GetString(1)
                            };
                            return user;
                        }
                    }
                }
            }
            return null;
        }
    }
}
