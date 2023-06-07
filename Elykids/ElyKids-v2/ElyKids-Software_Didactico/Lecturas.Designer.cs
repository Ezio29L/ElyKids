namespace ElyKids_Software_Didactico
{
    partial class Lecturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lecturas));
            this.PnlVol = new System.Windows.Forms.Panel();
            this.trbVolumen = new System.Windows.Forms.TrackBar();
            this.lblVol = new System.Windows.Forms.Label();
            this.CajaLectura = new System.Windows.Forms.ListBox();
            this.btnSalir = new CustomControls.EControls.EButton();
            this.btnSig = new CustomControls.EControls.EButton();
            this.ImagenPrincipal = new System.Windows.Forms.PictureBox();
            this.btnVolumen = new CustomControls.EControls.EButton();
            this.CajaLogo = new System.Windows.Forms.PictureBox();
            this.btnAtras = new CustomControls.EControls.EButton();
            this.PnlVol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbVolumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CajaLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlVol
            // 
            this.PnlVol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlVol.Controls.Add(this.trbVolumen);
            this.PnlVol.Controls.Add(this.lblVol);
            this.PnlVol.Location = new System.Drawing.Point(582, 15);
            this.PnlVol.Name = "PnlVol";
            this.PnlVol.Size = new System.Drawing.Size(247, 50);
            this.PnlVol.TabIndex = 12;
            this.PnlVol.Visible = false;
            // 
            // trbVolumen
            // 
            this.trbVolumen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trbVolumen.Location = new System.Drawing.Point(3, 2);
            this.trbVolumen.Maximum = 100;
            this.trbVolumen.Name = "trbVolumen";
            this.trbVolumen.Size = new System.Drawing.Size(191, 45);
            this.trbVolumen.TabIndex = 1;
            this.trbVolumen.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trbVolumen.Value = 100;
            this.trbVolumen.Scroll += new System.EventHandler(this.trbVolumen_Scroll);
            // 
            // lblVol
            // 
            this.lblVol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVol.AutoSize = true;
            this.lblVol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVol.Location = new System.Drawing.Point(190, 12);
            this.lblVol.Name = "lblVol";
            this.lblVol.Size = new System.Drawing.Size(54, 20);
            this.lblVol.TabIndex = 0;
            this.lblVol.Text = "100%";
            // 
            // CajaLectura
            // 
            this.CajaLectura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CajaLectura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(215)))));
            this.CajaLectura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CajaLectura.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CajaLectura.FormattingEnabled = true;
            this.CajaLectura.ItemHeight = 28;
            this.CajaLectura.Location = new System.Drawing.Point(98, 95);
            this.CajaLectura.Name = "CajaLectura";
            this.CajaLectura.Size = new System.Drawing.Size(521, 364);
            this.CajaLectura.TabIndex = 13;
            this.CajaLectura.SelectedIndexChanged += new System.EventHandler(this.CajaLectura_SelectedIndexChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSalir.BorderColor = System.Drawing.Color.Black;
            this.btnSalir.BorderRadius = 15;
            this.btnSalir.BorderSize = 5;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(887, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(55, 51);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "x";
            this.btnSalir.TextColor = System.Drawing.Color.Black;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnSig
            // 
            this.btnSig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSig.BackColor = System.Drawing.Color.Transparent;
            this.btnSig.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSig.BorderColor = System.Drawing.Color.Black;
            this.btnSig.BorderRadius = 32;
            this.btnSig.BorderSize = 4;
            this.btnSig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSig.FlatAppearance.BorderSize = 0;
            this.btnSig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSig.Font = new System.Drawing.Font("Tahoma", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSig.ForeColor = System.Drawing.Color.Black;
            this.btnSig.Image = global::ElyKids_Software_Didactico.Properties.Resources.tocarAncho_chico;
            this.btnSig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSig.Location = new System.Drawing.Point(765, 502);
            this.btnSig.Name = "btnSig";
            this.btnSig.Size = new System.Drawing.Size(177, 69);
            this.btnSig.TabIndex = 15;
            this.btnSig.Text = "SIGUIENTE";
            this.btnSig.TextColor = System.Drawing.Color.Black;
            this.btnSig.UseVisualStyleBackColor = false;
            this.btnSig.Click += new System.EventHandler(this.btnSig_Click);
            // 
            // ImagenPrincipal
            // 
            this.ImagenPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImagenPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImagenPrincipal.Location = new System.Drawing.Point(625, 108);
            this.ImagenPrincipal.Name = "ImagenPrincipal";
            this.ImagenPrincipal.Size = new System.Drawing.Size(287, 279);
            this.ImagenPrincipal.TabIndex = 14;
            this.ImagenPrincipal.TabStop = false;
            // 
            // btnVolumen
            // 
            this.btnVolumen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolumen.BackColor = System.Drawing.Color.Transparent;
            this.btnVolumen.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnVolumen.BackgroundImage = global::ElyKids_Software_Didactico.Properties.Resources.volumen;
            this.btnVolumen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolumen.BorderColor = System.Drawing.Color.Transparent;
            this.btnVolumen.BorderRadius = 15;
            this.btnVolumen.BorderSize = 5;
            this.btnVolumen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolumen.FlatAppearance.BorderSize = 0;
            this.btnVolumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolumen.ForeColor = System.Drawing.Color.Black;
            this.btnVolumen.Location = new System.Drawing.Point(832, 19);
            this.btnVolumen.Name = "btnVolumen";
            this.btnVolumen.Size = new System.Drawing.Size(49, 41);
            this.btnVolumen.TabIndex = 11;
            this.btnVolumen.TextColor = System.Drawing.Color.Black;
            this.btnVolumen.UseVisualStyleBackColor = false;
            this.btnVolumen.Click += new System.EventHandler(this.btnVolumen_Click);
            // 
            // CajaLogo
            // 
            this.CajaLogo.BackColor = System.Drawing.Color.Transparent;
            this.CajaLogo.BackgroundImage = global::ElyKids_Software_Didactico.Properties.Resources.LOGO;
            this.CajaLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CajaLogo.Location = new System.Drawing.Point(12, 12);
            this.CajaLogo.Name = "CajaLogo";
            this.CajaLogo.Size = new System.Drawing.Size(151, 80);
            this.CajaLogo.TabIndex = 10;
            this.CajaLogo.TabStop = false;
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAtras.BorderColor = System.Drawing.Color.Black;
            this.btnAtras.BorderRadius = 32;
            this.btnAtras.BorderSize = 4;
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Tahoma", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.Color.Black;
            this.btnAtras.Image = global::ElyKids_Software_Didactico.Properties.Resources.left_arrow__1_;
            this.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtras.Location = new System.Drawing.Point(12, 502);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(127, 69);
            this.btnAtras.TabIndex = 8;
            this.btnAtras.Text = "ATRÁS";
            this.btnAtras.TextColor = System.Drawing.Color.Black;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // Lecturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(954, 583);
            this.Controls.Add(this.btnSig);
            this.Controls.Add(this.ImagenPrincipal);
            this.Controls.Add(this.CajaLectura);
            this.Controls.Add(this.PnlVol);
            this.Controls.Add(this.btnVolumen);
            this.Controls.Add(this.CajaLogo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAtras);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(970, 622);
            this.Name = "Lecturas";
            this.Text = "Lecturas";
            this.Load += new System.EventHandler(this.Lecturas_Load);
            this.PnlVol.ResumeLayout(false);
            this.PnlVol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbVolumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CajaLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.EControls.EButton btnAtras;
        private CustomControls.EControls.EButton btnSalir;
        private System.Windows.Forms.PictureBox CajaLogo;
        private CustomControls.EControls.EButton btnVolumen;
        private System.Windows.Forms.Panel PnlVol;
        private System.Windows.Forms.TrackBar trbVolumen;
        private System.Windows.Forms.Label lblVol;
        private System.Windows.Forms.ListBox CajaLectura;
        private System.Windows.Forms.PictureBox ImagenPrincipal;
        private CustomControls.EControls.EButton btnSig;
    }
}