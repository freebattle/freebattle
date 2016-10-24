using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FreeBattle
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text == "test" && txtPWD.Text == "test")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("用户名或密码错误！");
            }

        }
    }
}
