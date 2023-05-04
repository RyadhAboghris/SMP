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
    public partial class FRM_SELL_ADD : Form
    {
        // init
        DB_SMPEntities db=new DB_SMPEntities();
        TB_Pur tb_pur = new TB_Pur();
        TB_Sell tb_sell = new TB_Sell();
        BL.Methods methods=new BL.Methods();
        double qtp,qtn,qtr;

        public int id;
        public FRM_SELL_ADD()
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
            qtp=Convert.ToDouble(txt_qt.Text);
            qtn=Convert.ToDouble(edt_qt.Text);
            qtr = qtp - qtn;
            if (edt_name.Text == "")
            {
                dialog.Width = this.Width;
                dialog.txt_caption.Text = "اسم المادة مطلوب";
                dialog.Show();
            }
            else
            {
                // check if add or edit
                if(id== 0)
                {

                    if (qtr >= 0)
                    {
                        label3.Visible = false;
                        tb_sell.Sell_Name = edt_name.Text;
                        tb_sell.Sell_Cus = edt_cus.Text;
                        tb_sell.Sell_Price = Convert.ToDouble(edt_sell.Text);
                        tb_sell.Sell_Qt= Convert.ToDouble(edt_qt.Text);
                        tb_sell.Sell_TPrice = (Convert.ToDouble(edt_qt.Text)) *(Convert.ToDouble(edt_sell.Text));
                        tb_sell.Sell_Date = DateTime.Now;
                        db.TB_Sell.Add(tb_sell);
                        tb_pur.Pur_Qt = qtr;
                        db.Entry(tb_pur).State=System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        toast.txt_caption.Text = "تم اجراء عملية بيع";
                        toast.Show();
                        this.Close();
                    }
                    else
                    {
                        label3.Visible = true; 
                    }
                   
                }
                else
                {
                    //tb_pur.ID = id;
                    //tb_pur.Pur_Name = edt_name.Text;
                    //tb_pur.Pur_Type = edt_type.Text;
                    //tb_pur.Pur_Cat = edt_name.Text;
                    //tb_pur.Pur_Supp = edt_cus.Text;
                    //tb_pur.Pur_Det = edt_det.Text;
                    //tb_pur.Pur_Buy = Convert.ToDouble(edt_sell.Text);
                    //tb_pur.Pur_Sell = Convert.ToDouble(edt_sell.Text);
                    //tb_pur.Pur_Qt = Convert.ToDouble(edt_qt.Text);
                    //tb_pur.Pur_Tbuy = Convert.ToDouble(edt_tbuy.Text);
                    //tb_pur.Pur_Tsell = Convert.ToDouble(edt_tsell.Text);
                    //tb_pur.Pur_TRev = Convert.ToDouble(edt_tqt.Text);
                    //db.Entry(tb_pur).State=System.Data.Entity.EntityState.Modified;
                    //db.SaveChanges();
                    //toast.txt_caption.Text = "تم تعديل عملية شراء بنجاح";
                    //toast.Show();
                    //this.Close();
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

        private void edt_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_pur = db.TB_Pur.Where(x => x.Pur_Name == edt_name.Text).FirstOrDefault();
            txt_buy.Text = tb_pur.Pur_Buy.ToString();
            txt_sell.Text = tb_pur.Pur_Sell.ToString();
            txt_qt.Text = tb_pur.Pur_Qt.ToString();
            edt_sell.Text = tb_pur.Pur_Sell.ToString();
        }

        private void FRM_PUR_ADD_Load(object sender, EventArgs e)
        {

        }

        private void FRM_PUR_ADD_Activated(object sender, EventArgs e)
        {
            var rs1 = db.TB_Pur.Select(x => x.Pur_Name).ToList();
            var rs2 = db.TB_Cus.Select(x => x.Supp_Name).ToList();
            edt_name.DataSource=rs1;
            edt_cus.DataSource=rs2;

            AutoCompleteStringCollection ACS1= new AutoCompleteStringCollection();  
            AutoCompleteStringCollection ACS2= new AutoCompleteStringCollection();
            ACS1.AddRange(rs1.ToArray());
            ACS2.AddRange(rs2.ToArray());

            edt_name.AutoCompleteCustomSource = ACS1;
            edt_cus.AutoCompleteCustomSource = ACS2;

          


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
           
        }
    }
}
