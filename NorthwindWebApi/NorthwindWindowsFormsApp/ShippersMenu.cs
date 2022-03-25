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
    public partial class ShippersMenu : Form
    {
        ShippersDAL shippersDAL = new ShippersDAL();
        public ShippersMenu()
        {
            InitializeComponent();
        }
     
        private void ShippersMenu_Load(object sender, EventArgs e)
        {
            var result = shippersDAL.GetAllShippers();
            dataGridView1.DataSource = result;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Shippers shipper = new Shippers()
            {
                ShipperID = int.Parse(txtShipID.Text.ToString()),
                CompanyName = txtShipCmpyName.Text,
                Phone = txtShipPhone.Text,
            };
            shippersDAL.UpdateShipper(shipper.ShipperID,shipper);
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Shippers shipper = new Shippers()
            {
                ShipperID = int.Parse(txtShipID.Text.ToString()),
                CompanyName = txtShipCmpyName.Text,
                Phone = txtShipPhone.Text,
            };
            shippersDAL.CreateShipper(shipper);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FrmMain menu = new FrmMain();
            menu.Show();
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtShipID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtShipCmpyName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtShipPhone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
