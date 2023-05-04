using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using SMP.EPL;

namespace SMP.PL
{
    public partial class FRM_SELL : Form
    {

        DB_SMPEntities db = new DB_SMPEntities();
        BL.Methods methods = new BL.Methods();

        TB_Sell tb_sell = new TB_Sell();
        int id;
        public FRM_SELL()
        {
            InitializeComponent();


            SMP.DB_SMPEntities dbContext = new SMP.DB_SMPEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TB_Sell.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.TB_Sell.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
        // add

        private void btn_add_Click(object sender, EventArgs e)
        {
            PL.FRM_SELL_ADD frm_add = new FRM_SELL_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "اضافة";
            frm_add.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            update_data();
        }

        private void ptn_delete_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Dialog dialog = new Dialog();
            id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
            if (id > 0)
            {
                try
                {
                    var rs = MessageBox.Show("هل انت متأكد من هذه العملية", "عملية حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (rs == DialogResult.Yes)
                    {

                        tb_sell = db.TB_Sell.Where(x => x.ID == id).FirstOrDefault();

                        db.Entry(tb_sell).State = EntityState.Deleted;
                        db.SaveChanges();
                        toast.txt_caption.Text = "تم حذف بيع";
                        toast.Show();
                        update_data();
                    }
                }
                catch
                {
                    dialog.txt_caption.Text = "لا يوجد عملية بيع لحذفه";
                    dialog.Width = this.Width;
                    dialog.Show();


                }
                
                
                

            }
            else
            {
                dialog.txt_caption.Text = "لا يوجد بيع لحذفه";
                dialog.Width = this.Width;
                dialog.Show();
            }
            


        }
        private void update_data()
        {
            db = new DB_SMPEntities();
            gridControl1.DataSource = db.TB_Sell.ToList();
        }
        // edit
        private void btn_edt_Click(object sender, EventArgs e)
        {

            Toast toast = new Toast();
            Dialog dialog = new Dialog();
            id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
            if (id > 0)
            {
                try
                {
                    //PL.FRM_PUR_ADD frm_add = new FRM_PUR_ADD();

                    //tb_pur = db.TB_Pur.Where(x => x.ID == id).FirstOrDefault();
                    //frm_add.edt_name.Text = tb_pur.Pur_Name;
                    //frm_add.edt_type.Text = tb_pur.Pur_Type;
                    //frm_add.edt_cat.Text = tb_pur.Pur_Cat;
                    //frm_add.edt_supp.Text = tb_pur.Pur_Supp;
                    //frm_add.edt_det.Text = tb_pur.Pur_Det;
                    //frm_add.edt_buy.Text = tb_pur.Pur_Buy.ToString();
                    //frm_add.edt_sell.Text = tb_pur.Pur_Sell.ToString();
                    //frm_add.edt_qt.Text = tb_pur.Pur_Qt.ToString();
                    //frm_add.edt_tsell.Text = tb_pur.Pur_Tsell.ToString();
                    //frm_add.edt_tbuy.Text = tb_pur.Pur_Tbuy.ToString();
                    //frm_add.edt_trev.Text = tb_pur.Pur_TRev.ToString();

                    //     frm_add.id = id;
                    //frm_add.btn_add.Text = "تعديل";
                    //frm_add.Show();
                }

                catch
                {
                    dialog.txt_caption.Text = "لا يوجد صنف لتعديله";
                    dialog.Width = this.Width;
                    dialog.Show();

                }
            }
            else
            {
                dialog.txt_caption.Text = "لا يوجد مشتري لتعديله";
                dialog.Width = this.Width;
                dialog.Show();
            }
            
        
        
}
        //search

        private void btn_search_Click(object sender, EventArgs e)
        {
            var _search=edt_search.Text;
            gridControl1.DataSource = db.TB_Sell.Where(x => x.Sell_Name.Contains(_search)|| x.Sell_Cus.Contains(_search) ).ToList();
        }
    }
}
