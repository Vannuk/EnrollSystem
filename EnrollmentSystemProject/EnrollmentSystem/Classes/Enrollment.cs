using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentSystemProject.EnrollmentSystem.Classes
{
    public class Enrollment : Students
    {
        public int RegNo { get; set; }
        public DateTime RegDate { get; set; }
        public string UserID { get; set; }
        public string EmpID { get; set; }
        public string Major { get; set; }
        public string Program { get; set; }
        public string StudyTime { get; set; }
        public bool InsertEnrollStudent(Enrollment enrollment)
        {
            bool check = false;
            SqlCommand cmd;
            SqlConnection con;
            using (con = new SqlConnection(AddConnection.GetConnection()))
            {
                cmd = new SqlCommand("Insert Into Students" +
              "(RegDate,StudentID,FullNameKH,FullNameEng,Gender,DOB,ParentContact,Email,Address,UserID,PhoneNumber,Major,Program,StudyTime)" +
              "values(@RegDate, @StudID, @FullNameKH, @FullNameEN, @Gender,@DOB, @ParentContact, @Email, @Address, @UserID, @PhoneNumber, @Major, @Program, @StudyTime);", con);
                cmd.Parameters.AddWithValue("@RegDate", enrollment.RegDate);
                cmd.Parameters.AddWithValue("@StudID", enrollment.StudID);
                cmd.Parameters.AddWithValue("@FullNameKH", enrollment.FullNameKH);
                cmd.Parameters.AddWithValue("@FullNameEN", enrollment.FullNameEN);
                cmd.Parameters.AddWithValue("@Gender", enrollment.Gender);
                cmd.Parameters.AddWithValue("@DOB", enrollment.DOB);
                cmd.Parameters.AddWithValue("@ParentContact", enrollment.ParentContact);
                cmd.Parameters.AddWithValue("@Email", enrollment.Email);
                cmd.Parameters.AddWithValue("@Address", enrollment.Address);
                cmd.Parameters.AddWithValue("@UserID", enrollment.UserID);
                cmd.Parameters.AddWithValue("@PhoneNumber", enrollment.PhoneNumber);
                cmd.Parameters.AddWithValue("@Major", enrollment.Major);
                cmd.Parameters.AddWithValue("@Program", enrollment.Program);
                cmd.Parameters.AddWithValue("@StudyTime", enrollment.StudyTime);
                if (con.State != System.Data.ConnectionState.Open)
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        System.Console.WriteLine("It is done!");
                        check = true;
                    }
                    catch (Exception)
                    {
                        System.Console.WriteLine("Error Insert");
                        check = false;
                    }
                //Output
                return check;
            }
        }
    }
}
