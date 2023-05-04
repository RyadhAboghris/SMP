using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using SMP.EPL;

namespace SMP.PL
{
    public partial class FRM_CUS_ADD : Form
    {
        // init
        DB_SMPEntities db=new DB_SMPEntities();
        TB_Cus tb_supp = new TB_Cus();
        BL.Methods methods=new BL.Methods();
       

        public int id;
        public FRM_CUS_ADD()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // add or edit
        private void btn_add_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Dialog dialog = new Dialog();
            // check if add or edit 
            if (edt_name.Text == "")
            {
                dialog.Width = this.Width;
                dialog.txt_caption.Text = "اسم العميل مطلوب";
                dialog.Show();
            }
            else
            {
                // check if add or edit
                if(id== 0)
                {
                    // add
                    pic_cover.Image.Save(methods.ma,System.Drawing.Imaging.ImageFormat.Png);
                    tb_supp.Supp_Name = edt_name.Text;
                    tb_supp.Supp_Phone = edt_phone.Text;
                    tb_supp.Supp_Email = edt_email.Text;
                    tb_supp.Supp_Image = methods.convert_byte();
                    db.TB_Cus.Add(tb_supp);
                    db.SaveChanges();
                    toast.txt_caption.Text = "تم اضافة عميل جديد";
                    toast.Show();
                    this.Close();
                }
                else
                {
                    // edit
                    pic_cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    tb_supp.ID = id;
                    tb_supp.Supp_Name = edt_name.Text;
                    tb_supp.Supp_Phone = edt_phone.Text;
                    tb_supp.Supp_Email = edt_email.Text;
                    tb_supp.Supp_Image = methods.convert_byte();
                    db.Entry(tb_supp).State=System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    toast.txt_caption.Text = "تم التعديل بنجاح";
                    toast.Show();
                    this.Close();
                }
            }

        }

        private void edt_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
