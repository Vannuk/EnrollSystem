using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentSystemProject.EnrollmentSystem.Classes
{
    internal class AddConnection
    {
        public static string GetConnection()
        {
            return ConfigurationManager.ConnectionStrings["ERU_Core"].ConnectionString;
        }
    }
}
