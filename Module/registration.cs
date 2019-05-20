using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Module
{
    public class registration
    {
        string registration_id;
        string username;
        string password;
        string fullname;
        string mobile_no;
        string email;
        string gender;

        public string Registration_id { get => registration_id; set => registration_id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public string Mobile_no { get => mobile_no; set => mobile_no = value; }
        public string Email { get => email; set => email = value; }
        public string Gender { get => gender; set => gender = value; }
    }
}