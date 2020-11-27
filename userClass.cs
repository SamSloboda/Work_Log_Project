using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_Log_Project
{
    public static class userClass
    {
        public static string username 
        { get; set; }
        public static string password
        { get; set; }
        public static bool adminAcc
        { get; set; }
        public static bool activeUser
        { get; set; }
        public static int user_id
        { get; set; }
        public static int employee_id
        { get; set; }
        public static string firstName
        { get; set; }
        public static string middleName
        { get; set; }
        public static string lastName
        { get; set; }
        public static DateTime creationTime
        { get; set; }

    }
}
