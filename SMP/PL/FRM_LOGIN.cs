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
    public partial class FRM_LOGIN : Form
    {
        // init
        DB_SMPEntities db=new DB_SMPEntities();
        TB_Users tb_users = new TB_Users();
        Main main = new Main();
       

        public FRM_LOGIN()
        {
            InitializeComponent();
        }



        // add or edit
        private void btn_login_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Dialog dialog = new Dialog();
            // check if add or edit 
            if (edt_name.Text == ""|| edt_pass.Text == "")
            {
                dialog.Width = this.Width;
                dialog.txt_caption.Text = " جميع الحقول مطلوبة";
                dialog.Show();
            }
            else
            {
                // login here
                tb_users = db.TB_Users.Where(x => x.User_Name == edt_name.Text && x.User_Pass == edt_pass.Text).FirstOrDefault();
                   if(tb_users!= null)
                {
                    tb_users.User_State = "True";
                    db.Entry(tb_users).State=System.Data.Entity.EntityState.Modified;

                    main.lb_username.Text = tb_users.User_Name;
                    main.lb_roll.Text = tb_users.User_Roll;
                    main.Enabled= true; 
                    db.SaveChanges();
                    main.Show();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("كلمة السر أو اسم المستخدم خطأ");
                }
                
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FRM_LOGIN_Load(object sender, EventArgs e)
        {
            main.Enabled = false;
        }

        private void FRM_LOGIN_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
