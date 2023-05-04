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
    public partial class FRM_SUPP : Form
    {

        DB_SMPEntities db = new DB_SMPEntities();
        BL.Methods methods = new BL.Methods();

        TB_Supp tb_supp = new TB_Supp();
        int id;
        public FRM_SUPP()
        {
            InitializeComponent();
            
            SMP.DB_SMPEntities dbContext = new SMP.DB_SMPEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TB_Supp.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.TB_Supp.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            PL.FRM_SUPP_ADD frm_add = new FRM_SUPP_ADD();
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
            id = Convert.ToInt16(tileView1.GetFocusedRowCellValue("ID"));
            if (id > 0)
            {
                try
                {
                    var rs = MessageBox.Show("هل انت متأكد من هذه العملية", "عملية حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (rs == DialogResult.Yes)
                    {

                        tb_supp = db.TB_Supp.Where(x => x.ID == id).FirstOrDefault();

                        db.Entry(tb_supp).State = EntityState.Deleted;
                        db.SaveChanges();
                        toast.txt_caption.Text = "تم حذف مورد";
                        toast.Show();
                        update_data();
                    }
                }
                catch
                {
                    dialog.txt_caption.Text = "لا يوجد مورد لحذفه";
                    dialog.Width = this.Width;
                    dialog.Show();


                }

            }
            else
            {
                dialog.txt_caption.Text = "لا يوجد مورد لحذفه";
                dialog.Width = this.Width;
                dialog.Show();
            }
            


        }
        private void update_data()
        {
            db = new DB_SMPEntities();
            gridControl1.DataSource = db.TB_Supp.ToList();
        }
        // edit
        private void btn_edt_Click(object sender, EventArgs e)
        {

            Toast toast = new Toast();
            Dialog dialog = new Dialog();
            id = Convert.ToInt16(tileView1.GetFocusedRowCellValue("ID"));
            if (id > 0)
            {
                try
                {
                    PL.FRM_SUPP_ADD frm_add = new FRM_SUPP_ADD();

                    tb_supp = db.TB_Supp.Where(x => x.ID == id).FirstOrDefault();
                    frm_add.edt_name.Text = tb_supp.Supp_Name.ToString();
                    frm_add.edt_phone.Text = tb_supp.Supp_Phone.ToString();
                    frm_add.edt_email.Text = tb_supp.Supp_Email.ToString();
                    methods.by = tb_supp.Supp_Image;
                    frm_add.pic_cover.Image = Image.FromStream(methods.convert_image());
                    frm_add.id = id;
                    frm_add.btn_add.Text = "تعديل";
                    frm_add.Show();
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
                dialog.txt_caption.Text = "لا يوجد صنف لتعديله";
                dialog.Width = this.Width;
                dialog.Show();
            }
            
        
        
}
        //search

        private void btn_search_Click(object sender, EventArgs e)
        {
            var _search=edt_search.Text;
            gridControl1.DataSource = db.TB_Supp.Where(x => x.Supp_Name.Contains(_search)|| x.Supp_Phone.Contains(_search) || x.Supp_Email.Contains(_search)).ToList();
        }
    }
}
