namespace ElyKids_Software_Didactico
{
    partial class DesplegarTutorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesplegarTutorial));
            this.btnSalir = new CustomControls.EControls.EButton();
            this.PnlVol = new System.Windows.Forms.Panel();
            this.trbVolumen = new System.Windows.Forms.TrackBar();
            this.lblVol = new System.Windows.Forms.Label();
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnPausaPlay = new CustomControls.EControls.EButton();
            this.btnVolumen = new CustomControls.EControls.EButton();
            this.btnAtras = new CustomControls.EControls.EButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlVol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbVolumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // PnlVol
            // 
            this.PnlVol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlVol.Controls.Add(this.trbVolumen);
            this.PnlVol.Controls.Add(this.lblVol);
            this.PnlVol.Location = new System.Drawing.Point(640, 521);
            this.PnlVol.Name = "PnlVol";
            this.PnlVol.Size = new System.Drawing.Size(247, 50);
            this.PnlVol.TabIndex = 11;
            this.PnlVol.Visible = false;
            // 
            // trbVolumen
            // 
            this.trbVolumen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trbVolumen.Location = new System.Drawing.Point(53, 2);
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
            this.lblVol.Location = new System.Drawing.Point(3, 15);
            this.lblVol.Name = "lblVol";
            this.lblVol.Size = new System.Drawing.Size(54, 20);
            this.lblVol.TabIndex = 0;
            this.lblVol.Text = "100%";
            // 
            // WMP
            // 
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(204, 100);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(612, 353);
            this.WMP.TabIndex = 12;
            this.WMP.TabStop = false;
            // 
            // btnPausaPlay
            // 
            this.btnPausaPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPausaPlay.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnPausaPlay.BorderColor = System.Drawing.Color.Black;
            this.btnPausaPlay.BorderRadius = 20;
            this.btnPausaPlay.BorderSize = 4;
            this.btnPausaPlay.FlatAppearance.BorderSize = 0;
            this.btnPausaPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPausaPlay.ForeColor = System.Drawing.Color.Black;
            this.btnPausaPlay.Image = global::ElyKids_Software_Didactico.Properties.Resources.boton_de_pausa;
            this.btnPausaPlay.Location = new System.Drawing.Point(204, 459);
            this.btnPausaPlay.Name = "btnPausaPlay";
            this.btnPausaPlay.Size = new System.Drawing.Size(50, 50);
            this.btnPausaPlay.TabIndex = 13;
            this.btnPausaPlay.TextColor = System.Drawing.Color.Black;
            this.btnPausaPlay.UseVisualStyleBackColor = false;
            this.btnPausaPlay.Click += new System.EventHandler(this.btnPausaPlay_Click);
            // 
            // btnVolumen
            // 
            this.btnVolumen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnVolumen.Location = new System.Drawing.Point(893, 530);
            this.btnVolumen.Name = "btnVolumen";
            this.btnVolumen.Size = new System.Drawing.Size(49, 41);
            this.btnVolumen.TabIndex = 10;
            this.btnVolumen.TextColor = System.Drawing.Color.Black;
            this.btnVolumen.UseVisualStyleBackColor = false;
            this.btnVolumen.Click += new System.EventHandler(this.btnVolumen_Click);
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::ElyKids_Software_Didactico.Properties.Resources.LOGO;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 102);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // DesplegarTutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(954, 583);
            this.Controls.Add(this.btnPausaPlay);
            this.Controls.Add(this.WMP);
            this.Controls.Add(this.PnlVol);
            this.Controls.Add(this.btnVolumen);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DesplegarTutorial";
            this.Text = "DesplegarTutorial";
            this.Load += new System.EventHandler(this.DesplegarTutorial_Load);
            this.PnlVol.ResumeLayout(false);
            this.PnlVol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbVolumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomControls.EControls.EButton btnAtras;
        private CustomControls.EControls.EButton btnSalir;
        private CustomControls.EControls.EButton btnVolumen;
        private System.Windows.Forms.Panel PnlVol;
        private System.Windows.Forms.TrackBar trbVolumen;
        private System.Windows.Forms.Label lblVol;
        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private CustomControls.EControls.EButton btnPausaPlay;
    }
}