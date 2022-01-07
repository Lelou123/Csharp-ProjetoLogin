using System;
using System.Windows.Forms;

namespace ProjetoLogin.Apresentacao
{
    public partial class BemVindo : Form
    {
        public BemVindo()
        {
            InitializeComponent();
        }

        private void BemVindo_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
