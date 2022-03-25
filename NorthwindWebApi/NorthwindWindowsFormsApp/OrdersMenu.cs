using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NorthwindDAL;
using NorthwindEntities;

namespace NorthwindWindowsFormsApp
{
    public partial class OrdersMenu : Form
    { 
        OrderDAL ordersDal = new OrderDAL();
        public OrdersMenu()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders()
            {
                OrderID = int.Parse(txtOrderID.Text),
                CustomerID = cmbCus.SelectedValue.ToString(),
                EmployeeID = int.Parse(cmbEmp.SelectedValue.ToString()),
                OrderDate = Convert.ToDateTime(txtOrDate.Text),
                RequiredDate = Convert.ToDateTime(txtReqDate.Text),
                ShippedDate = Convert.ToDateTime(txtShipDate.Text),
                ShipVia = int.Parse(txtShipVia.Text),
                Freight = decimal.Parse(txtFreight.Text),
                ShipName = txtShipName.Text,
                ShipAddress = txtShipAdress.Text,
                ShipCity = txtOrcity.Text,
                ShipRegion = txtOrReg.Text,
                ShipPostalCode = txtOrPostal.Text,
                ShipCountry = txtOrCountry.Text

            };

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Orders orders = new Orders()
            {
                OrderID = int.Parse(txtOrderID.Text),
                CustomerID = cmbCus.SelectedValue.ToString(),
                EmployeeID = int.Parse(cmbEmp.SelectedValue.ToString()),
                OrderDate = Convert.ToDateTime(txtOrDate.Text),
                RequiredDate = Convert.ToDateTime(txtReqDate.Text),
                ShippedDate = Convert.ToDateTime(txtShipDate.Text),
                ShipVia = int.Parse(txtShipVia.Text),
                Freight = decimal.Parse(txtFreight.Text),
                ShipName = txtShipName.Text,
                ShipAddress = txtShipAdress.Text,
                ShipCity = txtOrcity.Text,
                ShipRegion = txtOrReg.Text,
                ShipPostalCode = txtOrPostal.Text,
                ShipCountry = txtOrCountry.Text

            };
            ordersDal.CreateOrders(orders);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FrmMain menu = new FrmMain();
            menu.Show();
            this.Close();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
           
        }

        private void OrdersMenu_Load(object sender, EventArgs e)
        {
            var result = ordersDal.GetAllOrders();
            dataGridView1.DataSource = result;
        }
    }
}
