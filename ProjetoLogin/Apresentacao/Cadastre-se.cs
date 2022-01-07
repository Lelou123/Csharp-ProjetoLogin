using ProjetoLogin.Modelo;
using System;
using System.Windows.Forms;

namespace ProjetoLogin.Apresentacao
{
    public partial class CadastreSe : Form
    {
        public CadastreSe()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            string mensagem = controle.Cadastrar(txbLogin.Text, txbSenha.Text, txbConfirmarSenha.Text);
            if(controle.Tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }else
            {
                MessageBox.Show(controle.Mensagem); // mensagem erro 
            }
        }

        private void CadastreSe_Load(object sender, EventArgs e)
        {

        }
    }
}
