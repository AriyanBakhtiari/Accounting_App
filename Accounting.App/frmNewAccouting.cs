using Accounting.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.App
{
    public partial class frmNewAccouting : Form
    {
        UnitofWorks db = new UnitofWorks();
        public int AccountingID = 0 ; 
        public frmNewAccouting()
        {
            InitializeComponent();
        }

        private void frmNewAccouting_Load(object sender, EventArgs e)
        {
            dgCustomer.AutoGenerateColumns = false ;
            dgCustomer.DataSource = db.CustomerRepository.GetCustomerName();
            if (AccountingID != 0){
                var account = db.AccountingRepository.GetByID(AccountingID);
                txtName.Text = db.CustomerRepository.GetCustomerNamebyID(account.CustomerID);
                txtDescribe.Text = account.Description;
                numAmount.Text = account.Amount.ToString();
                if (account.TypeID == 0)
                {
                    btnPay.Checked = true;
                }
                else
                {
                    btnReceive.Checked = true;
                }
                this.Text = "ویرایش طرف حساب" ;
                this.btnSave.Text = "ویرایش" ;
            }

        }

        private void txtFilterName_TextChanged(object sender, EventArgs e)
        {
            
            dgCustomer.AutoGenerateColumns = false;
            dgCustomer.DataSource = db.CustomerRepository.GetCustomerName(txtFilterName.Text);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void dgCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgCustomer.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(btnPay.Checked || btnReceive.Checked)
            {
                DataLayer.Accounting accounting = new DataLayer.Accounting()
                {
                    Amount = int.Parse(numAmount.Value.ToString()),
                    CustomerID = db.CustomerRepository.GetCustomerID(txtName.Text),
                    TypeID = (btnReceive.Checked) ? 1 : 2,
                    DateTime = DateTime.Now,    
                    Description = txtDescribe.Text,
                };
                if (AccountingID == 0)
                {
                    db.AccountingRepository.Insert(accounting);
                }
                else
                {
                    accounting.ID = AccountingID;
                    db.AccountingRepository.Update(accounting);
                }
                db.Save();
                DialogResult = DialogResult.OK;
                 
            }
            else
            {
                MessageBox.Show("لطفا نوع تراکنش را انتخاب کنید");
            }
        }
    }
}
