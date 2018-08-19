using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Address
    {
        private int addressID;

        public int AddressID
        {
            get { return this.addressID; }
            set { this.addressID = value; }
        }

        private string city;

        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }

        private string street;

        public string Street
        {
            get { return this.street; }
            set { this.street = value; }
        }

        private string postalCode;

        public string PostalCode
        {
            get { return this.postalCode; }
            set { this.postalCode = value; }
        }

        public Address(int addressID, string city, string street, string postalCode)
        {
            this.addressID = addressID;
            this.city = city;
            this.street = street;
            this.postalCode = postalCode;
        }

        public Address()
        {

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
            return string.Format("AddressID = {0}\n City = {1} \n Street = {2} \n PoBox = {3}",this.addressID, this.city, this.street, this.postalCode);
        }
    }
}
