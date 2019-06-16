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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.bVoltar = new System.Windows.Forms.Button();
            this.bSalvar = new System.Windows.Forms.Button();
            this.bLimpar = new System.Windows.Forms.Button();
            this.cmbNomedeGuerra = new System.Windows.Forms.ComboBox();
            this.dtpSaida = new System.Windows.Forms.DateTimePicker();
            this.dtpVolta = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(27, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome de Guerra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "GERENCIAR MILITAR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(27, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Motivo da Saída:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(27, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Horário Saída:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(27, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Horário Volta:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(327, 55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 338);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(214, 132);
            this.txtMotivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(217, 22);
            this.txtMotivo.TabIndex = 9;
            // 
            // bVoltar
            // 
            this.bVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bVoltar.Location = new System.Drawing.Point(279, 308);
            this.bVoltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bVoltar.Name = "bVoltar";
            this.bVoltar.Size = new System.Drawing.Size(87, 39);
            this.bVoltar.TabIndex = 17;
            this.bVoltar.Text = "Voltar";
            this.bVoltar.UseVisualStyleBackColor = true;
            this.bVoltar.Click += new System.EventHandler(this.BVoltar_Click);
            // 
            // bSalvar
            // 
            this.bSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSalvar.Location = new System.Drawing.Point(35, 308);
            this.bSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bSalvar.Name = "bSalvar";
            this.bSalvar.Size = new System.Drawing.Size(87, 39);
            this.bSalvar.TabIndex = 18;
            this.bSalvar.Text = "Salvar";
            this.bSalvar.UseVisualStyleBackColor = true;
            this.bSalvar.Click += new System.EventHandler(this.BSalvar);
            // 
            // bLimpar
            // 
            this.bLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bLimpar.Location = new System.Drawing.Point(159, 308);
            this.bLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bLimpar.Name = "bLimpar";
            this.bLimpar.Size = new System.Drawing.Size(87, 39);
            this.bLimpar.TabIndex = 22;
            this.bLimpar.Text = "Limpar";
            this.bLimpar.UseVisualStyleBackColor = true;
            this.bLimpar.Click += new System.EventHandler(this.BLimpar_Click);
            // 
            // cmbNomedeGuerra
            // 
            this.cmbNomedeGuerra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNomedeGuerra.FormattingEnabled = true;
            this.cmbNomedeGuerra.Location = new System.Drawing.Point(214, 69);
            this.cmbNomedeGuerra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbNomedeGuerra.Name = "cmbNomedeGuerra";
            this.cmbNomedeGuerra.Size = new System.Drawing.Size(217, 24);
            this.cmbNomedeGuerra.TabIndex = 23;
            // 
            // dtpSaida
            // 
            this.dtpSaida.CustomFormat = "HH:mm";
            this.dtpSaida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSaida.Location = new System.Drawing.Point(214, 190);
            this.dtpSaida.Margin = new System.Windows.Forms.Padding(4);
            this.dtpSaida.Name = "dtpSaida";
            this.dtpSaida.Size = new System.Drawing.Size(217, 22);
            this.dtpSaida.TabIndex = 24;
            this.dtpSaida.ValueChanged += new System.EventHandler(this.dtpSaida_ValueChanged);
            // 
            // dtpVolta
            // 
            this.dtpVolta.CustomFormat = "HH:mm";
            this.dtpVolta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVolta.Location = new System.Drawing.Point(214, 252);
            this.dtpVolta.Margin = new System.Windows.Forms.Padding(4);
            this.dtpVolta.Name = "dtpVolta";
            this.dtpVolta.Size = new System.Drawing.Size(217, 22);
            this.dtpVolta.TabIndex = 24;
            // 
            // frmGerenciarMilitar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 428);
            this.Controls.Add(this.dtpVolta);
            this.Controls.Add(this.dtpSaida);
            this.Controls.Add(this.cmbNomedeGuerra);
            this.Controls.Add(this.bLimpar);
            this.Controls.Add(this.bSalvar);
            this.Controls.Add(this.bVoltar);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Button bVoltar;
        private System.Windows.Forms.Button bSalvar;
        private System.Windows.Forms.Button bLimpar;
        private System.Windows.Forms.ComboBox cmbNomedeGuerra;
        private System.Windows.Forms.DateTimePicker dtpSaida;
        private System.Windows.Forms.DateTimePicker dtpVolta;
    }
}