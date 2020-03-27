namespace appSistemaDeCredito
{
    partial class Actualizar_Info_General
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actualizar_Info_General));
            this.txtActEstNombre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtActEstApellido = new System.Windows.Forms.TextBox();
            this.grupActEstGenero = new System.Windows.Forms.GroupBox();
            this.rdActEstFemenino = new System.Windows.Forms.RadioButton();
            this.rdActEstMasculino = new System.Windows.Forms.RadioButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtActEstNomIes = new System.Windows.Forms.TextBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.btnActInfGeneral = new System.Windows.Forms.Button();
            this.btnActInfGeneralAtras = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.grupActEstGenero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // txtActEstNombre
            // 
            this.txtActEstNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActEstNombre.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtActEstNombre.Location = new System.Drawing.Point(127, 305);
            this.txtActEstNombre.Name = "txtActEstNombre";
            this.txtActEstNombre.Size = new System.Drawing.Size(255, 27);
            this.txtActEstNombre.TabIndex = 31;
            this.txtActEstNombre.Text = "Nombres";
            this.txtActEstNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarActEstNom);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = global::appSistemaDeCredito.Properties.Resources.usuariaA;
            this.pictureBox1.Location = new System.Drawing.Point(107, 372);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox3.Image = global::appSistemaDeCredito.Properties.Resources.usuariaA;
            this.pictureBox3.Location = new System.Drawing.Point(107, 305);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // txtActEstApellido
            // 
            this.txtActEstApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActEstApellido.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtActEstApellido.Location = new System.Drawing.Point(127, 372);
            this.txtActEstApellido.Name = "txtActEstApellido";
            this.txtActEstApellido.Size = new System.Drawing.Size(255, 27);
            this.txtActEstApellido.TabIndex = 33;
            this.txtActEstApellido.Text = "Apellidos";
            this.txtActEstApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarActEstApe);
            // 
            // grupActEstGenero
            // 
            this.grupActEstGenero.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grupActEstGenero.Controls.Add(this.rdActEstFemenino);
            this.grupActEstGenero.Controls.Add(this.rdActEstMasculino);
            this.grupActEstGenero.Controls.Add(this.pictureBox4);
            this.grupActEstGenero.Location = new System.Drawing.Point(107, 428);
            this.grupActEstGenero.Name = "grupActEstGenero";
            this.grupActEstGenero.Size = new System.Drawing.Size(275, 45);
            this.grupActEstGenero.TabIndex = 34;
            this.grupActEstGenero.TabStop = false;
            this.grupActEstGenero.Text = "Genero";
            // 
            // rdActEstFemenino
            // 
            this.rdActEstFemenino.AutoSize = true;
            this.rdActEstFemenino.Location = new System.Drawing.Point(20, 22);
            this.rdActEstFemenino.Name = "rdActEstFemenino";
            this.rdActEstFemenino.Size = new System.Drawing.Size(71, 17);
            this.rdActEstFemenino.TabIndex = 22;
            this.rdActEstFemenino.TabStop = true;
            this.rdActEstFemenino.Text = "Femenino";
            this.rdActEstFemenino.UseVisualStyleBackColor = true;
            // 
            // rdActEstMasculino
            // 
            this.rdActEstMasculino.AutoSize = true;
            this.rdActEstMasculino.Location = new System.Drawing.Point(126, 19);
            this.rdActEstMasculino.Name = "rdActEstMasculino";
            this.rdActEstMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdActEstMasculino.TabIndex = 23;
            this.rdActEstMasculino.TabStop = true;
            this.rdActEstMasculino.Text = "Masculino";
            this.rdActEstMasculino.UseVisualStyleBackColor = true;
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
            // txtActEstNomIes
            // 
            this.txtActEstNomIes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActEstNomIes.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtActEstNomIes.Location = new System.Drawing.Point(125, 505);
            this.txtActEstNomIes.Name = "txtActEstNomIes";
            this.txtActEstNomIes.Size = new System.Drawing.Size(257, 27);
            this.txtActEstNomIes.TabIndex = 35;
            this.txtActEstNomIes.Text = "Nombre IES";
            this.txtActEstNomIes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarActEstNomIes);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(107, 505);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(21, 27);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 36;
            this.pictureBox9.TabStop = false;
            // 
            // btnActInfGeneral
            // 
            this.btnActInfGeneral.Location = new System.Drawing.Point(179, 571);
            this.btnActInfGeneral.Name = "btnActInfGeneral";
            this.btnActInfGeneral.Size = new System.Drawing.Size(127, 40);
            this.btnActInfGeneral.TabIndex = 37;
            this.btnActInfGeneral.Text = "Actualizar";
            this.btnActInfGeneral.UseVisualStyleBackColor = true;
            this.btnActInfGeneral.Click += new System.EventHandler(this.btnActInfGeneral_Click);
            // 
            // btnActInfGeneralAtras
            // 
            this.btnActInfGeneralAtras.Location = new System.Drawing.Point(107, 56);
            this.btnActInfGeneralAtras.Name = "btnActInfGeneralAtras";
            this.btnActInfGeneralAtras.Size = new System.Drawing.Size(75, 23);
            this.btnActInfGeneralAtras.TabIndex = 38;
            this.btnActInfGeneralAtras.Text = "Atras";
            this.btnActInfGeneralAtras.UseVisualStyleBackColor = true;
            this.btnActInfGeneralAtras.Click += new System.EventHandler(this.btnActInfGeneralAtras_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-125, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(741, 642);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(107, 106);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(273, 163);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 40;
            this.pictureBox5.TabStop = false;
            // 
            // Actualizar_Info_General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 659);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnActInfGeneralAtras);
            this.Controls.Add(this.btnActInfGeneral);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.txtActEstNomIes);
            this.Controls.Add(this.grupActEstGenero);
            this.Controls.Add(this.txtActEstApellido);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtActEstNombre);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Actualizar_Info_General";
            this.Text = "Actualizar_Info_General";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.grupActEstGenero.ResumeLayout(false);
            this.grupActEstGenero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtActEstNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtActEstApellido;
        private System.Windows.Forms.GroupBox grupActEstGenero;
        private System.Windows.Forms.RadioButton rdActEstFemenino;
        private System.Windows.Forms.RadioButton rdActEstMasculino;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtActEstNomIes;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button btnActInfGeneral;
        private System.Windows.Forms.Button btnActInfGeneralAtras;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}