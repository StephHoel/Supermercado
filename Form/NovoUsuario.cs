using Library.Models;
using Library.Repo;
using Library.Service;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SupermercadoForm
{
    public partial class NovoUsuario : Form
    {
        private readonly UserRepository repository = new();

        public NovoUsuario()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            UserService userService = new(repository);
            userService.CreateUser(new User(txtNome.Text, txtEmail.Text, txtSenha.Text));
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            // pesquisa formulários abertos onde o nome seja Index
            var qrForm = from frm in Application.OpenForms.Cast<Form>()
                         where frm is Index
                         select frm;

            // verifica se existe ao menos 1 formulário aberto
            if (qrForm?.Count() > 0)
            {
                qrForm.First().Show(); // mostra form Index
                this.Close(); // fecha form atual
            }

        }
    }
}
