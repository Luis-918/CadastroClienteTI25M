namespace Form1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titulo_pagina = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.Consultar = new System.Windows.Forms.Button();
            this.Atualizar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titulo_pagina
            // 
            this.titulo_pagina.AutoSize = true;
            this.titulo_pagina.Cursor = System.Windows.Forms.Cursors.Default;
            this.titulo_pagina.Font = new System.Drawing.Font("Times New Roman", 26.25F);
            this.titulo_pagina.Location = new System.Drawing.Point(173, 25);
            this.titulo_pagina.Name = "titulo_pagina";
            this.titulo_pagina.Padding = new System.Windows.Forms.Padding(100, 0, 100, 0);
            this.titulo_pagina.Size = new System.Drawing.Size(483, 40);
            this.titulo_pagina.TabIndex = 0;
            this.titulo_pagina.Text = "Bem Vindo Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.25F);
            this.label1.Location = new System.Drawing.Point(257, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escolha uma das opções abaixo:";
            // 
            // Cadastrar
            // 
            this.Cadastrar.BackColor = System.Drawing.Color.Snow;
            this.Cadastrar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Cadastrar.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.Cadastrar.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Cadastrar.Location = new System.Drawing.Point(27, 225);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(367, 103);
            this.Cadastrar.TabIndex = 2;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = false;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // Consultar
            // 
            this.Consultar.BackColor = System.Drawing.Color.Snow;
            this.Consultar.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.Consultar.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Consultar.Location = new System.Drawing.Point(432, 225);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(367, 103);
            this.Consultar.TabIndex = 3;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseVisualStyleBackColor = false;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // Atualizar
            // 
            this.Atualizar.BackColor = System.Drawing.Color.Snow;
            this.Atualizar.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.Atualizar.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Atualizar.Location = new System.Drawing.Point(27, 369);
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.Size = new System.Drawing.Size(367, 103);
            this.Atualizar.TabIndex = 4;
            this.Atualizar.Text = "Atualizar";
            this.Atualizar.UseVisualStyleBackColor = false;
            this.Atualizar.Click += new System.EventHandler(this.Atualizar_Click);
            // 
            // Excluir
            // 
            this.Excluir.BackColor = System.Drawing.Color.Snow;
            this.Excluir.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.Excluir.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Excluir.Location = new System.Drawing.Point(432, 369);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(367, 103);
            this.Excluir.TabIndex = 5;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = false;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(811, 580);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Atualizar);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titulo_pagina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(827, 619);
            this.MinimumSize = new System.Drawing.Size(827, 619);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo_pagina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.Button Atualizar;
        private System.Windows.Forms.Button Excluir;
    }
}

