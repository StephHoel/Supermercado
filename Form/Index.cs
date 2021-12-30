using System;
using System.Windows.Forms;

namespace SupermercadoForm
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            NovoUsuario novoUsuario = new();
            novoUsuario.Show();
            this.Hide();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login login = new();
            login.Show();
            this.Hide();
        }
    }
}
