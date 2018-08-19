using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassLibrary
{
    public class PhoneCall
    {
        private static DataTable dt = new DataTable();

        private int callID;

        public int CallID
        {
            get { return this.callID; }
            set { this.callID = value; }
        }

        private string duration;

        public string Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }

        private DateTime date;

        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        private string reasonForCall;

        public string ReasonForCall
        {
            get { return this.reasonForCall; }
            set { this.reasonForCall = value; }
        }

        private string notes;

        public string Notes
        {
            get { return this.notes; }
            set { this.notes = value; }
        }

        private int adminID;

        public int AdminID
        {
            get { return this.adminID; }
            set { this.adminID = value; }
        }

        public PhoneCall(int callID, string duration, DateTime date, string reasonForCall, string notes, int adminID)
        {
            this.callID = callID;
            this.duration = duration;
            this.date = date;
            this.reasonForCall = reasonForCall;
            this.notes = notes;
            this.adminID = adminID;
        }

        public PhoneCall()
        {
        }

        public void AddCall()
        {
            DataHandler.AddCall(this);
        }

        public static List<PhoneCall> GetCalls()
        {
            List<PhoneCall> calls = new List<PhoneCall>();

            dt = DataHandler.GetCalls();

            foreach (DataRow row in dt.Rows)
            {
                calls.Add(new PhoneCall(int.Parse(row["CallID"].ToString()), row["Duration"].ToString(), Convert.ToDateTime(row["Date"].ToString()), row["Reason"].ToString(), row["Notes"].ToString(), int.Parse(row["AdminID"].ToString())));
            }

            return calls;
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
