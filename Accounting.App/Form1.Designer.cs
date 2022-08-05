namespace Accounting.App
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSetting = new System.Windows.Forms.ToolStripSplitButton();
            this.btnLoginSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnCustomer = new System.Windows.Forms.ToolStripButton();
            this.btnNewAccounting = new System.Windows.Forms.ToolStripButton();
            this.btnPayReport = new System.Windows.Forms.ToolStripButton();
            this.btnReceiveReport = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRecieve = new System.Windows.Forms.Label();
            this.lblPay = new System.Windows.Forms.Label();
            this.lblAccountBlance = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSetting});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSetting
            // 
            this.btnSetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoginSetting});
            this.btnSetting.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(66, 22);
            this.btnSetting.Text = "تنظیمات";
            // 
            // btnLoginSetting
            // 
            this.btnLoginSetting.Name = "btnLoginSetting";
            this.btnLoginSetting.Size = new System.Drawing.Size(142, 22);
            this.btnLoginSetting.Text = "تنظیمات ورود";
            this.btnLoginSetting.Click += new System.EventHandler(this.btnLoginSetting_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCustomer,
            this.btnNewAccounting,
            this.btnPayReport,
            this.btnReceiveReport});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(784, 62);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCustomer.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnCustomer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCustomer.Image = global::Accounting.App.Properties.Resources._1371476468_preferences_contact_list;
            this.btnCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(67, 59);
            this.btnCustomer.Text = "طرف حساب";
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnNewAccounting
            // 
            this.btnNewAccounting.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNewAccounting.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNewAccounting.Image = global::Accounting.App.Properties.Resources._1370791030_credit_card;
            this.btnNewAccounting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNewAccounting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewAccounting.Name = "btnNewAccounting";
            this.btnNewAccounting.Size = new System.Drawing.Size(72, 59);
            this.btnNewAccounting.Text = "تراکنش جدید";
            this.btnNewAccounting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewAccounting.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnPayReport
            // 
            this.btnPayReport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPayReport.Image = global::Accounting.App.Properties.Resources.servicesCosts;
            this.btnPayReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPayReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPayReport.Name = "btnPayReport";
            this.btnPayReport.Size = new System.Drawing.Size(97, 59);
            this.btnPayReport.Text = "گزارش پرداختی ها";
            this.btnPayReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPayReport.Click += new System.EventHandler(this.btnPayReport_Click);
            // 
            // btnReceiveReport
            // 
            this.btnReceiveReport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReceiveReport.Image = global::Accounting.App.Properties.Resources._1371476499_todo_list;
            this.btnReceiveReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReceiveReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReceiveReport.Name = "btnReceiveReport";
            this.btnReceiveReport.Size = new System.Drawing.Size(98, 59);
            this.btnReceiveReport.Text = "گزارش دریاقتی ها";
            this.btnReceiveReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReceiveReport.Click += new System.EventHandler(this.btnReceiveReport_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Accounting.App.Properties.Resources.Untitled_1;
            this.pictureBox1.Location = new System.Drawing.Point(27, 283);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDate,
            this.lblTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblDate
            // 
            this.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(118, 17);
            this.lblDate.Text = "toolStripStatusLabel1";
            // 
            // lblTime
            // 
            this.lblTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(118, 17);
            this.lblTime.Text = "toolStripStatusLabel2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblAccountBlance);
            this.groupBox1.Controls.Add(this.lblPay);
            this.groupBox1.Controls.Add(this.lblRecieve);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(448, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 132);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "گزارش ماه";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(244, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "دریافتی ها:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(241, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "پرداختی ها:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(236, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "مانده حساب:";
            // 
            // lblRecieve
            // 
            this.lblRecieve.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRecieve.Location = new System.Drawing.Point(24, 29);
            this.lblRecieve.Name = "lblRecieve";
            this.lblRecieve.Size = new System.Drawing.Size(201, 13);
            this.lblRecieve.TabIndex = 0;
            this.lblRecieve.Text = "0";
            // 
            // lblPay
            // 
            this.lblPay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPay.Location = new System.Drawing.Point(24, 57);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(201, 13);
            this.lblPay.TabIndex = 0;
            this.lblPay.Text = "0";
            // 
            // lblAccountBlance
            // 
            this.lblAccountBlance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAccountBlance.Location = new System.Drawing.Point(24, 88);
            this.lblAccountBlance.Name = "lblAccountBlance";
            this.lblAccountBlance.Size = new System.Drawing.Size(201, 13);
            this.lblAccountBlance.TabIndex = 0;
            this.lblAccountBlance.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حسابداری شخصی من";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnCustomer;
        private System.Windows.Forms.ToolStripButton btnNewAccounting;
        private System.Windows.Forms.ToolStripButton btnReceiveReport;
        private System.Windows.Forms.ToolStripButton btnPayReport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripSplitButton btnSetting;
        private System.Windows.Forms.ToolStripMenuItem btnLoginSetting;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAccountBlance;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.Label lblRecieve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

