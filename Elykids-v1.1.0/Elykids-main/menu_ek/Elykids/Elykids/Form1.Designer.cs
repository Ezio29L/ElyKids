namespace Elykids
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEx = new Button();
            btnSt = new Button();
            label1 = new Label();
            btnMute = new Button();
            SuspendLayout();
            // 
            // btnEx
            // 
            btnEx.Location = new Point(24, 585);
            btnEx.Name = "btnEx";
            btnEx.Size = new Size(75, 23);
            btnEx.TabIndex = 0;
            btnEx.Text = "Salir";
            btnEx.UseVisualStyleBackColor = true;
            btnEx.Click += btnEx_Click;
            // 
            // btnSt
            // 
            btnSt.Location = new Point(1188, 585);
            btnSt.Name = "btnSt";
            btnSt.Size = new Size(75, 23);
            btnSt.TabIndex = 1;
            btnSt.Text = "Iniciar";
            btnSt.UseVisualStyleBackColor = true;
            btnSt.Click += btnSt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(550, 589);
            label1.Name = "label1";
            label1.Size = new Size(222, 15);
            label1.TabIndex = 2;
            label1.Text = "Software Educativo Didáctico-Interactivo";
            // 
            // btnMute
            // 
            btnMute.Location = new Point(1188, 12);
            btnMute.Name = "btnMute";
            btnMute.Size = new Size(75, 23);
            btnMute.TabIndex = 3;
            btnMute.Text = "Silenciar";
            btnMute.UseVisualStyleBackColor = true;
            btnMute.Click += btnMute_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 650);
            Controls.Add(btnMute);
            Controls.Add(label1);
            Controls.Add(btnSt);
            Controls.Add(btnEx);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEx;
        private Button btnSt;
        private Label label1;
        private Button btnMute;
    }
}