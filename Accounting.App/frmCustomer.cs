using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLayer.Context;

namespace Accounting.App
{
    public partial class frmCustomer : Form
    {
        
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
        void BindGrid()
        {
            using (UnitofWorks db = new UnitofWorks() )
            {
                dgCustomers.AutoGenerateColumns = false;
                dgCustomers.DataSource = db.CustomerRepository.GetAllCustomers();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtFilter.Text = "";
            BindGrid();
        }

        private void txtFilter_Click(object sender, EventArgs e)
        {
            using (UnitofWorks db = new UnitofWorks())
            {
                dgCustomers.DataSource = db.CustomerRepository.GetCustomerByFilter(txtFilter.Text);
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dgCustomers.CurrentRow != null)
            {
                using (UnitofWorks db = new UnitofWorks())
                {
                    string CustomerName = dgCustomers.CurrentRow.Cells[1].Value.ToString();
                    if (MessageBox.Show($"آیا از حذف {CustomerName} مطمئن هستید؟","توجه",MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int CustomerID = (int)dgCustomers.CurrentRow.Cells[0].Value;
                        db.CustomerRepository.DeleteCustomer(CustomerID);
                        db.Save();
                        BindGrid();
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("لطفا سطری را انتخاب کنید");
            }
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            frmAddEditCustomer frmadd = new frmAddEditCustomer();
            if(frmadd.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            };
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dgCustomers.CurrentRow != null)
            {
                int CustomerID = (int)dgCustomers.CurrentRow.Cells[0].Value;
                frmAddEditCustomer frmAddEdit = new frmAddEditCustomer();
                frmAddEdit.CustomerID = CustomerID;
                if (frmAddEdit.ShowDialog() == DialogResult.OK )
                {
                    BindGrid();
                }
            }
        }
    }
}
 