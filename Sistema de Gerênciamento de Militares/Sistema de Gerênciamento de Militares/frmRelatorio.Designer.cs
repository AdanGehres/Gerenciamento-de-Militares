namespace Sistema_de_Gerênciamento_de_Militares
{
    partial class frmRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorio));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btRelatorioSemanal = new System.Windows.Forms.Button();
            this.btRelatorioMensal = new System.Windows.Forms.Button();
            this.btRelatorioAnual = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(326, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 338);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btRelatorioSemanal
            // 
            this.btRelatorioSemanal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRelatorioSemanal.Location = new System.Drawing.Point(52, 46);
            this.btRelatorioSemanal.Name = "btRelatorioSemanal";
            this.btRelatorioSemanal.Size = new System.Drawing.Size(144, 67);
            this.btRelatorioSemanal.TabIndex = 11;
            this.btRelatorioSemanal.Text = "Relatório Semanal";
            this.btRelatorioSemanal.UseVisualStyleBackColor = true;
            this.btRelatorioSemanal.Click += new System.EventHandler(this.button1_Click);
            // 
            // btRelatorioMensal
            // 
            this.btRelatorioMensal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRelatorioMensal.Location = new System.Drawing.Point(52, 152);
            this.btRelatorioMensal.Name = "btRelatorioMensal";
            this.btRelatorioMensal.Size = new System.Drawing.Size(144, 67);
            this.btRelatorioMensal.TabIndex = 12;
            this.btRelatorioMensal.Text = "Relatório Mensal";
            this.btRelatorioMensal.UseVisualStyleBackColor = true;
            this.btRelatorioMensal.Click += new System.EventHandler(this.btRelatorioMensal_Click);
            // 
            // btRelatorioAnual
            // 
            this.btRelatorioAnual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRelatorioAnual.Location = new System.Drawing.Point(52, 258);
            this.btRelatorioAnual.Name = "btRelatorioAnual";
            this.btRelatorioAnual.Size = new System.Drawing.Size(144, 67);
            this.btRelatorioAnual.TabIndex = 13;
            this.btRelatorioAnual.Text = "Relatório Anual";
            this.btRelatorioAnual.UseVisualStyleBackColor = true;
            this.btRelatorioAnual.Click += new System.EventHandler(this.btRelatorioAnual_Click);
            // 
            // btVoltar
            // 
            this.btVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btVoltar.Location = new System.Drawing.Point(75, 363);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(87, 40);
            this.btVoltar.TabIndex = 14;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 428);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btRelatorioAnual);
            this.Controls.Add(this.btRelatorioMensal);
            this.Controls.Add(this.btRelatorioSemanal);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gerenciamento de Militares";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btRelatorioSemanal;
        private System.Windows.Forms.Button btRelatorioMensal;
        private System.Windows.Forms.Button btRelatorioAnual;
        private System.Windows.Forms.Button btVoltar;
    }
}