namespace appSistemaDeCredito
{
    partial class EliminarPrestamo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarPrestamo));
            this.cbxIdPrestamo = new System.Windows.Forms.ComboBox();
            this.btnEliminarPrestamo = new System.Windows.Forms.Button();
            this.dgvEliminarPrestamo = new System.Windows.Forms.DataGridView();
            this.nomCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numCuotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminarPAtras = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminarPrestamo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxIdPrestamo
            // 
            this.cbxIdPrestamo.FormattingEnabled = true;
            this.cbxIdPrestamo.Location = new System.Drawing.Point(189, 292);
            this.cbxIdPrestamo.Name = "cbxIdPrestamo";
            this.cbxIdPrestamo.Size = new System.Drawing.Size(121, 21);
            this.cbxIdPrestamo.TabIndex = 0;
            // 
            // btnEliminarPrestamo
            // 
            this.btnEliminarPrestamo.Location = new System.Drawing.Point(316, 282);
            this.btnEliminarPrestamo.Name = "btnEliminarPrestamo";
            this.btnEliminarPrestamo.Size = new System.Drawing.Size(68, 38);
            this.btnEliminarPrestamo.TabIndex = 1;
            this.btnEliminarPrestamo.Text = "Eliminar";
            this.btnEliminarPrestamo.UseVisualStyleBackColor = true;
            this.btnEliminarPrestamo.Click += new System.EventHandler(this.btnEliminarPrestamo_Click);
            // 
            // dgvEliminarPrestamo
            // 
            this.dgvEliminarPrestamo.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvEliminarPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEliminarPrestamo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomCod,
            this.idPrestamo,
            this.fSolicitud,
            this.EPrestamo,
            this.nomBanco,
            this.monto,
            this.numCuotas});
            this.dgvEliminarPrestamo.Location = new System.Drawing.Point(115, 366);
            this.dgvEliminarPrestamo.Name = "dgvEliminarPrestamo";
            this.dgvEliminarPrestamo.Size = new System.Drawing.Size(267, 138);
            this.dgvEliminarPrestamo.TabIndex = 2;
            // 
            // nomCod
            // 
            this.nomCod.HeaderText = "Nombre Codeudor";
            this.nomCod.Name = "nomCod";
            // 
            // idPrestamo
            // 
            this.idPrestamo.HeaderText = "Id Prestamo";
            this.idPrestamo.Name = "idPrestamo";
            // 
            // fSolicitud
            // 
            this.fSolicitud.HeaderText = "Fecha Solicitud";
            this.fSolicitud.Name = "fSolicitud";
            // 
            // EPrestamo
            // 
            this.EPrestamo.HeaderText = "Estado Prestamo";
            this.EPrestamo.Name = "EPrestamo";
            // 
            // nomBanco
            // 
            this.nomBanco.HeaderText = "Nombre Banco";
            this.nomBanco.Name = "nomBanco";
            // 
            // monto
            // 
            this.monto.HeaderText = "Monto";
            this.monto.Name = "monto";
            // 
            // numCuotas
            // 
            this.numCuotas.HeaderText = "Numero  Cuotas";
            this.numCuotas.Name = "numCuotas";
            // 
            // btnEliminarPAtras
            // 
            this.btnEliminarPAtras.Location = new System.Drawing.Point(115, 282);
            this.btnEliminarPAtras.Name = "btnEliminarPAtras";
            this.btnEliminarPAtras.Size = new System.Drawing.Size(68, 38);
            this.btnEliminarPAtras.TabIndex = 3;
            this.btnEliminarPAtras.Text = "Atras";
            this.btnEliminarPAtras.UseVisualStyleBackColor = true;
            this.btnEliminarPAtras.Click += new System.EventHandler(this.btnEliminarPAtras_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(115, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-121, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(741, 642);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // EliminarPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 676);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEliminarPAtras);
            this.Controls.Add(this.dgvEliminarPrestamo);
            this.Controls.Add(this.btnEliminarPrestamo);
            this.Controls.Add(this.cbxIdPrestamo);
            this.Controls.Add(this.pictureBox2);
            this.Name = "EliminarPrestamo";
            this.Text = "EliminarPrestamo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminarPrestamo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxIdPrestamo;
        private System.Windows.Forms.Button btnEliminarPrestamo;
        private System.Windows.Forms.DataGridView dgvEliminarPrestamo;
        private System.Windows.Forms.Button btnEliminarPAtras;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn EPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCuotas;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}