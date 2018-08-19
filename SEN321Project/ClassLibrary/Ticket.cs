using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassLibrary
{
    public class Ticket
    {
        private static DataTable dt = new DataTable();

        private int ticketID;

        public int TicketID
        {
            get { return this.ticketID; }
            set { this.ticketID = value; }
        }

        private string clientID;

        public string ClientID
        {
            get { return this.clientID; }
            set { this.clientID = value; }
        }

        private string faultDescription;

        public string FaultDescription
        {
            get { return this.faultDescription; }
            set { this.faultDescription = value; }
        }

        private Service service;

        public Service Service
        {
            get { return this.service; }
            set { this.service = value; }
        }

        private DateTime ticketOpenDate;

        public DateTime TicketOpenDate
        {
            get { return this.ticketOpenDate; }
            set { this.ticketOpenDate = value; }
        }

        private bool open;

        public bool Open
        {
            get { return this.open; }
            set { this.open = value; }
        }

        public Ticket(int ticketID, string clientID, string faultDescription, Service service, DateTime ticketOpenDate, bool open)
        {
            this.ticketID = ticketID;
            this.clientID = clientID;
            this.faultDescription = faultDescription;
            this.service = service;
            this.ticketOpenDate = ticketOpenDate;
            this.open = open;
        }

        public void AddTicket()
        {
            DataHandler.AddTicket(this);
        }

        public static List<Ticket> GetTickets(bool assigned)
        {

            List<Ticket> tickets = new List<Ticket>();

            dt = DataHandler.GetTickets(assigned);

            foreach (DataRow row in dt.Rows)
            {
                tickets.Add(new Ticket(int.Parse(row["TicketID"].ToString()), row["ClientID"].ToString(), row["FaultDescription"].ToString(), new Service(int.Parse(row["ServiceID"].ToString()), int.Parse(row["Product"].ToString()), int.Parse(row["TypeOfService"].ToString()), int.Parse(row["Technician"].ToString())), Convert.ToDateTime(row["TicketOpenDate"].ToString()), (bool)row["Open"]));
            }

            return tickets;
        }

        public static List<Ticket> GetTickets(bool assigned, bool open)
        {

            List<Ticket> tickets = new List<Ticket>();

            dt = DataHandler.GetTickets(assigned, open);

            foreach (DataRow row in dt.Rows)
            {
                tickets.Add(new Ticket(int.Parse(row["TicketID"].ToString()), row["ClientID"].ToString(), row["FaultDescription"].ToString(), new Service(int.Parse(row["ServiceID"].ToString()), int.Parse(row["Product"].ToString()), int.Parse(row["TypeOfService"].ToString()), int.Parse(row["Technician"].ToString())), Convert.ToDateTime(row["TicketOpenDate"].ToString()), (bool)row["Open"]));
            }

            return tickets;
        }

        public static void CancelTicket(int ticketID)
        {
            DataHandler.CancelTicket(ticketID);
        }

        public static void CloseTicket(int ticketID)
        {
            DataHandler.CloseTicket(ticketID);
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
