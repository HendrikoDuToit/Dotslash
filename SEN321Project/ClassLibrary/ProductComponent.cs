using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassLibrary
{
    public class ProductComponent
    {

        private static DataTable dt = new DataTable();

        private _Component component;

        public _Component Component
        {
            get { return this.component; }
            set { this.component = value; }
        }

        private int quantity;

        public int Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }

        public ProductComponent(_Component component, int quantity)
        {
            this.component = component;
            this.quantity = quantity;
        }

        public static List<ProductComponent> GetProductComponentFromDB(int productID)
        {
            List<ProductComponent> productComponents = new List<ProductComponent>();

            dt = DataHandler.GetProductComponent(productID);

            foreach (DataRow row in dt.Rows)
            {
                productComponents.Add(new ProductComponent(new _Component(int.Parse(row["ComponentID"].ToString()), row["Description"].ToString()), int.Parse(row["Quantity"].ToString())));
            }

            return productComponents;
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
