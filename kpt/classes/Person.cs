using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace kpt.classes
{
    public class Person
    {
        // Properties
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public DataTable CourseLogin()
        {
            Sql db = new Sql();
            DataTable dt = new DataTable();

            // Dictionary to send parameters in format key-value
            Dictionary<string, string> myParams = new Dictionary<string, string>();

            myParams.Add("@username", Username);
            myParams.Add("@password", Password);

            // Sql query with parameters
            string sql = "SELECT * FROM person " +
                "WHERE username = @username AND " +
                "password = @password AND " +
                "isadmin = false";

            dt = db.Select(sql, myParams);
            return dt;
        }

        public DataTable AdmLogin()
        {
            Sql db = new Sql();
            DataTable dt = new DataTable();

            Dictionary<string, string> myParams = new Dictionary<string, string>();

            myParams.Add("@username", Username);
            myParams.Add("@password", Password);

            // Sql query with parameters
            string sql = "SELECT * FROM person " +
                "WHERE username = @username AND " +
                "password = @password AND " +
                "isadmin = true";

            dt = db.Select(sql, myParams);
            return dt;
        }
    }
}