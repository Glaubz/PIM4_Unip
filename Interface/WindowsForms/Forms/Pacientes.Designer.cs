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
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnCriar = new System.Windows.Forms.Button();
            this.BtnMenu = new System.Windows.Forms.Button();
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
            this.DgvPacientes.Location = new System.Drawing.Point(21, 177);
            this.DgvPacientes.Name = "DgvPacientes";
            this.DgvPacientes.Size = new System.Drawing.Size(756, 251);
            this.DgvPacientes.TabIndex = 1;
            this.DgvPacientes.Text = "dataGridView1";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNome.Location = new System.Drawing.Point(21, 52);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(52, 23);
            this.LblNome.TabIndex = 2;
            this.LblNome.Text = "Nome";
            // 
            // LblRG
            // 
            this.LblRG.AutoSize = true;
            this.LblRG.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblRG.Location = new System.Drawing.Point(21, 88);
            this.LblRG.Name = "LblRG";
            this.LblRG.Size = new System.Drawing.Size(33, 23);
            this.LblRG.TabIndex = 2;
            this.LblRG.Text = "RG";
            // 
            // LblCpf
            // 
            this.LblCpf.AutoSize = true;
            this.LblCpf.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCpf.Location = new System.Drawing.Point(413, 88);
            this.LblCpf.Name = "LblCpf";
            this.LblCpf.Size = new System.Drawing.Size(41, 23);
            this.LblCpf.TabIndex = 2;
            this.LblCpf.Text = "CPF";
            // 
            // LblDataNascimento
            // 
            this.LblDataNascimento.AutoSize = true;
            this.LblDataNascimento.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDataNascimento.Location = new System.Drawing.Point(21, 126);
            this.LblDataNascimento.Name = "LblDataNascimento";
            this.LblDataNascimento.Size = new System.Drawing.Size(150, 23);
            this.LblDataNascimento.TabIndex = 2;
            this.LblDataNascimento.Text = "Data de Nascimento";
            // 
            // LblGenero
            // 
            this.LblGenero.AutoSize = true;
            this.LblGenero.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblGenero.Location = new System.Drawing.Point(519, 126);
            this.LblGenero.Name = "LblGenero";
            this.LblGenero.Size = new System.Drawing.Size(63, 23);
            this.LblGenero.TabIndex = 2;
            this.LblGenero.Text = "Gênero";
            // 
            // CbGenero
            // 
            this.CbGenero.FormattingEnabled = true;
            this.CbGenero.Location = new System.Drawing.Point(602, 126);
            this.CbGenero.Name = "CbGenero";
            this.CbGenero.Size = new System.Drawing.Size(175, 23);
            this.CbGenero.TabIndex = 3;
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(90, 52);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(687, 23);
            this.TxtNome.TabIndex = 4;
            // 
            // TxtRg
            // 
            this.TxtRg.Location = new System.Drawing.Point(90, 88);
            this.TxtRg.Name = "TxtRg";
            this.TxtRg.Size = new System.Drawing.Size(306, 23);
            this.TxtRg.TabIndex = 5;
            // 
            // TxtCpf
            // 
            this.TxtCpf.Location = new System.Drawing.Point(471, 88);
            this.TxtCpf.Name = "TxtCpf";
            this.TxtCpf.Size = new System.Drawing.Size(306, 23);
            this.TxtCpf.TabIndex = 5;
            // 
            // TxtDataNascimento
            // 
            this.TxtDataNascimento.Location = new System.Drawing.Point(187, 126);
            this.TxtDataNascimento.Name = "TxtDataNascimento";
            this.TxtDataNascimento.Size = new System.Drawing.Size(306, 23);
            this.TxtDataNascimento.TabIndex = 6;
            // 
            // BtnOK
            // 
            this.BtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnOK.Location = new System.Drawing.Point(579, 12);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 3;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
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
            // 
            // BtnFechar
            // 
            this.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFechar.Location = new System.Drawing.Point(370, 12);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(75, 23);
            this.BtnFechar.TabIndex = 2;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
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
            // 
            // BtnMenu
            // 
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMenu.Location = new System.Drawing.Point(702, 11);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(75, 23);
            this.BtnMenu.TabIndex = 7;
            this.BtnMenu.Text = "Menu";
            this.BtnMenu.UseVisualStyleBackColor = true;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.BtnCriar);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.TxtDataNascimento);
            this.Controls.Add(this.TxtCpf);
            this.Controls.Add(this.TxtRg);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.CbGenero);
            this.Controls.Add(this.LblGenero);
            this.Controls.Add(this.LblDataNascimento);
            this.Controls.Add(this.LblCpf);
            this.Controls.Add(this.LblRG);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.DgvPacientes);
            this.Controls.Add(this.LblPacientes);
            this.Name = "Pacientes";
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
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnCriar;
        private System.Windows.Forms.Button BtnMenu;
    }
}