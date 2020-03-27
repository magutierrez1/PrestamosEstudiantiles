namespace appSistemaDeCredito
{
    partial class IniciarSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IniciarSesion));
            this.btnIniciar = new System.Windows.Forms.Button();
            this.txtIniciarEmail = new System.Windows.Forms.TextBox();
            this.txtIniciarContrasena = new System.Windows.Forms.TextBox();
            this.epVacio = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSesionAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.epVacio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(332, 536);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(115, 43);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Ingresar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // txtIniciarEmail
            // 
            this.txtIniciarEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIniciarEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtIniciarEmail.Location = new System.Drawing.Point(299, 402);
            this.txtIniciarEmail.Name = "txtIniciarEmail";
            this.txtIniciarEmail.Size = new System.Drawing.Size(208, 27);
            this.txtIniciarEmail.TabIndex = 3;
            this.txtIniciarEmail.Text = "Email";
            this.txtIniciarEmail.Enter += new System.EventHandler(this.txtIniciarEmail_Enter);
            this.txtIniciarEmail.Leave += new System.EventHandler(this.txtIniciarEmail_Leave);
            this.txtIniciarEmail.Validated += new System.EventHandler(this.validarVacioEmail);
            // 
            // txtIniciarContrasena
            // 
            this.txtIniciarContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIniciarContrasena.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtIniciarContrasena.Location = new System.Drawing.Point(299, 446);
            this.txtIniciarContrasena.Name = "txtIniciarContrasena";
            this.txtIniciarContrasena.Size = new System.Drawing.Size(208, 27);
            this.txtIniciarContrasena.TabIndex = 4;
            this.txtIniciarContrasena.Text = "Contraseña";
            this.txtIniciarContrasena.UseSystemPasswordChar = true;
            this.txtIniciarContrasena.Enter += new System.EventHandler(this.txtIniciarContrasena_Enter);
            this.txtIniciarContrasena.Leave += new System.EventHandler(this.txtIniciarContrasena_Leave);
            this.txtIniciarContrasena.Validated += new System.EventHandler(this.validarVacioContrasena);
            // 
            // epVacio
            // 
            this.epVacio.ContainerControl = this;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::appSistemaDeCredito.Properties.Resources.usuariaA;
            this.pictureBox2.Location = new System.Drawing.Point(272, 402);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(272, 446);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(256, 106);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(271, 276);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(741, 642);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // btnSesionAtras
            // 
            this.btnSesionAtras.Location = new System.Drawing.Point(256, 70);
            this.btnSesionAtras.Name = "btnSesionAtras";
            this.btnSesionAtras.Size = new System.Drawing.Size(65, 30);
            this.btnSesionAtras.TabIndex = 31;
            this.btnSesionAtras.Text = "Atras";
            this.btnSesionAtras.UseVisualStyleBackColor = true;
            this.btnSesionAtras.Click += new System.EventHandler(this.btnSesionAtras_Click);
            // 
            // IniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 680);
            this.Controls.Add(this.btnSesionAtras);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtIniciarContrasena);
            this.Controls.Add(this.txtIniciarEmail);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Name = "IniciarSesion";
            this.Text = "IniciarSesion";
            ((System.ComponentModel.ISupportInitialize)(this.epVacio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox txtIniciarEmail;
        private System.Windows.Forms.TextBox txtIniciarContrasena;
        private System.Windows.Forms.ErrorProvider epVacio;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSesionAtras;
    }
}