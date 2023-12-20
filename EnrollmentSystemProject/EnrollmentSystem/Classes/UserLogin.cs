using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EnrollmentSystemProject.EnrollmentSystem.Classes
{
    public class UserLogin
    {
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public bool CreateUsers()
        {
            SqlCommand cmd;
            SqlConnection conn;
            bool check = false;

            using (conn = new SqlConnection(AddConnection.GetConnection()))
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                cmd = new SqlCommand(@"INSERT INTO [UserLogin]([UserID],[UserName],[Userpassword],[UserRole])" +
                    " Values(@UserID,@UserName,@Userpassword,@UserRole);", conn);
                cmd.Parameters.AddWithValue("@UserID", UserID);
                cmd.Parameters.AddWithValue("@UserName", UserName);
                cmd.Parameters.AddWithValue("@Userpassword", Password);
                cmd.Parameters.AddWithValue("@UserRole", Role);
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                try
                {
                    cmd.ExecuteNonQuery();
                    check = true;
                }
                catch (Exception)
                {
                    check = false;
                }
                return check;
            }
        }
    }
}
