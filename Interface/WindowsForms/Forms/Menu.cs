using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms.Forms
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BtnConsultas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Consultas consultas = new Consultas();
            consultas.Show();
        }

        private void BtnPacientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pacientes pacientes = new Pacientes();
            pacientes.Show();
        }

        private void BtnMedicos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Medicos medicos = new Medicos();
            medicos.Show();
        }

        private void BtnFuncionarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            Funcionarios funcionarios = new Funcionarios();
            funcionarios.Show();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            Acesso acesso = new Acesso();
            acesso.Show();
        }
    }
}
