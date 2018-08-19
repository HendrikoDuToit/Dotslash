using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace ClassLibrary
{
    public class Order
    {
        private static DataTable dt = new DataTable();

        private int orderID;

        public int OrderID
        {
            get { return this.orderID; }
            set { this.orderID = value; }
        }

        private string clientID;

        public string ClientID
        {
            get { return this.clientID; }
            set { this.clientID = value; }
        }

        private int paymentMethod;

        public int PaymentMethod
        {
            get { return this.paymentMethod; }
            set { this.paymentMethod = value; }
        }

        private DateTime orderDate;

        public DateTime OrderDate
        {
            get { return this.orderDate; }
            set { this.orderDate = value; }
        }

        private bool delivered;

        public bool Delivered
        {
            get { return this.delivered; }
            set { this.delivered = value; }
        }

        private double price;

        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        private Administrator administrator;

        public Administrator Administrator
        {
            get { return this.administrator; }
            set { this.administrator = value; }
        }

        private Installation installation;

        public Installation Installation
        {
            get { return this.installation; }
            set { this.installation = value; }
        }

        private List<OrderDetail> orderDetails;

        public List<OrderDetail> OrderDetails
        {
            get { return this.orderDetails; }
            set { this.orderDetails = value; }
        }

        public Order(int orderID, string clientID, int paymentMethod, DateTime orderDate, bool delivered, double price, Administrator administrator, Installation installation, List<OrderDetail> orderDetails)
        {
            this.orderID = orderID;
            this.clientID = clientID;
            this.paymentMethod = paymentMethod;
            this.orderDate = orderDate;
            this.delivered = delivered;
            this.price = price;
            this.administrator = administrator;
            this.installation = installation;
            this.orderDetails = orderDetails;
        }

        public Order()
        {
            // TODO: Complete member initialization
        }

        public void AddOrder()
        {
            DataHandler.AddOrder(this);
        }



        public static List<int> GetOrderIDs()
        {
            List<int> orderIDs = new List<int>();

            dt = DataHandler.GetOrderIDs();

            foreach (DataRow row in dt.Rows)
            {
                orderIDs.Add(int.Parse(row[0].ToString()));
            }

            return orderIDs;
        }

        public static List<int> GetOrderIDs(bool delivered)
        {
            List<int> orderIDs = new List<int>();

            dt = DataHandler.GetOrderIDs(delivered);

            foreach (DataRow row in dt.Rows)
            {
                orderIDs.Add(int.Parse(row[0].ToString()));
            }

            return orderIDs;
        }

        public static List<int> GetOrderIDs(bool delivered, string clientID, bool installed)
        {
            List<int> orderIDs = new List<int>();

            dt = DataHandler.GetOrderIDs(delivered, clientID, installed);

            foreach (DataRow row in dt.Rows)
            {
                orderIDs.Add(int.Parse(row[0].ToString()));
            }

            return orderIDs;
        }

        public static List<int> GetOrderIDs(bool delivered, bool installed)
        {
            List<int> orderIDs = new List<int>();

            dt = DataHandler.GetOrderIDs(delivered, installed);

            foreach (DataRow row in dt.Rows)
            {
                orderIDs.Add(int.Parse(row[0].ToString()));
            }

            return orderIDs;
        }

        public static List<int> GetOrderIDs(bool delivered, bool installed, bool assigned)
        {
            List<int> orderIDs = new List<int>();

            dt = DataHandler.GetOrderIDs(delivered, installed, assigned);

            foreach (DataRow row in dt.Rows)
            {
                orderIDs.Add(int.Parse(row[0].ToString()));
            }

            return orderIDs;
        }

        public static List<Order> GetOrderFromDB(int orderID)
        {
            List<OrderDetail> orderDetails = new List<OrderDetail>();

            List<Order> orders = new List<Order>();

            dt = DataHandler.GetOrder(orderID);

            foreach (DataRow row in dt.Rows)
            {
                orders.Add(new Order(int.Parse(row["OrderID"].ToString()), row["ClientID"].ToString(), int.Parse(row["PaymentMethodID"].ToString()), Convert.ToDateTime(row["OrderDate"].ToString()), (bool)row["Delivered"], double.Parse(row["Price"].ToString()), new Administrator(int.Parse(row["EmployeeID"].ToString()), new Address(int.Parse(row["AddressID"].ToString()), row["City"].ToString(), row["Street"].ToString(), row["PostalCode"].ToString()), new Login(), row["EmployeeName"].ToString(), row["EmployeeSurname"].ToString(), Convert.ToDateTime(row["DateOfBirth"].ToString()), (bool)row["Available"]), new Installation(int.Parse(row["InstallationID"].ToString()), (bool)row["Installed"], new Technician()), orderDetails));
            }

            return orders;
        }

        public static List<Order> GetOrderFromDB(int orderID, bool delivered)
        {
            List<OrderDetail> orderDetails = new List<OrderDetail>();

            List<Order> orders = new List<Order>();

            dt = DataHandler.GetOrder(orderID, delivered);

            foreach (DataRow row in dt.Rows)
            {
                orders.Add(new Order(int.Parse(row["OrderID"].ToString()), row["ClientID"].ToString(), int.Parse(row["PaymentMethodID"].ToString()), Convert.ToDateTime(row["OrderDate"].ToString()), (bool)row["Delivered"], double.Parse(row["Price"].ToString()), new Administrator(int.Parse(row["EmployeeID"].ToString()), new Address(int.Parse(row["AddressID"].ToString()), row["City"].ToString(), row["Street"].ToString(), row["PostalCode"].ToString()), new Login(), row["EmployeeName"].ToString(), row["EmployeeSurname"].ToString(), Convert.ToDateTime(row["DateOfBirth"].ToString()), (bool)row["Available"]), new Installation(int.Parse(row["InstallationID"].ToString()), (bool)row["Installed"], new Technician()), orderDetails));
            }

            return orders;
        }

        public static List<Order> GetOrderFromDB(string clientID)
        {
            List<OrderDetail> orderDetails = new List<OrderDetail>();
            List<Order> orders = new List<Order>();

            dt = DataHandler.GetOrder(clientID);

            foreach (DataRow row in dt.Rows)
            {
                orders.Add(new Order(int.Parse(row["OrderID"].ToString()), row["ClientID"].ToString(), int.Parse(row["PaymentMethodID"].ToString()), Convert.ToDateTime(row["OrderDate"].ToString()), (bool)row["Delivered"], double.Parse(row["Price"].ToString()), new Administrator(int.Parse(row["EmployeeID"].ToString()), new Address(int.Parse(row["AddressID"].ToString()), row["City"].ToString(), row["Street"].ToString(), row["PostalCode"].ToString()), new Login(), row["EmployeeName"].ToString(), row["EmployeeSurname"].ToString(), Convert.ToDateTime(row["DateOfBirth"].ToString()), (bool)row["Available"]), new Installation(int.Parse(row["InstallationID"].ToString()), (bool)row["Installed"], new Technician()), orderDetails));
            }

            return orders;
        }

        public static void FinishOrder(int orderID)
        {
            DataHandler.FinishOrder(orderID);
        }

        public static void CancelOrder(int orderID)
        {
            DataHandler.CancelOrder(orderID);
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
