namespace appSistemaDeCredito
{
    partial class RegistroEstudiante
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroEstudiante));
            this.btnEstGuardar = new System.Windows.Forms.Button();
            this.txtEstId = new System.Windows.Forms.TextBox();
            this.txtEstNombre = new System.Windows.Forms.TextBox();
            this.txtEstApellido = new System.Windows.Forms.TextBox();
            this.txtEstNomIes = new System.Windows.Forms.TextBox();
            this.txtEstEmail = new System.Windows.Forms.TextBox();
            this.txtEstDireccion = new System.Windows.Forms.TextBox();
            this.txtEstTelefono = new System.Windows.Forms.TextBox();
            this.txtEstContrasema = new System.Windows.Forms.TextBox();
            this.rdEstTi = new System.Windows.Forms.RadioButton();
            this.rdEstCC = new System.Windows.Forms.RadioButton();
            this.rdEstFemenino = new System.Windows.Forms.RadioButton();
            this.rdEstMasculino = new System.Windows.Forms.RadioButton();
            this.grupEstTipoDoc = new System.Windows.Forms.GroupBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.grupEstGenero = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.epEstVacio = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegEAtras = new System.Windows.Forms.Button();
            this.grupEstTipoDoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.grupEstGenero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEstVacio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEstGuardar
            // 
            this.btnEstGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstGuardar.Location = new System.Drawing.Point(365, 541);
            this.btnEstGuardar.Name = "btnEstGuardar";
            this.btnEstGuardar.Size = new System.Drawing.Size(111, 43);
            this.btnEstGuardar.TabIndex = 11;
            this.btnEstGuardar.Text = "Guardar";
            this.btnEstGuardar.UseVisualStyleBackColor = true;
            this.btnEstGuardar.Click += new System.EventHandler(this.btnEstGuardar_Click);
            // 
            // txtEstId
            // 
            this.txtEstId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstId.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtEstId.Location = new System.Drawing.Point(330, 181);
            this.txtEstId.Name = "txtEstId";
            this.txtEstId.Size = new System.Drawing.Size(229, 27);
            this.txtEstId.TabIndex = 12;
            this.txtEstId.Text = "Número Documento";
            this.txtEstId.Enter += new System.EventHandler(this.txtEstId_Enter);
            this.txtEstId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarEstNumId);
            this.txtEstId.Leave += new System.EventHandler(this.txtEstId_Leave);
            this.txtEstId.Validated += new System.EventHandler(this.validarVacioEstNumId);
            // 
            // txtEstNombre
            // 
            this.txtEstNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstNombre.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtEstNombre.Location = new System.Drawing.Point(330, 223);
            this.txtEstNombre.Name = "txtEstNombre";
            this.txtEstNombre.Size = new System.Drawing.Size(229, 27);
            this.txtEstNombre.TabIndex = 13;
            this.txtEstNombre.Text = "Nombres";
            this.txtEstNombre.Enter += new System.EventHandler(this.txtEstNombre_Enter);
            this.txtEstNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarLetraNombre);
            this.txtEstNombre.Leave += new System.EventHandler(this.txtEstNombre_Leave);
            this.txtEstNombre.Validated += new System.EventHandler(this.validarVacioEstNom);
            // 
            // txtEstApellido
            // 
            this.txtEstApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstApellido.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtEstApellido.Location = new System.Drawing.Point(330, 262);
            this.txtEstApellido.Name = "txtEstApellido";
            this.txtEstApellido.Size = new System.Drawing.Size(229, 27);
            this.txtEstApellido.TabIndex = 14;
            this.txtEstApellido.Text = "Apellidos";
            this.txtEstApellido.Enter += new System.EventHandler(this.txtEstApellido_Enter);
            this.txtEstApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarLetraApellido);
            this.txtEstApellido.Leave += new System.EventHandler(this.txtEstApellido_Leave);
            this.txtEstApellido.Validated += new System.EventHandler(this.validarVacioEstApe);
            // 
            // txtEstNomIes
            // 
            this.txtEstNomIes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstNomIes.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtEstNomIes.Location = new System.Drawing.Point(329, 352);
            this.txtEstNomIes.Name = "txtEstNomIes";
            this.txtEstNomIes.Size = new System.Drawing.Size(229, 27);
            this.txtEstNomIes.TabIndex = 15;
            this.txtEstNomIes.Text = "Nombre IES";
            this.txtEstNomIes.Enter += new System.EventHandler(this.txtEstNomIes_Enter);
            this.txtEstNomIes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarNomIES);
            this.txtEstNomIes.Leave += new System.EventHandler(this.txtEstNomIes_Leave);
            this.txtEstNomIes.Validated += new System.EventHandler(this.validarVacioEstNomIes);
            // 
            // txtEstEmail
            // 
            this.txtEstEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtEstEmail.Location = new System.Drawing.Point(329, 391);
            this.txtEstEmail.Name = "txtEstEmail";
            this.txtEstEmail.Size = new System.Drawing.Size(229, 27);
            this.txtEstEmail.TabIndex = 16;
            this.txtEstEmail.Text = "Email";
            this.txtEstEmail.Enter += new System.EventHandler(this.txtEstEmail_Enter);
            this.txtEstEmail.Leave += new System.EventHandler(this.txtEstEmail_Leave);
            this.txtEstEmail.Validated += new System.EventHandler(this.validarVacioEstEmail);
            // 
            // txtEstDireccion
            // 
            this.txtEstDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstDireccion.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtEstDireccion.Location = new System.Drawing.Point(330, 430);
            this.txtEstDireccion.Name = "txtEstDireccion";
            this.txtEstDireccion.Size = new System.Drawing.Size(229, 27);
            this.txtEstDireccion.TabIndex = 17;
            this.txtEstDireccion.Text = "Dirección";
            this.txtEstDireccion.Enter += new System.EventHandler(this.txtEstDireccion_Enter);
            this.txtEstDireccion.Leave += new System.EventHandler(this.txtEstDireccion_Leave);
            this.txtEstDireccion.Validated += new System.EventHandler(this.validarVacioEstDir);
            // 
            // txtEstTelefono
            // 
            this.txtEstTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstTelefono.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtEstTelefono.Location = new System.Drawing.Point(329, 469);
            this.txtEstTelefono.Name = "txtEstTelefono";
            this.txtEstTelefono.Size = new System.Drawing.Size(229, 27);
            this.txtEstTelefono.TabIndex = 18;
            this.txtEstTelefono.Text = "Telefono";
            this.txtEstTelefono.Enter += new System.EventHandler(this.txtEstTelefono_Enter);
            this.txtEstTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarEstTelefono);
            this.txtEstTelefono.Leave += new System.EventHandler(this.txtEstTelefono_Leave);
            this.txtEstTelefono.Validated += new System.EventHandler(this.validarVacioEstTel);
            // 
            // txtEstContrasema
            // 
            this.txtEstContrasema.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstContrasema.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtEstContrasema.Location = new System.Drawing.Point(330, 508);
            this.txtEstContrasema.Name = "txtEstContrasema";
            this.txtEstContrasema.Size = new System.Drawing.Size(229, 27);
            this.txtEstContrasema.TabIndex = 19;
            this.txtEstContrasema.Text = "Contraseña";
            this.txtEstContrasema.UseSystemPasswordChar = true;
            this.txtEstContrasema.Enter += new System.EventHandler(this.txtEstContrasema_Enter);
            this.txtEstContrasema.Leave += new System.EventHandler(this.txtEstContrasema_Leave);
            this.txtEstContrasema.Validated += new System.EventHandler(this.validarVacioEstCon);
            // 
            // rdEstTi
            // 
            this.rdEstTi.AutoSize = true;
            this.rdEstTi.Location = new System.Drawing.Point(21, 19);
            this.rdEstTi.Name = "rdEstTi";
            this.rdEstTi.Size = new System.Drawing.Size(38, 17);
            this.rdEstTi.TabIndex = 20;
            this.rdEstTi.TabStop = true;
            this.rdEstTi.Text = "T.I";
            this.rdEstTi.UseVisualStyleBackColor = true;
            // 
            // rdEstCC
            // 
            this.rdEstCC.AutoSize = true;
            this.rdEstCC.Location = new System.Drawing.Point(87, 19);
            this.rdEstCC.Name = "rdEstCC";
            this.rdEstCC.Size = new System.Drawing.Size(42, 17);
            this.rdEstCC.TabIndex = 21;
            this.rdEstCC.TabStop = true;
            this.rdEstCC.Text = "C.C";
            this.rdEstCC.UseVisualStyleBackColor = true;
            // 
            // rdEstFemenino
            // 
            this.rdEstFemenino.AutoSize = true;
            this.rdEstFemenino.Location = new System.Drawing.Point(20, 22);
            this.rdEstFemenino.Name = "rdEstFemenino";
            this.rdEstFemenino.Size = new System.Drawing.Size(71, 17);
            this.rdEstFemenino.TabIndex = 22;
            this.rdEstFemenino.TabStop = true;
            this.rdEstFemenino.Text = "Femenino";
            this.rdEstFemenino.UseVisualStyleBackColor = true;
            // 
            // rdEstMasculino
            // 
            this.rdEstMasculino.AutoSize = true;
            this.rdEstMasculino.Location = new System.Drawing.Point(126, 19);
            this.rdEstMasculino.Name = "rdEstMasculino";
            this.rdEstMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdEstMasculino.TabIndex = 23;
            this.rdEstMasculino.TabStop = true;
            this.rdEstMasculino.Text = "Masculino";
            this.rdEstMasculino.UseVisualStyleBackColor = true;
            // 
            // grupEstTipoDoc
            // 
            this.grupEstTipoDoc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grupEstTipoDoc.Controls.Add(this.pictureBox6);
            this.grupEstTipoDoc.Controls.Add(this.rdEstTi);
            this.grupEstTipoDoc.Controls.Add(this.rdEstCC);
            this.grupEstTipoDoc.Location = new System.Drawing.Point(309, 123);
            this.grupEstTipoDoc.Name = "grupEstTipoDoc";
            this.grupEstTipoDoc.Size = new System.Drawing.Size(250, 39);
            this.grupEstTipoDoc.TabIndex = 24;
            this.grupEstTipoDoc.TabStop = false;
            this.grupEstTipoDoc.Text = "Tipo de Documento";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::appSistemaDeCredito.Properties.Resources.usuariaA;
            this.pictureBox6.Location = new System.Drawing.Point(2, 13);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(21, 26);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 31;
            this.pictureBox6.TabStop = false;
            // 
            // grupEstGenero
            // 
            this.grupEstGenero.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grupEstGenero.Controls.Add(this.rdEstFemenino);
            this.grupEstGenero.Controls.Add(this.rdEstMasculino);
            this.grupEstGenero.Controls.Add(this.pictureBox4);
            this.grupEstGenero.Location = new System.Drawing.Point(309, 295);
            this.grupEstGenero.Name = "grupEstGenero";
            this.grupEstGenero.Size = new System.Drawing.Size(250, 45);
            this.grupEstGenero.TabIndex = 25;
            this.grupEstGenero.TabStop = false;
            this.grupEstGenero.Text = "Genero";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::appSistemaDeCredito.Properties.Resources.usuariaA;
            this.pictureBox4.Location = new System.Drawing.Point(0, 16);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(21, 29);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 30;
            this.pictureBox4.TabStop = false;
            // 
            // epEstVacio
            // 
            this.epEstVacio.ContainerControl = this;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::appSistemaDeCredito.Properties.Resources.usuariaA;
            this.pictureBox7.Location = new System.Drawing.Point(309, 262);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(21, 27);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 37;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(309, 508);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(21, 27);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 36;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(309, 469);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(21, 27);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 35;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(309, 430);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(21, 27);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 34;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(309, 352);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(21, 27);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 33;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(309, 391);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(21, 27);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 32;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::appSistemaDeCredito.Properties.Resources.usuariaA;
            this.pictureBox5.Location = new System.Drawing.Point(311, 181);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(21, 27);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 31;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::appSistemaDeCredito.Properties.Resources.usuariaA;
            this.pictureBox3.Location = new System.Drawing.Point(309, 223);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(309, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-68, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1014, 639);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegEAtras
            // 
            this.btnRegEAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegEAtras.Location = new System.Drawing.Point(309, 40);
            this.btnRegEAtras.Name = "btnRegEAtras";
            this.btnRegEAtras.Size = new System.Drawing.Size(59, 25);
            this.btnRegEAtras.TabIndex = 38;
            this.btnRegEAtras.Text = "Atras";
            this.btnRegEAtras.UseVisualStyleBackColor = true;
            this.btnRegEAtras.Click += new System.EventHandler(this.btnRegEAtras_Click);
            // 
            // RegistroEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(927, 626);
            this.Controls.Add(this.btnRegEAtras);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtEstContrasema);
            this.Controls.Add(this.txtEstTelefono);
            this.Controls.Add(this.grupEstGenero);
            this.Controls.Add(this.txtEstDireccion);
            this.Controls.Add(this.btnEstGuardar);
            this.Controls.Add(this.txtEstEmail);
            this.Controls.Add(this.txtEstNomIes);
            this.Controls.Add(this.grupEstTipoDoc);
            this.Controls.Add(this.txtEstId);
            this.Controls.Add(this.txtEstNombre);
            this.Controls.Add(this.txtEstApellido);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RegistroEstudiante";
            this.Text = "Form1";
            this.grupEstTipoDoc.ResumeLayout(false);
            this.grupEstTipoDoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.grupEstGenero.ResumeLayout(false);
            this.grupEstGenero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEstVacio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEstGuardar;
        private System.Windows.Forms.TextBox txtEstId;
        private System.Windows.Forms.TextBox txtEstNombre;
        private System.Windows.Forms.TextBox txtEstApellido;
        private System.Windows.Forms.TextBox txtEstNomIes;
        private System.Windows.Forms.TextBox txtEstEmail;
        private System.Windows.Forms.TextBox txtEstDireccion;
        private System.Windows.Forms.TextBox txtEstTelefono;
        private System.Windows.Forms.TextBox txtEstContrasema;
        private System.Windows.Forms.RadioButton rdEstTi;
        private System.Windows.Forms.RadioButton rdEstCC;
        private System.Windows.Forms.RadioButton rdEstFemenino;
        private System.Windows.Forms.RadioButton rdEstMasculino;
        private System.Windows.Forms.GroupBox grupEstTipoDoc;
        private System.Windows.Forms.GroupBox grupEstGenero;
        private System.Windows.Forms.ErrorProvider epEstVacio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnRegEAtras;
    }
}

