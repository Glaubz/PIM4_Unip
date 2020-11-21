namespace WindowsForms.Forms
{
    partial class Consultas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DgvConsultas = new System.Windows.Forms.DataGridView();
            this.LblConsultas = new System.Windows.Forms.Label();
            this.BtnCriar = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.BtnOK = new System.Windows.Forms.Button();
            this.LblIdConsulta = new System.Windows.Forms.Label();
            this.LblDataConsulta = new System.Windows.Forms.Label();
            this.LblDescricaoEnfermidade = new System.Windows.Forms.Label();
            this.TxtDescricaoEnfermidade = new System.Windows.Forms.TextBox();
            this.LblIdPaciente = new System.Windows.Forms.Label();
            this.LblMedico = new System.Windows.Forms.Label();
            this.LblNomePaciente = new System.Windows.Forms.Label();
            this.LblNomeDoMedico = new System.Windows.Forms.Label();
            this.LblDataRetorno = new System.Windows.Forms.Label();
            this.TxtIdConsulta = new System.Windows.Forms.TextBox();
            this.TxtDataConsulta = new System.Windows.Forms.TextBox();
            this.TxtDataRetorno = new System.Windows.Forms.TextBox();
            this.TxtIdPaciente = new System.Windows.Forms.TextBox();
            this.TxtNomeDoPaciente = new System.Windows.Forms.TextBox();
            this.TxtIdMedico = new System.Windows.Forms.TextBox();
            this.TxtNomeMedico = new System.Windows.Forms.TextBox();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.LblModo = new System.Windows.Forms.Label();
            this.LblValorModo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvConsultas
            // 
            this.DgvConsultas.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.DgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvConsultas.Location = new System.Drawing.Point(22, 295);
            this.DgvConsultas.Name = "DgvConsultas";
            this.DgvConsultas.Size = new System.Drawing.Size(972, 190);
            this.DgvConsultas.TabIndex = 0;
            this.DgvConsultas.Text = "dataGridView1";
            // 
            // LblConsultas
            // 
            this.LblConsultas.AutoSize = true;
            this.LblConsultas.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblConsultas.Location = new System.Drawing.Point(22, 9);
            this.LblConsultas.Name = "LblConsultas";
            this.LblConsultas.Size = new System.Drawing.Size(117, 27);
            this.LblConsultas.TabIndex = 1;
            this.LblConsultas.Text = "Consultas";
            // 
            // BtnCriar
            // 
            this.BtnCriar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCriar.Location = new System.Drawing.Point(185, 14);
            this.BtnCriar.Name = "BtnCriar";
            this.BtnCriar.Size = new System.Drawing.Size(75, 23);
            this.BtnCriar.TabIndex = 2;
            this.BtnCriar.Text = "Criar";
            this.BtnCriar.UseVisualStyleBackColor = true;
            this.BtnCriar.Click += new System.EventHandler(this.BtnCriar_Click);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnConsultar.Location = new System.Drawing.Point(294, 14);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(75, 23);
            this.BtnConsultar.TabIndex = 2;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFechar.Location = new System.Drawing.Point(400, 14);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(75, 23);
            this.BtnFechar.TabIndex = 2;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAtualizar.Location = new System.Drawing.Point(504, 14);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.BtnAtualizar.TabIndex = 2;
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.UseVisualStyleBackColor = true;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // BtnOK
            // 
            this.BtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnOK.Location = new System.Drawing.Point(774, 14);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 3;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            // 
            // LblIdConsulta
            // 
            this.LblIdConsulta.AutoSize = true;
            this.LblIdConsulta.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblIdConsulta.Location = new System.Drawing.Point(22, 72);
            this.LblIdConsulta.Name = "LblIdConsulta";
            this.LblIdConsulta.Size = new System.Drawing.Size(76, 20);
            this.LblIdConsulta.TabIndex = 4;
            this.LblIdConsulta.Text = "ID Consulta";
            // 
            // LblDataConsulta
            // 
            this.LblDataConsulta.AutoSize = true;
            this.LblDataConsulta.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDataConsulta.Location = new System.Drawing.Point(22, 121);
            this.LblDataConsulta.Name = "LblDataConsulta";
            this.LblDataConsulta.Size = new System.Drawing.Size(94, 20);
            this.LblDataConsulta.TabIndex = 4;
            this.LblDataConsulta.Text = "Data Consulta ";
            // 
            // LblDescricaoEnfermidade
            // 
            this.LblDescricaoEnfermidade.AutoSize = true;
            this.LblDescricaoEnfermidade.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDescricaoEnfermidade.Location = new System.Drawing.Point(22, 232);
            this.LblDescricaoEnfermidade.Name = "LblDescricaoEnfermidade";
            this.LblDescricaoEnfermidade.Size = new System.Drawing.Size(149, 20);
            this.LblDescricaoEnfermidade.TabIndex = 4;
            this.LblDescricaoEnfermidade.Text = "Descrição Enfermidade";
            // 
            // TxtDescricaoEnfermidade
            // 
            this.TxtDescricaoEnfermidade.Location = new System.Drawing.Point(22, 255);
            this.TxtDescricaoEnfermidade.Name = "TxtDescricaoEnfermidade";
            this.TxtDescricaoEnfermidade.Size = new System.Drawing.Size(972, 23);
            this.TxtDescricaoEnfermidade.TabIndex = 5;
            // 
            // LblIdPaciente
            // 
            this.LblIdPaciente.AutoSize = true;
            this.LblIdPaciente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblIdPaciente.Location = new System.Drawing.Point(347, 72);
            this.LblIdPaciente.Name = "LblIdPaciente";
            this.LblIdPaciente.Size = new System.Drawing.Size(77, 20);
            this.LblIdPaciente.TabIndex = 4;
            this.LblIdPaciente.Text = "ID Paciente";
            // 
            // LblMedico
            // 
            this.LblMedico.AutoSize = true;
            this.LblMedico.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblMedico.Location = new System.Drawing.Point(724, 77);
            this.LblMedico.Name = "LblMedico";
            this.LblMedico.Size = new System.Drawing.Size(70, 20);
            this.LblMedico.TabIndex = 4;
            this.LblMedico.Text = "ID Médico";
            // 
            // LblNomePaciente
            // 
            this.LblNomePaciente.AutoSize = true;
            this.LblNomePaciente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNomePaciente.Location = new System.Drawing.Point(347, 121);
            this.LblNomePaciente.Name = "LblNomePaciente";
            this.LblNomePaciente.Size = new System.Drawing.Size(121, 20);
            this.LblNomePaciente.TabIndex = 4;
            this.LblNomePaciente.Text = "Nome do Paciente";
            // 
            // LblNomeDoMedico
            // 
            this.LblNomeDoMedico.AutoSize = true;
            this.LblNomeDoMedico.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNomeDoMedico.Location = new System.Drawing.Point(724, 125);
            this.LblNomeDoMedico.Name = "LblNomeDoMedico";
            this.LblNomeDoMedico.Size = new System.Drawing.Size(114, 20);
            this.LblNomeDoMedico.TabIndex = 4;
            this.LblNomeDoMedico.Text = "Nome do Médico";
            // 
            // LblDataRetorno
            // 
            this.LblDataRetorno.AutoSize = true;
            this.LblDataRetorno.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDataRetorno.Location = new System.Drawing.Point(22, 167);
            this.LblDataRetorno.Name = "LblDataRetorno";
            this.LblDataRetorno.Size = new System.Drawing.Size(86, 20);
            this.LblDataRetorno.TabIndex = 4;
            this.LblDataRetorno.Text = "Data Retorno";
            // 
            // TxtIdConsulta
            // 
            this.TxtIdConsulta.Location = new System.Drawing.Point(130, 73);
            this.TxtIdConsulta.Name = "TxtIdConsulta";
            this.TxtIdConsulta.Size = new System.Drawing.Size(130, 23);
            this.TxtIdConsulta.TabIndex = 6;
            // 
            // TxtDataConsulta
            // 
            this.TxtDataConsulta.Location = new System.Drawing.Point(130, 118);
            this.TxtDataConsulta.Name = "TxtDataConsulta";
            this.TxtDataConsulta.Size = new System.Drawing.Size(130, 23);
            this.TxtDataConsulta.TabIndex = 6;
            // 
            // TxtDataRetorno
            // 
            this.TxtDataRetorno.Location = new System.Drawing.Point(130, 164);
            this.TxtDataRetorno.Name = "TxtDataRetorno";
            this.TxtDataRetorno.Size = new System.Drawing.Size(130, 23);
            this.TxtDataRetorno.TabIndex = 6;
            // 
            // TxtIdPaciente
            // 
            this.TxtIdPaciente.Location = new System.Drawing.Point(480, 72);
            this.TxtIdPaciente.Name = "TxtIdPaciente";
            this.TxtIdPaciente.Size = new System.Drawing.Size(130, 23);
            this.TxtIdPaciente.TabIndex = 6;
            // 
            // TxtNomeDoPaciente
            // 
            this.TxtNomeDoPaciente.Location = new System.Drawing.Point(480, 121);
            this.TxtNomeDoPaciente.Name = "TxtNomeDoPaciente";
            this.TxtNomeDoPaciente.Size = new System.Drawing.Size(130, 23);
            this.TxtNomeDoPaciente.TabIndex = 6;
            // 
            // TxtIdMedico
            // 
            this.TxtIdMedico.Location = new System.Drawing.Point(864, 74);
            this.TxtIdMedico.Name = "TxtIdMedico";
            this.TxtIdMedico.Size = new System.Drawing.Size(130, 23);
            this.TxtIdMedico.TabIndex = 6;
            // 
            // TxtNomeMedico
            // 
            this.TxtNomeMedico.Location = new System.Drawing.Point(864, 122);
            this.TxtNomeMedico.Name = "TxtNomeMedico";
            this.TxtNomeMedico.Size = new System.Drawing.Size(130, 23);
            this.TxtNomeMedico.TabIndex = 6;
            // 
            // BtnMenu
            // 
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMenu.Location = new System.Drawing.Point(919, 14);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(75, 23);
            this.BtnMenu.TabIndex = 7;
            this.BtnMenu.Text = "Menu";
            this.BtnMenu.UseVisualStyleBackColor = true;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // LblModo
            // 
            this.LblModo.AutoSize = true;
            this.LblModo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblModo.Location = new System.Drawing.Point(606, 16);
            this.LblModo.Name = "LblModo";
            this.LblModo.Size = new System.Drawing.Size(56, 18);
            this.LblModo.TabIndex = 8;
            this.LblModo.Text = "Modo: ";
            // 
            // LblValorModo
            // 
            this.LblValorModo.AutoSize = true;
            this.LblValorModo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblValorModo.Location = new System.Drawing.Point(668, 16);
            this.LblValorModo.Name = "LblValorModo";
            this.LblValorModo.Size = new System.Drawing.Size(59, 18);
            this.LblValorModo.TabIndex = 8;
            this.LblValorModo.Text = "<valor>";
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1019, 509);
            this.Controls.Add(this.LblValorModo);
            this.Controls.Add(this.LblModo);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.TxtNomeMedico);
            this.Controls.Add(this.TxtIdMedico);
            this.Controls.Add(this.TxtNomeDoPaciente);
            this.Controls.Add(this.TxtIdPaciente);
            this.Controls.Add(this.TxtDataRetorno);
            this.Controls.Add(this.TxtDataConsulta);
            this.Controls.Add(this.TxtIdConsulta);
            this.Controls.Add(this.LblDataRetorno);
            this.Controls.Add(this.LblNomeDoMedico);
            this.Controls.Add(this.LblNomePaciente);
            this.Controls.Add(this.LblMedico);
            this.Controls.Add(this.LblIdPaciente);
            this.Controls.Add(this.TxtDescricaoEnfermidade);
            this.Controls.Add(this.LblDescricaoEnfermidade);
            this.Controls.Add(this.LblDataConsulta);
            this.Controls.Add(this.LblIdConsulta);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.BtnCriar);
            this.Controls.Add(this.LblConsultas);
            this.Controls.Add(this.DgvConsultas);
            this.Name = "Consultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas";
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvConsultas;
        private System.Windows.Forms.Label LblConsultas;
        private System.Windows.Forms.Button BtnCriar;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Label LblIdConsulta;
        private System.Windows.Forms.Label LblDataConsulta;
        private System.Windows.Forms.Label LblDescricaoEnfermidade;
        private System.Windows.Forms.TextBox TxtDescricaoEnfermidade;
        private System.Windows.Forms.Label LblIdPaciente;
        private System.Windows.Forms.Label LblMedico;
        private System.Windows.Forms.Label LblNomePaciente;
        private System.Windows.Forms.Label LblNomeDoMedico;
        private System.Windows.Forms.Label LblDataRetorno;
        private System.Windows.Forms.TextBox TxtIdConsulta;
        private System.Windows.Forms.TextBox TxtDataConsulta;
        private System.Windows.Forms.TextBox TxtDataRetorno;
        private System.Windows.Forms.TextBox TxtIdPaciente;
        private System.Windows.Forms.TextBox TxtNomeDoPaciente;
        private System.Windows.Forms.TextBox TxtIdMedico;
        private System.Windows.Forms.TextBox TxtNomeMedico;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Label LblModo;
        private System.Windows.Forms.Label LblValorModo;
    }
}