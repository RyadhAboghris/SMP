namespace SMP.PL
{
    partial class FRM_USER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_USER));
            this.pn_cat = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.edt_search = new System.Windows.Forms.TextBox();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.ptn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_edt = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.colUser_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUser_Pass = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUser_Roll = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUser_State = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pn_cat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_cat
            // 
            this.pn_cat.Controls.Add(this.gridControl1);
            this.pn_cat.Controls.Add(this.panel2);
            this.pn_cat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_cat.Location = new System.Drawing.Point(0, 0);
            this.pn_cat.Name = "pn_cat";
            this.pn_cat.Size = new System.Drawing.Size(1030, 720);
            this.pn_cat.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(SMP.TB_Users);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(5);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(1030, 620);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUser_Name,
            this.colUser_Pass,
            this.colUser_Roll,
            this.colUser_State});
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Controls.Add(this.edt_search);
            this.panel2.Controls.Add(this.btn_update);
            this.panel2.Controls.Add(this.ptn_delete);
            this.panel2.Controls.Add(this.btn_edt);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 620);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1030, 100);
            this.panel2.TabIndex = 2;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.Appearance.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Appearance.Options.UseFont = true;
            this.btn_search.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_search.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_search.ImageOptions.SvgImage")));
            this.btn_search.Location = new System.Drawing.Point(964, 27);
            this.btn_search.Margin = new System.Windows.Forms.Padding(19);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(55, 48);
            this.btn_search.TabIndex = 5;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // edt_search
            // 
            this.edt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.edt_search.Font = new System.Drawing.Font("LBC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_search.Location = new System.Drawing.Point(674, 31);
            this.edt_search.Name = "edt_search";
            this.edt_search.Size = new System.Drawing.Size(290, 42);
            this.edt_search.TabIndex = 4;
            this.edt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_update
            // 
            this.btn_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_update.Appearance.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Appearance.Options.UseFont = true;
            this.btn_update.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.ImageOptions.Image")));
            this.btn_update.Location = new System.Drawing.Point(488, 16);
            this.btn_update.Margin = new System.Windows.Forms.Padding(15);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(135, 75);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "تحديث";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // ptn_delete
            // 
            this.ptn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ptn_delete.Appearance.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptn_delete.Appearance.Options.UseFont = true;
            this.ptn_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ptn_delete.ImageOptions.Image")));
            this.ptn_delete.Location = new System.Drawing.Point(326, 16);
            this.ptn_delete.Margin = new System.Windows.Forms.Padding(12);
            this.ptn_delete.Name = "ptn_delete";
            this.ptn_delete.Size = new System.Drawing.Size(135, 75);
            this.ptn_delete.TabIndex = 3;
            this.ptn_delete.Text = "حذف";
            this.ptn_delete.Click += new System.EventHandler(this.ptn_delete_Click);
            // 
            // btn_edt
            // 
            this.btn_edt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_edt.Appearance.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edt.Appearance.Options.UseFont = true;
            this.btn_edt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_edt.ImageOptions.Image")));
            this.btn_edt.Location = new System.Drawing.Point(169, 14);
            this.btn_edt.Margin = new System.Windows.Forms.Padding(10);
            this.btn_edt.Name = "btn_edt";
            this.btn_edt.Size = new System.Drawing.Size(135, 75);
            this.btn_edt.TabIndex = 3;
            this.btn_edt.Text = "تعديل";
            this.btn_edt.Click += new System.EventHandler(this.btn_edt_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_add.Appearance.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.Image")));
            this.btn_add.Location = new System.Drawing.Point(16, 14);
            this.btn_add.Margin = new System.Windows.Forms.Padding(8);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(135, 75);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "اضافة";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // colUser_Name
            // 
            this.colUser_Name.Caption = "اسم المستخدم";
            this.colUser_Name.FieldName = "User_Name";
            this.colUser_Name.MinWidth = 25;
            this.colUser_Name.Name = "colUser_Name";
            this.colUser_Name.OptionsColumn.AllowEdit = false;
            this.colUser_Name.Visible = true;
            this.colUser_Name.VisibleIndex = 0;
            this.colUser_Name.Width = 94;
            // 
            // colUser_Pass
            // 
            this.colUser_Pass.Caption = "كلمة السر";
            this.colUser_Pass.FieldName = "User_Pass";
            this.colUser_Pass.MinWidth = 25;
            this.colUser_Pass.Name = "colUser_Pass";
            this.colUser_Pass.OptionsColumn.AllowEdit = false;
            this.colUser_Pass.Visible = true;
            this.colUser_Pass.VisibleIndex = 1;
            this.colUser_Pass.Width = 94;
            // 
            // colUser_Roll
            // 
            this.colUser_Roll.Caption = "الصلاحية";
            this.colUser_Roll.FieldName = "User_Roll";
            this.colUser_Roll.MinWidth = 25;
            this.colUser_Roll.Name = "colUser_Roll";
            this.colUser_Roll.OptionsColumn.AllowEdit = false;
            this.colUser_Roll.Visible = true;
            this.colUser_Roll.VisibleIndex = 2;
            this.colUser_Roll.Width = 94;
            // 
            // colUser_State
            // 
            this.colUser_State.Caption = "حالة الدخول";
            this.colUser_State.FieldName = "User_State";
            this.colUser_State.MinWidth = 25;
            this.colUser_State.Name = "colUser_State";
            this.colUser_State.OptionsColumn.AllowEdit = false;
            this.colUser_State.Visible = true;
            this.colUser_State.VisibleIndex = 3;
            this.colUser_State.Width = 94;
            // 
            // FRM_USER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1030, 720);
            this.Controls.Add(this.pn_cat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_USER";
            this.Text = "FRM_CAT";
            this.pn_cat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private System.Windows.Forms.TextBox edt_search;
        private DevExpress.XtraEditors.SimpleButton btn_update;
        private DevExpress.XtraEditors.SimpleButton ptn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_edt;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        public System.Windows.Forms.Panel pn_cat;
        public DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colUser_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colUser_Pass;
        private DevExpress.XtraGrid.Columns.GridColumn colUser_Roll;
        private DevExpress.XtraGrid.Columns.GridColumn colUser_State;
    }
}