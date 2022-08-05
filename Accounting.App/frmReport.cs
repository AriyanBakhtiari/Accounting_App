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
using Accounting.Utility.Convertor;

namespace Accounting.App
{
    public partial class frmReport : Form
    {
        public int TypeID = 0;
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            if (TypeID == 2)
            {
                this.Text = "گزارش پرداختی ها";
                filter();
            }
            else
            {
                this.Text = "گزارش دریافتی ها";
                filter();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            filter();
        }

        public void filter()
        {
            using (UnitofWorks db = new UnitofWorks())
            {
                var result = db.AccountingRepository.Get(a => a.TypeID == TypeID);
                //dbCustomer.AutoGenerateColumns = false;
                //dbCustomer.DataSource = result;
                dbCustomer.Rows.Clear();
                foreach (var Accounting in result)
                {
                    var CustomerName = db.CustomerRepository.GetCustomerNamebyID(Accounting.CustomerID);

                    dbCustomer.Rows.Add(Accounting.ID, CustomerName, Accounting.Amount, Accounting.DateTime.ToShamsi(), Accounting.Description);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            filter();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dbCustomer.SelectedRows != null)
            {
                int ID = int.Parse(dbCustomer.CurrentRow.Cells[0].Value.ToString());

                if (MessageBox.Show("ایا از حذف آن اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (UnitofWorks db = new UnitofWorks())
                    {
                        db.AccountingRepository.Delete(ID);
                        db.Save();
                        filter();
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dbCustomer.SelectedRows != null)
            {
                frmNewAccouting frm = new frmNewAccouting();
                frm.AccountingID = int.Parse(dbCustomer.CurrentRow.Cells[0].Value.ToString());
                frm.ShowDialog();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    filter();
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Customer");
            dt.Columns.Add("Amount");
            dt.Columns.Add("Date");
            dt.Columns.Add("Description");
            foreach (DataGridViewRow item in dbCustomer.Rows)
            {
                dt.Rows.Add(
                    item.Cells[0].Value.ToString(),
                    item.Cells[1].Value.ToString(),
                    item.Cells[2].Value.ToString(),
                    item.Cells[3].Value.ToString()
                    );
            }
            stiPrint.Load(Application.StartupPath + "/Report.mrt");
            stiPrint.RegData("DT" , dt);
            stiPrint.Show();
        }
    }
}
