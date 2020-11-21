using HospitalControllers;
using HospitalModels;
using System;
using System.Windows.Forms;

namespace WindowsForms.Forms
{
    public partial class Acesso : Form
    {
        public Acesso()
        {
            InitializeComponent();
        }

        private async void BtnEntrar_Click(object sender, EventArgs e)
        {
            var acesso = new CtlAcesso();

            MdlAcesso usuario = await acesso.GetUsuarioAsync(TxtUsuario.Text, TxtSenha.Text);

            if (usuario == null)
                MessageBox.Show("Login ou senha inválido");
            else
            {
                this.Hide();
                Menu menu = new Menu();
                menu.Show();
            }
        }
    }
}
