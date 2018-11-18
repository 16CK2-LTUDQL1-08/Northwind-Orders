using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO_Orders;
using DTO_Orders;
using System.Data;

namespace BUS_Orders
{
    public class B_Orders
    {
        public static DataTable getAllOrders()
        {
            return D_Orders.getData();
        }
       
        public static void InsertOrder(Orders od)
        {
            D_Orders.InsertOrder(od);
        }
       public static void UpdateOrder(Orders od)
        {
            D_Orders.UpdateOrders(od);
        }
        public static void DeleteOrder(int odID)
        {
            D_Orders.DeleteOrders(odID);
        }
    }
}
