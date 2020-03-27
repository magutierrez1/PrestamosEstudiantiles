namespace appSistemaDeCredito
{
    partial class HistorialPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialPrestamo));
            this.dgVHistorial = new System.Windows.Forms.DataGridView();
            this.nomCodeudor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nCoutas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHistorialAtras = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgVHistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVHistorial
            // 
            this.dgVHistorial.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgVHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomCodeudor,
            this.idPrestamo,
            this.fSolicitud,
            this.estadoP,
            this.nomBanco,
            this.montoP,
            this.nCoutas});
            this.dgVHistorial.Location = new System.Drawing.Point(272, 305);
            this.dgVHistorial.Name = "dgVHistorial";
            this.dgVHistorial.Size = new System.Drawing.Size(271, 178);
            this.dgVHistorial.TabIndex = 0;
            // 
            // nomCodeudor
            // 
            this.nomCodeudor.HeaderText = "Nombre Codeudor";
            this.nomCodeudor.Name = "nomCodeudor";
            // 
            // idPrestamo
            // 
            this.idPrestamo.HeaderText = "Id Prestamo";
            this.idPrestamo.Name = "idPrestamo";
            // 
            // fSolicitud
            // 
            this.fSolicitud.HeaderText = "Fecha de Solicitud";
            this.fSolicitud.Name = "fSolicitud";
            // 
            // estadoP
            // 
            this.estadoP.HeaderText = "Estado del Prestamo";
            this.estadoP.Name = "estadoP";
            // 
            // nomBanco
            // 
            this.nomBanco.HeaderText = "nombre de Banco";
            this.nomBanco.Name = "nomBanco";
            // 
            // montoP
            // 
            this.montoP.HeaderText = "Monto";
            this.montoP.Name = "montoP";
            // 
            // nCoutas
            // 
            this.nCoutas.HeaderText = "numeroCuotas";
            this.nCoutas.Name = "nCoutas";
            // 
            // btnHistorialAtras
            // 
            this.btnHistorialAtras.Location = new System.Drawing.Point(346, 531);
            this.btnHistorialAtras.Name = "btnHistorialAtras";
            this.btnHistorialAtras.Size = new System.Drawing.Size(107, 41);
            this.btnHistorialAtras.TabIndex = 1;
            this.btnHistorialAtras.Text = "Atras";
            this.btnHistorialAtras.UseVisualStyleBackColor = true;
            this.btnHistorialAtras.Click += new System.EventHandler(this.btnHistorialAtras_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(741, 642);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(272, 93);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(271, 168);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // HistorialPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 652);
            this.Controls.Add(this.dgVHistorial);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnHistorialAtras);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HistorialPrestamo";
            this.Text = "HistorialPrestamo";
            ((System.ComponentModel.ISupportInitialize)(this.dgVHistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCodeudor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCoutas;
        private System.Windows.Forms.Button btnHistorialAtras;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}