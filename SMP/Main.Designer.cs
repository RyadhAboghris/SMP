namespace SMP
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pn_topbar = new System.Windows.Forms.Panel();
            this.lb_titlepage = new System.Windows.Forms.Label();
            this.btn_logout = new DevExpress.XtraEditors.SimpleButton();
            this.btn_min = new DevExpress.XtraEditors.SimpleButton();
            this.btn_max = new DevExpress.XtraEditors.SimpleButton();
            this.btn_close = new DevExpress.XtraEditors.SimpleButton();
            this.pn_navbar = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_home = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_supp = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton9 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton10 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton11 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton12 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_user = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton14 = new DevExpress.XtraEditors.SimpleButton();
            this.pn_headernavbar = new System.Windows.Forms.Panel();
            this.pn_tittelnavbar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_roll = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_collapse = new DevExpress.XtraEditors.SimpleButton();
            this.pn_cont = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pn_topbar.SuspendLayout();
            this.pn_navbar.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pn_headernavbar.SuspendLayout();
            this.pn_tittelnavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_topbar
            // 
            this.pn_topbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pn_topbar.Controls.Add(this.lb_titlepage);
            this.pn_topbar.Controls.Add(this.btn_logout);
            this.pn_topbar.Controls.Add(this.btn_min);
            this.pn_topbar.Controls.Add(this.btn_max);
            this.pn_topbar.Controls.Add(this.btn_close);
            this.pn_topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_topbar.Location = new System.Drawing.Point(0, 0);
            this.pn_topbar.Name = "pn_topbar";
            this.pn_topbar.Size = new System.Drawing.Size(1030, 70);
            this.pn_topbar.TabIndex = 0;
            // 
            // lb_titlepage
            // 
            this.lb_titlepage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_titlepage.AutoSize = true;
            this.lb_titlepage.ForeColor = System.Drawing.Color.DarkGray;
            this.lb_titlepage.Location = new System.Drawing.Point(543, 20);
            this.lb_titlepage.Name = "lb_titlepage";
            this.lb_titlepage.Size = new System.Drawing.Size(85, 30);
            this.lb_titlepage.TabIndex = 7;
            this.lb_titlepage.Text = "الرئيسة";
            // 
            // btn_logout
            // 
            this.btn_logout.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_logout.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_logout.ImageOptions.SvgImage")));
            this.btn_logout.Location = new System.Drawing.Point(173, 12);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_logout.Size = new System.Drawing.Size(50, 50);
            this.btn_logout.TabIndex = 4;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_min
            // 
            this.btn_min.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_min.ImageOptions.Image")));
            this.btn_min.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_min.Location = new System.Drawing.Point(120, 12);
            this.btn_min.Name = "btn_min";
            this.btn_min.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_min.Size = new System.Drawing.Size(50, 50);
            this.btn_min.TabIndex = 5;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_max
            // 
            this.btn_max.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_max.ImageOptions.Image")));
            this.btn_max.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_max.Location = new System.Drawing.Point(67, 12);
            this.btn_max.Name = "btn_max";
            this.btn_max.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_max.Size = new System.Drawing.Size(50, 50);
            this.btn_max.TabIndex = 6;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // btn_close
            // 
            this.btn_close.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.ImageOptions.Image")));
            this.btn_close.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_close.Location = new System.Drawing.Point(14, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_close.Size = new System.Drawing.Size(50, 50);
            this.btn_close.TabIndex = 3;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pn_navbar
            // 
            this.pn_navbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pn_navbar.Controls.Add(this.flowLayoutPanel1);
            this.pn_navbar.Controls.Add(this.pn_headernavbar);
            this.pn_navbar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pn_navbar.Location = new System.Drawing.Point(1030, 0);
            this.pn_navbar.Name = "pn_navbar";
            this.pn_navbar.Size = new System.Drawing.Size(250, 720);
            this.pn_navbar.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_home);
            this.flowLayoutPanel1.Controls.Add(this.btn_cat);
            this.flowLayoutPanel1.Controls.Add(this.btn_supp);
            this.flowLayoutPanel1.Controls.Add(this.simpleButton9);
            this.flowLayoutPanel1.Controls.Add(this.simpleButton10);
            this.flowLayoutPanel1.Controls.Add(this.simpleButton11);
            this.flowLayoutPanel1.Controls.Add(this.simpleButton12);
            this.flowLayoutPanel1.Controls.Add(this.btn_user);
            this.flowLayoutPanel1.Controls.Add(this.simpleButton14);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 209);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(250, 511);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btn_home
            // 
            this.btn_home.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.btn_home.Appearance.Options.UseFont = true;
            this.btn_home.Appearance.Options.UseForeColor = true;
            this.btn_home.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.ImageOptions.Image")));
            this.btn_home.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(3, 3);
            this.btn_home.Name = "btn_home";
            this.btn_home.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_home.Size = new System.Drawing.Size(244, 40);
            this.btn_home.TabIndex = 4;
            this.btn_home.Text = "الرئيسة";
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_cat
            // 
            this.btn_cat.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cat.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.btn_cat.Appearance.Options.UseFont = true;
            this.btn_cat.Appearance.Options.UseForeColor = true;
            this.btn_cat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_cat.ImageOptions.Image")));
            this.btn_cat.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_cat.Location = new System.Drawing.Point(3, 49);
            this.btn_cat.Name = "btn_cat";
            this.btn_cat.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_cat.Size = new System.Drawing.Size(244, 40);
            this.btn_cat.TabIndex = 5;
            this.btn_cat.Text = "الاصناف";
            this.btn_cat.Click += new System.EventHandler(this.btn_cat_Click);
            // 
            // btn_supp
            // 
            this.btn_supp.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supp.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.btn_supp.Appearance.Options.UseFont = true;
            this.btn_supp.Appearance.Options.UseForeColor = true;
            this.btn_supp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_supp.ImageOptions.Image")));
            this.btn_supp.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_supp.Location = new System.Drawing.Point(3, 95);
            this.btn_supp.Name = "btn_supp";
            this.btn_supp.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_supp.Size = new System.Drawing.Size(244, 40);
            this.btn_supp.TabIndex = 6;
            this.btn_supp.Text = "الموردين";
            this.btn_supp.Click += new System.EventHandler(this.btn_supp_Click);
            // 
            // simpleButton9
            // 
            this.simpleButton9.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton9.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.simpleButton9.Appearance.Options.UseFont = true;
            this.simpleButton9.Appearance.Options.UseForeColor = true;
            this.simpleButton9.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton9.ImageOptions.Image")));
            this.simpleButton9.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton9.Location = new System.Drawing.Point(3, 141);
            this.simpleButton9.Name = "simpleButton9";
            this.simpleButton9.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton9.Size = new System.Drawing.Size(244, 40);
            this.simpleButton9.TabIndex = 7;
            this.simpleButton9.Text = "المشتريات";
            this.simpleButton9.Click += new System.EventHandler(this.simpleButton9_Click);
            // 
            // simpleButton10
            // 
            this.simpleButton10.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton10.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.simpleButton10.Appearance.Options.UseFont = true;
            this.simpleButton10.Appearance.Options.UseForeColor = true;
            this.simpleButton10.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton10.ImageOptions.Image")));
            this.simpleButton10.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton10.Location = new System.Drawing.Point(3, 187);
            this.simpleButton10.Name = "simpleButton10";
            this.simpleButton10.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton10.Size = new System.Drawing.Size(244, 40);
            this.simpleButton10.TabIndex = 8;
            this.simpleButton10.Text = "العملاء";
            this.simpleButton10.Click += new System.EventHandler(this.simpleButton10_Click);
            // 
            // simpleButton11
            // 
            this.simpleButton11.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton11.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.simpleButton11.Appearance.Options.UseFont = true;
            this.simpleButton11.Appearance.Options.UseForeColor = true;
            this.simpleButton11.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton11.ImageOptions.Image")));
            this.simpleButton11.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton11.Location = new System.Drawing.Point(3, 233);
            this.simpleButton11.Name = "simpleButton11";
            this.simpleButton11.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton11.Size = new System.Drawing.Size(244, 40);
            this.simpleButton11.TabIndex = 9;
            this.simpleButton11.Text = "المبيعات";
            this.simpleButton11.Click += new System.EventHandler(this.simpleButton11_Click);
            // 
            // simpleButton12
            // 
            this.simpleButton12.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton12.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.simpleButton12.Appearance.Options.UseFont = true;
            this.simpleButton12.Appearance.Options.UseForeColor = true;
            this.simpleButton12.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton12.ImageOptions.Image")));
            this.simpleButton12.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton12.Location = new System.Drawing.Point(3, 279);
            this.simpleButton12.Name = "simpleButton12";
            this.simpleButton12.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton12.Size = new System.Drawing.Size(244, 40);
            this.simpleButton12.TabIndex = 10;
            this.simpleButton12.Text = "التقارير";
            this.simpleButton12.Click += new System.EventHandler(this.simpleButton12_Click);
            // 
            // btn_user
            // 
            this.btn_user.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_user.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.btn_user.Appearance.Options.UseFont = true;
            this.btn_user.Appearance.Options.UseForeColor = true;
            this.btn_user.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton13.ImageOptions.Image")));
            this.btn_user.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_user.Location = new System.Drawing.Point(3, 325);
            this.btn_user.Name = "btn_user";
            this.btn_user.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_user.Size = new System.Drawing.Size(244, 40);
            this.btn_user.TabIndex = 11;
            this.btn_user.Text = "المستخدمين";
            this.btn_user.Click += new System.EventHandler(this.simpleButton13_Click);
            // 
            // simpleButton14
            // 
            this.simpleButton14.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton14.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.simpleButton14.Appearance.Options.UseFont = true;
            this.simpleButton14.Appearance.Options.UseForeColor = true;
            this.simpleButton14.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton14.ImageOptions.Image")));
            this.simpleButton14.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton14.Location = new System.Drawing.Point(3, 371);
            this.simpleButton14.Name = "simpleButton14";
            this.simpleButton14.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton14.Size = new System.Drawing.Size(244, 40);
            this.simpleButton14.TabIndex = 12;
            this.simpleButton14.Text = "الاعدادات";
            this.simpleButton14.Click += new System.EventHandler(this.simpleButton14_Click);
            // 
            // pn_headernavbar
            // 
            this.pn_headernavbar.Controls.Add(this.pn_tittelnavbar);
            this.pn_headernavbar.Controls.Add(this.flowLayoutPanel2);
            this.pn_headernavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_headernavbar.Location = new System.Drawing.Point(0, 0);
            this.pn_headernavbar.Name = "pn_headernavbar";
            this.pn_headernavbar.Size = new System.Drawing.Size(250, 209);
            this.pn_headernavbar.TabIndex = 0;
            // 
            // pn_tittelnavbar
            // 
            this.pn_tittelnavbar.Controls.Add(this.pictureBox1);
            this.pn_tittelnavbar.Controls.Add(this.lb_roll);
            this.pn_tittelnavbar.Controls.Add(this.lb_username);
            this.pn_tittelnavbar.Location = new System.Drawing.Point(8, 12);
            this.pn_tittelnavbar.Name = "pn_tittelnavbar";
            this.pn_tittelnavbar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pn_tittelnavbar.Size = new System.Drawing.Size(197, 191);
            this.pn_tittelnavbar.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lb_roll
            // 
            this.lb_roll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_roll.AutoSize = true;
            this.lb_roll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lb_roll.Location = new System.Drawing.Point(13, 155);
            this.lb_roll.Name = "lb_roll";
            this.lb_roll.Size = new System.Drawing.Size(61, 30);
            this.lb_roll.TabIndex = 9;
            this.lb_roll.Text = "ادمن";
            // 
            // lb_username
            // 
            this.lb_username.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_username.AutoSize = true;
            this.lb_username.ForeColor = System.Drawing.Color.DarkGray;
            this.lb_username.Location = new System.Drawing.Point(13, 125);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(156, 30);
            this.lb_username.TabIndex = 8;
            this.lb_username.Text = "رياض ابو غريس";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btn_collapse);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(211, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(39, 209);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // btn_collapse
            // 
            this.btn_collapse.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_collapse.ImageOptions.Image")));
            this.btn_collapse.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_collapse.Location = new System.Drawing.Point(1, 3);
            this.btn_collapse.Name = "btn_collapse";
            this.btn_collapse.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_collapse.Size = new System.Drawing.Size(35, 54);
            this.btn_collapse.TabIndex = 8;
            this.btn_collapse.Click += new System.EventHandler(this.btn_collapse_Click);
            // 
            // pn_cont
            // 
            this.pn_cont.BackColor = System.Drawing.Color.White;
            this.pn_cont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_cont.Location = new System.Drawing.Point(0, 70);
            this.pn_cont.Name = "pn_cont";
            this.pn_cont.Size = new System.Drawing.Size(1030, 650);
            this.pn_cont.TabIndex = 2;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pn_topbar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pn_cont);
            this.Controls.Add(this.pn_topbar);
            this.Controls.Add(this.pn_navbar);
            this.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMP";
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.Load += new System.EventHandler(this.Main_Load);
            this.pn_topbar.ResumeLayout(false);
            this.pn_topbar.PerformLayout();
            this.pn_navbar.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pn_headernavbar.ResumeLayout(false);
            this.pn_tittelnavbar.ResumeLayout(false);
            this.pn_tittelnavbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_topbar;
        private System.Windows.Forms.Panel pn_navbar;
        private System.Windows.Forms.Panel pn_cont;
        private System.Windows.Forms.Label lb_titlepage;
        private DevExpress.XtraEditors.SimpleButton btn_logout;
        private DevExpress.XtraEditors.SimpleButton btn_min;
        private DevExpress.XtraEditors.SimpleButton btn_max;
        private DevExpress.XtraEditors.SimpleButton btn_close;
        private System.Windows.Forms.Panel pn_headernavbar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton btn_collapse;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btn_home;
        private DevExpress.XtraEditors.SimpleButton btn_cat;
        private DevExpress.XtraEditors.SimpleButton btn_supp;
        private DevExpress.XtraEditors.SimpleButton simpleButton9;
        private DevExpress.XtraEditors.SimpleButton simpleButton10;
        private DevExpress.XtraEditors.SimpleButton simpleButton11;
        private DevExpress.XtraEditors.SimpleButton simpleButton12;
        private DevExpress.XtraEditors.SimpleButton btn_user;
        private DevExpress.XtraEditors.SimpleButton simpleButton14;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel pn_tittelnavbar;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        public System.Windows.Forms.Label lb_roll;
        public System.Windows.Forms.Label lb_username;
    }
}

