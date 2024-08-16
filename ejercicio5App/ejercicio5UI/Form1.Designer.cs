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
            selccionarButton = new Button();
            SuspendLayout();
            // 
            // seleccionFiguraComboBox
            // 
            seleccionFiguraComboBox.FormattingEnabled = true;
            seleccionFiguraComboBox.Items.AddRange(new object[] { "Pentagono", "Trapecio" });
            seleccionFiguraComboBox.Location = new Point(97, 98);
            seleccionFiguraComboBox.Name = "seleccionFiguraComboBox";
            seleccionFiguraComboBox.Size = new Size(151, 28);
            seleccionFiguraComboBox.TabIndex = 9;
            // 
            // selccionarButton
            // 
            selccionarButton.Location = new Point(123, 155);
            selccionarButton.Name = "selccionarButton";
            selccionarButton.Size = new Size(94, 29);
            selccionarButton.TabIndex = 10;
            selccionarButton.Text = "Seleccionar";
            selccionarButton.UseVisualStyleBackColor = true;
            selccionarButton.Click += selccionarButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 325);
            Controls.Add(selccionarButton);
            Controls.Add(seleccionFiguraComboBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private ComboBox seleccionFiguraComboBox;
        private Button selccionarButton;
    }
}
