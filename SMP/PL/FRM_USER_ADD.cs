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
    public partial class FRM_USER_ADD : Form
    {
        // init
        DB_SMPEntities db=new DB_SMPEntities();
        TB_Users tb_users = new TB_Users();
        BL.Methods methods=new BL.Methods();
       

        public int id;
        public FRM_USER_ADD()
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
                dialog.txt_caption.Text = "اسم المستخدم مطلوب";
                dialog.Show();
            }
            else
            {
                // check if add or edit
                if(id== 0)
                {
                    // add
                    tb_users.User_Name = edt_name.Text;
                    tb_users.User_Pass = edt_pass.Text;
                    tb_users.User_Roll = edt_roll.Text;     
                    tb_users.User_State = "False";
                    db.TB_Users.Add(tb_users);
                    db.SaveChanges();
                    toast.txt_caption.Text = "تم اضافة مستخدم جديد";
                    toast.Show();
                    this.Close();
                }
                else
                {
                    // edit
                    pic_cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    tb_users.ID = id;
                    tb_users.User_Name = edt_name.Text;
                    tb_users.User_Pass = edt_pass.Text;
                    tb_users.User_Roll = edt_roll.Text;
                    tb_users.User_State = "False";
                    db.Entry(tb_users).State=System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    toast.txt_caption.Text = "تم التعديل بنجاح";
                    toast.Show();
                    this.Close();
                }
            }

        }
    }
}
