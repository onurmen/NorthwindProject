using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindWindowsFormsApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomersMenu customersMenu = new CustomersMenu();
            customersMenu.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShippersMenu shippersMenu = new ShippersMenu();
            shippersMenu.Show();
            this.Hide();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            CategoriesMenu categories = new CategoriesMenu();
            categories.Show();
            this.Hide();

        }

        private void btnEmployess_Click(object sender, EventArgs e)
        {
            EmployessMenu employess = new EmployessMenu();
           employess.Show();
            this.Hide();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductsMenu products = new ProductsMenu();
            products.Show();
            this.Hide();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OrdersMenu orders = new OrdersMenu();  
            orders.Show();
            this.Hide();
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            SuppliersMenu suppliers = new SuppliersMenu();
            suppliers.Show();
            this.Hide();
        }
    }
}
