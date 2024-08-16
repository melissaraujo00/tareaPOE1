namespace TeclaNumeroUI
{
    partial class TeclaNumForms
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
            tituloLabel = new Label();
            teclaNumTextBox = new TextBox();
            respuestaLabel = new Label();
            SuspendLayout();
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tituloLabel.Location = new Point(201, 9);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new Size(393, 74);
            tituloLabel.TabIndex = 0;
            tituloLabel.Text = "Tecla Número";
            // 
            // teclaNumTextBox
            // 
            teclaNumTextBox.Location = new Point(63, 108);
            teclaNumTextBox.Multiline = true;
            teclaNumTextBox.Name = "teclaNumTextBox";
            teclaNumTextBox.Size = new Size(675, 231);
            teclaNumTextBox.TabIndex = 1;
            teclaNumTextBox.KeyPress += teclaNumTextBox_KeyPress;
            // 
            // respuestaLabel
            // 
            respuestaLabel.AutoSize = true;
            respuestaLabel.Location = new Point(308, 368);
            respuestaLabel.Name = "respuestaLabel";
            respuestaLabel.Size = new Size(0, 25);
            respuestaLabel.TabIndex = 2;
            // 
            // TeclaNumForms
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(respuestaLabel);
            Controls.Add(teclaNumTextBox);
            Controls.Add(tituloLabel);
            Name = "TeclaNumForms";
            Text = "TeclaNumForms";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloLabel;
        private TextBox teclaNumTextBox;
        private Label respuestaLabel;
    }
}