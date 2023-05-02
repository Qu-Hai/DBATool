using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginPixelPoint;
using System.Data.Odbc;
using System.Text.RegularExpressions;
namespace DBATool
{
    public partial class frmMain : Form
    {
        OdbcConnection conPixelSqlbase = new OdbcConnection("DSN=PixelSqlbase;UID=DBA;ENP=28f3cd0c3ddcfc32");
        EmployeeLogin EmployeeLogin = null;
        DateTime fromDate = DateTime.Now;
        DateTime toDate = DateTime.Now;
        string fromAmount = "0";
        string toAmount = "99,999,999";
        List<TransactionModel> transactions = new List<TransactionModel>();
        bool isSortAscending = true;
        public frmMain(EmployeeLogin _EmployeeLogin)
        {
            InitializeComponent();
            //this.Resize += new EventHandler(frmMain_Resize);
            //this.SizeChanged += new EventHandler(frmMain_SizeChanged);
            Configuration.InitConfig();
            CreateDb();
            dtFromDate.Value = DateTime.Now;
            dtToDate.Value = DateTime.Now;
            EmployeeLogin = _EmployeeLogin;

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (EmployeeLogin.ACTION == 0)
            {
                Application.Exit();
            }


        }



        private void Minisize()
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void dtFromDate_ValueChanged(object sender, EventArgs e)
        {


            
            //fromDate = DateTime.Parse(dtFromDate.Value.ToString("MM-dd-yyyy"));
            //toDate = DateTime.Parse(dtToDate.Value.ToString("MM-dd-yyyy"));

        }

        private void dtToDate_ValueChanged(object sender, EventArgs e)
        {
            //if (DateTime.Parse(dtFromDate.Value.ToString("MM-dd-yyyy")).AddDays(31) < DateTime.Parse(dtToDate.Value.ToString("MM-dd-yyyy")))
            //{
            //    MessageBox.Show("You only can select data in 31 days!");
            //    dtToDate.Value = toDate;
            //    dtFromDate.Value = fromDate;
            //}
            //fromDate = DateTime.Parse(dtFromDate.Value.ToString("MM-dd-yyyy"));
            //toDate = DateTime.Parse(dtToDate.Value.ToString("MM-dd-yyyy"));
        }
        private int CalculateDateTime(DateTime fromDate, DateTime toDate)
        {
            TimeSpan duration = toDate - fromDate;
            return duration.Days;
        }



        private string FormatCurrentcy(string amount)
        {
            try
            {
                amount = amount.Replace(",", "");
                amount = Regex.Match(amount, @"\d+").Value;

                amount = Convert.ToInt32(amount).ToString("#,###");
                if (string.IsNullOrEmpty(amount))
                    amount = "0";


                return amount;
            }
            catch (Exception ex)
            {
                return "0";
            }

        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            if (DateTime.Parse(dtFromDate.Value.ToString("MM-dd-yyyy")).AddDays(31) < DateTime.Parse(dtToDate.Value.ToString("MM-dd-yyyy")))
            {
                MessageBox.Show("You only can select data in 31 days!");
                //dtToDate.Value = toDate;
                //dtFromDate.Value = fromDate;
            }
            else if (DateTime.Parse(dtToDate.Value.ToString("MM-dd-yyyy")) < DateTime.Parse(dtFromDate.Value.ToString("MM-dd-yyyy"))) {
                MessageBox.Show("Start Date must be prior to End Date!");
            }
            else
            {
                Inquiry();
            }
        }

        private void CreateDb()
        {
            try
            {

                conPixelSqlbase.Open();
                OdbcCommand cmdPixelSqlbase = new OdbcCommand();
                cmdPixelSqlbase.Connection = conPixelSqlbase;
                cmdPixelSqlbase.CommandText = @"IF NOT EXISTS(select 1
                                                  from sys.systab
                                                  where sys.systab.creator = 1
                                                    and sys.systab.table_type_str = 'BASE'
                                                    and sys.systab.table_name = 'WrongTransAdjust')
                                                BEGIN
                                                    CREATE TABLE DBA.WrongTransAdjust (
                                                        UniqueID integer NOT NULL,
                                                        EMPNUM integer NULL,
                                                        Transact long varchar NULL,
                                                        DateCreated datetime NULL,
	                                                    PRIMARY KEY ( UniqueID ASC )
                                                    )
                                                    GRANT SELECT, REFERENCES ON DBA.WrongTransAdjust TO ReportUser
                                                END";



                cmdPixelSqlbase.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conPixelSqlbase.Close();
            }
        }

        private void Inquiry()
        {
            try
            {
                dgvDataTransaction.AutoGenerateColumns = false;
                string fromAmount = txtFromAmount.Text.Replace(",", "");
                string toAmount = txtToAmount.Text.Replace(",", "");
                string fromDate = dtFromDate.Value.ToString("yyyy-MM-dd");
                string toDate = dtToDate.Value.ToString("yyyy-MM-dd");
                conPixelSqlbase.Open();
                OdbcCommand cmdPixelSqlbase = new OdbcCommand();
                cmdPixelSqlbase.Connection = conPixelSqlbase;
                string cmdQuery = "SELECT Dateformat(PH.TimeEnd,'mm-dd-yyyy hh:mm') as TimeEnd,PH.TRANSACT as Transact,PH.NETTOTAL as NetTotal,PH.FINALTOTAL as FinalTotal,ES.EMPNAME as WhoOpen,EE.EMPNAME as WhoClose,PH.TAX1 +PH.TAX4 as SVC,PH.Tax2+PH.Tax3 as VAT FROM DBA.POSHEADER PH LEFT JOIN DBA.employee ES ON PH.WHOSTART = ES.EMPNUM LEFT JOIN DBA.employee EE ON PH.WHOCLOSE = EE.EMPNUM LEFT JOIN DBA.Sysinfo S ON (1 = 1) WHERE PH.Status = 3 AND PH.FinalTotal <> 0 AND PH.FINALTOTAL BETWEEN " + fromAmount + " AND " + toAmount + " AND PH.OpenDate BETWEEN '" + fromDate + "' AND '" + toDate + "'";



                cmdPixelSqlbase.CommandText = cmdQuery;

                transactions = DataReaderToList<TransactionModel>(cmdPixelSqlbase.ExecuteReader());

                dgvDataTransaction.DataSource = transactions;
                cbAll.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conPixelSqlbase.Close();
            }
        }

        private void InquiryDetail(string _transact, string _netTotal, string _finalTotal,string _emp)
        {
            try
            {
                dgvDataTransaction.AutoGenerateColumns = false;

                conPixelSqlbase.Open();
                OdbcCommand cmdPixelSqlbase = new OdbcCommand();
                cmdPixelSqlbase.Connection = conPixelSqlbase;
                string cmdQuery = "SELECT PD.UNIQUEID as UNIQUEID,(CASE WHEN P.PRODTYPE = 101 THEN '*' ELSE '' END + P.DESCRIPT) AS DESCRIPT,PD.QUAN AS QUAN,CAST(PD.OrigCostEach*PD.Quan AS VARCHAR) AS AMOUNT from DBA.POSDETAIL PD LEFT JOIN DBA.Product P ON PD.PRODNUM = P.PRODNUM where PD.Transact = " + _transact + " AND PD.OrigCostEach <> 0 AND PD.PRODTYPE <> 100 UNION ALL SELECT PD.UNIQUEID as UNIQUEID,P.DESCRIPT AS DESCRIPT,PD.QUAN AS QUAN,CAST(PD.OrigCostEach*PD.Quan AS VARCHAR) AS AMOUNT from DBA.POSDETAIL PD LEFT JOIN DBA.Promo P ON PD.PRODNUM = P.PROMONUM where PD.Transact = " + _transact + " AND PD.PRODTYPE = 100 AND PD.OrigCostEach <> 0 Order by 1";



                cmdPixelSqlbase.CommandText = cmdQuery;

                List<TransactionDetailModel> transactionDetails = DataReaderToList<TransactionDetailModel>(cmdPixelSqlbase.ExecuteReader());
                cmdPixelSqlbase.CommandText = "SELECT TABLENUM FROM DBA.POSHEADER WHERE Transact = " + _transact + "";

                string tableNum = Convert.ToString(cmdPixelSqlbase.ExecuteScalar());
                frmViewDetail frmViewDetail = new frmViewDetail(transactionDetails, _netTotal, _finalTotal,_emp, "#"+tableNum);
                frmViewDetail.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conPixelSqlbase.Close();
            }
        }

        public static List<T> DataReaderToList<T>(OdbcDataReader reader)
        {
            DataTable dt = new DataTable();
            dt.Load(reader);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<T>>(Newtonsoft.Json.JsonConvert.SerializeObject(dt));
        }


        private void CheckAll(bool value)
        {
            foreach (DataGridViewRow row in dgvDataTransaction.Rows)
            {
                DataGridViewCheckBoxCell cell = row.Cells["Select"] as DataGridViewCheckBoxCell;
                cell.Value = value;
            }
        }

        private void cbAll_CheckedChanged(object sender, EventArgs e)
        {

            CheckAll((bool)cbAll.Checked);

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string transactions = "(";
            foreach (DataGridViewRow row in dgvDataTransaction.Rows)
            {
                // Lấy giá trị checkbox tại cột đầu tiên của hàng hiện tại
                DataGridViewCheckBoxCell chk = row.Cells[0] as DataGridViewCheckBoxCell;
                if (chk != null && chk.Value != null && (bool)chk.Value)
                {
                    // Nếu checkbox được chọn, thêm hàng hiện tại vào danh sách hàng đã chọn

                    string transact = row.Cells[1].Value.ToString();
                    transactions += transact + ",";
                    //selectedRows.Add(row);
                }
            }
            transactions += ")";
            transactions = transactions.Replace(",)", ")");
            if (transactions != "()")
            {
                frmConfirm frmConfirm = new frmConfirm();
                if (frmConfirm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    OdbcTransaction tranPixelSqlbase = null;

                    conPixelSqlbase.Open();
                    tranPixelSqlbase = conPixelSqlbase.BeginTransaction();
                    OdbcCommand cmdPixelSqlbase = new OdbcCommand();
                    cmdPixelSqlbase.Connection = conPixelSqlbase;
                    cmdPixelSqlbase.Transaction = tranPixelSqlbase;
                    try
                    {

                        string cmdQuery = "UPDATE DBA.POSHEADER PH SET UpdateStatus = 1, OpenDate = '1990-01-01' WHERE Transact IN " + transactions + ";\n";
                        cmdQuery += "UPDATE DBA.POSDETAIL PH SET UpdateStatus = 1, OpenDate = '1990-01-01' WHERE Transact IN " + transactions + ";\n";
                        cmdQuery += "UPDATE DBA.HOWPAID PH SET UpdateStatus = 1,PunchIndex = -1, OpenDate = '1990-01-01' WHERE Transact IN " + transactions + ";\n";
                        cmdQuery += "INSERT INTO DBA.WrongTransAdjust(UniqueID,EMPNUM,Transact,DateCreated) VALUES((select isnull(max(UniqueID),0)+1 from DBA.WrongTransAdjust)," + EmployeeLogin.EMPNUM + ",'" + transactions.Replace(")", "").Replace("(", "") + "',getdate())";
                        frmMessage frmMessage = new frmMessage(cmdPixelSqlbase, cmdQuery);
                        if (frmMessage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            tranPixelSqlbase.Commit();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        tranPixelSqlbase.Rollback();
                    }
                    finally
                    {
                        conPixelSqlbase.Close();
                        Inquiry();
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult _DialogResult = MessageBox.Show("Are you sure you want to close the app?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (_DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtFromAmount_Validating(object sender, CancelEventArgs e)
        {
            txtFromAmount.Text = FormatCurrentcy(txtFromAmount.Text);
            fromAmount = txtFromAmount.Text;

        }

        private void txtToAmount_Validating(object sender, CancelEventArgs e)
        {
            txtToAmount.Text = FormatCurrentcy(txtToAmount.Text);
            toAmount = txtToAmount.Text;
        }

        private void dgvDataTransaction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.ColumnIndex;
            if (e.RowIndex == -1 && index > 0 && transactions.Count > 0)
            {

                isSortAscending = !isSortAscending;
                SortData(index);
                dgvDataTransaction.DataSource = transactions;
                cbAll.Checked = false;
                CheckAll((bool)cbAll.Checked);
            }
            else if (e.RowIndex != -1 && index == 9 && transactions.Count > 0)
            {
                string transact = dgvDataTransaction.Rows[e.RowIndex].Cells[1].Value.ToString();
                string netTotal = dgvDataTransaction.Rows[e.RowIndex].Cells[3].Value.ToString();
                string finalTotal = dgvDataTransaction.Rows[e.RowIndex].Cells[6].Value.ToString();
                string emp = dgvDataTransaction.Rows[e.RowIndex].Cells[8].Value.ToString();
                if (Convert.ToDecimal(finalTotal) != 0 && !string.IsNullOrEmpty(transact))
                {
                    InquiryDetail(transact, netTotal, finalTotal, emp);
                }
            }
        }


        private void dgvDataTransaction_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            //if (e.RowIndex != -1 && e.ColumnIndex != 0)
            //{
            //    string transact = dgvDataTransaction.Rows[e.RowIndex].Cells[1].Value.ToString();
            //    string finalTotal = dgvDataTransaction.Rows[e.RowIndex].Cells[6].Value.ToString();
            //    if (Convert.ToDecimal(finalTotal) != 0 && !string.IsNullOrEmpty(transact))
            //    {
            //        InquiryDetail(transact);
            //    }
            //}
        }

        private void SortData(int _index)
        {
            switch (_index)
            {
                case 1:

                    transactions = isSortAscending ? transactions.OrderBy(o => o.Transact).ToList() : transactions.OrderByDescending(o => o.Transact).ToList();
                    break;
                case 2:
                    transactions = isSortAscending ? transactions.OrderBy(o => o.TimeEnd).ToList() : transactions.OrderByDescending(o => o.TimeEnd).ToList();
                    break;
                case 3:

                    transactions = isSortAscending ? transactions.OrderBy(o => o.NetTotal).ToList() : transactions.OrderByDescending(o => o.NetTotal).ToList();
                    break;
                case 4:
                    transactions = isSortAscending ? transactions.OrderBy(o => o.SVC).ToList() : transactions.OrderByDescending(o => o.SVC).ToList();
                    break;
                case 5:

                    transactions = isSortAscending ? transactions.OrderBy(o => o.VAT).ToList() : transactions.OrderByDescending(o => o.VAT).ToList();
                    break;
                case 6:
                    transactions = isSortAscending ? transactions.OrderBy(o => o.FinalTotal).ToList() : transactions.OrderByDescending(o => o.FinalTotal).ToList();
                    break;
                case 7:

                    transactions = isSortAscending ? transactions.OrderBy(o => o.WhoOpen).ToList() : transactions.OrderByDescending(o => o.WhoOpen).ToList();
                    break;
                case 8:
                    transactions = isSortAscending ? transactions.OrderBy(o => o.WhoClose).ToList() : transactions.OrderByDescending(o => o.WhoClose).ToList();
                    break;
            }
        }

        private void txtFromAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtToAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void frmMain_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }






    }
}
