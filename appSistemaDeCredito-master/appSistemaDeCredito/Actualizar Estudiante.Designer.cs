namespace appSistemaDeCredito
{
    partial class ActualizarEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizarEstudiante));
            this.btnActEstGeneral = new System.Windows.Forms.Button();
            this.btnActEstContacto = new System.Windows.Forms.Button();
            this.btnActEstContrasena = new System.Windows.Forms.Button();
            this.btnActEstAtras = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActEstGeneral
            // 
            this.btnActEstGeneral.Location = new System.Drawing.Point(149, 280);
            this.btnActEstGeneral.Name = "btnActEstGeneral";
            this.btnActEstGeneral.Size = new System.Drawing.Size(252, 42);
            this.btnActEstGeneral.TabIndex = 0;
            this.btnActEstGeneral.Text = "Informacion General";
            this.btnActEstGeneral.UseVisualStyleBackColor = true;
            this.btnActEstGeneral.Click += new System.EventHandler(this.btnActEstGeneral_Click);
            // 
            // btnActEstContacto
            // 
            this.btnActEstContacto.Location = new System.Drawing.Point(150, 395);
            this.btnActEstContacto.Name = "btnActEstContacto";
            this.btnActEstContacto.Size = new System.Drawing.Size(252, 42);
            this.btnActEstContacto.TabIndex = 1;
            this.btnActEstContacto.Text = "Informacion de Contacto";
            this.btnActEstContacto.UseVisualStyleBackColor = true;
            this.btnActEstContacto.Click += new System.EventHandler(this.btnActEstContacto_Click);
            // 
            // btnActEstContrasena
            // 
            this.btnActEstContrasena.Location = new System.Drawing.Point(149, 499);
            this.btnActEstContrasena.Name = "btnActEstContrasena";
            this.btnActEstContrasena.Size = new System.Drawing.Size(251, 42);
            this.btnActEstContrasena.TabIndex = 2;
            this.btnActEstContrasena.Text = "Cambiar contraseña";
            this.btnActEstContrasena.UseVisualStyleBackColor = true;
            this.btnActEstContrasena.Click += new System.EventHandler(this.btnActEstContrasena_Click);
            // 
            // btnActEstAtras
            // 
            this.btnActEstAtras.Location = new System.Drawing.Point(150, 47);
            this.btnActEstAtras.Name = "btnActEstAtras";
            this.btnActEstAtras.Size = new System.Drawing.Size(75, 23);
            this.btnActEstAtras.TabIndex = 3;
            this.btnActEstAtras.Text = "Atras";
            this.btnActEstAtras.UseVisualStyleBackColor = true;
            this.btnActEstAtras.Click += new System.EventHandler(this.btnActEstAtras_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-95, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(741, 642);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(149, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // ActualizarEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 681);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnActEstAtras);
            this.Controls.Add(this.btnActEstContrasena);
            this.Controls.Add(this.btnActEstContacto);
            this.Controls.Add(this.btnActEstGeneral);
            this.Controls.Add(this.pictureBox2);
            this.Name = "ActualizarEstudiante";
            this.Text = "CambiarInformacionEstudiante";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnActEstGeneral;
        private System.Windows.Forms.Button btnActEstContacto;
        private System.Windows.Forms.Button btnActEstContrasena;
        private System.Windows.Forms.Button btnActEstAtras;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}