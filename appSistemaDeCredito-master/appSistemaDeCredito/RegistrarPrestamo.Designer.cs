namespace appSistemaDeCredito
{
    partial class RegistrarPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarPrestamo));
            this.btnPrestamo = new System.Windows.Forms.Button();
            this.cbxPreCuotas = new System.Windows.Forms.ComboBox();
            this.cbxPreMonto = new System.Windows.Forms.ComboBox();
            this.cbxPreBanco = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnRegPAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrestamo
            // 
            this.btnPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestamo.Location = new System.Drawing.Point(401, 546);
            this.btnPrestamo.Name = "btnPrestamo";
            this.btnPrestamo.Size = new System.Drawing.Size(102, 46);
            this.btnPrestamo.TabIndex = 15;
            this.btnPrestamo.Text = "Solicitar";
            this.btnPrestamo.UseVisualStyleBackColor = true;
            this.btnPrestamo.Click += new System.EventHandler(this.btnPrestamo_Click);
            // 
            // cbxPreCuotas
            // 
            this.cbxPreCuotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPreCuotas.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbxPreCuotas.FormattingEnabled = true;
            this.cbxPreCuotas.Items.AddRange(new object[] {
            "6",
            "12",
            "24"});
            this.cbxPreCuotas.Location = new System.Drawing.Point(355, 490);
            this.cbxPreCuotas.Name = "cbxPreCuotas";
            this.cbxPreCuotas.Size = new System.Drawing.Size(231, 28);
            this.cbxPreCuotas.TabIndex = 14;
            this.cbxPreCuotas.Text = "Cuotas";
            this.cbxPreCuotas.Enter += new System.EventHandler(this.cbxPreCuotas_Enter);
            this.cbxPreCuotas.Leave += new System.EventHandler(this.cbxPreCuotas_Leave);
            // 
            // cbxPreMonto
            // 
            this.cbxPreMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPreMonto.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbxPreMonto.FormattingEnabled = true;
            this.cbxPreMonto.Items.AddRange(new object[] {
            "500000 ",
            "1000000",
            "1500000",
            "2000000"});
            this.cbxPreMonto.Location = new System.Drawing.Point(355, 420);
            this.cbxPreMonto.Name = "cbxPreMonto";
            this.cbxPreMonto.Size = new System.Drawing.Size(231, 28);
            this.cbxPreMonto.TabIndex = 12;
            this.cbxPreMonto.Text = "Monto";
            this.cbxPreMonto.Enter += new System.EventHandler(this.cbxPreMonto_Enter);
            this.cbxPreMonto.Leave += new System.EventHandler(this.cbxPreMonto_Leave);
            // 
            // cbxPreBanco
            // 
            this.cbxPreBanco.BackColor = System.Drawing.SystemColors.Info;
            this.cbxPreBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPreBanco.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbxPreBanco.FormattingEnabled = true;
            this.cbxPreBanco.Items.AddRange(new object[] {
            "Bancolombia",
            "Banco Popular",
            "Agrario",
            "Davivienda",
            "BBVA"});
            this.cbxPreBanco.Location = new System.Drawing.Point(355, 351);
            this.cbxPreBanco.Name = "cbxPreBanco";
            this.cbxPreBanco.Size = new System.Drawing.Size(231, 28);
            this.cbxPreBanco.TabIndex = 9;
            this.cbxPreBanco.Text = "Banco";
            this.cbxPreBanco.Enter += new System.EventHandler(this.cbxPreBanco_Enter);
            this.cbxPreBanco.Leave += new System.EventHandler(this.cbxPreBanco_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(79, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(741, 642);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.Image")));
            this.picBoxLogo.Location = new System.Drawing.Point(315, 55);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(271, 276);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLogo.TabIndex = 31;
            this.picBoxLogo.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(315, 351);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(315, 490);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(315, 420);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(43, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 34;
            this.pictureBox4.TabStop = false;
            // 
            // btnRegPAtras
            // 
            this.btnRegPAtras.Location = new System.Drawing.Point(315, 55);
            this.btnRegPAtras.Name = "btnRegPAtras";
            this.btnRegPAtras.Size = new System.Drawing.Size(76, 22);
            this.btnRegPAtras.TabIndex = 35;
            this.btnRegPAtras.Text = "Atras";
            this.btnRegPAtras.UseVisualStyleBackColor = true;
            this.btnRegPAtras.Click += new System.EventHandler(this.btnRegPAtras_Click);
            // 
            // RegistrarPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 710);
            this.Controls.Add(this.btnRegPAtras);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picBoxLogo);
            this.Controls.Add(this.btnPrestamo);
            this.Controls.Add(this.cbxPreCuotas);
            this.Controls.Add(this.cbxPreMonto);
            this.Controls.Add(this.cbxPreBanco);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RegistrarPrestamo";
            this.Text = "RegistrarPrestamo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrestamo;
        private System.Windows.Forms.ComboBox cbxPreCuotas;
        private System.Windows.Forms.ComboBox cbxPreMonto;
        private System.Windows.Forms.ComboBox cbxPreBanco;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnRegPAtras;
    }
}