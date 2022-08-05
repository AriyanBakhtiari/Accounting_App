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
using ValidationComponents;

namespace Accounting.App
{
    public partial class frmLogin : Form
    {
        public bool IsEdit = false;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (IsEdit)
            {
                
                    this.Text = "تنظیمات کاربری";
                    btnLogin.Text = "اعمال تغییرات";
                

            }

        }

        private void btnLogin_Click(object sender, EventArgs e)

        {
            using (UnitofWorks db = new UnitofWorks())
            {
                if (IsEdit)
                {
                    if (BaseValidator.IsFormValid(this.components))
                    {
                        if (db.LoginRepostitory.Get(l => l.Username == txtUsername.Text).Any())
                        {
                            var result = db.LoginRepostitory.Get().First(r => r.Username == txtUsername.Text);
                            result.Username = txtUsername.Text;
                            result.Password = txtPassword.Text;
                            db.LoginRepostitory.Update(result);
                            db.Save();
                            Application.Exit();
                        }
                        else
                        {
                            MessageBox.Show("لطفا نام کاربری را صحیح وارد نمایید!");
                        }
                    }
                }
                else
                {

                    if (db.LoginRepostitory.Get(l => l.Username == txtUsername.Text && l.Password == txtPassword.Text).Any())
                    {
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("نام کاربری یا رمز عبور اشتباه است!");
                    }
                    




                }

            }
        }
    }
}

