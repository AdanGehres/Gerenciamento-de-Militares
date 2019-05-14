namespace Sistema_de_Gerênciamento_de_Militares
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbUsuarioLogin = new System.Windows.Forms.TextBox();
            this.txtbSenhaLogin = new System.Windows.Forms.TextBox();
            this.btnEntrarLogin = new System.Windows.Forms.Button();
            this.btnSairLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(182, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(182, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(17, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(424, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sistema de Gerênciamento de Militares";
            // 
            // txtbUsuarioLogin
            // 
            this.txtbUsuarioLogin.Location = new System.Drawing.Point(256, 76);
            this.txtbUsuarioLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbUsuarioLogin.Name = "txtbUsuarioLogin";
            this.txtbUsuarioLogin.Size = new System.Drawing.Size(142, 20);
            this.txtbUsuarioLogin.TabIndex = 3;
            // 
            // txtbSenhaLogin
            // 
            this.txtbSenhaLogin.Location = new System.Drawing.Point(256, 132);
            this.txtbSenhaLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbSenhaLogin.Name = "txtbSenhaLogin";
            this.txtbSenhaLogin.PasswordChar = '*';
            this.txtbSenhaLogin.Size = new System.Drawing.Size(142, 20);
            this.txtbSenhaLogin.TabIndex = 4;
            // 
            // btnEntrarLogin
            // 
            this.btnEntrarLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrarLogin.Location = new System.Drawing.Point(248, 190);
            this.btnEntrarLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEntrarLogin.Name = "btnEntrarLogin";
            this.btnEntrarLogin.Size = new System.Drawing.Size(65, 32);
            this.btnEntrarLogin.TabIndex = 5;
            this.btnEntrarLogin.Text = "Entrar";
            this.btnEntrarLogin.UseVisualStyleBackColor = true;
            this.btnEntrarLogin.Click += new System.EventHandler(this.btnEntrarLogin_Click);
            // 
            // btnSairLogin
            // 
            this.btnSairLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSairLogin.Location = new System.Drawing.Point(332, 190);
            this.btnSairLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSairLogin.Name = "btnSairLogin";
            this.btnSairLogin.Size = new System.Drawing.Size(65, 32);
            this.btnSairLogin.TabIndex = 7;
            this.btnSairLogin.Text = "Sair";
            this.btnSairLogin.UseVisualStyleBackColor = true;
            this.btnSairLogin.Click += new System.EventHandler(this.btnSairLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 43);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 275);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(260, 265);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 14);
            this.label4.TabIndex = 11;
            this.label4.Text = "Esqueceu a senha? ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(246, 278);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 14);
            this.label5.TabIndex = 12;
            this.label5.Text = "Contate o administrador.";
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnEntrarLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 348);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSairLogin);
            this.Controls.Add(this.btnEntrarLogin);
            this.Controls.Add(this.txtbSenhaLogin);
            this.Controls.Add(this.txtbUsuarioLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gerenciamento de Militares";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbUsuarioLogin;
        private System.Windows.Forms.TextBox txtbSenhaLogin;
        private System.Windows.Forms.Button btnEntrarLogin;
        private System.Windows.Forms.Button btnSairLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

