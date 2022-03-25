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
    public partial class CustomersMenu : Form

    {
        public CustomersDAL customersDAL = new CustomersDAL();


        public CustomersMenu()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCountry_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPostal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRegion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStreet_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContactTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContactName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCompanyName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lblcity_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FrmMain menu = new FrmMain();
            menu.Show();
            this.Close();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Customers customer = new Customers()
            {
                CustomerID = int.Parse(txtID.Text),
                CompanyName = txtCompanyName.Text,
                ContactName = txtContactName.Text,
                ContactTitle = txtContactTitle.Text,
                Address = txtAdress.Text,
                City = txtCity.Text,
                Region = txtRegion.Text,
                PostalCode = txtPostal.Text,
                Country = txtCountry.Text,
                Phone = txtPhone.Text,
                Fax = txtFax.Text,
            };
            customersDAL.UpdateCustomer(customer.CustomerID, customer);
            

        }

        private void CustomersMenu_Load(object sender, EventArgs e)
        {
            var result = customersDAL.GetAllCustomers();
            dataGridView1.DataSource = result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Customers customer = new Customers()
            {
                CustomerID = int.Parse(txtID.Text),
                CompanyName = txtCompanyName.Text,
                ContactName = txtContactName.Text,
                ContactTitle = txtContactTitle.Text,
                Address = txtAdress.Text,
                City = txtCity.Text,
                Region = txtRegion.Text,
                PostalCode = txtPostal.Text,
                Country = txtCountry.Text,
                Phone = txtPhone.Text,
                Fax = txtFax.Text,
            };
            customersDAL.CreateCustomer(customer);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtCompanyName.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtContactName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtContactTitle .Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtAdress.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtStreet.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtCity.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtRegion.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtPostal.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtCountry.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtPhone.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtFax.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }
    }
}
