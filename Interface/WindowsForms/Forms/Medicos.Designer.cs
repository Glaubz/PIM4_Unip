namespace WindowsForms.Forms
{
    partial class Medicos
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
            this.BtnMenu = new System.Windows.Forms.Button();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.BtnDeletar = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnCriar = new System.Windows.Forms.Button();
            this.LblMedicos = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtIdMedico = new System.Windows.Forms.TextBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.LblEspecialidade = new System.Windows.Forms.Label();
            this.LblMedico = new System.Windows.Forms.Label();
            this.TxtCrm = new System.Windows.Forms.TextBox();
            this.LblCrm = new System.Windows.Forms.Label();
            this.BtnAjuda = new System.Windows.Forms.Button();
            this.TxtCpf = new System.Windows.Forms.TextBox();
            this.TxtRg = new System.Windows.Forms.TextBox();
            this.LblRg = new System.Windows.Forms.Label();
            this.TxtDataNascimento = new System.Windows.Forms.TextBox();
            this.LblDataNascimento = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.LblLogin = new System.Windows.Forms.Label();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.LblSenha = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.CbGenero = new System.Windows.Forms.ComboBox();
            this.LblCpf = new System.Windows.Forms.Label();
            this.CbIdEspecialidade = new System.Windows.Forms.ComboBox();
            this.DgvMedicos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnMenu
            // 
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMenu.Location = new System.Drawing.Point(904, 20);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(75, 23);
            this.BtnMenu.TabIndex = 7;
            this.BtnMenu.Text = "Menu";
            this.BtnMenu.UseVisualStyleBackColor = true;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAtualizar.Location = new System.Drawing.Point(489, 20);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.BtnAtualizar.TabIndex = 2;
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.UseVisualStyleBackColor = true;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDeletar.Location = new System.Drawing.Point(385, 20);
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.Size = new System.Drawing.Size(75, 23);
            this.BtnDeletar.TabIndex = 2;
            this.BtnDeletar.Text = "Deletar";
            this.BtnDeletar.UseVisualStyleBackColor = true;
            this.BtnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnConsultar.Location = new System.Drawing.Point(279, 20);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(75, 23);
            this.BtnConsultar.TabIndex = 2;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // BtnCriar
            // 
            this.BtnCriar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCriar.Location = new System.Drawing.Point(170, 20);
            this.BtnCriar.Name = "BtnCriar";
            this.BtnCriar.Size = new System.Drawing.Size(75, 23);
            this.BtnCriar.TabIndex = 2;
            this.BtnCriar.Text = "Criar";
            this.BtnCriar.UseVisualStyleBackColor = true;
            this.BtnCriar.Click += new System.EventHandler(this.BtnCriar_Click);
            // 
            // LblMedicos
            // 
            this.LblMedicos.AutoSize = true;
            this.LblMedicos.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblMedicos.Location = new System.Drawing.Point(7, 15);
            this.LblMedicos.Name = "LblMedicos";
            this.LblMedicos.Size = new System.Drawing.Size(100, 27);
            this.LblMedicos.TabIndex = 1;
            this.LblMedicos.Text = "Médicos";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(408, 67);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(199, 23);
            this.TxtNome.TabIndex = 6;
            // 
            // TxtIdMedico
            // 
            this.TxtIdMedico.Location = new System.Drawing.Point(130, 67);
            this.TxtIdMedico.Name = "TxtIdMedico";
            this.TxtIdMedico.Size = new System.Drawing.Size(212, 23);
            this.TxtIdMedico.TabIndex = 6;
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNome.Location = new System.Drawing.Point(348, 68);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(45, 20);
            this.LblNome.TabIndex = 4;
            this.LblNome.Text = "Nome";
            // 
            // LblEspecialidade
            // 
            this.LblEspecialidade.AutoSize = true;
            this.LblEspecialidade.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblEspecialidade.Location = new System.Drawing.Point(22, 160);
            this.LblEspecialidade.Name = "LblEspecialidade";
            this.LblEspecialidade.Size = new System.Drawing.Size(111, 20);
            this.LblEspecialidade.TabIndex = 4;
            this.LblEspecialidade.Text = "ID Especialidade";
            // 
            // LblMedico
            // 
            this.LblMedico.AutoSize = true;
            this.LblMedico.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblMedico.Location = new System.Drawing.Point(22, 66);
            this.LblMedico.Name = "LblMedico";
            this.LblMedico.Size = new System.Drawing.Size(70, 20);
            this.LblMedico.TabIndex = 4;
            this.LblMedico.Text = "ID Médico";
            // 
            // TxtCrm
            // 
            this.TxtCrm.Location = new System.Drawing.Point(130, 112);
            this.TxtCrm.Name = "TxtCrm";
            this.TxtCrm.Size = new System.Drawing.Size(212, 23);
            this.TxtCrm.TabIndex = 6;
            // 
            // LblCrm
            // 
            this.LblCrm.AutoSize = true;
            this.LblCrm.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCrm.Location = new System.Drawing.Point(22, 115);
            this.LblCrm.Name = "LblCrm";
            this.LblCrm.Size = new System.Drawing.Size(38, 20);
            this.LblCrm.TabIndex = 4;
            this.LblCrm.Text = "CRM";
            // 
            // BtnAjuda
            // 
            this.BtnAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAjuda.Location = new System.Drawing.Point(759, 20);
            this.BtnAjuda.Name = "BtnAjuda";
            this.BtnAjuda.Size = new System.Drawing.Size(75, 23);
            this.BtnAjuda.TabIndex = 3;
            this.BtnAjuda.Text = "Ajuda";
            this.BtnAjuda.UseVisualStyleBackColor = true;
            // 
            // TxtCpf
            // 
            this.TxtCpf.Location = new System.Drawing.Point(408, 112);
            this.TxtCpf.Name = "TxtCpf";
            this.TxtCpf.Size = new System.Drawing.Size(199, 23);
            this.TxtCpf.TabIndex = 6;
            // 
            // TxtRg
            // 
            this.TxtRg.Location = new System.Drawing.Point(408, 157);
            this.TxtRg.Name = "TxtRg";
            this.TxtRg.Size = new System.Drawing.Size(199, 23);
            this.TxtRg.TabIndex = 6;
            // 
            // LblRg
            // 
            this.LblRg.AutoSize = true;
            this.LblRg.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblRg.Location = new System.Drawing.Point(348, 160);
            this.LblRg.Name = "LblRg";
            this.LblRg.Size = new System.Drawing.Size(28, 20);
            this.LblRg.TabIndex = 4;
            this.LblRg.Text = "RG";
            // 
            // TxtDataNascimento
            // 
            this.TxtDataNascimento.Location = new System.Drawing.Point(759, 203);
            this.TxtDataNascimento.Name = "TxtDataNascimento";
            this.TxtDataNascimento.Size = new System.Drawing.Size(209, 23);
            this.TxtDataNascimento.TabIndex = 6;
            // 
            // LblDataNascimento
            // 
            this.LblDataNascimento.AutoSize = true;
            this.LblDataNascimento.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDataNascimento.Location = new System.Drawing.Point(624, 206);
            this.LblDataNascimento.Name = "LblDataNascimento";
            this.LblDataNascimento.Size = new System.Drawing.Size(129, 20);
            this.LblDataNascimento.TabIndex = 4;
            this.LblDataNascimento.Text = "Data de Nascimento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(348, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Gênero";
            // 
            // TxtLogin
            // 
            this.TxtLogin.Location = new System.Drawing.Point(759, 67);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(209, 23);
            this.TxtLogin.TabIndex = 6;
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblLogin.Location = new System.Drawing.Point(624, 70);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(42, 20);
            this.LblLogin.TabIndex = 4;
            this.LblLogin.Text = "Login";
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(759, 112);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(209, 23);
            this.TxtSenha.TabIndex = 6;
            // 
            // LblSenha
            // 
            this.LblSenha.AutoSize = true;
            this.LblSenha.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSenha.Location = new System.Drawing.Point(624, 115);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(47, 20);
            this.LblSenha.TabIndex = 4;
            this.LblSenha.Text = "Senha";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(759, 156);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(209, 23);
            this.TxtEmail.TabIndex = 6;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblEmail.Location = new System.Drawing.Point(624, 159);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(42, 20);
            this.LblEmail.TabIndex = 4;
            this.LblEmail.Text = "Email";
            // 
            // CbGenero
            // 
            this.CbGenero.FormattingEnabled = true;
            this.CbGenero.Items.AddRange(new object[] {
            "M",
            "F"});
            this.CbGenero.Location = new System.Drawing.Point(408, 200);
            this.CbGenero.Name = "CbGenero";
            this.CbGenero.Size = new System.Drawing.Size(199, 23);
            this.CbGenero.TabIndex = 10;
            // 
            // LblCpf
            // 
            this.LblCpf.AutoSize = true;
            this.LblCpf.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCpf.Location = new System.Drawing.Point(348, 113);
            this.LblCpf.Name = "LblCpf";
            this.LblCpf.Size = new System.Drawing.Size(35, 20);
            this.LblCpf.TabIndex = 4;
            this.LblCpf.Text = "CPF";
            // 
            // CbIdEspecialidade
            // 
            this.CbIdEspecialidade.FormattingEnabled = true;
            this.CbIdEspecialidade.Items.AddRange(new object[] {
            "1-Ortopedista",
            "2-Ginecologista",
            "3-Cirurgião",
            "Qualquer especialidade"});
            this.CbIdEspecialidade.Location = new System.Drawing.Point(148, 156);
            this.CbIdEspecialidade.Name = "CbIdEspecialidade";
            this.CbIdEspecialidade.Size = new System.Drawing.Size(194, 23);
            this.CbIdEspecialidade.TabIndex = 12;
            // 
            // DgvMedicos
            // 
            this.DgvMedicos.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.DgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMedicos.Location = new System.Drawing.Point(22, 246);
            this.DgvMedicos.Name = "DgvMedicos";
            this.DgvMedicos.Size = new System.Drawing.Size(957, 192);
            this.DgvMedicos.TabIndex = 13;
            this.DgvMedicos.Text = "dataGridView1";
            // 
            // Medicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1005, 450);
            this.Controls.Add(this.DgvMedicos);
            this.Controls.Add(this.CbIdEspecialidade);
            this.Controls.Add(this.LblCpf);
            this.Controls.Add(this.CbGenero);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.LblSenha);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.LblLogin);
            this.Controls.Add(this.TxtLogin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LblDataNascimento);
            this.Controls.Add(this.TxtDataNascimento);
            this.Controls.Add(this.LblRg);
            this.Controls.Add(this.TxtRg);
            this.Controls.Add(this.TxtCpf);
            this.Controls.Add(this.BtnAjuda);
            this.Controls.Add(this.LblCrm);
            this.Controls.Add(this.TxtCrm);
            this.Controls.Add(this.LblMedico);
            this.Controls.Add(this.LblEspecialidade);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.TxtIdMedico);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblMedicos);
            this.Controls.Add(this.BtnCriar);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.BtnDeletar);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.BtnMenu);
            this.Name = "Medicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicos";
            ((System.ComponentModel.ISupportInitialize)(this.DgvMedicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.Button BtnDeletar;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnCriar;
        private System.Windows.Forms.Label LblMedicos;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtIdMedico;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblEspecialidade;
        private System.Windows.Forms.Label LblMedico;
        private System.Windows.Forms.TextBox TxtCrm;
        private System.Windows.Forms.Label LblCrm;
        private System.Windows.Forms.Button BtnAjuda;
        private System.Windows.Forms.TextBox TxtCpf;
        private System.Windows.Forms.TextBox TxtRg;
        private System.Windows.Forms.Label LblRg;
        private System.Windows.Forms.TextBox TxtDataNascimento;
        private System.Windows.Forms.Label LblDataNascimento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Label LblSenha;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.ComboBox CbGenero;
        private System.Windows.Forms.Label LblCpf;
        private System.Windows.Forms.ComboBox CbIdEspecialidade;
        private System.Windows.Forms.DataGridView DgvMedicos;
    }
}