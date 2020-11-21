using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms.Forms
{
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void BtnCriar_Click(object sender, EventArgs e)
        {
            LblValorModo.Text = "Criar";
            BtnConsultar.Visible = false;
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            LblValorModo.Text = "Consultar";
            
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            LblValorModo.Text = "Fechar";
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            LblValorModo.Text = "Atualizar";
        }
    }
}
