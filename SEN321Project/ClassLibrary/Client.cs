using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace ClassLibrary
{
    public class Client : Person
    {
        private static DataTable dt = new DataTable();

        private string clientID;

        public string ClientID
        {
            get { return this.clientID; }
            set { this.clientID = value; }
        }

        private Address address;

        public Address Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        private string contract;

        public string Contract
        {
            get { return this.contract; }
            set { this.contract = value; }
        }

        public Client(string clientID, string name, string surname, DateTime dateOfBirth, Address address, string contract) 
            : base(name, surname, dateOfBirth)
        {
            this.clientID = clientID;
            this.address = address;
            this.contract = contract;
        }

        public Client() : base (){}

        public static List<string> GetClientIDs()
        {
            List<string> clientIDs = new List<string>();

            dt = DataHandler.GetClientIDs();

            foreach (DataRow row in dt.Rows)
            {
                clientIDs.Add(row[0].ToString());
            }

            return clientIDs;
        }

        public static string GenerateClientID()
        {
            Random ran = new Random();

            string[] characters = new string[4] {"A", "B", "C", "D"};

            string generatedID = characters[ran.Next(0, 4)] + ran.Next(10000000, 100000000).ToString();

            return generatedID;
        }

        public static Client GetClientFromDB(string clientID)
        {
            Client client = new Client();

            dt = DataHandler.GetClient(clientID);

            foreach (DataRow row in dt.Rows)
            {
                client = new Client(row[0].ToString(), row[1].ToString(), row[2].ToString(), Convert.ToDateTime(row[3].ToString()), new Address(int.Parse(row[6].ToString()), row[7].ToString(), row[8].ToString(), row[9].ToString()), row[5].ToString());
            }

            return client;
        }

        public static void AddClient(Client client)
        {
            DataHandler.AddClient(client);
        }

        public void UpdateClient()
        {
            DataHandler.UpdateClient(this);
        }

        public static void DeleteClient(string clientID)
        {
            DataHandler.DeleteClient(clientID);
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
            return string.Format("{0}\n {1}\n {2}", this.clientID, address.ToString(), base.ToString());
        }
    }
}
