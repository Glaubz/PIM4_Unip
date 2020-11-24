using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms.Forms
{
    public partial class Medicos : Form
    {
        public Medicos()
        {
            InitializeComponent();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {

        }
    }
}
