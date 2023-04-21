using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBATool
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
            //lblContent.Text = "";
           
        }

        private void frmSplash_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.FromArgb(34, 86, 135), Color.FromArgb(17, 50, 68), 90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
            e.Graphics.DrawRectangle(new Pen(Color.Gray, 8), this.DisplayRectangle);
        }
    }
}
