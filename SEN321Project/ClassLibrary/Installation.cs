using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassLibrary
{
    public class Installation
    {
        private static DataTable dt = new DataTable();

        private int installationID;

        public int InstallationID
        {
            get { return this.installationID; }
            set { this.installationID = value; }
        }

        private bool installed;

        public bool Installed
        {
            get { return this.installed; }
            set { this.installed = value; }
        }

        private Technician technician;

        public Technician Technician
        {
            get { return this.technician; }
            set { this.technician = value; }
        }

        public Installation(int installationID, bool installed, Technician technician)
        {
            this.installationID = installationID;
            this.installed = installed;
            this.technician = technician;
        }

        public Installation()
        {

        }

        public static List<Installation> GetInstallations(bool assigned, bool installed)
        {
            List<Installation> installations = new List<Installation>();

            dt = DataHandler.GetInstallation(assigned, installed);

            foreach (DataRow row in dt.Rows)
            {
                installations.Add(new Installation(int.Parse(row["InstallationID"].ToString()), (bool)row["Installed"], new Technician(int.Parse(row["Technician"].ToString()))));
            }

            return installations;
        }

        public static void AddInstallation(Installation installation, int orderID)
        {
            DataHandler.AddInstallation(installation, orderID);
        }

        public static void CancelInstallation(int installationID)
        {
            DataHandler.CancelInstallation(installationID);
        }

        public static void FinishInstallation(int installationID)
        {
            DataHandler.FinishInstallation(installationID);
        }

        public Installation(int installationID)
        {
            this.installationID = installationID;
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
            return string.Format("{0}", this.installationID);
        }
    }
}
