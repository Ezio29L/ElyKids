namespace Elykids
{
    partial class VenetanaInicio
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
            this.btnMute = new System.Windows.Forms.Button();
            this.btnSt = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.PanVolumen = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVolumen = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.PanVolumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolumen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMute
            // 
            this.btnMute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMute.BackColor = System.Drawing.Color.Transparent;
            this.btnMute.BackgroundImage = global::Elykids.Properties.Resources.Speaker_Icon;
            this.btnMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMute.FlatAppearance.BorderSize = 0;
            this.btnMute.ForeColor = System.Drawing.Color.Transparent;
            this.btnMute.Location = new System.Drawing.Point(12, 316);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(35, 35);
            this.btnMute.TabIndex = 0;
            this.btnMute.UseVisualStyleBackColor = false;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
            // 
            // btnSt
            // 
            this.btnSt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSt.BackColor = System.Drawing.Color.Transparent;
            this.btnSt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSt.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSt.Image = global::Elykids.Properties.Resources.tocar;
            this.btnSt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSt.Location = new System.Drawing.Point(475, 267);
            this.btnSt.Name = "btnSt";
            this.btnSt.Size = new System.Drawing.Size(163, 82);
            this.btnSt.TabIndex = 1;
            this.btnSt.Text = "Iniciar";
            this.btnSt.UseVisualStyleBackColor = false;
            this.btnSt.Click += new System.EventHandler(this.btnSt_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Image = global::Elykids.Properties.Resources.letra_x;
            this.btnSalir.Location = new System.Drawing.Point(593, 12);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(40, 40);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // PanVolumen
            // 
            this.PanVolumen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PanVolumen.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PanVolumen.Controls.Add(this.label2);
            this.PanVolumen.Controls.Add(this.tbVolumen);
            this.PanVolumen.Location = new System.Drawing.Point(49, 308);
            this.PanVolumen.Name = "PanVolumen";
            this.PanVolumen.Size = new System.Drawing.Size(234, 54);
            this.PanVolumen.TabIndex = 3;
            this.PanVolumen.Visible = false;
            this.PanVolumen.Paint += new System.Windows.Forms.PaintEventHandler(this.PanVolumen_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(178, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "100%";
            // 
            // tbVolumen
            // 
            this.tbVolumen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbVolumen.Location = new System.Drawing.Point(3, 5);
            this.tbVolumen.Maximum = 100;
            this.tbVolumen.Name = "tbVolumen";
            this.tbVolumen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbVolumen.Size = new System.Drawing.Size(175, 45);
            this.tbVolumen.TabIndex = 0;
            this.tbVolumen.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbVolumen.Value = 100;
            this.tbVolumen.Scroll += new System.EventHandler(this.tbVolumen_Scroll);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(191, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Software Educativo Didáctico-Interactivo";
            // 
            // VenetanaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Elykids.Properties.Resources.Pantalla_de_inicio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 361);
            this.Controls.Add(this.PanVolumen);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnSt);
            this.Controls.Add(this.btnMute);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(666, 400);
            this.Name = "VenetanaInicio";
            this.Text = "VenetanaInicio";
            this.Load += new System.EventHandler(this.VenetanaInicio_Load);
            this.PanVolumen.ResumeLayout(false);
            this.PanVolumen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolumen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnMute;
        private Button btnSt;
        private Button btnSalir;
        private Panel PanVolumen;
        private TrackBar tbVolumen;
        private Label label2;
        private Label label1;
    }
}