using System;
using System.Windows.Forms;

namespace CPU_ProcessCoordinationAlgorithm
{
    public partial class FormCPU : Form
    {
        public FormCPU()
        {
            InitializeComponent();
        }
        #region Button
        private void btnFCFS_Click(object sender, EventArgs e)
        {
            FormFCFS fcfs = new FormFCFS();
            this.Hide();
            fcfs.ShowDialog();
            this.Show();
        }

        private void btnSJF_Click(object sender, EventArgs e)
        {
            FormSJF sjf = new FormSJF();
            this.Hide();
            sjf.ShowDialog();
            this.Show();
        }

        private void btnRR_Click(object sender, EventArgs e)
        {
            FormRR rr = new FormRR();
            this.Hide();
            rr.ShowDialog();
            this.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            this.Hide();
            about.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
