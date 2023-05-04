namespace SMP.PL
{
    partial class FRM_SETTINGS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_SETTINGS));
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.edt_sv = new System.Windows.Forms.TextBox();
            this.lb_titlepage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_save.Appearance.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Appearance.Options.UseFont = true;
            this.btn_save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.Image")));
            this.btn_save.Location = new System.Drawing.Point(462, 376);
            this.btn_save.Margin = new System.Windows.Forms.Padding(5);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(158, 60);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "حفظ";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // edt_sv
            // 
            this.edt_sv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edt_sv.Font = new System.Drawing.Font("LBC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_sv.Location = new System.Drawing.Point(30, 147);
            this.edt_sv.Name = "edt_sv";
            this.edt_sv.Size = new System.Drawing.Size(445, 42);
            this.edt_sv.TabIndex = 13;
            this.edt_sv.Text = "RYADHABOGHRIS";
            this.edt_sv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_titlepage
            // 
            this.lb_titlepage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_titlepage.AutoSize = true;
            this.lb_titlepage.Font = new System.Drawing.Font("LBC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titlepage.ForeColor = System.Drawing.Color.Gray;
            this.lb_titlepage.Location = new System.Drawing.Point(481, 147);
            this.lb_titlepage.Name = "lb_titlepage";
            this.lb_titlepage.Size = new System.Drawing.Size(105, 42);
            this.lb_titlepage.TabIndex = 12;
            this.lb_titlepage.Text = "الخادم";
            // 
            // FRM_SETTINGS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.edt_sv);
            this.Controls.Add(this.lb_titlepage);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_SETTINGS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_SETTINGS";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton btn_save;
        public System.Windows.Forms.TextBox edt_sv;
        private System.Windows.Forms.Label lb_titlepage;
    }
}