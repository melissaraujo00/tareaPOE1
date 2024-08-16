namespace ejercicio4
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
            primeraCadenaLabel = new Label();
            primeraCadenaTextBox = new TextBox();
            segundaCadenaTextBox = new TextBox();
            segundaCadenaLabel = new Label();
            resultLabel = new Label();
            compararButton = new Button();
            tituloLabel = new Label();
            SuspendLayout();
            // 
            // primeraCadenaLabel
            // 
            primeraCadenaLabel.AutoSize = true;
            primeraCadenaLabel.Location = new Point(68, 92);
            primeraCadenaLabel.Name = "primeraCadenaLabel";
            primeraCadenaLabel.Size = new Size(114, 20);
            primeraCadenaLabel.TabIndex = 0;
            primeraCadenaLabel.Text = "Primera Cadena";
            // 
            // primeraCadenaTextBox
            // 
            primeraCadenaTextBox.Location = new Point(68, 132);
            primeraCadenaTextBox.Name = "primeraCadenaTextBox";
            primeraCadenaTextBox.Size = new Size(125, 27);
            primeraCadenaTextBox.TabIndex = 1;
            // 
            // segundaCadenaTextBox
            // 
            segundaCadenaTextBox.Location = new Point(312, 132);
            segundaCadenaTextBox.Name = "segundaCadenaTextBox";
            segundaCadenaTextBox.Size = new Size(125, 27);
            segundaCadenaTextBox.TabIndex = 3;
            // 
            // segundaCadenaLabel
            // 
            segundaCadenaLabel.AutoSize = true;
            segundaCadenaLabel.Location = new Point(312, 92);
            segundaCadenaLabel.Name = "segundaCadenaLabel";
            segundaCadenaLabel.Size = new Size(121, 20);
            segundaCadenaLabel.TabIndex = 2;
            segundaCadenaLabel.Text = "Segunda Cadena";
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(179, 236);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 20);
            resultLabel.TabIndex = 5;
            // 
            // compararButton
            // 
            compararButton.Location = new Point(197, 182);
            compararButton.Name = "compararButton";
            compararButton.Size = new Size(94, 29);
            compararButton.TabIndex = 6;
            compararButton.Text = "Comparar Cadenas";
            compararButton.UseVisualStyleBackColor = true;
            compararButton.Click += compararButton_Click;
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Location = new Point(179, 28);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new Size(179, 20);
            tituloLabel.TabIndex = 7;
            tituloLabel.Text = "Comparación de Cadenas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 292);
            Controls.Add(tituloLabel);
            Controls.Add(compararButton);
            Controls.Add(resultLabel);
            Controls.Add(segundaCadenaTextBox);
            Controls.Add(segundaCadenaLabel);
            Controls.Add(primeraCadenaTextBox);
            Controls.Add(primeraCadenaLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label primeraCadenaLabel;
        private TextBox primeraCadenaTextBox;
        private TextBox segundaCadenaTextBox;
        private Label segundaCadenaLabel;
        private Label resultLabel;
        private Button compararButton;
        private Label tituloLabel;
    }
}
