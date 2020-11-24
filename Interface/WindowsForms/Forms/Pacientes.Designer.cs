namespace WindowsForms.Forms
{
    partial class Pacientes
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
            this.LblPacientes = new System.Windows.Forms.Label();
            this.DgvPacientes = new System.Windows.Forms.DataGridView();
            this.LblNome = new System.Windows.Forms.Label();
            this.LblRG = new System.Windows.Forms.Label();
            this.LblCpf = new System.Windows.Forms.Label();
            this.LblDataNascimento = new System.Windows.Forms.Label();
            this.LblGenero = new System.Windows.Forms.Label();
            this.CbGenero = new System.Windows.Forms.ComboBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtRg = new System.Windows.Forms.TextBox();
            this.TxtCpf = new System.Windows.Forms.TextBox();
            this.TxtDataNascimento = new System.Windows.Forms.TextBox();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.BtnDeletar = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnCriar = new System.Windows.Forms.Button();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblSenha = new System.Windows.Forms.Label();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.LblLogin = new System.Windows.Forms.Label();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.TxtNumConvenio = new System.Windows.Forms.TextBox();
            this.LblNumConvenio = new System.Windows.Forms.Label();
            this.LblIdPaciente = new System.Windows.Forms.Label();
            this.TxtIdPaciente = new System.Windows.Forms.TextBox();
            this.BtnAjuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // LblPacientes
            // 
            this.LblPacientes.AutoSize = true;
            this.LblPacientes.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPacientes.Location = new System.Drawing.Point(21, 9);
            this.LblPacientes.Name = "LblPacientes";
            this.LblPacientes.Size = new System.Drawing.Size(117, 27);
            this.LblPacientes.TabIndex = 0;
            this.LblPacientes.Text = "Pacientes";
            // 
            // DgvPacientes
            // 
            this.DgvPacientes.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.DgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPacientes.Location = new System.Drawing.Point(21, 256);
            this.DgvPacientes.Name = "DgvPacientes";
            this.DgvPacientes.Size = new System.Drawing.Size(756, 172);
            this.DgvPacientes.TabIndex = 1;
            this.DgvPacientes.Text = "dataGridView1";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNome.Location = new System.Drawing.Point(230, 55);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(45, 20);
            this.LblNome.TabIndex = 2;
            this.LblNome.Text = "Nome";
            // 
            // LblRG
            // 
            this.LblRG.AutoSize = true;
            this.LblRG.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblRG.Location = new System.Drawing.Point(21, 133);
            this.LblRG.Name = "LblRG";
            this.LblRG.Size = new System.Drawing.Size(28, 20);
            this.LblRG.TabIndex = 2;
            this.LblRG.Text = "RG";
            // 
            // LblCpf
            // 
            this.LblCpf.AutoSize = true;
            this.LblCpf.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCpf.Location = new System.Drawing.Point(21, 169);
            this.LblCpf.Name = "LblCpf";
            this.LblCpf.Size = new System.Drawing.Size(35, 20);
            this.LblCpf.TabIndex = 2;
            this.LblCpf.Text = "CPF";
            // 
            // LblDataNascimento
            // 
            this.LblDataNascimento.AutoSize = true;
            this.LblDataNascimento.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDataNascimento.Location = new System.Drawing.Point(21, 205);
            this.LblDataNascimento.Name = "LblDataNascimento";
            this.LblDataNascimento.Size = new System.Drawing.Size(129, 20);
            this.LblDataNascimento.TabIndex = 2;
            this.LblDataNascimento.Text = "Data de Nascimento";
            // 
            // LblGenero
            // 
            this.LblGenero.AutoSize = true;
            this.LblGenero.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblGenero.Location = new System.Drawing.Point(519, 205);
            this.LblGenero.Name = "LblGenero";
            this.LblGenero.Size = new System.Drawing.Size(54, 20);
            this.LblGenero.TabIndex = 2;
            this.LblGenero.Text = "Gênero";
            // 
            // CbGenero
            // 
            this.CbGenero.FormattingEnabled = true;
            this.CbGenero.Items.AddRange(new object[] {
            "M",
            "F"});
            this.CbGenero.Location = new System.Drawing.Point(602, 205);
            this.CbGenero.Name = "CbGenero";
            this.CbGenero.Size = new System.Drawing.Size(175, 23);
            this.CbGenero.TabIndex = 3;
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(281, 52);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(496, 23);
            this.TxtNome.TabIndex = 4;
            // 
            // TxtRg
            // 
            this.TxtRg.Location = new System.Drawing.Point(90, 133);
            this.TxtRg.Name = "TxtRg";
            this.TxtRg.Size = new System.Drawing.Size(306, 23);
            this.TxtRg.TabIndex = 5;
            // 
            // TxtCpf
            // 
            this.TxtCpf.Location = new System.Drawing.Point(90, 169);
            this.TxtCpf.Name = "TxtCpf";
            this.TxtCpf.Size = new System.Drawing.Size(306, 23);
            this.TxtCpf.TabIndex = 5;
            // 
            // TxtDataNascimento
            // 
            this.TxtDataNascimento.Location = new System.Drawing.Point(187, 205);
            this.TxtDataNascimento.Name = "TxtDataNascimento";
            this.TxtDataNascimento.Size = new System.Drawing.Size(306, 23);
            this.TxtDataNascimento.TabIndex = 6;
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAtualizar.Location = new System.Drawing.Point(474, 12);
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
            this.BtnDeletar.Location = new System.Drawing.Point(370, 12);
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
            this.BtnConsultar.Location = new System.Drawing.Point(264, 12);
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
            this.BtnCriar.Location = new System.Drawing.Point(155, 12);
            this.BtnCriar.Name = "BtnCriar";
            this.BtnCriar.Size = new System.Drawing.Size(75, 23);
            this.BtnCriar.TabIndex = 2;
            this.BtnCriar.Text = "Criar";
            this.BtnCriar.UseVisualStyleBackColor = true;
            this.BtnCriar.Click += new System.EventHandler(this.BtnCriar_Click);
            // 
            // BtnMenu
            // 
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMenu.Location = new System.Drawing.Point(702, 12);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(75, 23);
            this.BtnMenu.TabIndex = 7;
            this.BtnMenu.Text = "Menu";
            this.BtnMenu.UseVisualStyleBackColor = true;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblEmail.Location = new System.Drawing.Point(413, 172);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(42, 20);
            this.LblEmail.TabIndex = 4;
            this.LblEmail.Text = "Email";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(471, 169);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(306, 23);
            this.TxtEmail.TabIndex = 6;
            // 
            // LblSenha
            // 
            this.LblSenha.AutoSize = true;
            this.LblSenha.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSenha.Location = new System.Drawing.Point(413, 136);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(47, 20);
            this.LblSenha.TabIndex = 4;
            this.LblSenha.Text = "Senha";
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(471, 134);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(306, 23);
            this.TxtSenha.TabIndex = 6;
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblLogin.Location = new System.Drawing.Point(413, 99);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(42, 20);
            this.LblLogin.TabIndex = 4;
            this.LblLogin.Text = "Login";
            // 
            // TxtLogin
            // 
            this.TxtLogin.Location = new System.Drawing.Point(471, 97);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(306, 23);
            this.TxtLogin.TabIndex = 6;
            // 
            // TxtNumConvenio
            // 
            this.TxtNumConvenio.Location = new System.Drawing.Point(111, 96);
            this.TxtNumConvenio.Name = "TxtNumConvenio";
            this.TxtNumConvenio.Size = new System.Drawing.Size(285, 23);
            this.TxtNumConvenio.TabIndex = 4;
            // 
            // LblNumConvenio
            // 
            this.LblNumConvenio.AutoSize = true;
            this.LblNumConvenio.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNumConvenio.Location = new System.Drawing.Point(21, 99);
            this.LblNumConvenio.Name = "LblNumConvenio";
            this.LblNumConvenio.Size = new System.Drawing.Size(84, 20);
            this.LblNumConvenio.TabIndex = 2;
            this.LblNumConvenio.Text = "Nº Convênio";
            // 
            // LblIdPaciente
            // 
            this.LblIdPaciente.AutoSize = true;
            this.LblIdPaciente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblIdPaciente.Location = new System.Drawing.Point(21, 55);
            this.LblIdPaciente.Name = "LblIdPaciente";
            this.LblIdPaciente.Size = new System.Drawing.Size(77, 20);
            this.LblIdPaciente.TabIndex = 2;
            this.LblIdPaciente.Text = "ID Paciente";
            // 
            // TxtIdPaciente
            // 
            this.TxtIdPaciente.Location = new System.Drawing.Point(111, 52);
            this.TxtIdPaciente.Name = "TxtIdPaciente";
            this.TxtIdPaciente.Size = new System.Drawing.Size(100, 23);
            this.TxtIdPaciente.TabIndex = 8;
            // 
            // BtnAjuda
            // 
            this.BtnAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAjuda.Location = new System.Drawing.Point(589, 12);
            this.BtnAjuda.Name = "BtnAjuda";
            this.BtnAjuda.Size = new System.Drawing.Size(75, 23);
            this.BtnAjuda.TabIndex = 2;
            this.BtnAjuda.Text = "Ajuda";
            this.BtnAjuda.UseVisualStyleBackColor = true;
            this.BtnAjuda.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAjuda);
            this.Controls.Add(this.TxtIdPaciente);
            this.Controls.Add(this.LblIdPaciente);
            this.Controls.Add(this.LblNumConvenio);
            this.Controls.Add(this.TxtNumConvenio);
            this.Controls.Add(this.TxtLogin);
            this.Controls.Add(this.LblLogin);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.LblSenha);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.BtnCriar);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.BtnDeletar);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.TxtDataNascimento);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.TxtRg);
            this.Controls.Add(this.TxtCpf);
            this.Controls.Add(this.CbGenero);
            this.Controls.Add(this.LblGenero);
            this.Controls.Add(this.LblDataNascimento);
            this.Controls.Add(this.LblCpf);
            this.Controls.Add(this.LblRG);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.DgvPacientes);
            this.Controls.Add(this.LblPacientes);
            this.Name = "Pacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacientes";
            ((System.ComponentModel.ISupportInitialize)(this.DgvPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPacientes;
        private System.Windows.Forms.DataGridView DgvPacientes;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblRG;
        private System.Windows.Forms.Label LblCpf;
        private System.Windows.Forms.Label LblDataNascimento;
        private System.Windows.Forms.Label LblGenero;
        private System.Windows.Forms.ComboBox CbGenero;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtRg;
        private System.Windows.Forms.TextBox TxtCpf;
        private System.Windows.Forms.TextBox TxtDataNascimento;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.Button BtnDeletar;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnCriar;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblSenha;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.TextBox TxtNumConvenio;
        private System.Windows.Forms.Label LblNumConvenio;
        private System.Windows.Forms.Label LblIdPaciente;
        private System.Windows.Forms.TextBox TxtIdPaciente;
        private System.Windows.Forms.Button BtnAjuda;
    }
}