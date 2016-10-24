using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreeBattle
{
    public partial class frmMain : Form
    {
        private bool isLogin = false;

        public frmMain()
        {
            InitializeComponent();
            if (!isLogin)
            {
                frmLogin login = new frmLogin();
                login.ShowDialog();
                if(login.DialogResult == DialogResult.OK)
                {
                    isLogin = true;
                    lblUser.Text = "test";
                    lblMoney.Text = "余额 100";
                    btnBuy_Click(null,null);
                }
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnControlPanel_Click(object sender, EventArgs e)
        {
            lblFunc.Text = btnControlPanel.Text;
            ucControlPanel cp = new ucControlPanel();
            pnlView.Controls.Clear();
            pnlView.Controls.Add(cp);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            lblFunc.Text = btnSetting.Text;
            ucSetting cp = new ucSetting();
            pnlView.Controls.Clear();
            pnlView.Controls.Add(cp);
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            lblFunc.Text = btnBuy.Text;
            ucBuy cp = new ucBuy();
            pnlView.Controls.Clear();
            pnlView.Controls.Add(cp);
        }
    }
}
