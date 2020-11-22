namespace WindowsForms.Forms
{
    partial class Funcionarios
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
            this.BtnAjuda = new System.Windows.Forms.Button();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.BtnDeletar = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnCriar = new System.Windows.Forms.Button();
            this.LblFuncionarios = new System.Windows.Forms.Label();
            this.DgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtIdFuncionario = new System.Windows.Forms.TextBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.LblIdCargo = new System.Windows.Forms.Label();
            this.LblIdFuncionario = new System.Windows.Forms.Label();
            this.TxtSalario = new System.Windows.Forms.TextBox();
            this.LblSalario = new System.Windows.Forms.Label();
            this.LblTerceirizado = new System.Windows.Forms.Label();
            this.TxtCpf = new System.Windows.Forms.TextBox();
            this.LblCpf = new System.Windows.Forms.Label();
            this.TxtRg = new System.Windows.Forms.TextBox();
            this.LblRg = new System.Windows.Forms.Label();
            this.TxtDataNascimento = new System.Windows.Forms.TextBox();
            this.LblDataNascimento = new System.Windows.Forms.Label();
            this.LblGenero = new System.Windows.Forms.Label();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.LblLogin = new System.Windows.Forms.Label();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.LblSenha = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.CbGenero = new System.Windows.Forms.ComboBox();
            this.CbTerceirizado = new System.Windows.Forms.ComboBox();
            this.CbIdCargo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnMenu
            // 
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMenu.Location = new System.Drawing.Point(909, 14);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(75, 23);
            this.BtnMenu.TabIndex = 7;
            this.BtnMenu.Text = "Menu";
            this.BtnMenu.UseVisualStyleBackColor = true;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // BtnAjuda
            // 
            this.BtnAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAjuda.Location = new System.Drawing.Point(764, 14);
            this.BtnAjuda.Name = "BtnAjuda";
            this.BtnAjuda.Size = new System.Drawing.Size(75, 23);
            this.BtnAjuda.TabIndex = 3;
            this.BtnAjuda.Text = "Ajuda";
            this.BtnAjuda.UseVisualStyleBackColor = true;
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAtualizar.Location = new System.Drawing.Point(494, 14);
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
            this.BtnDeletar.Location = new System.Drawing.Point(390, 14);
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
            this.BtnConsultar.Location = new System.Drawing.Point(284, 14);
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
            this.BtnCriar.Location = new System.Drawing.Point(175, 14);
            this.BtnCriar.Name = "BtnCriar";
            this.BtnCriar.Size = new System.Drawing.Size(75, 23);
            this.BtnCriar.TabIndex = 2;
            this.BtnCriar.Text = "Criar";
            this.BtnCriar.UseVisualStyleBackColor = true;
            this.BtnCriar.Click += new System.EventHandler(this.BtnCriar_Click);
            // 
            // LblFuncionarios
            // 
            this.LblFuncionarios.AutoSize = true;
            this.LblFuncionarios.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblFuncionarios.Location = new System.Drawing.Point(12, 9);
            this.LblFuncionarios.Name = "LblFuncionarios";
            this.LblFuncionarios.Size = new System.Drawing.Size(148, 27);
            this.LblFuncionarios.TabIndex = 1;
            this.LblFuncionarios.Text = "Funcionarios";
            // 
            // DgvFuncionarios
            // 
            this.DgvFuncionarios.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.DgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFuncionarios.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.DgvFuncionarios.Location = new System.Drawing.Point(27, 241);
            this.DgvFuncionarios.Name = "DgvFuncionarios";
            this.DgvFuncionarios.Size = new System.Drawing.Size(957, 186);
            this.DgvFuncionarios.TabIndex = 9;
            this.DgvFuncionarios.Text = "dataGridView1";
            this.DgvFuncionarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFuncionarios_CellContentClick);
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(413, 61);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(175, 23);
            this.TxtNome.TabIndex = 6;
            // 
            // TxtIdFuncionario
            // 
            this.TxtIdFuncionario.Location = new System.Drawing.Point(135, 61);
            this.TxtIdFuncionario.Name = "TxtIdFuncionario";
            this.TxtIdFuncionario.Size = new System.Drawing.Size(212, 23);
            this.TxtIdFuncionario.TabIndex = 6;
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNome.Location = new System.Drawing.Point(353, 62);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(45, 20);
            this.LblNome.TabIndex = 4;
            this.LblNome.Text = "Nome";
            // 
            // LblIdCargo
            // 
            this.LblIdCargo.AutoSize = true;
            this.LblIdCargo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblIdCargo.Location = new System.Drawing.Point(27, 109);
            this.LblIdCargo.Name = "LblIdCargo";
            this.LblIdCargo.Size = new System.Drawing.Size(61, 20);
            this.LblIdCargo.TabIndex = 4;
            this.LblIdCargo.Text = "ID Cargo";
            // 
            // LblIdFuncionario
            // 
            this.LblIdFuncionario.AutoSize = true;
            this.LblIdFuncionario.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblIdFuncionario.Location = new System.Drawing.Point(27, 60);
            this.LblIdFuncionario.Name = "LblIdFuncionario";
            this.LblIdFuncionario.Size = new System.Drawing.Size(94, 20);
            this.LblIdFuncionario.TabIndex = 4;
            this.LblIdFuncionario.Text = "ID Funcionario";
            // 
            // TxtSalario
            // 
            this.TxtSalario.Location = new System.Drawing.Point(135, 148);
            this.TxtSalario.Name = "TxtSalario";
            this.TxtSalario.Size = new System.Drawing.Size(212, 23);
            this.TxtSalario.TabIndex = 6;
            // 
            // LblSalario
            // 
            this.LblSalario.AutoSize = true;
            this.LblSalario.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSalario.Location = new System.Drawing.Point(27, 148);
            this.LblSalario.Name = "LblSalario";
            this.LblSalario.Size = new System.Drawing.Size(50, 20);
            this.LblSalario.TabIndex = 4;
            this.LblSalario.Text = "Salário";
            // 
            // LblTerceirizado
            // 
            this.LblTerceirizado.AutoSize = true;
            this.LblTerceirizado.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTerceirizado.Location = new System.Drawing.Point(27, 194);
            this.LblTerceirizado.Name = "LblTerceirizado";
            this.LblTerceirizado.Size = new System.Drawing.Size(83, 20);
            this.LblTerceirizado.TabIndex = 4;
            this.LblTerceirizado.Text = "Terceirizado";
            // 
            // TxtCpf
            // 
            this.TxtCpf.Location = new System.Drawing.Point(413, 106);
            this.TxtCpf.Name = "TxtCpf";
            this.TxtCpf.Size = new System.Drawing.Size(175, 23);
            this.TxtCpf.TabIndex = 6;
            // 
            // LblCpf
            // 
            this.LblCpf.AutoSize = true;
            this.LblCpf.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCpf.Location = new System.Drawing.Point(353, 107);
            this.LblCpf.Name = "LblCpf";
            this.LblCpf.Size = new System.Drawing.Size(35, 20);
            this.LblCpf.TabIndex = 4;
            this.LblCpf.Text = "CPF";
            // 
            // TxtRg
            // 
            this.TxtRg.Location = new System.Drawing.Point(413, 151);
            this.TxtRg.Name = "TxtRg";
            this.TxtRg.Size = new System.Drawing.Size(175, 23);
            this.TxtRg.TabIndex = 6;
            // 
            // LblRg
            // 
            this.LblRg.AutoSize = true;
            this.LblRg.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblRg.Location = new System.Drawing.Point(353, 146);
            this.LblRg.Name = "LblRg";
            this.LblRg.Size = new System.Drawing.Size(28, 20);
            this.LblRg.TabIndex = 4;
            this.LblRg.Text = "RG";
            // 
            // TxtDataNascimento
            // 
            this.TxtDataNascimento.Location = new System.Drawing.Point(728, 197);
            this.TxtDataNascimento.Name = "TxtDataNascimento";
            this.TxtDataNascimento.Size = new System.Drawing.Size(245, 23);
            this.TxtDataNascimento.TabIndex = 6;
            // 
            // LblDataNascimento
            // 
            this.LblDataNascimento.AutoSize = true;
            this.LblDataNascimento.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDataNascimento.Location = new System.Drawing.Point(594, 197);
            this.LblDataNascimento.Name = "LblDataNascimento";
            this.LblDataNascimento.Size = new System.Drawing.Size(129, 20);
            this.LblDataNascimento.TabIndex = 4;
            this.LblDataNascimento.Text = "Data de Nascimento";
            // 
            // LblGenero
            // 
            this.LblGenero.AutoSize = true;
            this.LblGenero.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblGenero.Location = new System.Drawing.Point(353, 192);
            this.LblGenero.Name = "LblGenero";
            this.LblGenero.Size = new System.Drawing.Size(54, 20);
            this.LblGenero.TabIndex = 4;
            this.LblGenero.Text = "Gênero";
            // 
            // TxtLogin
            // 
            this.TxtLogin.Location = new System.Drawing.Point(728, 61);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(245, 23);
            this.TxtLogin.TabIndex = 6;
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblLogin.Location = new System.Drawing.Point(594, 61);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(42, 20);
            this.LblLogin.TabIndex = 4;
            this.LblLogin.Text = "Login";
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(728, 106);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(245, 23);
            this.TxtSenha.TabIndex = 6;
            // 
            // LblSenha
            // 
            this.LblSenha.AutoSize = true;
            this.LblSenha.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSenha.Location = new System.Drawing.Point(594, 106);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(47, 20);
            this.LblSenha.TabIndex = 4;
            this.LblSenha.Text = "Senha";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(728, 150);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(245, 23);
            this.TxtEmail.TabIndex = 6;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblEmail.Location = new System.Drawing.Point(594, 150);
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
            this.CbGenero.Location = new System.Drawing.Point(413, 194);
            this.CbGenero.Name = "CbGenero";
            this.CbGenero.Size = new System.Drawing.Size(175, 23);
            this.CbGenero.TabIndex = 10;
            // 
            // CbTerceirizado
            // 
            this.CbTerceirizado.FormattingEnabled = true;
            this.CbTerceirizado.Items.AddRange(new object[] {
            "true",
            "false"});
            this.CbTerceirizado.Location = new System.Drawing.Point(135, 193);
            this.CbTerceirizado.Name = "CbTerceirizado";
            this.CbTerceirizado.Size = new System.Drawing.Size(212, 23);
            this.CbTerceirizado.TabIndex = 11;
            // 
            // CbIdCargo
            // 
            this.CbIdCargo.FormattingEnabled = true;
            this.CbIdCargo.Items.AddRange(new object[] {
            "1-Atendente",
            "2-Técnico em Enfermagem",
            "3-Técnico Administrativo",
            "Qualquer cargo"});
            this.CbIdCargo.Location = new System.Drawing.Point(135, 107);
            this.CbIdCargo.Name = "CbIdCargo";
            this.CbIdCargo.Size = new System.Drawing.Size(212, 23);
            this.CbIdCargo.TabIndex = 12;
            // 
            // Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1012, 450);
            this.Controls.Add(this.CbIdCargo);
            this.Controls.Add(this.CbTerceirizado);
            this.Controls.Add(this.CbGenero);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.LblSenha);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.LblLogin);
            this.Controls.Add(this.TxtLogin);
            this.Controls.Add(this.LblGenero);
            this.Controls.Add(this.LblDataNascimento);
            this.Controls.Add(this.TxtDataNascimento);
            this.Controls.Add(this.LblRg);
            this.Controls.Add(this.TxtRg);
            this.Controls.Add(this.LblCpf);
            this.Controls.Add(this.TxtCpf);
            this.Controls.Add(this.LblTerceirizado);
            this.Controls.Add(this.LblSalario);
            this.Controls.Add(this.TxtSalario);
            this.Controls.Add(this.LblIdFuncionario);
            this.Controls.Add(this.LblIdCargo);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.TxtIdFuncionario);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.DgvFuncionarios);
            this.Controls.Add(this.LblFuncionarios);
            this.Controls.Add(this.BtnCriar);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.BtnDeletar);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.BtnAjuda);
            this.Controls.Add(this.BtnMenu);
            this.Name = "Funcionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionarios";
            ((System.ComponentModel.ISupportInitialize)(this.DgvFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Button BtnAjuda;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.Button BtnDeletar;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnCriar;
        private System.Windows.Forms.Label LblFuncionarios;
        private System.Windows.Forms.DataGridView DgvFuncionarios;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtIdFuncionario;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblIdCargo;
        private System.Windows.Forms.Label LblIdFuncionario;
        private System.Windows.Forms.TextBox TxtSalario;
        private System.Windows.Forms.Label LblSalario;
        private System.Windows.Forms.Label LblTerceirizado;
        private System.Windows.Forms.TextBox TxtCpf;
        private System.Windows.Forms.Label LblCpf;
        private System.Windows.Forms.TextBox TxtRg;
        private System.Windows.Forms.Label LblRg;
        private System.Windows.Forms.TextBox TxtDataNascimento;
        private System.Windows.Forms.Label LblDataNascimento;
        private System.Windows.Forms.Label LblGenero;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Label LblSenha;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.ComboBox CbGenero;
        private System.Windows.Forms.ComboBox CbTerceirizado;
        private System.Windows.Forms.ComboBox CbIdCargo;
    }
}