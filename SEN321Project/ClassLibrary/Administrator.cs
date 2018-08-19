using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassLibrary
{
    public class Administrator : Person
    {

        private static DataTable dt = new DataTable();

        private int administratorID;

        public int AdministratorID
        {
            get { return this.administratorID; }
            set { this.administratorID = value; }
        }

        private Address address;

        public Address Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        private Login login;

        public Login Login
        {
            get { return this.login; }
            set { this.login = value; }
        }

        private bool available;

        public bool Available
        {
            get { return this.available; }
            set { this.available = value; }
        }

        public Administrator(int administratorID, Address address, Login login, string name, string surname, DateTime dateOfBirth, bool available)
            : base(name, surname, dateOfBirth)
        {
            this.administratorID = administratorID;
            this.address = address;
            this.login = login;
            this.available = available;
        }

        public Administrator() : base ()
        {

        }

        public Administrator(int administratorID)
            : base()
        {
            this.administratorID = administratorID;
        }

        public static Administrator GetLoggedInAdmin(string username, string password)
        {
            Administrator admin = new Administrator(); // Instantiating a new admin with an empty constructor.
            dt = DataHandler.GetLoggedInAdmin(username, password); // Retrieving the datatable that consists of all relevant data for the administrator.

            foreach (DataRow row in dt.Rows) // populating the admin object with the values inside the datatable.
	        {
                admin = new Administrator(int.Parse(row[0].ToString()), new Address(int.Parse(row["AddressID"].ToString()), row["City"].ToString(), row["Street"].ToString(), row["PostalCode"].ToString()), new Login(0, username, password), row["EmployeeName"].ToString(), row["EmployeeSurname"].ToString(), Convert.ToDateTime(row["DateOfBirth"].ToString()), (bool)row["Available"]);
	        }
            

            return admin;
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
            return string.Format("{0}", this.administratorID);
        }

    }
}
