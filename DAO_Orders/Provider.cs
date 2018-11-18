using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_Orders
{
    public class Provider
    {
        SqlConnection connection { get; set; }
        public static SqlConnection Connect()
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=HOANG_NAM\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True");
            return Conn;
        }
    }
}
