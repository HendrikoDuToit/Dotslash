using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassLibrary
{
    public class Payment
    {
        private static DataTable dt = new DataTable();

        private int paymentID;

        public int PaymentID
        {
            get { return this.paymentID; }
            set { this.paymentID = value; }
        }

        private string description;

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        public Payment(int paymentID, string description)
        {
            this.paymentID = paymentID;
            this.description = description;
        }

        public static List<Payment> GetPaymentMethodsFromDB()
        {
            List<Payment> paymentMethods = new List<Payment>();

            dt = DataHandler.GetPaymentMethods();

            foreach (DataRow row in dt.Rows)
            {
                paymentMethods.Add(new Payment(int.Parse(row[0].ToString()), (string)row[1].ToString()));
            }

            return paymentMethods;
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
