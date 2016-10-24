using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace FreeBattle
{
    public partial class ucControlPanel : UserControl
    {
        public ucControlPanel()
        {
            InitializeComponent();
        }

        private void ucControlPanel_Load(object sender, EventArgs e)
        {
            int i;

            Process[] processlist = Process.GetProcesses();
            i = 0;
            foreach (Process theprocess in processlist)
            {
                dgridAttach.Rows.Add();
                dgridAttach.Rows[i].Selected = false;
                dgridAttach.Rows[i].Cells["id"].Value = theprocess.Id.ToString("X8");
                dgridAttach.Rows[i].Cells["name"].Value = theprocess.ProcessName;
                dgridAttach.Rows[i].Cells["window"].Value = theprocess.MainWindowTitle;
                try
                {
                    dgridAttach.Rows[i].Cells["path"].Value = theprocess.MainModule.FileName;
                }
                catch { }
                if (dgridAttach.Rows[i].Cells["path"].Value == null)
                    dgridAttach.Rows.RemoveAt(i);
                else
                    i++;
            }
        }
    }
}
