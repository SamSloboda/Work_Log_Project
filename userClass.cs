using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_Log_Project
{
    public class userClass
    {
        public string username 
        { get; set; }
        public string password
        { get; set; }
        public bool adminAcc
        { get; set; }
        public bool activeUser
        { get; set; }
        public int user_id
        { get; set; }
        public int employee_id
        { get; set; }
        public string firstName
        { get; set; }
        public string middleName
        { get; set; }
        public string lastName
        { get; set; }
        public DateTime creationTime
        { get; set; }

    }
}
