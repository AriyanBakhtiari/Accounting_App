namespace Accounting.App
{
    partial class frmNewAccouting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgCustomer = new System.Windows.Forms.DataGridView();
            this.نام = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFilterName = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.RadioButton();
            this.btnReceive = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescribe = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dgCustomer);
            this.groupBox1.Controls.Add(this.txtFilterName);
            this.groupBox1.Location = new System.Drawing.Point(6, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 354);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اشخاص";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(431, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label1";
            // 
            // dgCustomer
            // 
            this.dgCustomer.AllowUserToAddRows = false;
            this.dgCustomer.AllowUserToDeleteRows = false;
            this.dgCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.نام});
            this.dgCustomer.Location = new System.Drawing.Point(6, 45);
            this.dgCustomer.Name = "dgCustomer";
            this.dgCustomer.ReadOnly = true;
            this.dgCustomer.Size = new System.Drawing.Size(190, 300);
            this.dgCustomer.TabIndex = 1;
            this.dgCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCustomer_CellClick);
            // 
            // نام
            // 
            this.نام.DataPropertyName = "FullName";
            this.نام.HeaderText = "نام";
            this.نام.Name = "نام";
            this.نام.ReadOnly = true;
            // 
            // txtFilterName
            // 
            this.txtFilterName.Location = new System.Drawing.Point(6, 19);
            this.txtFilterName.Name = "txtFilterName";
            this.txtFilterName.Size = new System.Drawing.Size(190, 20);
            this.txtFilterName.TabIndex = 1;
            this.txtFilterName.TextChanged += new System.EventHandler(this.txtFilterName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label1.Location = new System.Drawing.Point(422, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام شخص:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(226, 15);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(190, 20);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label3.Location = new System.Drawing.Point(417, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "نوع تراکنش:";
            // 
            // btnPay
            // 
            this.btnPay.AutoSize = true;
            this.btnPay.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnPay.Location = new System.Drawing.Point(340, 49);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(58, 17);
            this.btnPay.TabIndex = 4;
            this.btnPay.TabStop = true;
            this.btnPay.Text = "پرداخت";
            this.btnPay.UseVisualStyleBackColor = true;
            // 
            // btnReceive
            // 
            this.btnReceive.AutoSize = true;
            this.btnReceive.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnReceive.Location = new System.Drawing.Point(269, 49);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(55, 17);
            this.btnReceive.TabIndex = 4;
            this.btnReceive.TabStop = true;
            this.btnReceive.Text = "دریافت";
            this.btnReceive.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label4.Location = new System.Drawing.Point(449, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "مبلغ:";
            // 
            // numAmount
            // 
            this.numAmount.Location = new System.Drawing.Point(226, 84);
            this.numAmount.Maximum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            0});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(190, 20);
            this.numAmount.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label5.Location = new System.Drawing.Point(446, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "شرح:";
            // 
            // txtDescribe
            // 
            this.txtDescribe.Location = new System.Drawing.Point(226, 125);
            this.txtDescribe.Multiline = true;
            this.txtDescribe.Name = "txtDescribe";
            this.txtDescribe.Size = new System.Drawing.Size(190, 152);
            this.txtDescribe.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(394, 326);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "ثبت";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmNewAccouting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDescribe);
            this.Controls.Add(this.numAmount);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNewAccouting";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تراکنش جدید";
            this.Load += new System.EventHandler(this.frmNewAccouting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgCustomer;
        private System.Windows.Forms.TextBox txtFilterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn نام;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton btnPay;
        private System.Windows.Forms.RadioButton btnReceive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescribe;
        private System.Windows.Forms.Button btnSave;
    }
}