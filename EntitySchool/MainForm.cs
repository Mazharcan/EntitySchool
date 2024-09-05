using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntitySchool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOgr_Click(object sender, EventArgs e)
        {
            frmOgrenci frmOgrenci = new frmOgrenci();
            frmOgrenci.Show();
            this.Hide();
        }

        private void btnDers_Click(object sender, EventArgs e)
        {
            frmDersler frmDersler = new frmDersler();
            frmDersler.Show();
            this.Hide();
        }

        private void btnNot_Click(object sender, EventArgs e)
        {
            frmNotlar frmNotlar = new frmNotlar();
            frmNotlar.Show();
            this.Hide();
        }
        private void btnLINQ_Click(object sender, EventArgs e)
        {
            frmLINQ frmLINQ = new frmLINQ();
            frmLINQ.Show();
            this.Hide();
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
