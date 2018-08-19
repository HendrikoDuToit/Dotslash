using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassLibrary
{
    public class Product
    {
        private static DataTable dt = new DataTable();

        private int productID;

        public int ProductID
        {
            get { return this.productID; }
            set { this.productID = value; }
        }

        private string description;

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        private double price;

        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        private List<ProductComponent> productComponent;

        public List<ProductComponent> ProductComponent
        {
            get { return this.productComponent; }
            set { this.productComponent = value; }
        }

        public Product(int productID, string description, double price, List<ProductComponent> productComponent)
        {
            this.productID = productID;
            this.description = description;
            this.price = price;
            this.ProductComponent = productComponent;
        }

        public Product(){}

        public static Dictionary<int, string> GetProductIDs()
        {
            Dictionary<int, string> dictionaryProductIDs = new Dictionary<int, string>();

            dt = DataHandler.GetProductIDs();

            foreach (DataRow row in dt.Rows)
            {
                dictionaryProductIDs[int.Parse(row["ProductID"].ToString())] = row["Description"].ToString();
            }

            return dictionaryProductIDs;
        }

        public static List<string> GetProductIDs(string clientID)
        {
            Dictionary<int, string> dictionaryProductIDs = new Dictionary<int, string>();

            dt = DataHandler.GetProductIDs(clientID);

            foreach (DataRow row in dt.Rows)
            {
                dictionaryProductIDs[int.Parse(row["ProductID"].ToString())] = row["Description"].ToString();
            }

            List<string> productIDs = new List<string>();

            foreach (KeyValuePair<int, string> item in dictionaryProductIDs)
            {
                productIDs.Add(item.Key.ToString() + " - " + item.Value);
            }

            return productIDs;
        }

        public static List<string> GetProductIDs(int orderID)
        {
            Dictionary<int, string> dictionaryProductIDs = new Dictionary<int, string>();

            dt = DataHandler.GetProductIDs(orderID);

            foreach (DataRow row in dt.Rows)
            {
                dictionaryProductIDs[int.Parse(row["ProductID"].ToString())] = row["Description"].ToString();
            }

            List<string> productIDs = new List<string>();

            foreach (KeyValuePair<int, string> item in dictionaryProductIDs)
            {
                productIDs.Add(item.Key.ToString() + " - " + item.Value);
            }

            return productIDs;
        }

        public static Product GetProductFromDB(int productID)
        {
            Product product = new Product();

            dt = DataHandler.GetProduct(productID);

            foreach (DataRow row in dt.Rows)
            {
                product = new Product(int.Parse(row["ProductID"].ToString()), row["Description"].ToString(), double.Parse(row["Price"].ToString()), null);
            }

            return product;
        }

        public void AddProduct()
        {
            DataHandler.AddProduct(this);
        }

        public void UpdateProduct()
        {
            DataHandler.UpdateProduct(this);
        }

        public static void DeleteProduct(int productID)
        {
            DataHandler.DeleteProduct(productID);
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
            return string.Format("{0}{1}", this.productID, this.Description);
        }
    }
}
