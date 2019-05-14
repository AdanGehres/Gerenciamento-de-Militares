namespace Sistema_de_Gerênciamento_de_Militares
{
    partial class frmGerenciarMilitar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarMilitar));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.txtVolta = new System.Windows.Forms.TextBox();
            this.txtSaida = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.cmbNomedeGuerra = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(26, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome de Guerra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "GERENCIAR MILITAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(26, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(26, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Motivo da Saída:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(26, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Horário Saída:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(26, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Horário Volta:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(327, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 338);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(149, 164);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(217, 22);
            this.txtMotivo.TabIndex = 9;
            // 
            // txtVolta
            // 
            this.txtVolta.Location = new System.Drawing.Point(149, 252);
            this.txtVolta.Name = "txtVolta";
            this.txtVolta.Size = new System.Drawing.Size(217, 22);
            this.txtVolta.TabIndex = 15;
            // 
            // txtSaida
            // 
            this.txtSaida.Location = new System.Drawing.Point(149, 205);
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.Size = new System.Drawing.Size(217, 22);
            this.txtSaida.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(279, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 40);
            this.button1.TabIndex = 17;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(35, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 40);
            this.button2.TabIndex = 18;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(149, 116);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(217, 22);
            this.txtData.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(159, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 40);
            this.button3.TabIndex = 22;
            this.button3.Text = "Limpar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmbNomedeGuerra
            // 
            this.cmbNomedeGuerra.FormattingEnabled = true;
            this.cmbNomedeGuerra.Location = new System.Drawing.Point(149, 75);
            this.cmbNomedeGuerra.Name = "cmbNomedeGuerra";
            this.cmbNomedeGuerra.Size = new System.Drawing.Size(217, 24);
            this.cmbNomedeGuerra.TabIndex = 23;
            this.cmbNomedeGuerra.SelectedIndexChanged += new System.EventHandler(this.cmbNomedeGuerra_SelectedIndexChanged);
            // 
            // frmGerenciarMilitar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 428);
            this.Controls.Add(this.cmbNomedeGuerra);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSaida);
            this.Controls.Add(this.txtVolta);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGerenciarMilitar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gerenciamento de Militares";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.TextBox txtVolta;
        private System.Windows.Forms.TextBox txtSaida;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cmbNomedeGuerra;
    }
}