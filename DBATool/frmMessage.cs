using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBATool
{
    public partial class frmMessage : Form
    {
        //string _query = "";
        //OdbcCommand _cmdPixelSqlbase = null;
        public frmMessage(OdbcCommand cmdPixelSqlbase, string query)
        {
            InitializeComponent();
            cmdPixelSqlbase.CommandText = query;
            cmdPixelSqlbase.ExecuteNonQuery();
        }

        private void frmMessage_Load(object sender, EventArgs e)
        {
            
            DialogResult = DialogResult.OK;
        }
    }
}
