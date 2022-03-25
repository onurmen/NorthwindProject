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
    public partial class SuppliersMenu : Form
    {
        SuppliersDAL supplierDal = new SuppliersDAL();
        public SuppliersMenu()
        {
            InitializeComponent();
        }

        private void txtSuppPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSuppCountry_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSuppPostal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSuppRegion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSuppCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSuppStreet_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSuppAdress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSuppContactTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSuppContactName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSuppCompanyName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSuppID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblstreet_Click(object sender, EventArgs e)
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Suppliers suppliers = new Suppliers()
            {
                SuppliersID = int.Parse(txtSuppID.Text),
                CompanyName = txtSuppCompanyName.Text,
                ContactName = txtSuppContactName.Text,
                ContactTitle = txtSuppContactTitle.Text,
                Address = txtSuppAdress.Text,
                Street = txtSuppStreet.Text,
                City = txtSuppCity.Text,
                PostalCode=txtSuppPostal.Text, 
                Country = txtSuppCountry.Text,
                Phone = txtSuppPhone.Text,
            };
            supplierDal.UpdateSuppliers(suppliers.SuppliersID,suppliers);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Suppliers suppliers = new Suppliers()
            {
                SuppliersID = int.Parse(txtSuppID.Text),
                CompanyName = txtSuppCompanyName.Text,
                ContactName = txtSuppContactName.Text,
                ContactTitle = txtSuppContactTitle.Text,
                Address = txtSuppAdress.Text,
                Street = txtSuppStreet.Text,
                City = txtSuppCity.Text,
                PostalCode = txtSuppPostal.Text,
                Country = txtSuppCountry.Text,
                Phone = txtSuppPhone.Text,
            };
            supplierDal.CreateSupplier(suppliers);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FrmMain menu = new FrmMain();
            menu.Show();
            this.Close();
        }

        private void SuppliersMenu_Load(object sender, EventArgs e)
        {
            var result = supplierDal.GetAllSuppliers();
            dataGridView1.DataSource = result;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            txtSuppID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtSuppCompanyName.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtSuppContactName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSuppContactTitle.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtSuppAdress.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtSuppStreet.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtSuppCity.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtSuppRegion.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtSuppPostal.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtSuppCountry.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtSuppPhone.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
           
        }
    }
}
