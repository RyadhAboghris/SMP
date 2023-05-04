using SMP.PL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMP
{
    public partial class Main : Form
    {
        // init from
        PL.FRM_HOME frm_home=new PL.FRM_HOME();
        PL.FRM_CAT frm_cat=new PL.FRM_CAT();
        PL.FRM_SUPP frm_supp=new PL.FRM_SUPP();
        PL.FRM_PUR frm_pur=new PL.FRM_PUR();
        PL.FRM_CUS frm_cus=new PL.FRM_CUS();
        PL.FRM_SELL frm_sell=new PL.FRM_SELL();
        PL.FRM_REPORT frm_report=new PL.FRM_REPORT();
        PL.FRM_USER frm_user=new PL.FRM_USER();
        DB_SMPEntities db;

        public Main()
        {
            InitializeComponent();
        }

        
        // close app
        private void btn_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        // min app
        private void btn_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        // max app
        private void btn_max_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState |= FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }
        //collapse
        private void btn_collapse_Click(object sender, EventArgs e)
        {
            if (pn_navbar.Width == 250)
            {
                pn_navbar.Width = 50;
                pn_tittelnavbar.Visible=false;
                pn_headernavbar.Height = 150;
            }
            else
            {
                pn_navbar.Width = 250;
                pn_tittelnavbar.Visible = true;
                pn_headernavbar.Height = 209;
            }
        }
        // load home page

        private void btn_home_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_home.pn_home);
            lb_titlepage.Text = "الرئيسة";

        }

        private void Main_Load(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_home.pn_home);
            //set roll
            if (lb_roll.Text == "مدير")
            {
                btn_user.Enabled = true;

            }
            else
            {
                btn_user.Enabled = false;

            }
        }
        // load cat
        private void btn_cat_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_cat.pn_cat);
            db = new DB_SMPEntities();
            lb_titlepage.Text = "الاصناف";
        }
        //load supp
        private void btn_supp_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_supp.pn_cat);
            db = new DB_SMPEntities();
            lb_titlepage.Text = "الموردين";

        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_pur.pn_cat);
            db = new DB_SMPEntities();
            lb_titlepage.Text = "المشتريات";
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_cus.pn_cat);
            db = new DB_SMPEntities();
            lb_titlepage.Text = "العملاء";
        }
        // load sell
        private void simpleButton11_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_sell.pn_cat);
            db = new DB_SMPEntities();
            lb_titlepage.Text = "المبيعات";
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_report.pn_cat);
            lb_titlepage.Text = "التقارير";
        }

        private void simpleButton13_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_user.pn_cat);
            frm_user.update_data();
            db = new DB_SMPEntities();
            lb_titlepage.Text = "المستخدمين";
        }

        private void simpleButton14_Click(object sender, EventArgs e)
        {
            PL.FRM_SETTINGS frm_settings = new PL.FRM_SETTINGS();
            frm_settings.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            TB_Users tb_users =new TB_Users();
            PL.FRM_LOGIN login=new PL.FRM_LOGIN();
            // login here
            try
            {
                tb_users = db.TB_Users.Where(x => x.User_State == "True").FirstOrDefault();
                tb_users.User_State = "False";
                db.Entry(tb_users).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }catch
            {

            }
          
            this.Enabled = false;
            this.Hide();
            login.Show();
        }

        private void Main_Activated(object sender, EventArgs e)
        {

            
        }
    }
}
