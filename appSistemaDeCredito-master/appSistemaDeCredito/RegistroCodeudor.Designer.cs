namespace appSistemaDeCredito
{
    partial class RegistroCodeudor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroCodeudor));
            this.txtCodApellido = new System.Windows.Forms.TextBox();
            this.txtCodNumeroDocumento = new System.Windows.Forms.TextBox();
            this.rbCodTi = new System.Windows.Forms.RadioButton();
            this.rbCodCc = new System.Windows.Forms.RadioButton();
            this.txtCodEmail = new System.Windows.Forms.TextBox();
            this.txtCodDireccion = new System.Windows.Forms.TextBox();
            this.txtCodTelefono = new System.Windows.Forms.TextBox();
            this.grupCodTipoDocumento = new System.Windows.Forms.GroupBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.groupCodGenero = new System.Windows.Forms.GroupBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.rbCodMasculino = new System.Windows.Forms.RadioButton();
            this.rbCodFemenino = new System.Windows.Forms.RadioButton();
            this.btnCodRegistrar = new System.Windows.Forms.Button();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.txtCodNombre = new System.Windows.Forms.TextBox();
            this.btnRegCAtras = new System.Windows.Forms.Button();
            this.grupCodTipoDocumento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.groupCodGenero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodApellido
            // 
            this.txtCodApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodApellido.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCodApellido.Location = new System.Drawing.Point(400, 322);
            this.txtCodApellido.Name = "txtCodApellido";
            this.txtCodApellido.Size = new System.Drawing.Size(235, 27);
            this.txtCodApellido.TabIndex = 9;
            this.txtCodApellido.Text = "Apellidos";
            this.txtCodApellido.Enter += new System.EventHandler(this.txtCodApellido_Enter);
            this.txtCodApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarLetraApellido);
            this.txtCodApellido.Leave += new System.EventHandler(this.txtCodApellido_Leave);
            // 
            // txtCodNumeroDocumento
            // 
            this.txtCodNumeroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodNumeroDocumento.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCodNumeroDocumento.Location = new System.Drawing.Point(400, 234);
            this.txtCodNumeroDocumento.Name = "txtCodNumeroDocumento";
            this.txtCodNumeroDocumento.Size = new System.Drawing.Size(235, 27);
            this.txtCodNumeroDocumento.TabIndex = 10;
            this.txtCodNumeroDocumento.Text = "Número Documento";
            this.txtCodNumeroDocumento.Enter += new System.EventHandler(this.txtCodNumeroDocumento_Enter);
            this.txtCodNumeroDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarCodNumId);
            this.txtCodNumeroDocumento.Leave += new System.EventHandler(this.txtCodNumeroDocumento_Leave);
            // 
            // rbCodTi
            // 
            this.rbCodTi.AutoSize = true;
            this.rbCodTi.Location = new System.Drawing.Point(69, 19);
            this.rbCodTi.Name = "rbCodTi";
            this.rbCodTi.Size = new System.Drawing.Size(38, 17);
            this.rbCodTi.TabIndex = 11;
            this.rbCodTi.TabStop = true;
            this.rbCodTi.Text = "T.I";
            this.rbCodTi.UseVisualStyleBackColor = true;
            // 
            // rbCodCc
            // 
            this.rbCodCc.AutoSize = true;
            this.rbCodCc.Location = new System.Drawing.Point(143, 19);
            this.rbCodCc.Name = "rbCodCc";
            this.rbCodCc.Size = new System.Drawing.Size(42, 17);
            this.rbCodCc.TabIndex = 12;
            this.rbCodCc.TabStop = true;
            this.rbCodCc.Text = "C.C";
            this.rbCodCc.UseVisualStyleBackColor = true;
            // 
            // txtCodEmail
            // 
            this.txtCodEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCodEmail.Location = new System.Drawing.Point(400, 422);
            this.txtCodEmail.Name = "txtCodEmail";
            this.txtCodEmail.Size = new System.Drawing.Size(235, 27);
            this.txtCodEmail.TabIndex = 13;
            this.txtCodEmail.Text = "Email";
            this.txtCodEmail.Enter += new System.EventHandler(this.txtCodEmail_Enter);
            this.txtCodEmail.Leave += new System.EventHandler(this.txtCodEmail_Leave);
            // 
            // txtCodDireccion
            // 
            this.txtCodDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodDireccion.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCodDireccion.Location = new System.Drawing.Point(400, 466);
            this.txtCodDireccion.Name = "txtCodDireccion";
            this.txtCodDireccion.Size = new System.Drawing.Size(235, 27);
            this.txtCodDireccion.TabIndex = 14;
            this.txtCodDireccion.Text = "Dirección";
            this.txtCodDireccion.Enter += new System.EventHandler(this.txtCodDireccion_Enter);
            this.txtCodDireccion.Leave += new System.EventHandler(this.txtCodDireccion_Leave);
            // 
            // txtCodTelefono
            // 
            this.txtCodTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodTelefono.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCodTelefono.Location = new System.Drawing.Point(400, 510);
            this.txtCodTelefono.Name = "txtCodTelefono";
            this.txtCodTelefono.Size = new System.Drawing.Size(235, 27);
            this.txtCodTelefono.TabIndex = 15;
            this.txtCodTelefono.Text = "Telefono";
            this.txtCodTelefono.Enter += new System.EventHandler(this.txtCodTelefono_Enter);
            this.txtCodTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarCodTelefono);
            this.txtCodTelefono.Leave += new System.EventHandler(this.txtCodTelefono_Leave);
            // 
            // grupCodTipoDocumento
            // 
            this.grupCodTipoDocumento.Controls.Add(this.pictureBox7);
            this.grupCodTipoDocumento.Controls.Add(this.rbCodTi);
            this.grupCodTipoDocumento.Controls.Add(this.rbCodCc);
            this.grupCodTipoDocumento.Location = new System.Drawing.Point(378, 172);
            this.grupCodTipoDocumento.Name = "grupCodTipoDocumento";
            this.grupCodTipoDocumento.Size = new System.Drawing.Size(257, 46);
            this.grupCodTipoDocumento.TabIndex = 16;
            this.grupCodTipoDocumento.TabStop = false;
            this.grupCodTipoDocumento.Text = "Tipo de documento:";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::appSistemaDeCredito.Properties.Resources.usuariaA;
            this.pictureBox7.Location = new System.Drawing.Point(0, 13);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(24, 27);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 34;
            this.pictureBox7.TabStop = false;
            // 
            // groupCodGenero
            // 
            this.groupCodGenero.Controls.Add(this.pictureBox8);
            this.groupCodGenero.Controls.Add(this.rbCodMasculino);
            this.groupCodGenero.Controls.Add(this.rbCodFemenino);
            this.groupCodGenero.Location = new System.Drawing.Point(378, 366);
            this.groupCodGenero.Name = "groupCodGenero";
            this.groupCodGenero.Size = new System.Drawing.Size(257, 36);
            this.groupCodGenero.TabIndex = 17;
            this.groupCodGenero.TabStop = false;
            this.groupCodGenero.Text = "Genero: ";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::appSistemaDeCredito.Properties.Resources.usuariaA;
            this.pictureBox8.Location = new System.Drawing.Point(0, 13);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(24, 27);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 34;
            this.pictureBox8.TabStop = false;
            // 
            // rbCodMasculino
            // 
            this.rbCodMasculino.AutoSize = true;
            this.rbCodMasculino.Location = new System.Drawing.Point(141, 13);
            this.rbCodMasculino.Name = "rbCodMasculino";
            this.rbCodMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbCodMasculino.TabIndex = 1;
            this.rbCodMasculino.TabStop = true;
            this.rbCodMasculino.Text = "Masculino";
            this.rbCodMasculino.UseVisualStyleBackColor = true;
            // 
            // rbCodFemenino
            // 
            this.rbCodFemenino.AutoSize = true;
            this.rbCodFemenino.Location = new System.Drawing.Point(63, 13);
            this.rbCodFemenino.Name = "rbCodFemenino";
            this.rbCodFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbCodFemenino.TabIndex = 0;
            this.rbCodFemenino.TabStop = true;
            this.rbCodFemenino.Text = "Femenino";
            this.rbCodFemenino.UseVisualStyleBackColor = true;
            // 
            // btnCodRegistrar
            // 
            this.btnCodRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCodRegistrar.Location = new System.Drawing.Point(447, 564);
            this.btnCodRegistrar.Name = "btnCodRegistrar";
            this.btnCodRegistrar.Size = new System.Drawing.Size(108, 38);
            this.btnCodRegistrar.TabIndex = 18;
            this.btnCodRegistrar.Text = "Registrar";
            this.btnCodRegistrar.UseVisualStyleBackColor = true;
            this.btnCodRegistrar.Click += new System.EventHandler(this.btnCodRegistrar_Click);
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1007, 642);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(378, 54);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(257, 112);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::appSistemaDeCredito.Properties.Resources.usuariaA;
            this.pictureBox4.Location = new System.Drawing.Point(378, 234);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 27);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::appSistemaDeCredito.Properties.Resources.usuariaA;
            this.pictureBox5.Location = new System.Drawing.Point(378, 322);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 27);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 32;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::appSistemaDeCredito.Properties.Resources.usuariaA;
            this.pictureBox6.Location = new System.Drawing.Point(378, 279);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(24, 27);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 33;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(378, 466);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(24, 27);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 35;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(100, 50);
            this.pictureBox9.TabIndex = 36;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(378, 422);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(24, 27);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 37;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(378, 510);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(24, 27);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 38;
            this.pictureBox12.TabStop = false;
            // 
            // txtCodNombre
            // 
            this.txtCodNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodNombre.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCodNombre.Location = new System.Drawing.Point(400, 279);
            this.txtCodNombre.Name = "txtCodNombre";
            this.txtCodNombre.Size = new System.Drawing.Size(235, 27);
            this.txtCodNombre.TabIndex = 39;
            this.txtCodNombre.Text = "Nombres";
            this.txtCodNombre.Enter += new System.EventHandler(this.txtCodNombre_Enter);
            this.txtCodNombre.Leave += new System.EventHandler(this.txtCodNombre_Leave);
            // 
            // btnRegCAtras
            // 
            this.btnRegCAtras.Location = new System.Drawing.Point(378, 54);
            this.btnRegCAtras.Name = "btnRegCAtras";
            this.btnRegCAtras.Size = new System.Drawing.Size(57, 23);
            this.btnRegCAtras.TabIndex = 40;
            this.btnRegCAtras.Text = "Atras";
            this.btnRegCAtras.UseVisualStyleBackColor = true;
            this.btnRegCAtras.Click += new System.EventHandler(this.btnRegCAtras_Click);
            // 
            // RegistroCodeudor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 658);
            this.Controls.Add(this.btnRegCAtras);
            this.Controls.Add(this.txtCodNombre);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnCodRegistrar);
            this.Controls.Add(this.groupCodGenero);
            this.Controls.Add(this.grupCodTipoDocumento);
            this.Controls.Add(this.txtCodTelefono);
            this.Controls.Add(this.txtCodDireccion);
            this.Controls.Add(this.txtCodEmail);
            this.Controls.Add(this.txtCodNumeroDocumento);
            this.Controls.Add(this.txtCodApellido);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RegistroCodeudor";
            this.Text = "RegistroCodeudor";
            this.grupCodTipoDocumento.ResumeLayout(false);
            this.grupCodTipoDocumento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.groupCodGenero.ResumeLayout(false);
            this.groupCodGenero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCodApellido;
        private System.Windows.Forms.TextBox txtCodNumeroDocumento;
        private System.Windows.Forms.RadioButton rbCodTi;
        private System.Windows.Forms.RadioButton rbCodCc;
        private System.Windows.Forms.TextBox txtCodEmail;
        private System.Windows.Forms.TextBox txtCodDireccion;
        private System.Windows.Forms.TextBox txtCodTelefono;
        private System.Windows.Forms.GroupBox grupCodTipoDocumento;
        private System.Windows.Forms.GroupBox groupCodGenero;
        private System.Windows.Forms.RadioButton rbCodFemenino;
        private System.Windows.Forms.RadioButton rbCodMasculino;
        private System.Windows.Forms.Button btnCodRegistrar;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.TextBox txtCodNombre;
        private System.Windows.Forms.Button btnRegCAtras;
    }
}