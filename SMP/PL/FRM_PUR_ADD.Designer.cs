namespace SMP.PL
{
    partial class FRM_PUR_ADD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_PUR_ADD));
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.edt_det = new System.Windows.Forms.RichTextBox();
            this.edt_supp = new System.Windows.Forms.ComboBox();
            this.edt_cat = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edt_type = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.edt_name = new System.Windows.Forms.TextBox();
            this.lb_titlepage = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.edt_qt = new DevExpress.XtraEditors.SpinEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.edt_sell = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.edt_buy = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.edt_tbuy = new System.Windows.Forms.Label();
            this.edt_tsell = new System.Windows.Forms.Label();
            this.edt_trev = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_qt.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add.Appearance.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.Image")));
            this.btn_add.Location = new System.Drawing.Point(985, 655);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(158, 60);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "اضافة";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.edt_det);
            this.groupBox1.Controls.Add(this.edt_supp);
            this.groupBox1.Controls.Add(this.edt_cat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.edt_type);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.edt_name);
            this.groupBox1.Controls.Add(this.lb_titlepage);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(468, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(675, 418);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات اساسية";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(390, 215);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(62, 29);
            this.linkLabel2.TabIndex = 30;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "اضافة";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(390, 156);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(62, 29);
            this.linkLabel1.TabIndex = 29;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "اضافة";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // edt_det
            // 
            this.edt_det.Location = new System.Drawing.Point(6, 270);
            this.edt_det.Name = "edt_det";
            this.edt_det.Size = new System.Drawing.Size(467, 133);
            this.edt_det.TabIndex = 28;
            this.edt_det.Text = "";
            // 
            // edt_supp
            // 
            this.edt_supp.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_supp.FormattingEnabled = true;
            this.edt_supp.Location = new System.Drawing.Point(6, 212);
            this.edt_supp.Name = "edt_supp";
            this.edt_supp.Size = new System.Drawing.Size(378, 34);
            this.edt_supp.TabIndex = 27;
            // 
            // edt_cat
            // 
            this.edt_cat.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_cat.FormattingEnabled = true;
            this.edt_cat.Location = new System.Drawing.Point(6, 158);
            this.edt_cat.Name = "edt_cat";
            this.edt_cat.Size = new System.Drawing.Size(378, 34);
            this.edt_cat.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(593, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 26);
            this.label5.TabIndex = 24;
            this.label5.Text = "تفاصيل";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(603, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 26);
            this.label4.TabIndex = 22;
            this.label4.Text = "المورد";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(602, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 26);
            this.label2.TabIndex = 20;
            this.label2.Text = "الصنف";
            // 
            // edt_type
            // 
            this.edt_type.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edt_type.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_type.Location = new System.Drawing.Point(6, 100);
            this.edt_type.Name = "edt_type";
            this.edt_type.Size = new System.Drawing.Size(378, 33);
            this.edt_type.TabIndex = 19;
            this.edt_type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(611, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 26);
            this.label1.TabIndex = 18;
            this.label1.Text = "النوع";
            // 
            // edt_name
            // 
            this.edt_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edt_name.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_name.Location = new System.Drawing.Point(6, 52);
            this.edt_name.Name = "edt_name";
            this.edt_name.Size = new System.Drawing.Size(378, 33);
            this.edt_name.TabIndex = 17;
            this.edt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_titlepage
            // 
            this.lb_titlepage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_titlepage.AutoSize = true;
            this.lb_titlepage.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titlepage.ForeColor = System.Drawing.Color.Gray;
            this.lb_titlepage.Location = new System.Drawing.Point(560, 52);
            this.lb_titlepage.Name = "lb_titlepage";
            this.lb_titlepage.Size = new System.Drawing.Size(109, 26);
            this.lb_titlepage.TabIndex = 16;
            this.lb_titlepage.Text = "اسم المادة";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.edt_qt);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.edt_sell);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.edt_buy);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(468, 436);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(675, 199);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "البيع و الشراء";
            // 
            // edt_qt
            // 
            this.edt_qt.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.edt_qt.Location = new System.Drawing.Point(6, 159);
            this.edt_qt.Name = "edt_qt";
            this.edt_qt.Properties.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_qt.Properties.Appearance.Options.UseFont = true;
            this.edt_qt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edt_qt.Size = new System.Drawing.Size(378, 32);
            this.edt_qt.TabIndex = 27;
            this.edt_qt.EditValueChanged += new System.EventHandler(this.edt_qt_EditValueChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(599, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 26);
            this.label8.TabIndex = 20;
            this.label8.Text = "الكمية";
            // 
            // edt_sell
            // 
            this.edt_sell.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edt_sell.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_sell.Location = new System.Drawing.Point(6, 100);
            this.edt_sell.Name = "edt_sell";
            this.edt_sell.Size = new System.Drawing.Size(378, 33);
            this.edt_sell.TabIndex = 19;
            this.edt_sell.Text = "0";
            this.edt_sell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edt_sell.TextChanged += new System.EventHandler(this.edt_sell_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(499, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 26);
            this.label9.TabIndex = 18;
            this.label9.Text = "سعر البيع (المفرد)";
            // 
            // edt_buy
            // 
            this.edt_buy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edt_buy.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_buy.Location = new System.Drawing.Point(6, 52);
            this.edt_buy.Name = "edt_buy";
            this.edt_buy.Size = new System.Drawing.Size(378, 33);
            this.edt_buy.TabIndex = 17;
            this.edt_buy.Text = "0";
            this.edt_buy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edt_buy.TextChanged += new System.EventHandler(this.edt_buy_TextChanged);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(490, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 26);
            this.label10.TabIndex = 16;
            this.label10.Text = "سعر الشراء (المفرد)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.edt_tbuy);
            this.panel1.Controls.Add(this.edt_tsell);
            this.panel1.Controls.Add(this.edt_trev);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(21, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 409);
            this.panel1.TabIndex = 30;
            // 
            // edt_tbuy
            // 
            this.edt_tbuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edt_tbuy.AutoSize = true;
            this.edt_tbuy.Font = new System.Drawing.Font("LBC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_tbuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.edt_tbuy.Location = new System.Drawing.Point(190, 83);
            this.edt_tbuy.Name = "edt_tbuy";
            this.edt_tbuy.Size = new System.Drawing.Size(33, 36);
            this.edt_tbuy.TabIndex = 22;
            this.edt_tbuy.Text = "0";
            // 
            // edt_tsell
            // 
            this.edt_tsell.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edt_tsell.AutoSize = true;
            this.edt_tsell.Font = new System.Drawing.Font("LBC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_tsell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.edt_tsell.Location = new System.Drawing.Point(190, 206);
            this.edt_tsell.Name = "edt_tsell";
            this.edt_tsell.Size = new System.Drawing.Size(33, 36);
            this.edt_tsell.TabIndex = 21;
            this.edt_tsell.Text = "0";
            // 
            // edt_trev
            // 
            this.edt_trev.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edt_trev.AutoSize = true;
            this.edt_trev.Font = new System.Drawing.Font("LBC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_trev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.edt_trev.Location = new System.Drawing.Point(190, 330);
            this.edt_trev.Name = "edt_trev";
            this.edt_trev.Size = new System.Drawing.Size(33, 36);
            this.edt_trev.TabIndex = 20;
            this.edt_trev.Text = "0";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("LBC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(137, 284);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 36);
            this.label11.TabIndex = 19;
            this.label11.Text = "الارباح الكلية";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("LBC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(65, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(289, 36);
            this.label7.TabIndex = 18;
            this.label7.Text = "المبيعات  (السعر الكلي)";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("LBC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(64, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(300, 36);
            this.label6.TabIndex = 17;
            this.label6.Text = "المشتريات (السعر الكلي)";
            // 
            // FRM_PUR_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_PUR_ADD";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.FRM_PUR_ADD_Activated);
            this.Load += new System.EventHandler(this.FRM_PUR_ADD_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_qt.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public DevExpress.XtraEditors.SimpleButton btn_add;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox edt_type;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox edt_name;
        private System.Windows.Forms.Label lb_titlepage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox edt_sell;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox edt_buy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        public System.Windows.Forms.RichTextBox edt_det;
        public System.Windows.Forms.ComboBox edt_supp;
        public System.Windows.Forms.ComboBox edt_cat;
        public DevExpress.XtraEditors.SpinEdit edt_qt;
        public System.Windows.Forms.Label edt_tbuy;
        public System.Windows.Forms.Label edt_tsell;
        public System.Windows.Forms.Label edt_trev;
    }
}