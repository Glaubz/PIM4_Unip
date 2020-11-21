namespace WindowsForms.Forms
{
    partial class Menu
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
            this.LblMenu = new System.Windows.Forms.Label();
            this.BtnConsultas = new System.Windows.Forms.Button();
            this.BtnPacientes = new System.Windows.Forms.Button();
            this.BtnMedicos = new System.Windows.Forms.Button();
            this.BtnRemedios = new System.Windows.Forms.Button();
            this.BtnFuncionarios = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblMenu
            // 
            this.LblMenu.AutoSize = true;
            this.LblMenu.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblMenu.Location = new System.Drawing.Point(369, 21);
            this.LblMenu.Name = "LblMenu";
            this.LblMenu.Size = new System.Drawing.Size(69, 27);
            this.LblMenu.TabIndex = 0;
            this.LblMenu.Text = "Menu";
            // 
            // BtnConsultas
            // 
            this.BtnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnConsultas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnConsultas.Location = new System.Drawing.Point(344, 77);
            this.BtnConsultas.Name = "BtnConsultas";
            this.BtnConsultas.Size = new System.Drawing.Size(119, 33);
            this.BtnConsultas.TabIndex = 1;
            this.BtnConsultas.Text = "Consultas";
            this.BtnConsultas.UseVisualStyleBackColor = true;
            this.BtnConsultas.Click += new System.EventHandler(this.BtnConsultas_Click);
            // 
            // BtnPacientes
            // 
            this.BtnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPacientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnPacientes.Location = new System.Drawing.Point(344, 140);
            this.BtnPacientes.Name = "BtnPacientes";
            this.BtnPacientes.Size = new System.Drawing.Size(119, 33);
            this.BtnPacientes.TabIndex = 1;
            this.BtnPacientes.Text = "Pacientes";
            this.BtnPacientes.UseVisualStyleBackColor = true;
            this.BtnPacientes.Click += new System.EventHandler(this.BtnPacientes_Click);
            // 
            // BtnMedicos
            // 
            this.BtnMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMedicos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnMedicos.Location = new System.Drawing.Point(344, 202);
            this.BtnMedicos.Name = "BtnMedicos";
            this.BtnMedicos.Size = new System.Drawing.Size(119, 33);
            this.BtnMedicos.TabIndex = 1;
            this.BtnMedicos.Text = "Medicos";
            this.BtnMedicos.UseVisualStyleBackColor = true;
            this.BtnMedicos.Click += new System.EventHandler(this.BtnMedicos_Click);
            // 
            // BtnRemedios
            // 
            this.BtnRemedios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRemedios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnRemedios.Location = new System.Drawing.Point(344, 266);
            this.BtnRemedios.Name = "BtnRemedios";
            this.BtnRemedios.Size = new System.Drawing.Size(119, 33);
            this.BtnRemedios.TabIndex = 1;
            this.BtnRemedios.Text = "Remédios";
            this.BtnRemedios.UseVisualStyleBackColor = true;
            this.BtnRemedios.Click += new System.EventHandler(this.BtnRemedios_Click);
            // 
            // BtnFuncionarios
            // 
            this.BtnFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFuncionarios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnFuncionarios.Location = new System.Drawing.Point(344, 329);
            this.BtnFuncionarios.Name = "BtnFuncionarios";
            this.BtnFuncionarios.Size = new System.Drawing.Size(119, 33);
            this.BtnFuncionarios.TabIndex = 1;
            this.BtnFuncionarios.Text = "Funcionários";
            this.BtnFuncionarios.UseVisualStyleBackColor = true;
            this.BtnFuncionarios.Click += new System.EventHandler(this.BtnFuncionarios_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSair.Location = new System.Drawing.Point(344, 391);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(119, 33);
            this.BtnSair.TabIndex = 2;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnFuncionarios);
            this.Controls.Add(this.BtnRemedios);
            this.Controls.Add(this.BtnMedicos);
            this.Controls.Add(this.BtnPacientes);
            this.Controls.Add(this.BtnConsultas);
            this.Controls.Add(this.LblMenu);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMenu;
        private System.Windows.Forms.Button BtnConsultas;
        private System.Windows.Forms.Button BtnPacientes;
        private System.Windows.Forms.Button BtnMedicos;
        private System.Windows.Forms.Button BtnRemedios;
        private System.Windows.Forms.Button BtnFuncionarios;
        private System.Windows.Forms.Button BtnSair;
    }
}