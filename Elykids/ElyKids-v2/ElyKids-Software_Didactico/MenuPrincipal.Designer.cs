namespace ElyKids_Software_Didactico
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.FlowPrincipal = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSalir = new CustomControls.EControls.EButton();
            this.btnAtras = new CustomControls.EControls.EButton();
            this.btnVolumen = new CustomControls.EControls.EButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FlowPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.FlowPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.PnlVol = new System.Windows.Forms.Panel();
            this.trbVolumen = new System.Windows.Forms.TrackBar();
            this.lblVol = new System.Windows.Forms.Label();
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.FlowPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PnlVol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbVolumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.SuspendLayout();
            // 
            // FlowPrincipal
            // 
            this.FlowPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlowPrincipal.Controls.Add(this.FlowPanel1);
            this.FlowPrincipal.Controls.Add(this.FlowPanel2);
            this.FlowPrincipal.Location = new System.Drawing.Point(169, 66);
            this.FlowPrincipal.Name = "FlowPrincipal";
            this.FlowPrincipal.Size = new System.Drawing.Size(564, 320);
            this.FlowPrincipal.TabIndex = 0;
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
            this.btnSalir.Location = new System.Drawing.Point(765, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(55, 51);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "x";
            this.btnSalir.TextColor = System.Drawing.Color.Black;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            this.btnAtras.Location = new System.Drawing.Point(12, 351);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(142, 65);
            this.btnAtras.TabIndex = 7;
            this.btnAtras.Text = "ATRÁS";
            this.btnAtras.TextColor = System.Drawing.Color.Black;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
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
            this.btnVolumen.Location = new System.Drawing.Point(765, 375);
            this.btnVolumen.Name = "btnVolumen";
            this.btnVolumen.Size = new System.Drawing.Size(49, 41);
            this.btnVolumen.TabIndex = 6;
            this.btnVolumen.TextColor = System.Drawing.Color.Black;
            this.btnVolumen.UseVisualStyleBackColor = false;
            this.btnVolumen.Click += new System.EventHandler(this.btnVolumen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::ElyKids_Software_Didactico.Properties.Resources.fondo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 80);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FlowPanel1
            // 
            this.FlowPanel1.Location = new System.Drawing.Point(3, 3);
            this.FlowPanel1.Name = "FlowPanel1";
            this.FlowPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FlowPanel1.Size = new System.Drawing.Size(561, 250);
            this.FlowPanel1.TabIndex = 0;
            // 
            // FlowPanel2
            // 
            this.FlowPanel2.Location = new System.Drawing.Point(3, 259);
            this.FlowPanel2.Name = "FlowPanel2";
            this.FlowPanel2.Size = new System.Drawing.Size(561, 315);
            this.FlowPanel2.TabIndex = 1;
            this.FlowPanel2.Visible = false;
            // 
            // PnlVol
            // 
            this.PnlVol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PnlVol.Controls.Add(this.trbVolumen);
            this.PnlVol.Controls.Add(this.lblVol);
            this.PnlVol.Location = new System.Drawing.Point(511, 369);
            this.PnlVol.Name = "PnlVol";
            this.PnlVol.Size = new System.Drawing.Size(247, 50);
            this.PnlVol.TabIndex = 8;
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
            this.WMP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(12, 98);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(124, 117);
            this.WMP.TabIndex = 9;
            this.WMP.TabStop = false;
            this.WMP.Visible = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(832, 428);
            this.Controls.Add(this.WMP);
            this.Controls.Add(this.PnlVol);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnVolumen);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FlowPrincipal);
            this.MinimumSize = new System.Drawing.Size(848, 467);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.FlowPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PnlVol.ResumeLayout(false);
            this.PnlVol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbVolumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlowPrincipal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomControls.EControls.EButton btnSalir;
        private CustomControls.EControls.EButton btnVolumen;
        private CustomControls.EControls.EButton btnAtras;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel1;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel2;
        private System.Windows.Forms.Panel PnlVol;
        private System.Windows.Forms.TrackBar trbVolumen;
        private System.Windows.Forms.Label lblVol;
        private AxWMPLib.AxWindowsMediaPlayer WMP;
    }
}