using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Orders;
namespace DAO_Orders
{
    public class D_Orders
    {
        public static DataTable getData()
        {

            SqlConnection Conn = Provider.Connect();
            SqlCommand command = new SqlCommand("sp_Load", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }

        public static void InsertOrder(Orders od)
        {
            SqlConnection Conn = Provider.Connect();
            SqlCommand command = new SqlCommand("sp_Them", Conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@OrderID", SqlDbType.Int);
            command.Parameters.Add("@CustomerID", SqlDbType.NChar, 5);
            command.Parameters.Add("@EmployeeID", SqlDbType.Int);
            command.Parameters.Add("@OrderDate", SqlDbType.DateTime);
            command.Parameters.Add("@RequiredDate", SqlDbType.Date);
            command.Parameters.Add("@ShippedDate", SqlDbType.Date);
            command.Parameters.Add("@ShipVia", SqlDbType.Int);
            command.Parameters.Add("@Freight", SqlDbType.Float);
            command.Parameters.Add("@ShipName", SqlDbType.NVarChar, 40);
            command.Parameters.Add("@ShipAddress", SqlDbType.NVarChar, 60);
            command.Parameters.Add("@ShipCity", SqlDbType.NVarChar, 15);
            command.Parameters.Add("@ShipRegion", SqlDbType.NVarChar, 15);
            command.Parameters.Add("@ShipPostalCode", SqlDbType.NVarChar, 10);
            command.Parameters.Add("@ShipCountry", SqlDbType.NVarChar, 15);

            command.Parameters["@OrderID"].Value = od.OderID;
            command.Parameters["@CustomerID"].Value = od.CustomerID;
            command.Parameters["@EmployeeID"].Value = od.EmployeeID;
            command.Parameters["@OrderDate"].Value = od.OrderDate;
            command.Parameters["@RequiredDate"].Value = od.RequiredDate;
            command.Parameters["@ShippedDate"].Value = od.ShippedDate;
            command.Parameters["@ShipVia"].Value = od.ShipVia;
            command.Parameters["@Freight"].Value = od.Freight;
            command.Parameters["@ShipName"].Value = od.ShipName;
            command.Parameters["@ShipAddress"].Value = od.ShipAddress;
            command.Parameters["@ShipCity"].Value = od.ShipCity;
            command.Parameters["@ShipRegion"].Value = od.ShipRegion;
            command.Parameters["@ShipPostalCode"].Value = od.ShipPostalCode;
            command.Parameters["@ShipCountry"].Value = od.ShipCountry;


            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
            
        }
        public static void UpdateOrders(Orders od)
        {
            SqlConnection Conn = Provider.Connect();
            SqlCommand command = new SqlCommand("sp_Update", Conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@OrderID", SqlDbType.Int);
            command.Parameters.Add("@CustomerID", SqlDbType.NChar, 5);
            command.Parameters.Add("@EmployeeID", SqlDbType.Int);
            command.Parameters.Add("@OrderDate", SqlDbType.DateTime);
            command.Parameters.Add("@RequiredDate", SqlDbType.Date);
            command.Parameters.Add("@ShippedDate", SqlDbType.Date);
            command.Parameters.Add("@ShipVia", SqlDbType.Int);
            command.Parameters.Add("@Freight", SqlDbType.Float);
            command.Parameters.Add("@ShipName", SqlDbType.NVarChar, 40);
            command.Parameters.Add("@ShipAddress", SqlDbType.NVarChar, 60);
            command.Parameters.Add("@ShipCity", SqlDbType.NVarChar, 15);
            command.Parameters.Add("@ShipRegion", SqlDbType.NVarChar, 15);
            command.Parameters.Add("@ShipPostalCode", SqlDbType.NVarChar, 10);
            command.Parameters.Add("@ShipCountry", SqlDbType.NVarChar, 15);

            command.Parameters["@OrderID"].Value = od.OderID;
            command.Parameters["@CustomerID"].Value = od.CustomerID;
            command.Parameters["@EmployeeID"].Value = od.EmployeeID;
            command.Parameters["@OrderDate"].Value = od.OrderDate;
            command.Parameters["@RequiredDate"].Value = od.RequiredDate;
            command.Parameters["@ShippedDate"].Value = od.ShippedDate;
            command.Parameters["@ShipVia"].Value = od.ShipVia;
            command.Parameters["@Freight"].Value = od.Freight;
            command.Parameters["@ShipName"].Value = od.ShipName;
            command.Parameters["@ShipAddress"].Value = od.ShipAddress;
            command.Parameters["@ShipCity"].Value = od.ShipCity;
            command.Parameters["@ShipRegion"].Value = od.ShipRegion;
            command.Parameters["@ShipPostalCode"].Value = od.ShipPostalCode;
            command.Parameters["@ShipCountry"].Value = od.ShipCountry;


            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();

        }
        public static void DeleteOrders(int odID)
        {
            SqlConnection Conn = Provider.Connect();
            SqlCommand command = new SqlCommand("sp_Delete", Conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@OrderID", SqlDbType.Int);
           
            command.Parameters["@OrderID"].Value = odID;
            
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();

        }
    }
}