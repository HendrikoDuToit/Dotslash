using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassLibrary
{
    public class _Component
    {
        private static DataTable dt = new DataTable();

        private int componentID;

        public int ComponentID
        {
            get { return this.componentID; }
            set { this.componentID = value; }
        }

        private string description;

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        public _Component(int componentID, string description)
        {
            this.componentID = componentID;
            this.description = description;
        }

        public _Component(){}

        public static Dictionary<int, string> GetComponentIDs()
        {
            Dictionary<int, string> componentIDs = new Dictionary<int, string>();

            dt = DataHandler.GetComponentIDs();

            foreach (DataRow row in dt.Rows)
            {
                componentIDs[int.Parse(row["ComponentID"].ToString())] = row["Description"].ToString();
            }

            return componentIDs;
        }

        public void AddComponent()
        {
            DataHandler.AddComponent(this);
        }

        public static _Component GetComponentWithComponentID(int componentID)
        {
            _Component component = new _Component();

            dt = DataHandler.GetComponent(componentID);

            foreach (DataRow row in dt.Rows)
            {
                component = new _Component(int.Parse(row["ComponentID"].ToString()), row["Description"].ToString());
            }

            return component;
        }

        public static List<_Component> GetComponentsWithProductID(int productID)
        {
            List<_Component> components = new List<_Component>();

            dt = DataHandler.GetComponent(0, productID);

            foreach (DataRow row in dt.Rows)
            {
                components.Add(new _Component(int.Parse(row["ComponentID"].ToString()), row["Description"].ToString()));
            }

            return components;
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
