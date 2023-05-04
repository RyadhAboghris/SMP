using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMP.PL
{
    public partial class FRM_HOME : Form
    {

        DB_SMPEntities db=new DB_SMPEntities();
        public FRM_HOME()
        {
            InitializeComponent();
            List<TB_CAT> list_cat = db.TB_CAT.ToList();
            lb_cat.Text = list_cat.Count.ToString();
            List<TB_Supp> list_supp = db.TB_Supp.ToList();
            lb_supp.Text = list_supp.Count.ToString();
            List<TB_Sell> list_sell = db.TB_Sell.ToList();
            lb_sell.Text = list_sell.Count.ToString();
            List<TB_Cus> list_cus = db.TB_Cus.ToList();
            lb_cus.Text = list_cus.Count.ToString();
            List<TB_Pur> list_pur = db.TB_Pur.ToList();
            lb_pur.Text = list_pur.Count.ToString();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            PL.FRM_SELL_ADD frm_add = new FRM_SELL_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "اضافة";
            frm_add.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            PL.FRM_CUS_ADD frm_add = new FRM_CUS_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "اضافة";
            frm_add.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            PL.FRM_SUPP_ADD frm_add = new FRM_SUPP_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "اضافة";
            frm_add.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            PL.FRM_CUS_ADD frm_add = new FRM_CUS_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "اضافة";
            frm_add.Show();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            PL.FRM_PUR_ADD frm_add = new FRM_PUR_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "اضافة";
            frm_add.Show();
        }
    }
}
