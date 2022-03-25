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
    public partial class CategoriesMenu : Form
    {
        public CategoriesDAL categoriesDAL = new CategoriesDAL();
        public CategoriesMenu()
        {
            InitializeComponent();
        }

        private void CategoriesMenu_Load(object sender, EventArgs e)
        {
            
                   
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories()
            {
                CategoriesID = int.Parse(txtCATID.Text),
                Description = txtDescription.Text,
                CategoriesName = txtCATName.Text,
            };

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FrmMain menu = new FrmMain();
            menu.Show();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories()
            {
                CategoriesID = int.Parse(txtCATID.Text),
                Description = txtDescription.Text,
                CategoriesName = txtCATName.Text,
            };
            categoriesDAL.CreateCategories(categories);
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtCATID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtDescription.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtCATName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
