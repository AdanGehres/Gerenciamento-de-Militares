namespace Sistema_de_Gerênciamento_de_Militares
{
    partial class frmCadastrarMilitar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarMilitar));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.graduacao11 = new System.Windows.Forms.Label();
            this.rdGrad1 = new System.Windows.Forms.RadioButton();
            this.rdGrad2 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtGrad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "CADASTRAR MILITAR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(26, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome do Militar:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(157, 131);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(164, 22);
            this.txtNome.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(30, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 40);
            this.button2.TabIndex = 19;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(157, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 40);
            this.button1.TabIndex = 20;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // graduacao11
            // 
            this.graduacao11.AutoSize = true;
            this.graduacao11.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.graduacao11.Location = new System.Drawing.Point(26, 79);
            this.graduacao11.Name = "graduacao11";
            this.graduacao11.Size = new System.Drawing.Size(122, 20);
            this.graduacao11.TabIndex = 21;
            this.graduacao11.Text = "Graduação Militar:";
            // 
            // rdGrad1
            // 
            this.rdGrad1.AutoSize = true;
            this.rdGrad1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.rdGrad1.Location = new System.Drawing.Point(166, 75);
            this.rdGrad1.Name = "rdGrad1";
            this.rdGrad1.Size = new System.Drawing.Size(62, 24);
            this.rdGrad1.TabIndex = 22;
            this.rdGrad1.TabStop = true;
            this.rdGrad1.Text = "Cabo";
            this.rdGrad1.UseVisualStyleBackColor = true;
            // 
            // rdGrad2
            // 
            this.rdGrad2.AutoSize = true;
            this.rdGrad2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.rdGrad2.Location = new System.Drawing.Point(240, 75);
            this.rdGrad2.Name = "rdGrad2";
            this.rdGrad2.Size = new System.Drawing.Size(81, 24);
            this.rdGrad2.TabIndex = 23;
            this.rdGrad2.TabStop = true;
            this.rdGrad2.Text = "Soldado";
            this.rdGrad2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(327, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 338);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // txtGrad
            // 
            this.txtGrad.AutoSize = true;
            this.txtGrad.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.txtGrad.Location = new System.Drawing.Point(557, 396);
            this.txtGrad.Name = "txtGrad";
            this.txtGrad.Size = new System.Drawing.Size(0, 20);
            this.txtGrad.TabIndex = 24;
            this.txtGrad.Visible = false;
            // 
            // frmCadastrarMilitar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 428);
            this.Controls.Add(this.txtGrad);
            this.Controls.Add(this.rdGrad2);
            this.Controls.Add(this.rdGrad1);
            this.Controls.Add(this.graduacao11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmCadastrarMilitar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gerenciamento de Militares";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label graduacao11;
        private System.Windows.Forms.RadioButton rdGrad1;
        private System.Windows.Forms.RadioButton rdGrad2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtGrad;
    }
}