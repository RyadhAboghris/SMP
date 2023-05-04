namespace SMP.PL
{
    partial class FRM_CUS_ADD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_CUS_ADD));
            this.btn_close = new DevExpress.XtraEditors.SimpleButton();
            this.lb_titlepage = new System.Windows.Forms.Label();
            this.edt_name = new System.Windows.Forms.TextBox();
            this.pic_cover = new DevExpress.XtraEditors.PictureEdit();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.edt_phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.edt_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cover.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_close.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.ImageOptions.Image")));
            this.btn_close.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_close.Location = new System.Drawing.Point(603, 11);
            this.btn_close.Name = "btn_close";
            this.btn_close.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_close.Size = new System.Drawing.Size(50, 50);
            this.btn_close.TabIndex = 4;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lb_titlepage
            // 
            this.lb_titlepage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_titlepage.AutoSize = true;
            this.lb_titlepage.Font = new System.Drawing.Font("LBC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titlepage.ForeColor = System.Drawing.Color.Gray;
            this.lb_titlepage.Location = new System.Drawing.Point(490, 99);
            this.lb_titlepage.Name = "lb_titlepage";
            this.lb_titlepage.Size = new System.Drawing.Size(170, 42);
            this.lb_titlepage.TabIndex = 8;
            this.lb_titlepage.Text = "اسم المورد";
            // 
            // edt_name
            // 
            this.edt_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edt_name.Font = new System.Drawing.Font("LBC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_name.Location = new System.Drawing.Point(35, 99);
            this.edt_name.Name = "edt_name";
            this.edt_name.Size = new System.Drawing.Size(378, 42);
            this.edt_name.TabIndex = 9;
            this.edt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edt_name.TextChanged += new System.EventHandler(this.edt_name_TextChanged);
            // 
            // pic_cover
            // 
            this.pic_cover.EditValue = ((object)(resources.GetObject("pic_cover.EditValue")));
            this.pic_cover.Location = new System.Drawing.Point(35, 373);
            this.pic_cover.Name = "pic_cover";
            this.pic_cover.Properties.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.pic_cover.Properties.Appearance.Options.UseBackColor = true;
            this.pic_cover.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_cover.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pic_cover.Size = new System.Drawing.Size(310, 259);
            this.pic_cover.TabIndex = 10;
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add.Appearance.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.Image")));
            this.btn_add.Location = new System.Drawing.Point(495, 645);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(158, 60);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "اضافة";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // edt_phone
            // 
            this.edt_phone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edt_phone.Font = new System.Drawing.Font("LBC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_phone.Location = new System.Drawing.Point(35, 172);
            this.edt_phone.Name = "edt_phone";
            this.edt_phone.Size = new System.Drawing.Size(378, 42);
            this.edt_phone.TabIndex = 13;
            this.edt_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LBC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(495, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 42);
            this.label1.TabIndex = 12;
            this.label1.Text = "رقم الهاتف";
            // 
            // edt_email
            // 
            this.edt_email.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edt_email.Font = new System.Drawing.Font("LBC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_email.Location = new System.Drawing.Point(35, 250);
            this.edt_email.Name = "edt_email";
            this.edt_email.Size = new System.Drawing.Size(378, 42);
            this.edt_email.TabIndex = 15;
            this.edt_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("LBC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(539, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 42);
            this.label2.TabIndex = 14;
            this.label2.Text = "العنوان";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("LBC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(149, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 42);
            this.label3.TabIndex = 16;
            this.label3.Text = "صورة";
            // 
            // FRM_CUS_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(665, 719);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edt_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edt_phone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.pic_cover);
            this.Controls.Add(this.edt_name);
            this.Controls.Add(this.lb_titlepage);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_CUS_ADD";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pic_cover.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_close;
        private System.Windows.Forms.Label lb_titlepage;
        public DevExpress.XtraEditors.SimpleButton btn_add;
        public System.Windows.Forms.TextBox edt_name;
        public DevExpress.XtraEditors.PictureEdit pic_cover;
        public System.Windows.Forms.TextBox edt_phone;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox edt_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}