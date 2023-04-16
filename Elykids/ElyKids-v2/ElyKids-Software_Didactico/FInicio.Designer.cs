namespace ElyKids_Software_Didactico
{
    partial class FInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FInicio));
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.PnlVol = new System.Windows.Forms.Panel();
            this.trbVolumen = new System.Windows.Forms.TrackBar();
            this.lblVol = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolumen = new CustomControls.EControls.EButton();
            this.btnSalir = new CustomControls.EControls.EButton();
            this.btnInicio = new CustomControls.EControls.EButton();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.PnlVol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbVolumen)).BeginInit();
            this.SuspendLayout();
            // 
            // WMP
            // 
            this.WMP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(2, 0);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(170, 117);
            this.WMP.TabIndex = 0;
            this.WMP.TabStop = false;
            this.WMP.Visible = false;
            this.WMP.Enter += new System.EventHandler(this.WMP_Enter);
            // 
            // PnlVol
            // 
            this.PnlVol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PnlVol.Controls.Add(this.trbVolumen);
            this.PnlVol.Controls.Add(this.lblVol);
            this.PnlVol.Location = new System.Drawing.Point(67, 375);
            this.PnlVol.Name = "PnlVol";
            this.PnlVol.Size = new System.Drawing.Size(247, 50);
            this.PnlVol.TabIndex = 4;
            this.PnlVol.Visible = false;
            // 
            // trbVolumen
            // 
            this.trbVolumen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trbVolumen.Location = new System.Drawing.Point(3, 3);
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
            this.lblVol.Location = new System.Drawing.Point(189, 15);
            this.lblVol.Name = "lblVol";
            this.lblVol.Size = new System.Drawing.Size(54, 20);
            this.lblVol.TabIndex = 0;
            this.lblVol.Text = "100%";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Software Educativo Didáctico-Interactivo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnVolumen
            // 
            this.btnVolumen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.btnVolumen.Location = new System.Drawing.Point(12, 375);
            this.btnVolumen.Name = "btnVolumen";
            this.btnVolumen.Size = new System.Drawing.Size(49, 41);
            this.btnVolumen.TabIndex = 3;
            this.btnVolumen.TextColor = System.Drawing.Color.Black;
            this.btnVolumen.UseVisualStyleBackColor = false;
            this.btnVolumen.Click += new System.EventHandler(this.btnVolumen_Click_1);
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
            this.btnSalir.Location = new System.Drawing.Point(675, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(55, 51);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "x";
            this.btnSalir.TextColor = System.Drawing.Color.Black;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnInicio.BorderColor = System.Drawing.Color.Black;
            this.btnInicio.BorderRadius = 50;
            this.btnInicio.BorderSize = 5;
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Tahoma", 23F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.Black;
            this.btnInicio.Image = global::ElyKids_Software_Didactico.Properties.Resources.tocarAncho;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(501, 313);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(229, 103);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "INICIAR";
            this.btnInicio.TextColor = System.Drawing.Color.Black;
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.eButton1_Click);
            // 
            // FInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ElyKids_Software_Didactico.Properties.Resources.Pantalla_de_inicio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(742, 428);
            this.Controls.Add(this.PnlVol);
            this.Controls.Add(this.btnVolumen);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.WMP);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(758, 467);
            this.Name = "FInicio";
            this.Text = "FInicio";
            this.Load += new System.EventHandler(this.FInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.PnlVol.ResumeLayout(false);
            this.PnlVol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbVolumen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private CustomControls.EControls.EButton btnInicio;
        private CustomControls.EControls.EButton btnSalir;
        private CustomControls.EControls.EButton btnVolumen;
        private System.Windows.Forms.Panel PnlVol;
        private System.Windows.Forms.TrackBar trbVolumen;
        private System.Windows.Forms.Label lblVol;
        private System.Windows.Forms.Label label1;
    }
}