using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlybanthuoc
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void quảnLýNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDangnhap f = new FrmDangnhap();
            f.Show();
        }

        private void tsrExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
