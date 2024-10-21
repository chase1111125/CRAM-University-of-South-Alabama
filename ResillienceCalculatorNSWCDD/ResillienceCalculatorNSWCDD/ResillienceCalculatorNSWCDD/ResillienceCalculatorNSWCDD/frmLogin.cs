using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResillienceCalculatorNSWCDD
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string allowedUsers = "admin";
            string allowedPasswords = "password";

            if(allowedUsers == "admin" && allowedPasswords == "password")
            {
                this.Close();
                frmSwitchboard frmSwitchboard = new frmSwitchboard();
                frmSwitchboard.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incorrect Password");
            }
        }
    }
}
