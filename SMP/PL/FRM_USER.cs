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
    public partial class FRM_USER : Form
    {

        DB_SMPEntities db = new DB_SMPEntities();
        BL.Methods methods = new BL.Methods();

        TB_Users tb_users = new TB_Users();
        int id;
        public FRM_USER()
        {
            InitializeComponent();


           
            SMP.DB_SMPEntities dbContext = new SMP.DB_SMPEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TB_Users.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.TB_Users.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
        // add

        private void btn_add_Click(object sender, EventArgs e)
        {
            PL.FRM_USER_ADD frm_add = new FRM_USER_ADD();
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

                        tb_users = db.TB_Users.Where(x => x.ID == id).FirstOrDefault();

                        db.Entry(tb_users).State = EntityState.Deleted;
                        db.SaveChanges();
                        toast.txt_caption.Text = "تم حذف مستخدم";
                        toast.Show();
                        update_data();
                    }
                }
                catch
                {
                    dialog.txt_caption.Text = "لا يوجد مستخدم لحذفه";
                    dialog.Width = this.Width;
                    dialog.Show();


                }
                
                
                

            }
            else
            {
                dialog.txt_caption.Text = "لا يوجد مستخدم لحذفه";
                dialog.Width = this.Width;
                dialog.Show();
            }
            


        }
        public void update_data()
        {
            db = new DB_SMPEntities();
            gridControl1.DataSource = db.TB_Users.ToList();
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
                    PL.FRM_USER_ADD frm_add = new FRM_USER_ADD();

                    tb_users = db.TB_Users.Where(x => x.ID == id).FirstOrDefault();
                    frm_add.edt_name.Text = tb_users.User_Name;
                    frm_add.edt_pass.Text = tb_users.User_Pass;
                    frm_add.edt_roll.Text = tb_users.User_Roll;


                    frm_add.id = id;
                    frm_add.btn_add.Text = "تعديل";
                    frm_add.Show();
                }

                catch
                {
                    dialog.txt_caption.Text = "لا يوجد مستخدم لتعديله";
                    dialog.Width = this.Width;
                    dialog.Show();

                }
            }
            else
            {
                dialog.txt_caption.Text = "لا يوجد مستخدم لتعديله";
                dialog.Width = this.Width;
                dialog.Show();
            }
            
        
        
}
        //search

        private void btn_search_Click(object sender, EventArgs e)
        {
            var _search=edt_search.Text;
            gridControl1.DataSource = db.TB_Users.Where(x => x.User_Name.Contains(_search)|| x.User_Roll.Contains(_search) ).ToList();
        }
    }
}
