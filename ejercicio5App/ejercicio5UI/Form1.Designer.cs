namespace ejercicio5UI
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
            seleccionFiguraComboBox = new ComboBox();
            seleccionarButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // seleccionFiguraComboBox
            // 
            seleccionFiguraComboBox.ForeColor = Color.Gray;
            seleccionFiguraComboBox.FormattingEnabled = true;
            seleccionFiguraComboBox.Items.AddRange(new object[] { "Pentagono", "Trapecio" });
            seleccionFiguraComboBox.Location = new Point(97, 119);
            seleccionFiguraComboBox.Name = "seleccionFiguraComboBox";
            seleccionFiguraComboBox.Size = new Size(151, 28);
            seleccionFiguraComboBox.TabIndex = 9;
            // 
            // seleccionarButton
            // 
            seleccionarButton.Location = new Point(123, 176);
            seleccionarButton.Name = "seleccionarButton";
            seleccionarButton.Size = new Size(94, 29);
            seleccionarButton.TabIndex = 10;
            seleccionarButton.Text = "Seleccionar";
            seleccionarButton.UseVisualStyleBackColor = true;
            seleccionarButton.Click += seleccionarButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 70);
            label1.Name = "label1";
            label1.Size = new Size(274, 23);
            label1.TabIndex = 12;
            label1.Text = "Calculadora de Area y Perimetro ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 284);
            Controls.Add(label1);
            Controls.Add(seleccionarButton);
            Controls.Add(seleccionFiguraComboBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox seleccionFiguraComboBox;
        private Button seleccionarButton;
        private Label label1;
    }
}
