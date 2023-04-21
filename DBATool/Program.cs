using LoginPixelPoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBATool
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Configuration.InitConfig();
            frmSplash frmSplash = new frmSplash();
            if (frmSplash.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
            Login:
                EmployeeLogin EmployeeLogin = new EmployeeLogin();
                EmployeeLogin = LoginPixelPoint.LoginPixelPoint.Auth(Convert.ToInt32(Configuration.getConfig["SECLEVEL"]));

                //if (EmployeeLogin.ACTION == 0)
                //{
                //    Application.Exit();
                //}
                if (EmployeeLogin.EMPNUM != -1 || EmployeeLogin.ACTION == 0)
                    Application.Run(new frmMain(EmployeeLogin));
                else
                    goto Login;
            }
            else
            {
                Application.Exit();
            }

        }
    }
}
