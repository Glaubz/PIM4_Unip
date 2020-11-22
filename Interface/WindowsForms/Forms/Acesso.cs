using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HospitalControllers;
using System.Threading.Tasks;
using HospitalModels;

namespace WindowsForms.Forms
{
    public partial class Acesso : Form
    {
        public Acesso()
        {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            CtlUsuario usuario = new CtlUsuario();
            var _usuario = usuario.GetUsuarioAsync(TxtUsuario.Text, TxtSenha.Text);
            if (_usuario == null)
            {
                MessageBox.Show("Login ou senha inválido");
            }
            else
            {
                this.Hide();
                Menu menu = new Menu();
                menu.Show();
            }            
        }


    }
}
