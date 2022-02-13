using System;
using System.Windows.Forms;

namespace CPU_ProcessCoordinationAlgorithm
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            lblProductName.Text = String.Format("Product name: {0}", Application.ProductName);
            lblProductVersion.Text = String.Format("Product version: {0}", Application.ProductVersion);
            lblCopyright.Text = "Copyright © 2021 by " + Application.CompanyName;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
