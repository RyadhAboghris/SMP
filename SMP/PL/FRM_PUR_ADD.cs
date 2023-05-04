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
    public partial class FRM_PUR_ADD : Form
    {
        // init
        DB_SMPEntities db=new DB_SMPEntities();
        TB_Pur tb_pur = new TB_Pur();
        BL.Methods methods=new BL.Methods();
        double buy, sell, qt, tbuy, tsell, trev;

        public int id;
        public FRM_PUR_ADD()
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
                dialog.txt_caption.Text = "اسم الصنف مطلوب";
                dialog.Show();
            }
            else
            {
                // check if add or edit
                if(id== 0)
                {
                    tb_pur.Pur_Name= edt_name.Text;
                    tb_pur.Pur_Type= edt_type.Text;
                    tb_pur.Pur_Cat= edt_cat.Text;
                    tb_pur.Pur_Supp= edt_supp.Text;
                    tb_pur.Pur_Det= edt_det.Text;
                    tb_pur.Pur_Buy=Convert.ToDouble(edt_buy.Text);
                    tb_pur.Pur_Sell=Convert.ToDouble(edt_sell.Text);
                    tb_pur.Pur_Qt=Convert.ToDouble(edt_qt.Text);
                    tb_pur.Pur_Tbuy=Convert.ToDouble(edt_tbuy.Text);
                    tb_pur.Pur_Tsell=Convert.ToDouble(edt_tsell.Text);
                    tb_pur.Pur_TRev=Convert.ToDouble(edt_trev.Text);
                    db.TB_Pur.Add(tb_pur);
                    db.SaveChanges();
                    toast.txt_caption.Text = "تم اجراء عملية شراء";
                    toast.Show();
                    this.Close();
                }
                else
                {
                    tb_pur.ID = id;
                    tb_pur.Pur_Name = edt_name.Text;
                    tb_pur.Pur_Type = edt_type.Text;
                    tb_pur.Pur_Cat = edt_cat.Text;
                    tb_pur.Pur_Supp = edt_supp.Text;
                    tb_pur.Pur_Det = edt_det.Text;
                    tb_pur.Pur_Buy = Convert.ToDouble(edt_buy.Text);
                    tb_pur.Pur_Sell = Convert.ToDouble(edt_sell.Text);
                    tb_pur.Pur_Qt = Convert.ToDouble(edt_qt.Text);
                    tb_pur.Pur_Tbuy = Convert.ToDouble(edt_tbuy.Text);
                    tb_pur.Pur_Tsell = Convert.ToDouble(edt_tsell.Text);
                    tb_pur.Pur_TRev = Convert.ToDouble(edt_trev.Text);
                    db.Entry(tb_pur).State=System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    toast.txt_caption.Text = "تم تعديل عملية شراء بنجاح";
                    toast.Show();
                    this.Close();
                }
            }

        }

        private void edt_buy_TextChanged(object sender, EventArgs e)
        {
            pro_cal();
        }

        private void edt_sell_TextChanged(object sender, EventArgs e)
        {
            pro_cal();

        }

        private void edt_qt_EditValueChanged(object sender, EventArgs e)
        {
            pro_cal();

        }

        private void FRM_PUR_ADD_Load(object sender, EventArgs e)
        {

        }

        private void FRM_PUR_ADD_Activated(object sender, EventArgs e)
        {
            edt_cat.DataSource = db.TB_CAT.Select(x => x.CAT_Name).ToList();
            edt_supp.DataSource = db.TB_Supp.Select(x => x.Supp_Name).ToList();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PL.FRM_CAT_ADD frm_add = new FRM_CAT_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "اضافة";
            frm_add.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PL.FRM_SUPP_ADD frm_add = new FRM_SUPP_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "اضافة";
            frm_add.Show();
        }

        private void pro_cal()
        {
            sell=Convert.ToDouble(edt_sell.Text);
            buy=Convert.ToDouble(edt_buy.Text);
            qt=Convert.ToDouble(edt_qt.Value);
            tsell = sell * qt;
            tbuy = buy * qt;
            trev = tsell - tbuy;
            edt_tsell.Text=tsell.ToString();
            edt_tbuy.Text=tbuy.ToString();
            edt_trev.Text=trev.ToString();
        }
    }
}
