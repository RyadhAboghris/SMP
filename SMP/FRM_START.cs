using DevExpress.Data.ODataLinq.Helpers;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMP
{
    public partial class FRM_START : SplashScreen
    {
        DB_SMPEntities db = new DB_SMPEntities();
        TB_Users tb_users = new TB_Users();
        Main main = new Main();
        PL.FRM_LOGIN login = new PL.FRM_LOGIN();

        public FRM_START()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            tb_users = db.TB_Users.Where(x => x.User_State == "True").FirstOrDefault();
            if(tb_users!= null)
            {
                main.lb_username.Text = tb_users.User_Name;
                main.lb_roll.Text = tb_users.User_Roll;
                main.Show();
            }
            else
            {
                login.Show();
            }
            timer1.Enabled = false;
            this.Hide();
        }
    }
}