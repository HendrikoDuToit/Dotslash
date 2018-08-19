using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Contract
    {

        private string contractID;

        public string ContractID
        {
            get { return this.contractID; }
            set { this.contractID = value; }
        }

        private char contractLevel;

        public char ContractLevel
        {
            get { return this.contractLevel; }
            set { this.contractLevel = value; }
        }

        public Contract(string contractID, char contractLevel)
        {
            this.contractID = contractID;
            this.contractLevel = contractLevel;
        }

        public Contract()
        {

        }

        public static string GenerateContractID(string contractType)
        {
            Random ran = new Random();
            string generatedID = DateTime.Now.Year.ToString() + contractType.ToUpper() + contractType + ran.Next(100000, 1000000).ToString();

            return generatedID;
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
