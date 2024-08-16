namespace Ejercicio2
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
            ResultadoLabel = new Label();
            FrasetextBox = new TextBox();
            Presionarbutton = new Button();
            SuspendLayout();
            // 
            // ResultadoLabel
            // 
            ResultadoLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ResultadoLabel.AutoSize = true;
            ResultadoLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ResultadoLabel.Location = new Point(298, 126);
            ResultadoLabel.Name = "ResultadoLabel";
            ResultadoLabel.RightToLeft = RightToLeft.Yes;
            ResultadoLabel.Size = new Size(164, 22);
            ResultadoLabel.TabIndex = 0;
            ResultadoLabel.Text = "¡Escriba una frase!";
            // 
            // FrasetextBox
            // 
            FrasetextBox.BorderStyle = BorderStyle.FixedSingle;
            FrasetextBox.ForeColor = SystemColors.InfoText;
            FrasetextBox.Location = new Point(270, 162);
            FrasetextBox.Multiline = true;
            FrasetextBox.Name = "FrasetextBox";
            FrasetextBox.Size = new Size(220, 49);
            FrasetextBox.TabIndex = 1;
            // 
            // Presionarbutton
            // 
            Presionarbutton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Presionarbutton.Location = new Point(298, 230);
            Presionarbutton.Name = "Presionarbutton";
            Presionarbutton.Size = new Size(142, 32);
            Presionarbutton.TabIndex = 2;
            Presionarbutton.Text = "Comprobar";
            Presionarbutton.UseVisualStyleBackColor = true;
            Presionarbutton.Click += Presionarbutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Presionarbutton);
            Controls.Add(FrasetextBox);
            Controls.Add(ResultadoLabel);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ResultadoLabel;
        private TextBox FrasetextBox;
        private Button Presionarbutton;
        private Label label1;
    }
}
