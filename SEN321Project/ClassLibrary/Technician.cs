using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassLibrary
{
    public class Technician : Person
    {
        private static DataTable dt = new DataTable();

        private int technicianID;

        public int TechnicianID
        {
            get { return this.technicianID; }
            set { this.technicianID = value; }
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

        public Technician(int technicianID, Address address, Login login, string name, string surname, DateTime dateOfBirth, bool available)
            : base(name, surname, dateOfBirth)
        {
            this.technicianID = technicianID;
            this.address = address;
            this.login = login;
            this.available = available;
        }

        public Technician(int technicianID) : base()
        {
            this.technicianID = technicianID;
        }

        public Technician(){}

        public static List<int> GetAvailableTechnicianIDs()
        {
            List<int> technicianIDs = new List<int>();

            dt = DataHandler.GetAvailableTechnicianIDs();

            foreach (DataRow row in dt.Rows)
            {
                technicianIDs.Add(int.Parse(row["EmployeeID"].ToString()));
            }

            return technicianIDs;
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
            return string.Format("{0}", base.Name);
        }
    }
}
