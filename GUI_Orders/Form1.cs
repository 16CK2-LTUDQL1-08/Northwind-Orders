using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_Orders;
using DTO_Orders;

namespace GUI_Orders
{
    public partial class Form1 : Form
    { 
    //{
    //    private int cur;
    //    DataTable dt = BUS_Orders.B_Orders.getAllOrders();
        public Form1()
        {
            InitializeComponent();
        }
        //private void loading()
        //{
        //    cur= dtgvOrders.
        //}
        private void Form1_Load(object sender, EventArgs e)
        {
            dtgvOrders.DataSource = B_Orders.getAllOrders();
      
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int oID = Int32.Parse(tbOrderID.Text);
                string cID = tbCustomerID.Text;
                int eID = Int32.Parse(tbEmployeeID.Text);
                DateTime oDate = dtOrder.Value;
                DateTime rDate = dtRequired.Value;
                DateTime sDate = dtShipped.Value;
                int sVia = Int32.Parse(tbShipVia.Text);
                float fre = float.Parse(tbFreight.Text);
                string sName = tbShipName.Text;
                string sAddress = tbShipAddress.Text;
                string sCity = tbShipCity.Text;
                string sRegion = tbShipRegion.Text;
                string sPostalCode = tbShipPostalCode.Text;
                string sCountry = tbShipCountry.Text;
                Orders order = new Orders(oID, cID, eID, oDate, rDate, sDate, sVia, fre, sName, sAddress, sCity, sRegion, sPostalCode, sCountry);
                B_Orders.InsertOrder(order);
                MessageBox.Show("Bạn đã thêm order có ID " + oID + " thành công!");
                dtgvOrders.DataSource = B_Orders.getAllOrders();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void dtgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgvOrders.Rows[e.RowIndex];
                tbOrderID.Text = row.Cells[0].Value.ToString();
                tbCustomerID.Text = row.Cells[1].Value.ToString();
                tbEmployeeID.Text = row.Cells[2].Value.ToString();
                dtOrder.Text = row.Cells[3].Value.ToString();
                dtRequired.Text = row.Cells[4].Value.ToString();
                dtShipped.Text = row.Cells[5].Value.ToString();
                tbShipVia.Text = row.Cells[6].Value.ToString();
                tbFreight.Text = row.Cells[7].Value.ToString();
                tbShipName.Text = row.Cells[8].Value.ToString();
                tbShipAddress.Text = row.Cells[9].Value.ToString();
                tbShipCity.Text = row.Cells[10].Value.ToString();
                tbShipRegion.Text = row.Cells[11].Value.ToString();
                tbShipPostalCode.Text = row.Cells[12].Value.ToString();
                tbShipCountry.Text = row.Cells[12].Value.ToString();
            }
            catch
            {

            }


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int oID = Int32.Parse(tbOrderID.Text);
                string cID = tbCustomerID.Text;
                int eID = Int32.Parse(tbEmployeeID.Text);
                DateTime oDate = dtOrder.Value;
                DateTime rDate = dtRequired.Value;
                DateTime sDate = dtShipped.Value;
                int sVia = Int32.Parse(tbShipVia.Text);
                float fre = float.Parse(tbFreight.Text);
                string sName = tbShipName.Text;
                string sAddress = tbShipAddress.Text;
                string sCity = tbShipCity.Text;
                string sRegion = tbShipRegion.Text;
                string sPostalCode = tbShipPostalCode.Text;
                string sCountry = tbShipCountry.Text;
                Orders order = new Orders(oID, cID, eID, oDate, rDate, sDate, sVia, fre, sName, sAddress, sCity, sRegion, sPostalCode, sCountry);
                B_Orders.UpdateOrder(order);
                MessageBox.Show("Bạn đã sửa order có ID " + oID + " thành công!");
                dtgvOrders.DataSource = B_Orders.getAllOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int oID = Int32.Parse(tbOrderID.Text);
                string cID = tbCustomerID.Text;
                int eID = Int32.Parse(tbEmployeeID.Text);
                DateTime oDate = dtOrder.Value;
                DateTime rDate = dtRequired.Value;
                DateTime sDate = dtShipped.Value;
                int sVia = Int32.Parse(tbShipVia.Text);
                float fre = float.Parse(tbFreight.Text);
                string sName = tbShipName.Text;
                string sAddress = tbShipAddress.Text;
                string sCity = tbShipCity.Text;
                string sRegion = tbShipRegion.Text;
                string sPostalCode = tbShipPostalCode.Text;
                string sCountry = tbShipCountry.Text;
                Orders order = new Orders(oID, cID, eID, oDate, rDate, sDate, sVia, fre, sName, sAddress, sCity, sRegion, sPostalCode, sCountry);
                B_Orders.DeleteOrder(oID);
                MessageBox.Show("Bạn đã xóa order có ID " + oID + " thành công!");
                dtgvOrders.DataSource = B_Orders.getAllOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

    }
}