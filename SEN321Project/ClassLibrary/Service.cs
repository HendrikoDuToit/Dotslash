using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassLibrary
{
    public class Service
    {
        private static DataTable dt = new DataTable();

        private int serviceID;

        public int ServiceID
        {
            get { return this.serviceID; }
            set { this.serviceID = value; }
        }

        private int product;

        public int Product
        {
            get { return this.product; }
            set { this.product = value; }
        }

        private int typeOfService;

        public int TypeOfService
        {
            get { return this.typeOfService; }
            set { this.typeOfService = value; }
        }

        private int technician;

        public int Technician
        {
            get { return this.technician; }
            set { this.technician = value; }
        }

        public Service(int serviceID, int product, int typeOfService, int technician)
        {
            this.serviceID = serviceID;
            this.product = product;
            this.typeOfService = typeOfService;
            this.technician = technician;
        }

        public Service()
        {
        }

        public static Dictionary<int, string> GetTypesOfServices()
        {
            Dictionary<int, string> typesOfServices = new Dictionary<int, string>();

            dt = DataHandler.GetTypesOfServices();

            foreach (DataRow row in dt.Rows)
            {
                typesOfServices[int.Parse(row["TypeOfServiceID"].ToString())] = row["Description"].ToString();
            }

            return typesOfServices;
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
