using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassLibrary
{
    public class OrderDetail
    {
        private static DataTable dt = new DataTable();

        private int orderID;

        public int OrderID
        {
            get { return this.orderID; }
            set { this.orderID = value; }
        }

        private Product product;

        public Product Product
        {
            get { return this.product; }
            set { this.product = value; }
        }

        private int quantity;

        public int Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }

        public OrderDetail(int orderID, Product product, int quantity)
        {
            this.orderID = orderID;
            this.product = product;
            this.quantity = quantity;
        }

        public OrderDetail()
        {
            // TODO: Complete member initialization
        }

        public static List<OrderDetail> GetOrderDetailsFromDB(int orderID)
        {
            List<OrderDetail> orderDetails = new List<OrderDetail>();

            dt = DataHandler.GetOrderDetails(orderID);

            foreach (DataRow row in dt.Rows)
            {
                orderDetails.Add(new OrderDetail(int.Parse(row["OrderID"].ToString()), new Product(int.Parse(row["ProductID"].ToString()), "", 0, null), int.Parse(row["Quantity"].ToString())));
            }

            return orderDetails;
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
            return string.Format("{0}\n{1}", this.product.Description, this.quantity);
        }
    }
}
