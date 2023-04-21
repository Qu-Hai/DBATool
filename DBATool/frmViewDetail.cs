using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBATool
{
    public partial class frmViewDetail : Form
    {
        List<TransactionDetailModel> transactionDetails = new List<TransactionDetailModel>();
        public frmViewDetail(List<TransactionDetailModel> _transactionDetails, string _netTotal, string _finalTotal,string _emp,string _tableNum)
        {
            InitializeComponent();
            transactionDetails = _transactionDetails.Where(w=>w.Amount != "0").ToList();
            string finalTotal = Convert.ToDouble(_finalTotal).ToString("#,###");
            string netTotal = Convert.ToDouble(_netTotal).ToString("#,###");
            if (string.IsNullOrEmpty(finalTotal))
                finalTotal = "0";
            if (string.IsNullOrEmpty(netTotal))
                netTotal = "0";
            txtFinalTotal.Text = finalTotal;
            txtNetTotal.Text = netTotal;
            txtEmpClose.Text = _emp;
            txtTableNum.Text = _tableNum;
            //dgvDataDetail.FirstDisplayedScrollingRowIndex = -1;
        }

        private void frmViewDetail_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < transactionDetails.Count; i++)
            {
                bool isNegative = Convert.ToDouble(transactionDetails[i].Amount) < 0;
                string amount = isNegative ? "(" + Math.Abs(Convert.ToDouble(transactionDetails[i].Amount)).ToString("#,###") + ")" : Math.Abs(Convert.ToDouble(transactionDetails[i].Amount)).ToString("#,###");
                if (string.IsNullOrEmpty(amount))
                    amount = "0";
                transactionDetails[i].Amount = amount;
            }

            dgvDataDetail.DataSource = transactionDetails;
        }



    }
}
