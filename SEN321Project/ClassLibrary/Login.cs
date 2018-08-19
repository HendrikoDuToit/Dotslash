using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Login
    {

        private int loginID;

        public int LoginID
        {
            get { return this.loginID; }
            set { this.loginID = value; }
        }

        private string username;

        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }

        private string password;

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public Login(int loginID, string username, string password)
        {
            this.loginID = loginID;
            this.username = username;
            this.password = password;
        }

        public Login()
        {
            // TODO: Complete member initialization
        }

        // Verifies whether the employee trying to login has entered the correct login details.
        public static Administrator VerifyLogin(string username, string password)
        {
            if (DataHandler.Login(username, password)) // if the login details are true
            {
                Administrator admin = Administrator.GetLoggedInAdmin(username, password); // Getting the details of the admin that is logging in.
                return admin; // Returning the admin object.
            }

            return null;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
