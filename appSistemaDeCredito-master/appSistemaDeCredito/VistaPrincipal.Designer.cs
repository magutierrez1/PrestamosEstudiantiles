namespace appSistemaDeCredito
{
    partial class VistaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaPrincipal));
            this.btnVistIniciar = new System.Windows.Forms.Button();
            this.btnVistRegistrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVistIniciar
            // 
            this.btnVistIniciar.BackColor = System.Drawing.Color.LightGray;
            this.btnVistIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVistIniciar.Location = new System.Drawing.Point(342, 402);
            this.btnVistIniciar.Name = "btnVistIniciar";
            this.btnVistIniciar.Size = new System.Drawing.Size(126, 42);
            this.btnVistIniciar.TabIndex = 0;
            this.btnVistIniciar.Text = "Iniciar Sesion";
            this.btnVistIniciar.UseVisualStyleBackColor = false;
            this.btnVistIniciar.Click += new System.EventHandler(this.btnVistIniciar_Click);
            // 
            // btnVistRegistrar
            // 
            this.btnVistRegistrar.BackColor = System.Drawing.Color.LightGray;
            this.btnVistRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVistRegistrar.Location = new System.Drawing.Point(342, 507);
            this.btnVistRegistrar.Name = "btnVistRegistrar";
            this.btnVistRegistrar.Size = new System.Drawing.Size(126, 42);
            this.btnVistRegistrar.TabIndex = 1;
            this.btnVistRegistrar.Text = "Registrar ";
            this.btnVistRegistrar.UseVisualStyleBackColor = false;
            this.btnVistRegistrar.Click += new System.EventHandler(this.btnVistRegistrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(741, 642);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(265, 81);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(271, 276);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // VistaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(888, 656);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnVistRegistrar);
            this.Controls.Add(this.btnVistIniciar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "VistaPrincipal";
            this.Text = "VistaPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVistIniciar;
        private System.Windows.Forms.Button btnVistRegistrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}