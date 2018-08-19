using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ClassLibrary
{
    public static class DataHandler
    {

        public static OleDbConnection connection = new OleDbConnection("Provider=SQLNCLI11;Data Source=ATOM\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=dbProject");

        #region Components

        public static DataTable GetComponentIDs()
        {
            DataSet ds = new DataSet();

            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    OleDbDataAdapter data = new OleDbDataAdapter("SELECT ComponentID, Description FROM Component", connection);

                    data.Fill(ds);
                }
                else
                {
                    throw new CustomException("Connection to the database could not be established!");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            return ds.Tables[0];
        }

        public static DataTable GetComponent(int componentID = 0, int productID = 0)
        {
            DataSet ds = new DataSet();

            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    string query = "";

                    if (componentID == 0)
                    {
                        query = "SELECT Component.ComponentID, Component.Description FROM Component INNER JOIN ProductComponent ON Component.ComponentID = ProductComponent.ComponentID WHERE ProductComponent.ProductID = '" + productID + "'";
                    }
                    else if (productID == 0)
                    {
                        query = "SELECT ComponentID, Description FROM Component WHERE ComponentID = '" + componentID + "'";
                    }

                    OleDbDataAdapter data = new OleDbDataAdapter(query, connection);

                    data.Fill(ds);
                }
                else
                {
                    throw new CustomException("Connection to the database could not be established!");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            return ds.Tables[0];
        }

        public static DataTable GetProductComponent(int productID)
        {
            DataSet ds = new DataSet();

            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    OleDbDataAdapter data = new OleDbDataAdapter("SELECT ComponentID, Amount, Description FROM ProductComponent INNER JOIN Component ON Component.ComponentID = PRoductComponent.ComponentID WHERE ProductComponent.ProductID = '"+productID+"'", connection);

                    data.Fill(ds);
                }
                else
                {
                    throw new CustomException("Connection to the database could not be established!");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            return ds.Tables[0];
        }

        public static void AddComponent(_Component component)
        {
            DataSet ds = new DataSet();
            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    OleDbCommand cmd = new OleDbCommand("INSERT INTO Component(Description) VALUES (?)", connection);
                    cmd.Parameters.AddWithValue("?", component.Description);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Component has successfully been added!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    throw new CustomException("Connection to the database could not be established!");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        #endregion

        #region Products

        public static DataTable GetProduct(int productID)
        {
            DataSet ds = new DataSet();

            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    OleDbDataAdapter data = new OleDbDataAdapter("SELECT ProductID, Description, Price FROM Product WHERE ProductID = '" + productID + "' AND Available = 1", connection);

                    data.Fill(ds);
                }
                else
                {
                    throw new CustomException("Connection to the database could not be established!");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            return ds.Tables[0];
        }

        public static DataTable GetProductIDs(string clientID)
        {
            DataSet ds = new DataSet();

            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    OleDbDataAdapter data = new OleDbDataAdapter("SELECT Product.ProductID, Description FROM Product INNER JOIN OrderDetails ON OrderDetails.ProductID = Product.ProductID INNER JOIN [Order] ON [Order].OrderID = OrderDetails.OrderID WHERE [Order].ClientID = '" + clientID + "'", connection);
                    data.Fill(ds);
                }
                else
                {
                    throw new CustomException("Connection to the database could not be established!");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            return ds.Tables[0];
        }

        public static DataTable GetProductIDs(int orderID)
        {
            DataSet ds = new DataSet();

            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    OleDbDataAdapter data = new OleDbDataAdapter("SELECT Product.ProductID, Description FROM Product INNER JOIN OrderDetails ON OrderDetails.ProductID = Product.ProductID INNER JOIN [Order] ON [Order].OrderID = OrderDetails.OrderID INNER JOIN Installation ON [Order].Installation = Installation.InstallationID WHERE [Order].OrderID = '" + orderID + "' AND Installation.Installed = 1", connection);
                    data.Fill(ds);
                }
                else
                {
                    throw new CustomException("Connection to the database could not be established!");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            return ds.Tables[0];
        }

        public static DataTable GetProductIDs()
        {
            DataSet ds = new DataSet();

            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    OleDbDataAdapter data = new OleDbDataAdapter("SELECT ProductID, Description FROM Product WHERE Available = 1", connection);
                    data.Fill(ds);
                }
                else
                {
                    throw new CustomException("Connection to the database could not be established!");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            return ds.Tables[0];
        }

        public static void AddProduct(Product product)
        {
            DataSet ds = new DataSet();
            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {

                    OleDbCommand cmd = new OleDbCommand("INSERT INTO Product(Description, Price, Available) VALUES (?,?,?)", connection);
                    cmd.Parameters.AddWithValue("?", product.Description);
                    cmd.Parameters.AddWithValue("?", product.Price);
                    cmd.Parameters.AddWithValue("?", true);
                    cmd.ExecuteNonQuery();

                    OleDbDataAdapter data = new OleDbDataAdapter("SELECT ProductID FROM Product", connection);
                    data.Fill(ds);

                    int productID = 0;

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        productID = int.Parse(row["ProductID"].ToString());
                    }

                    for (int i = 0; i < product.ProductComponent.Count; i++)
                    {
                        OleDbCommand cmd1 = new OleDbCommand("INSERT INTO ProductComponent(ProductID, ComponentID, Amount) VALUES(?,?,?)", connection);
                        cmd1.Parameters.AddWithValue("?", productID);
                        cmd1.Parameters.AddWithValue("?", product.ProductComponent[i].Component.ComponentID);
                        cmd1.Parameters.AddWithValue("?", product.ProductComponent[i].Quantity);
                        cmd1.ExecuteNonQuery();
                    }

                    MessageBox.Show("Product has successfully been added!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    throw new CustomException("Connection to the database could not be established!");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void UpdateProduct(Product product)
        {
            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    OleDbCommand cmd = new OleDbCommand("UPDATE Product SET Description = ?, Price = ?  WHERE ProductID = ?", connection);
                    cmd.Parameters.AddWithValue("?", product.Description);
                    cmd.Parameters.AddWithValue("?", product.Price);
                    cmd.Parameters.AddWithValue("?", product.ProductID);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Product has successfully been updated!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    throw new CustomException("Connection to the database could not be established!");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void DeleteProduct(int productID)
        {
            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    OleDbCommand cmd = new OleDbCommand("UPDATE Product SET Available = 0 WHERE ProductID = '"+productID+"'", connection);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Product has successfully been deleted!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    throw new CustomException("Connection to the database could not be established!");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        #endregion

        #region Clients

        public static DataTable GetClient(string clientID)
        {
            DataTable dt = new DataTable();

            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    OleDbCommand cmd = new OleDbCommand("GetClient", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@clientID", SqlDbType.Char).Value = clientID;
                    dt.Load(cmd.ExecuteReader());
                }
                else
                {
                    throw new CustomException("Unable to Connect to database");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OleDbException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static void AddClient(Client client)
        {
            OleDbCommand cmd;
            DataSet ds = new DataSet();

            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    cmd = new OleDbCommand("INSERT INTO Address([City], [Street], [PostalCode]) VALUES ('" + client.Address.City + "','" + client.Address.Street + "','" + client.Address.PostalCode + "')", connection);
                    cmd.ExecuteNonQuery();

                    OleDbDataAdapter data = new OleDbDataAdapter("SELECT [AddressID] FROM Address WHERE [City] = '" + client.Address.City + "' AND [Street] = '" + client.Address.Street + "' AND [PostalCode] = '" + client.Address.PostalCode + "'", connection);

                    data.Fill(ds);

                    int addressID = 0;

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        addressID = int.Parse(row["AddressID"].ToString());
                    }

                    cmd = new OleDbCommand("INSERT INTO Client([ClientID], [ClientName], [ClientSurname], [DateOfBirth], [Address], [Contract]) VALUES ('" + client.ClientID + "', '" + client.Name + "','" + client.Surname + "','" + client.DateOfBirth + "','" + addressID + "', '" + client.Contract + "')", connection);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Client has successfully been added!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    throw new CustomException("Connection to the database could not be established!");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void UpdateClient(Client client)
        {
            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    OleDbCommand cmd = new OleDbCommand("UPDATE Client SET ClientName = ?, ClientSurname = ?, DateOfBirth = ? WHERE ClientID = ?", connection);
                    cmd.Parameters.AddWithValue("?", client.Name);
                    cmd.Parameters.AddWithValue("?", client.Surname);
                    cmd.Parameters.AddWithValue("?", client.DateOfBirth);
                    cmd.Parameters.AddWithValue("?", client.ClientID);
                    cmd.ExecuteNonQuery();

                    OleDbCommand cmd1 = new OleDbCommand("UPDATE Address SET City = ?, Street = ?, PostalCode = ? WHERE AddressID = ?", connection);

                    cmd1.Parameters.AddWithValue("?", client.Address.City);
                    cmd1.Parameters.AddWithValue("?", client.Address.Street);
                    cmd1.Parameters.AddWithValue("?", client.Address.PostalCode);
                    cmd1.Parameters.AddWithValue("?", client.Address.AddressID);
                    cmd1.ExecuteNonQuery();

                    MessageBox.Show("Client has successfully been updated!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    throw new CustomException("Connection to the database could not be established!");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        public static DataTable GetClientIDs()
        {
            DataSet ds = new DataSet();

            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    OleDbDataAdapter data = new OleDbDataAdapter("SELECT ClientID FROM Client", connection);
                    data.Fill(ds);
                }
                else
                {
                    throw new CustomException("Connection to the database could not be established!");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            return ds.Tables[0];
        }

        public static void DeleteClient(string clientID)
        {
            DataSet ds = new DataSet();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataAdapter data = new OleDbDataAdapter();
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    List<int> installationIDs = new List<int>();

                    data = new OleDbDataAdapter("SELECT [Order].Installation FROM [Order] WHERE [Order].ClientID = '" + clientID + "'", connection);
                    data.Fill(ds);

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        installationIDs.Add(int.Parse(row["Installation"].ToString()));
                    }

                    ds.Clear();

                    List<int> technicianIDs = new List<int>();

                    for (int i = 0; i < installationIDs.Count; i++)
                    {
                        data = new OleDbDataAdapter("SELECT Technician FROM Installation WHERE InstallationID = '" + installationIDs[i] + "'", connection);
                        data.Fill(ds);

                        foreach (DataRow row in ds.Tables[0].Rows)
                        {
                            technicianIDs.Add(int.Parse(row["Technician"].ToString()));
                        }
                    }

                    ds.Clear();

                    for (int i = 0; i < technicianIDs.Count; i++)
                    {
                        cmd = new OleDbCommand("UPDATE Employee SET Available = 1 WHERE EmployeeID = '" + technicianIDs[i] + "'", connection);
                        cmd.ExecuteNonQuery();
                    }
                    
                    int addressID = 0;

                    data = new OleDbDataAdapter("SELECT Client.Address FROM Client WHERE Client.ClientID = '" + clientID + "'", connection);
                    data.Fill(ds);

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        addressID = int.Parse(row["Address"].ToString());
                    }

                    cmd = new OleDbCommand("DELETE FROM Address WHERE Address.AddressID = '" + addressID + "'", connection);
                    cmd.ExecuteNonQuery();


                    cmd = new OleDbCommand("DELETE FROM Client WHERE ClientID = '" + clientID + "'", connection);
                    cmd.ExecuteNonQuery();


                    for (int i = 0; i < installationIDs.Count; i++)
                    {
                        cmd = new OleDbCommand("DELETE FROM Installation WHERE InstallationID = '" + installationIDs[i] + "'", connection);
                        cmd.ExecuteNonQuery();
                    }


                    MessageBox.Show("Client has successfully been deleted!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    throw new CustomException("Connection to the database could not be established!");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        #endregion

        #region Login

        public static bool Login(string username, string password)
        {
            DataTable dt = new DataTable();

            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    OleDbCommand cmd = new OleDbCommand("ValidateLogin", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", SqlDbType.VarChar).Value = username;
                    cmd.Parameters.AddWithValue("@password", SqlDbType.VarChar).Value = password;
                    dt.Load(cmd.ExecuteReader());

                    if (dt.Rows.Count > 0)
                    {
                        return true;
                    }

                }
                else
                {
                    throw new CustomException("Connection to database could not be established!");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            MessageBox.Show("Invalid Username or Password...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        #endregion 

        #region Administrator / Technician

        public static DataTable GetLoggedInAdmin(string username, string password)
        {
            DataSet ds = new DataSet();

            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    OleDbDataAdapter data = new OleDbDataAdapter("SELECT * FROM Employee INNER JOIN Login ON Employee.Login = Login.LoginID INNER JOIN Address ON Employee.Address = Address.AddressID WHERE  [Username] = '" + username + "' AND [Password] = '" + password + "' ", connection);
                    data.Fill(ds);
                }
                else
                {
                    throw new CustomException("Connection to the database could not be established!");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            return ds.Tables[0];
        }

        public static DataTable GetAvailableTechnicianIDs()
        {
            DataSet ds = new DataSet();

            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    OleDbDataAdapter data = new OleDbDataAdapter("SELECT EmployeeID FROM Employee INNER JOIN EmployeeType ON Employee.EmployeeType = EmployeeType.EmployeeTypeID WHERE EmployeeType.EmployeeTypeID = 2 AND Employee.Available = 1", connection);
                    data.Fill(ds);
                }
                else
                {
                    throw new CustomException("Connection to the database could not be established!");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            return ds.Tables[0];
        }

        #endregion

        #region Orders

        public static DataTable GetOrderIDs()
        {
            DataSet ds = new DataSet();

            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    OleDbDataAdapter data = new OleDbDataAdapter("SELECT OrderID FROM [Order]", connection);
                    data.Fill(ds);
                }
                else
                {
                    throw new CustomException("Connection to the database could not be established!");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            return ds.Tables[0];
        }

        public static DataTable GetOrderIDs(bool delivered, bool installed, bool assigned)
        {
            DataSet ds = new DataSet();

            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    string query = "";

                    if ((delivered) && (installed))
                    {
                        query = "SELECT OrderID FROM [Order] INNER JOIN Installation ON [Order].Installation = Installation.InstallationID WHERE Delivered = 1 AND Installed = 1";
                    }
                    else if ((delivered) && (!installed) && (!assigned))
                    {
                        query = "SELECT OrderID FROM [Order] INNER JOIN Installation ON [Order].Installation = Installation.InstallationID WHERE Delivered = 1 AND Installed = 0 AND Technician = 0";
                    }
                    else if ((delivered) && (!installed) && (assigned))
                    {
                        query = "SELECT OrderID FROM [Order] INNER JOIN Installation ON [Order].Installation = Installation.InstallationID WHERE Delivered = 1 AND Installed = 0 AND Technician > 0";
                    }

                    OleDbDataAdapter data = new OleDbDataAdapter(query, connection);
                    data.Fill(ds);
                }
                else
                {
                    throw new CustomException("Connection to the database could not be established!");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            return ds.Tables[0];
        }

        public static DataTable GetOrderIDs(bool delivered, bool installed)
        {
            DataSet ds = new DataSet();

            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    string query = "";

                    if ((delivered) && (installed))
                    {
                        query = "SELECT OrderID FROM [Order] INNER JOIN Installation ON [Order].Installation = Installation.InstallationID WHERE Delivered = 1 AND Installed = 1";
                    }
                    else if ((delivered) && (!installed))
                    {
                        query = "SELECT OrderID FROM [Order] INNER JOIN Installation ON [Order].Installation = Installation.InstallationID WHERE Delivered = 1 AND Installed = 0 AND Technician = 0";
                    }

                    OleDbDataAdapter data = new OleDbDataAdapter(query, connection);
                    data.Fill(ds);
                }
                else
                {
                    throw new CustomException("Connection to the database could not be established!");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            return ds.Tables[0];
        }

        public static DataTable GetOrderIDs(bool delivered, string clientID, bool installed)
        {
            DataSet ds = new DataSet();

            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    string query = "";

                    if (delivered)
                    {
                        query = "SELECT OrderID FROM [Order] INNER JOIN Installation ON [Order].Installation = Installation.InstallationID WHERE Delivered = 1 AND ClientID = '" + clientID + "' AND Installed = 1";
                    }
                    else
                    {
                        query = "SELECT OrderID FROM [Order] INNER JOIN Installation ON [Order].Installation = Installation.InstallationID WHERE Delivered = 0 AND ClientID = '" + clientID + "' AND Installed = 0";
                    }

                    OleDbDataAdapter data = new OleDbDataAdapter(query, connection);
                    data.Fill(ds);
                }
                else
                {
                    throw new CustomException("Connection to the database could not be established!");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            return ds.Tables[0];
        }

        public static DataTable GetOrderIDs(bool delivered)
        {
            DataSet ds = new DataSet();

            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    string query = "";

                    if (delivered)
                    {
                        query = "SELECT OrderID FROM [Order] WHERE Delivered = 1";
                    }
                    else
                    {
                        query = "SELECT OrderID FROM [Order] WHERE Delivered = 0";
                    }

                    OleDbDataAdapter data = new OleDbDataAdapter(query, connection);
                    data.Fill(ds);
                }
                else
                {
                    throw new CustomException("Connection to the database could not be established!");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            return ds.Tables[0];
        }

        public static void AddOrder(Order order)
        {
            OleDbCommand cmd;
            OleDbDataAdapter data;
            DataSet ds = new DataSet();

            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    cmd = new OleDbCommand("INSERT INTO Installation([Installed], [Technician]) VALUES (0,0)", connection);
                    cmd.ExecuteNonQuery();

                    data = new OleDbDataAdapter("SELECT [InstallationID] FROM Installation", connection);

                    data.Fill(ds);

                    int installationID = 0;

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        installationID = int.Parse(row[0].ToString());
                    }

                    ds.Clear();

                    cmd = new OleDbCommand("INSERT INTO [Order] ([ClientID],[OrderDate],[Delivered],[Employee],[PaymentMethod],[Price],[Installation]) VALUES ('" + order.ClientID + "', '" + order.OrderDate + "', 0, '" + order.Administrator.AdministratorID + "', '" + order.PaymentMethod + "', '" + order.Price + "', '" + installationID + "')", connection);
                    cmd.ExecuteNonQuery();

                    data = new OleDbDataAdapter("SELECT [OrderID] FROM [Order] WHERE [ClientID] = '" + order.ClientID + "' AND [OrderDate] = '" + order.OrderDate + "' AND [Employee] = '" + order.Administrator.AdministratorID + "' AND [Price] = '" + order.Price + "'", connection);

                    data.Fill(ds);

                    int orderID = 0;

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        orderID = int.Parse(row[1].ToString());
                    }

                    for (int i = 0; i < order.OrderDetails.Count; i++)
                    {
                        cmd = new OleDbCommand("INSERT INTO OrderDetails ([OrderID], [ProductID], [Quantity]) VALUES ('" + orderID + "', '" + order.OrderDetails[i].Product.ProductID + "', '" + order.OrderDetails[i].Quantity + "')", connection);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Order has successfully been added!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    throw new CustomException("Connection to the database could not be established!");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OleDbException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        public static DataTable GetOrder(int orderID)
        {
            DataSet ds = new DataSet();
            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {

                    OleDbDataAdapter data = new OleDbDataAdapter("SELECT OrderID, ClientID, Available, PaymentMethodID, Description, OrderDate, Delivered, Price, EmployeeID, EmployeeName, EmployeeSurname, DateOfBirth, AddressID, City, Street, PostalCode, InstallationID, Installed, Technician FROM [Order] INNER JOIN Installation ON [Order].Installation = Installation.InstallationID INNER JOIN Payment ON Payment.PaymentMethodID = PaymentMethod INNER JOIN Employee ON [Order].Employee = Employee.EmployeeID INNER JOIN Address ON Address.AddressID = Employee.Address WHERE OrderID = '" + orderID + "'", connection);
                    data.Fill(ds);
                }
                else
                {
                    throw new CustomException("Connection to the database could not be established!");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            return ds.Tables[0];
        }

        public static DataTable GetOrder(string clientID)
        {
            DataSet ds = new DataSet();
            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {

                    OleDbDataAdapter data = new OleDbDataAdapter("SELECT OrderID, ClientID, Available, PaymentMethodID, Description, OrderDate, Delivered, Price, EmployeeID, EmployeeName, EmployeeSurname, DateOfBirth, AddressID, City, Street, PostalCode, InstallationID, Installed, Technician FROM [Order] INNER JOIN Installation ON [Order].Installation = Installation.InstallationID INNER JOIN Payment ON Payment.PaymentMethodID = [Order].PaymentMethod INNER JOIN Employee ON [Order].Employee = Employee.EmployeeID INNER JOIN Address ON Address.AddressID = Employee.Address WHERE [Order].ClientID = '" + clientID + "'", connection);
                    data.Fill(ds);
                }
                else
                {
                    throw new CustomException("Connection to the database could not be established!");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            return ds.Tables[0];
        }

        public static DataTable GetOrder(int orderID, bool delivered)
        {
            DataSet ds = new DataSet();
            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    string query = "";

                    if (delivered)
                    {
                        query = "SELECT OrderID, ClientID, Available, PaymentMethodID, Description, OrderDate, Delivered, Price, EmployeeID, EmployeeName, EmployeeSurname, DateOfBirth, AddressID, City, Street, PostalCode, InstallationID, Installed, Technician FROM [Order] INNER JOIN Installation ON [Order].Installation = Installation.InstallationID INNER JOIN Payment ON Payment.PaymentMethodID = [Order].PaymentMethod INNER JOIN Employee ON [Order].Employee = Employee.EmployeeID INNER JOIN Address ON Address.AddressID = Employee.Address WHERE [Order].OrderID = '" + orderID + "' AND Delivered = 1";
                    }
                    else
                    {
                        query = "SELECT OrderID, ClientID, Available, PaymentMethodID, Description, OrderDate, Delivered, Price, EmployeeID, EmployeeName, EmployeeSurname, DateOfBirth, AddressID, City, Street, PostalCode, InstallationID, Installed, Technician FROM [Order] INNER JOIN Installation ON [Order].Installation = Installation.InstallationID INNER JOIN Payment ON Payment.PaymentMethodID = [Order].PaymentMethod INNER JOIN Employee ON [Order].Employee = Employee.EmployeeID INNER JOIN Address ON Address.AddressID = Employee.Address WHERE [Order].OrderID = '" + orderID + "' AND Delivered = 0";
                    }

                    OleDbDataAdapter data = new OleDbDataAdapter(query, connection);
                    data.Fill(ds);
                }
                else
                {
                    throw new CustomException("Connection to the database could not be established!");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            return ds.Tables[0];
        }

        public static DataTable GetOrderDetails(int orderID)
        {
            DataSet ds = new DataSet();

            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    OleDbDataAdapter data = new OleDbDataAdapter("SELECT * FROM OrderDetails WHERE OrderID = '" + orderID + "'", connection);
                    data.Fill(ds);
                }
                else
                {
                    throw new CustomException("Connection to the database could not be established!");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            return ds.Tables[0];
        }

        public static void FinishOrder(int orderID)
        {
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    OleDbCommand cmd = new OleDbCommand("UPDATE [Order] SET Delivered = 1 WHERE OrderID = '" + orderID + "'", connection);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Order's status has successfully been changed to 'Delivered'", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    throw new CustomException("Connection to the database could not be established!");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void CancelOrder(int orderID)
        {
            OleDbCommand cmd = new OleDbCommand();
            DataSet ds = new DataSet();
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    OleDbDataAdapter data = new OleDbDataAdapter("SELECT Installation FROM [Order] WHERE OrderID = '"+orderID+"'",connection);
                    data.Fill(ds);

                    int installationID = int.Parse(ds.Tables[0].Rows[0]["Installation"].ToString());

                    cmd = new OleDbCommand("DELETE  FROM [Order] WHERE OrderID = '" + orderID + "'", connection);
                    cmd.ExecuteNonQuery();

                    cmd = new OleDbCommand("DELETE FROM Installation WHERE InstallationID = '" + installationID + "'", connection);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Order has successfully been Cancelled!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    throw new CustomException("Connection to the database could not be established!");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        #endregion

        #region Payments

        public static DataTable GetPaymentMethods()
        {
            DataSet ds = new DataSet();

            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    OleDbDataAdapter data = new OleDbDataAdapter("SELECT * FROM Payment", connection);

                    data.Fill(ds);

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {

                    }
                }
                else
                {
                    throw new CustomException("Connection to the database could not be established!");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            return ds.Tables[0];
        }

        #endregion

        #region Services

        public static DataTable GetTypesOfServices()
        {
            DataSet ds = new DataSet();

            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    OleDbDataAdapter data = new OleDbDataAdapter("SELECT TypeOfServiceID, Description FROM TypeOfService", connection);
                    data.Fill(ds);
                }
                else
                {
                    throw new CustomException("Connection to the database could not be established!");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            return ds.Tables[0];
        }

        #endregion

        #region Tickets

        public static void AddTicket(Ticket ticket)
        {
            DataSet ds = new DataSet();

            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    OleDbCommand cmd = new OleDbCommand("INSERT INTO Service(Product, TypeOfService, Technician) VALUES ('" + ticket.Service.Product + "', '" + ticket.Service.TypeOfService + "', '" + ticket.Service.Technician + "')", connection);
                    cmd.ExecuteNonQuery();

                    int serviceID = 0;

                    OleDbDataAdapter data = new OleDbDataAdapter("SELECT ServiceID FROM Service", connection);
                    data.Fill(ds);

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        serviceID = int.Parse(row["ServiceID"].ToString());
                    }

                    OleDbCommand cmd1 = new OleDbCommand("INSERT INTO Ticket(ClientID, FaultDescription, Service, TicketOpenDate, [Open]) VALUES ('" + ticket.ClientID + "', '" + ticket.FaultDescription + "', '" + serviceID + "', '" + ticket.TicketOpenDate + "', '" + ticket.Open + "')", connection);
                    cmd1.ExecuteNonQuery();

                    OleDbCommand cmd2 = new OleDbCommand("UPDATE Employee SET Available = 0 WHERE EmployeeID = '"+ticket.Service.Technician+"'", connection);
                    cmd2.ExecuteNonQuery();

                    MessageBox.Show("Ticket has successfully been logged!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    throw new CustomException("Connection to the database could not be established!");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        public static DataTable GetTickets(bool assigned)
        {
            DataSet ds = new DataSet();

            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    string query = "";

                    if (assigned)
                    {
                        query = "SELECT * FROM Ticket INNER JOIN Service ON Ticket.Service = Service.ServiceID WHERE Service.Technician > 0";
                    }
                    else
                    {
                        query = "SELECT * FROM Ticket INNER JOIN Service ON Ticket.Service = Service.ServiceID WHERE Service.Technician = 0";
                    }

                    OleDbDataAdapter data = new OleDbDataAdapter(query, connection);
                    data.Fill(ds);
                }
                else
                {
                    throw new CustomException("Connection to the database could not be established!");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            return ds.Tables[0];
        }

        public static DataTable GetTickets(bool assigned, bool open)
        {
            DataSet ds = new DataSet();

            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    string query = "";

                    if ((assigned) && (open))
                    {
                        query = "SELECT * FROM Ticket INNER JOIN Service ON Ticket.Service = Service.ServiceID WHERE Service.Technician > 0 AND Ticket.[Open] = 1";
                    }
                    else if ((assigned) && (!open))
                    {
                        query = "SELECT * FROM Ticket INNER JOIN Service ON Ticket.Service = Service.ServiceID WHERE Service.Technician > 0 AND Ticket.[Open] = 0";
                    }
                    else if ((!assigned) && (open))
                    {
                        query = "SELECT * FROM Ticket INNER JOIN Service ON Ticket.Service = Service.ServiceID WHERE Service.Technician = 0 AND Ticket.[Open] = 1";
                    }
                    else if ((!assigned) && (!open))
                    {
                        query = "SELECT * FROM Ticket INNER JOIN Service ON Ticket.Service = Service.ServiceID WHERE Service.Technician = 0 AND Ticket.[Open] = 0";
                    }

                    OleDbDataAdapter data = new OleDbDataAdapter(query, connection);
                    data.Fill(ds);
                }
                else
                {
                    throw new CustomException("Connection to the database could not be established!");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            return ds.Tables[0];
        }

        public static void CancelTicket(int ticketID)
        {
            DataSet ds = new DataSet();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataAdapter data = new OleDbDataAdapter();
            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    data = new OleDbDataAdapter("SELECT Technician FROM Service INNER JOIN Ticket ON Ticket.Service = Service.ServiceID WHERE Ticket.TicketID = '" + ticketID + "'", connection);
                    data.Fill(ds);

                    int technicianID = int.Parse(ds.Tables[0].Rows[0]["Technician"].ToString());

                    ds.Clear();

                    data = new OleDbDataAdapter("SELECT Service FROM Ticket WHERE TicketID = '"+ticketID+"'", connection);
                    data.Fill(ds);

                    int serviceID = int.Parse(ds.Tables[0].Rows[0]["Service"].ToString());

                    cmd = new OleDbCommand("UPDATE Employee SET Available = 1 WHERE EmployeeID = '" + technicianID + "'", connection);
                    cmd.ExecuteNonQuery();

                    cmd = new OleDbCommand("DELETE FROM Ticket WHERE TicketID = '" + ticketID + "'", connection);
                    cmd.ExecuteNonQuery();

                    cmd = new OleDbCommand("DELETE FROM Service WHERE ServiceID = '" + serviceID + "'", connection);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Ticket has successfully been cancelled!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    throw new CustomException("Connection to the database could not be established!");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void CloseTicket(int ticketID)
        {
            DataSet ds = new DataSet();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataAdapter data = new OleDbDataAdapter();
            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    data = new OleDbDataAdapter("SELECT Technician FROM Service INNER JOIN Ticket ON Ticket.Service = Service.ServiceID WHERE Ticket.TicketID = '" + ticketID + "'", connection);
                    data.Fill(ds);

                    int technicianID = int.Parse(ds.Tables[0].Rows[0]["Technician"].ToString());

                    cmd = new OleDbCommand("UPDATE Employee SET Available = 1 WHERE EmployeeID = '" + technicianID + "'", connection);
                    cmd.ExecuteNonQuery();

                    cmd = new OleDbCommand("UPDATE Ticket SET [Open] = 0 WHERE TicketID = '"+ticketID+"'", connection);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Ticket has successfully been closed!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    throw new CustomException("Connection to the database could not be established!");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        #endregion

        #region Installations

        public static DataTable GetInstallation(bool assigned, bool installed)
        {
            DataSet ds = new DataSet();

            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    string query = "";

                    if ((assigned) && (installed))
                    {
                        query = "SELECT InstallationID, Installed, Technician FROM Installation WHERE Technician > 0 AND Installed = 1";
                    }
                    else if ((assigned) && (!installed))
                    {
                        query = "SELECT InstallationID, Installed, Technician FROM Installation WHERE Technician > 0 AND Installed = 0";
                    }
                    else if ((!assigned) && (!installed))
                    {
                        query = "SELECT InstallationID, Installed, Technician FROM Installation WHERE Technician = 0 AND Installed = 0";
                    }

                    OleDbDataAdapter data = new OleDbDataAdapter(query, connection);
                    data.Fill(ds);
                }
                else
                {
                    throw new CustomException("Connection to the database could not be established!");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            return ds.Tables[0];
        }

        public static void AddInstallation(Installation installation, int orderID)
        {
            DataSet ds = new DataSet();
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    int installationID = 0;

                    OleDbDataAdapter data = new OleDbDataAdapter("SELECT Installation FROM [Order] WHERE OrderID = '"+orderID+"'", connection);
                    data.Fill(ds);

                    installationID = int.Parse(ds.Tables[0].Rows[0]["Installation"].ToString());

                    OleDbCommand cmd = new OleDbCommand("UPDATE Installation SET Installed = '"+installation.Installed+"', Technician = '"+installation.Technician.TechnicianID+"' WHERE InstallationID = '"+installationID+"'", connection);
                    cmd.ExecuteNonQuery();

                    OleDbCommand cmd1 = new OleDbCommand("UPDATE Employee SET Available = 0 WHERE EmployeeID = '"+installation.Technician.TechnicianID+"'", connection);
                    cmd1.ExecuteNonQuery();

                    MessageBox.Show("Installation has successfully been added!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    throw new CustomException("Connection to the database could not be established!");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void CancelInstallation(int installationID)
        {
            OleDbCommand cmd = new OleDbCommand();
            DataSet ds = new DataSet();
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {

                    OleDbDataAdapter data = new OleDbDataAdapter("SELECT Technician FROM Installation WHERE InstallationID = '"+installationID+"'", connection);
                    data.Fill(ds);

                    int technicianID = int.Parse(ds.Tables[0].Rows[0]["Technician"].ToString());

                    cmd = new OleDbCommand("UPDATE Employee SET Available = 1 WHERE EmployeeID = '" + technicianID + "'", connection);
                    cmd.ExecuteNonQuery();

                    cmd = new OleDbCommand("UPDATE Installation SET Technician = 0 WHERE InstallationID = '" + installationID + "'", connection);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Installation has successfully been cancelled!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    throw new CustomException("Connection to the database could not be established!");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void FinishInstallation(int installationID)
        {
            OleDbCommand cmd = new OleDbCommand();
            DataSet ds = new DataSet();
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {

                    OleDbDataAdapter data = new OleDbDataAdapter("SELECT Technician FROM Installation WHERE InstallationID = '" + installationID + "'", connection);
                    data.Fill(ds);

                    int technicianID = int.Parse(ds.Tables[0].Rows[0]["Technician"].ToString());

                    cmd = new OleDbCommand("UPDATE Employee SET Available = 1 WHERE EmployeeID = '" + technicianID + "'", connection);
                    cmd.ExecuteNonQuery();

                    cmd = new OleDbCommand("UPDATE Installation SET Installed = 1 WHERE InstallationID = '" + installationID + "'", connection);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Installation has successfully been completed!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    throw new CustomException("Connection to the database could not be established!");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        #endregion

        #region Calls

        public static void AddCall(PhoneCall call)
        {
            OleDbCommand cmd;
            DataSet ds = new DataSet();

            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    cmd = new OleDbCommand("INSERT INTO CallLog(Duration, Date, Reason, Notes, AdminID) VALUES('" + call.Duration + "', '" + call.Date + "', '" + call.ReasonForCall + "', '" + call.Notes + "', '" + call.AdminID + "')", connection);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    throw new CustomException("Connection to the database could not be established!");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        public static DataTable GetCalls()
        {
            DataSet ds = new DataSet();

            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    OleDbDataAdapter data = new OleDbDataAdapter("SELECT * FROM CallLog", connection);
                    data.Fill(ds);
                }
                else
                {
                    throw new CustomException("Connection to the database could not be established!");
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show(e.Message, "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            return ds.Tables[0];
        }

        #endregion

    }
}
