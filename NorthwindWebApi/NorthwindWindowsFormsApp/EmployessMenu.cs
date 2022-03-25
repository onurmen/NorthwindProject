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
    public partial class EmployessMenu : Form
    {
        public EmployessDAL employessDAL = new EmployessDAL();
        public EmployessMenu()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Employess employes = new Employess()
            {
                EmployeeID = int.Parse(txtEmpID.Text),
                LastName = txtEmpName.Text,
                FirstName = txtEmpNameF.Text,
                Title = txtEmpTitle.Text,
                TitleOfCourtesy = txtEmpTitleOf.Text,
                BirthDate = Convert.ToDateTime(txtEmpBirth.Text),
                HireDate = Convert.ToDateTime(txtEmpHire.Text),
                Address = txtEmpAdrs.Text,
                City = txtEmpCty.Text,
                Region = txtEmpReg.Text,
                PostalCode = txtEmpPostal.Text,
                Country = txtEmpCntry.Text,
                HomePhone = txtEmpHomePhone.Text,
                Extension = txtEmpExtension.Text,
                Notes = txtEmpNotes.Text,
                ReportsTo = int.Parse(txtEmpRep.Text),
                PhotoPath = txtEmpPhoto.Text,
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
            Employess employes = new Employess()
            {
                EmployeeID = int.Parse(txtEmpID.Text),
                LastName = txtEmpName.Text,
                FirstName = txtEmpNameF.Text,
                Title = txtEmpTitle.Text,
                TitleOfCourtesy = txtEmpTitleOf.Text,
                BirthDate = Convert.ToDateTime(txtEmpBirth.Text),
                HireDate = Convert.ToDateTime(txtEmpHire.Text),
                Address = txtEmpAdrs.Text,
                City = txtEmpCty.Text,
                Region = txtEmpReg.Text,
                PostalCode = txtEmpPostal.Text,
                Country = txtEmpCntry.Text,
                HomePhone = txtEmpHomePhone.Text,
                Extension = txtEmpExtension.Text,
                Notes = txtEmpNotes.Text,
                ReportsTo = int.Parse(txtEmpRep.Text),
                PhotoPath = txtEmpPhoto.Text,
            };
            employessDAL.CreateEmployess(employes);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtEmpID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtEmpName.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtEmpNameF.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtEmpTitle.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtEmpTitleOf.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtEmpBirth.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            txtEmpHire.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtEmpAdrs.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            txtEmpCty.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtEmpReg.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtEmpPostal.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtEmpCntry.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            txtEmpHomePhone.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            txtEmpExtension.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            txtEmpNotes.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            txtEmpRep.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            txtEmpPhoto.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            
        }
    }
    }

