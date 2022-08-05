using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLayer;
using Accounting.DataLayer.Context;
using ValidationComponents;



namespace Accounting.App
{

    public partial class frmAddEditCustomer : Form
    {
        public int CustomerID = 0;
        UnitofWorks db = new UnitofWorks();
        public frmAddEditCustomer()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                // pcCustomer.ima
                pcCustomer.ImageLocation = openFile.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                string imageName = Guid.NewGuid().ToString() + Path.GetExtension(pcCustomer.ImageLocation);
                string path = Application.StartupPath + "/Images/";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                pcCustomer.Image.Save(path + imageName);
                Customer customers = new Customer()
                {
                    Address = txtCustomerAddress.Text,
                    Email = txtCustomerEmail.Text,
                    FullName = txtCustomerName.Text,
                    Mobile = txtCustomerNumber.Text,
                    CustomerImage = imageName
                };
                if (CustomerID == 0)
                {
                    db.CustomerRepository.InsertCustomer(customers);
                   
                }
                else
                {
                    customers.CustomerID = CustomerID;
                    db.CustomerRepository.UpdateCustomer(customers);
                }
                db.Save();
                DialogResult = DialogResult.OK;

            }
            
        }

        private void frmAddEditCustomer_Load(object sender, EventArgs e)
        {
            if (CustomerID != 0)
            {
                this.Text = "ویرایش شخص";
                btnSave.Text = "ویرایش";
                var customer = db.CustomerRepository.GetCustomerByID(CustomerID);
                txtCustomerName.Text = customer.FullName;
                txtCustomerAddress.Text = customer.Address;
                txtCustomerNumber.Text = customer.Mobile;
                txtCustomerEmail.Text = customer.Email;
                pcCustomer.ImageLocation = Application.StartupPath + "/Image/" + customer.CustomerImage;

            }
        }
    }
}
