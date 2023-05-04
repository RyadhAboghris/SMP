namespace SMP.PL
{
    partial class FRM_PUR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_PUR));
            this.pn_cat = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPur_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_Type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_Cat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_Supp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_Det = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_Buy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_Sell = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_Qt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_Tbuy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_Tsell = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_TRev = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.edt_search = new System.Windows.Forms.TextBox();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.ptn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_edt = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
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
            this.gridControl1.DataSource = typeof(SMP.TB_Pur);
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
            this.colPur_Name,
            this.colPur_Type,
            this.colPur_Cat,
            this.colPur_Supp,
            this.colPur_Det,
            this.colPur_Buy,
            this.colPur_Sell,
            this.colPur_Qt,
            this.colPur_Tbuy,
            this.colPur_Tsell,
            this.colPur_TRev});
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colPur_Name
            // 
            this.colPur_Name.Caption = "اسم المادة";
            this.colPur_Name.FieldName = "Pur_Name";
            this.colPur_Name.MinWidth = 25;
            this.colPur_Name.Name = "colPur_Name";
            this.colPur_Name.OptionsColumn.AllowEdit = false;
            this.colPur_Name.Visible = true;
            this.colPur_Name.VisibleIndex = 0;
            this.colPur_Name.Width = 94;
            // 
            // colPur_Type
            // 
            this.colPur_Type.Caption = "نوع";
            this.colPur_Type.FieldName = "Pur_Type";
            this.colPur_Type.MinWidth = 25;
            this.colPur_Type.Name = "colPur_Type";
            this.colPur_Type.OptionsColumn.AllowEdit = false;
            this.colPur_Type.Visible = true;
            this.colPur_Type.VisibleIndex = 1;
            this.colPur_Type.Width = 94;
            // 
            // colPur_Cat
            // 
            this.colPur_Cat.Caption = "الصنف";
            this.colPur_Cat.FieldName = "Pur_Cat";
            this.colPur_Cat.MinWidth = 25;
            this.colPur_Cat.Name = "colPur_Cat";
            this.colPur_Cat.OptionsColumn.AllowEdit = false;
            this.colPur_Cat.Visible = true;
            this.colPur_Cat.VisibleIndex = 2;
            this.colPur_Cat.Width = 94;
            // 
            // colPur_Supp
            // 
            this.colPur_Supp.Caption = "المورد";
            this.colPur_Supp.FieldName = "Pur_Supp";
            this.colPur_Supp.MinWidth = 25;
            this.colPur_Supp.Name = "colPur_Supp";
            this.colPur_Supp.OptionsColumn.AllowEdit = false;
            this.colPur_Supp.Visible = true;
            this.colPur_Supp.VisibleIndex = 3;
            this.colPur_Supp.Width = 94;
            // 
            // colPur_Det
            // 
            this.colPur_Det.Caption = "التفاصيل";
            this.colPur_Det.FieldName = "Pur_Det";
            this.colPur_Det.MinWidth = 25;
            this.colPur_Det.Name = "colPur_Det";
            this.colPur_Det.OptionsColumn.AllowEdit = false;
            this.colPur_Det.Visible = true;
            this.colPur_Det.VisibleIndex = 4;
            this.colPur_Det.Width = 94;
            // 
            // colPur_Buy
            // 
            this.colPur_Buy.Caption = "سعر الشراء";
            this.colPur_Buy.FieldName = "Pur_Buy";
            this.colPur_Buy.MinWidth = 25;
            this.colPur_Buy.Name = "colPur_Buy";
            this.colPur_Buy.OptionsColumn.AllowEdit = false;
            this.colPur_Buy.Visible = true;
            this.colPur_Buy.VisibleIndex = 5;
            this.colPur_Buy.Width = 94;
            // 
            // colPur_Sell
            // 
            this.colPur_Sell.Caption = "سعر البيع";
            this.colPur_Sell.FieldName = "Pur_Sell";
            this.colPur_Sell.MinWidth = 25;
            this.colPur_Sell.Name = "colPur_Sell";
            this.colPur_Sell.OptionsColumn.AllowEdit = false;
            this.colPur_Sell.Visible = true;
            this.colPur_Sell.VisibleIndex = 6;
            this.colPur_Sell.Width = 94;
            // 
            // colPur_Qt
            // 
            this.colPur_Qt.Caption = "الكمية";
            this.colPur_Qt.FieldName = "Pur_Qt";
            this.colPur_Qt.MinWidth = 25;
            this.colPur_Qt.Name = "colPur_Qt";
            this.colPur_Qt.OptionsColumn.AllowEdit = false;
            this.colPur_Qt.Visible = true;
            this.colPur_Qt.VisibleIndex = 7;
            this.colPur_Qt.Width = 94;
            // 
            // colPur_Tbuy
            // 
            this.colPur_Tbuy.Caption = "الشراء الكلي";
            this.colPur_Tbuy.FieldName = "Pur_Tbuy";
            this.colPur_Tbuy.MinWidth = 25;
            this.colPur_Tbuy.Name = "colPur_Tbuy";
            this.colPur_Tbuy.OptionsColumn.AllowEdit = false;
            this.colPur_Tbuy.Visible = true;
            this.colPur_Tbuy.VisibleIndex = 8;
            this.colPur_Tbuy.Width = 94;
            // 
            // colPur_Tsell
            // 
            this.colPur_Tsell.Caption = "البيع الكلي";
            this.colPur_Tsell.FieldName = "Pur_Tsell";
            this.colPur_Tsell.MinWidth = 25;
            this.colPur_Tsell.Name = "colPur_Tsell";
            this.colPur_Tsell.OptionsColumn.AllowEdit = false;
            this.colPur_Tsell.Visible = true;
            this.colPur_Tsell.VisibleIndex = 9;
            this.colPur_Tsell.Width = 94;
            // 
            // colPur_TRev
            // 
            this.colPur_TRev.Caption = "الارباح";
            this.colPur_TRev.FieldName = "Pur_TRev";
            this.colPur_TRev.MinWidth = 25;
            this.colPur_TRev.Name = "colPur_TRev";
            this.colPur_TRev.OptionsColumn.AllowEdit = false;
            this.colPur_TRev.Visible = true;
            this.colPur_TRev.VisibleIndex = 10;
            this.colPur_TRev.Width = 94;
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
            // FRM_PUR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1030, 720);
            this.Controls.Add(this.pn_cat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_PUR";
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
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Type;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Cat;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Supp;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Det;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Buy;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Sell;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Qt;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Tbuy;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Tsell;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_TRev;
    }
}