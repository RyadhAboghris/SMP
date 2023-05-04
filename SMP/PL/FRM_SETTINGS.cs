using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace SMP.PL
{
    public partial class FRM_SETTINGS : Form
    {
        public FRM_SETTINGS()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            const string qu= "\"";
            var sv=edt_sv.Text;
            var constr = @"metadata=res://*/SMPM.csdl|res://*/SMPM.ssdl|res://*/SMPM.msl;provider=System.Data.SqlClient;provider connection string="+ qu + ";data source="+sv+";initial catalog=DB_SMP;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework\";";
        
        var config= ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings["DB_SMPEntities"].ConnectionString = constr;
            config.Save();
            ConfigurationManager.RefreshSection("connectionString");
            var strl = config.ConnectionStrings.ConnectionStrings["DB_SMPEntities"].ConnectionString;
            MessageBox.Show(strl);
            Application.Restart();
        }
    }
}
