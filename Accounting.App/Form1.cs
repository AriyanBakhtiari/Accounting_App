using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.Business;
using Accounting.Utility.Convertor;
using Accounting.ViewModels.Accounting;

namespace Accounting.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer frmCustomer = new frmCustomer();
            frmCustomer.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmNewAccouting frmNewAccouting = new frmNewAccouting();
            frmNewAccouting.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Hide();
            frmLogin login = new frmLogin();
            if (login.ShowDialog() == DialogResult.OK)
            {
                this.Show();
                lblDate.Text = DateTime.Now.ToShamsi();
                lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
                

            }
            else
            {
                Application.Exit();
            }
        }


        private void btnPayReport_Click(object sender, EventArgs e)
        {
            frmReport frmreport = new frmReport();
            frmreport.TypeID = 2;
            frmreport.ShowDialog();
        }

        private void btnReceiveReport_Click(object sender, EventArgs e)
        {
            frmReport frmreport = new frmReport();
            frmreport.TypeID = 1;
            frmreport.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            Report();
            
        }

        private void btnLoginSetting_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.IsEdit = true;
            login.ShowDialog();
        }

        void Report()
        {
            ReportView Report = Account.ReportMain();
            lblRecieve.Text = Report.Receive.ToString("#,0");
            lblPay.Text = Report.Pay.ToString("#,0");
            lblAccountBlance.Text = Report.Balance.ToString("#,0");
        }

       
    }
}
