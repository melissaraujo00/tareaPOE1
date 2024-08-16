namespace ejercicio5UI
{
    partial class PentagonoForm
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
            apotemaTextBox = new TextBox();
            apotemaLabel = new Label();
            longitudLadoTextBox = new TextBox();
            longitudLadoLabel = new Label();
            pentagonoLabel = new Label();
            calcularButton = new Button();
            SuspendLayout();
            // 
            // apotemaTextBox
            // 
            apotemaTextBox.Location = new Point(230, 188);
            apotemaTextBox.Name = "apotemaTextBox";
            apotemaTextBox.Size = new Size(155, 27);
            apotemaTextBox.TabIndex = 12;
            // 
            // apotemaLabel
            // 
            apotemaLabel.AutoSize = true;
            apotemaLabel.Location = new Point(150, 191);
            apotemaLabel.Name = "apotemaLabel";
            apotemaLabel.Size = new Size(74, 20);
            apotemaLabel.TabIndex = 11;
            apotemaLabel.Text = "Apotema:";
            // 
            // longitudLadoTextBox
            // 
            longitudLadoTextBox.Location = new Point(230, 126);
            longitudLadoTextBox.Name = "longitudLadoTextBox";
            longitudLadoTextBox.Size = new Size(155, 27);
            longitudLadoTextBox.TabIndex = 10;
            // 
            // longitudLadoLabel
            // 
            longitudLadoLabel.AutoSize = true;
            longitudLadoLabel.Location = new Point(98, 126);
            longitudLadoLabel.Name = "longitudLadoLabel";
            longitudLadoLabel.Size = new Size(126, 20);
            longitudLadoLabel.TabIndex = 9;
            longitudLadoLabel.Text = "Longitud de lado:";
            // 
            // pentagonoLabel
            // 
            pentagonoLabel.AutoSize = true;
            pentagonoLabel.Location = new Point(180, 55);
            pentagonoLabel.Name = "pentagonoLabel";
            pentagonoLabel.Size = new Size(80, 20);
            pentagonoLabel.TabIndex = 8;
            pentagonoLabel.Text = "Pentagono";
            // 
            // calcularButton
            // 
            calcularButton.Location = new Point(196, 252);
            calcularButton.Name = "calcularButton";
            calcularButton.Size = new Size(94, 29);
            calcularButton.TabIndex = 13;
            calcularButton.Text = "Calcular";
            calcularButton.UseVisualStyleBackColor = true;
            calcularButton.Click += calcularButton_Click;
            // 
            // PentagonoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 370);
            Controls.Add(calcularButton);
            Controls.Add(apotemaTextBox);
            Controls.Add(apotemaLabel);
            Controls.Add(longitudLadoTextBox);
            Controls.Add(longitudLadoLabel);
            Controls.Add(pentagonoLabel);
            Name = "PentagonoForm";
            Text = "PentagonoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox apotemaTextBox;
        private Label apotemaLabel;
        private TextBox longitudLadoTextBox;
        private Label longitudLadoLabel;
        private Label pentagonoLabel;
        private Button calcularButton;
    }
}