namespace ElyKids_Software_Didactico
{
    partial class Trazado
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
            this.Borrarbtn = new System.Windows.Forms.Button();
            this.Lienzo = new System.Windows.Forms.Panel();
            this.CajaLogo = new System.Windows.Forms.PictureBox();
            this.Dibujar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CajaLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dibujar)).BeginInit();
            this.SuspendLayout();
            // 
            // Borrarbtn
            // 
            this.Borrarbtn.Location = new System.Drawing.Point(361, 29);
            this.Borrarbtn.Name = "Borrarbtn";
            this.Borrarbtn.Size = new System.Drawing.Size(195, 63);
            this.Borrarbtn.TabIndex = 13;
            this.Borrarbtn.Text = "Borrar";
            this.Borrarbtn.UseVisualStyleBackColor = true;
            this.Borrarbtn.Click += new System.EventHandler(this.Borrarbtn_Click);
            // 
            // Lienzo
            // 
            this.Lienzo.BackgroundImage = global::ElyKids_Software_Didactico.Properties.Resources.D_removebg_preview;
            this.Lienzo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Lienzo.Location = new System.Drawing.Point(109, 133);
            this.Lienzo.Name = "Lienzo";
            this.Lienzo.Size = new System.Drawing.Size(744, 389);
            this.Lienzo.TabIndex = 14;
            this.Lienzo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Lienzo_MouseDown);
            this.Lienzo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Lienzo_MouseMove);
            this.Lienzo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Lienzo_MouseUp);
            // 
            // CajaLogo
            // 
            this.CajaLogo.BackColor = System.Drawing.Color.Transparent;
            this.CajaLogo.BackgroundImage = global::ElyKids_Software_Didactico.Properties.Resources.LOGO;
            this.CajaLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CajaLogo.Location = new System.Drawing.Point(12, 12);
            this.CajaLogo.Name = "CajaLogo";
            this.CajaLogo.Size = new System.Drawing.Size(151, 80);
            this.CajaLogo.TabIndex = 12;
            this.CajaLogo.TabStop = false;
            // 
            // Dibujar
            // 
            this.Dibujar.BackColor = System.Drawing.Color.Black;
            this.Dibujar.Location = new System.Drawing.Point(187, 46);
            this.Dibujar.Name = "Dibujar";
            this.Dibujar.Size = new System.Drawing.Size(100, 50);
            this.Dibujar.TabIndex = 15;
            this.Dibujar.TabStop = false;
            this.Dibujar.Visible = false;
            this.Dibujar.Click += new System.EventHandler(this.Dibujar_Click);
            // 
            // Trazado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(954, 583);
            this.Controls.Add(this.Dibujar);
            this.Controls.Add(this.Lienzo);
            this.Controls.Add(this.Borrarbtn);
            this.Controls.Add(this.CajaLogo);
            this.MinimumSize = new System.Drawing.Size(970, 622);
            this.Name = "Trazado";
            this.Text = "Trazado";
            ((System.ComponentModel.ISupportInitialize)(this.CajaLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dibujar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CajaLogo;
        private System.Windows.Forms.Button Borrarbtn;
        private System.Windows.Forms.Panel Lienzo;
        private System.Windows.Forms.PictureBox Dibujar;
    }
}