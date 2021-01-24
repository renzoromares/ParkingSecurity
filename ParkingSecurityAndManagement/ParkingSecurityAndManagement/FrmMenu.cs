using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace ParkingSecurityAndManagement
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            FrmRegister register = new FrmRegister();
            mainPanel.Controls.Clear();
            register.TopLevel = false;
            mainPanel.Controls.Add(register);
            register.Show();
            
            if(register.isDone)
            {
                
            }
        }

        private void btnSearchAcc_Click(object sender, EventArgs e)
        {
            FrmSearchAccount searchAccount = new FrmSearchAccount();
            mainPanel.Controls.Clear();
            searchAccount.TopLevel = false;
            mainPanel.Controls.Add(searchAccount);
            searchAccount.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            FrmAccount account = new FrmAccount();
            mainPanel.Controls.Clear();
            account.TopLevel = false;
            mainPanel.Controls.Add(account);
            account.Show();
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            FrmRecords records = new FrmRecords();
            mainPanel.Controls.Clear();
            records.TopLevel = false;
            mainPanel.Controls.Add(records);
            records.Show();
        }


    }
}
