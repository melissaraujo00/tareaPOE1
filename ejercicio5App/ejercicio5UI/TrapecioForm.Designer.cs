namespace ejercicio5UI
{
    partial class TrapecioForm
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
            alturaTrapecioLabel = new Label();
            alturaTrapecioTextBox = new TextBox();
            ladosParalelosLabel = new Label();
            ladosParalelosTextBox = new TextBox();
            baseMenorLabel = new Label();
            baseMenorTextBox = new TextBox();
            baseMayorLabel = new Label();
            baseMayorTextBox = new TextBox();
            trapecioLabel = new Label();
            calcularButton = new Button();
            SuspendLayout();
            // 
            // alturaTrapecioLabel
            // 
            alturaTrapecioLabel.AutoSize = true;
            alturaTrapecioLabel.Location = new Point(165, 238);
            alturaTrapecioLabel.Name = "alturaTrapecioLabel";
            alturaTrapecioLabel.Size = new Size(52, 20);
            alturaTrapecioLabel.TabIndex = 25;
            alturaTrapecioLabel.Text = "Altura:";
            // 
            // alturaTrapecioTextBox
            // 
            alturaTrapecioTextBox.Location = new Point(247, 238);
            alturaTrapecioTextBox.Name = "alturaTrapecioTextBox";
            alturaTrapecioTextBox.Size = new Size(125, 27);
            alturaTrapecioTextBox.TabIndex = 24;
            // 
            // ladosParalelosLabel
            // 
            ladosParalelosLabel.AutoSize = true;
            ladosParalelosLabel.Location = new Point(115, 191);
            ladosParalelosLabel.Name = "ladosParalelosLabel";
            ladosParalelosLabel.Size = new Size(116, 20);
            ladosParalelosLabel.TabIndex = 23;
            ladosParalelosLabel.Text = "Lados paralelos:";
            // 
            // ladosParalelosTextBox
            // 
            ladosParalelosTextBox.Location = new Point(247, 191);
            ladosParalelosTextBox.Name = "ladosParalelosTextBox";
            ladosParalelosTextBox.Size = new Size(125, 27);
            ladosParalelosTextBox.TabIndex = 22;
            // 
            // baseMenorLabel
            // 
            baseMenorLabel.AutoSize = true;
            baseMenorLabel.Location = new Point(141, 146);
            baseMenorLabel.Name = "baseMenorLabel";
            baseMenorLabel.Size = new Size(90, 20);
            baseMenorLabel.TabIndex = 21;
            baseMenorLabel.Text = "Base Menor:";
            // 
            // baseMenorTextBox
            // 
            baseMenorTextBox.Location = new Point(247, 146);
            baseMenorTextBox.Name = "baseMenorTextBox";
            baseMenorTextBox.Size = new Size(125, 27);
            baseMenorTextBox.TabIndex = 20;
            // 
            // baseMayorLabel
            // 
            baseMayorLabel.AutoSize = true;
            baseMayorLabel.Location = new Point(141, 102);
            baseMayorLabel.Name = "baseMayorLabel";
            baseMayorLabel.Size = new Size(89, 20);
            baseMayorLabel.TabIndex = 19;
            baseMayorLabel.Text = "Base Mayor:";
            // 
            // baseMayorTextBox
            // 
            baseMayorTextBox.Location = new Point(247, 99);
            baseMayorTextBox.Name = "baseMayorTextBox";
            baseMayorTextBox.Size = new Size(125, 27);
            baseMayorTextBox.TabIndex = 18;
            // 
            // trapecioLabel
            // 
            trapecioLabel.AutoSize = true;
            trapecioLabel.Location = new Point(213, 51);
            trapecioLabel.Name = "trapecioLabel";
            trapecioLabel.Size = new Size(66, 20);
            trapecioLabel.TabIndex = 17;
            trapecioLabel.Text = "Trapecio";
            // 
            // calcularButton
            // 
            calcularButton.Location = new Point(195, 308);
            calcularButton.Name = "calcularButton";
            calcularButton.Size = new Size(94, 29);
            calcularButton.TabIndex = 26;
            calcularButton.Text = "Calcular";
            calcularButton.UseVisualStyleBackColor = true;
            calcularButton.Click += calcularButton_Click;
            // 
            // TrapecioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 402);
            Controls.Add(calcularButton);
            Controls.Add(alturaTrapecioLabel);
            Controls.Add(alturaTrapecioTextBox);
            Controls.Add(ladosParalelosLabel);
            Controls.Add(ladosParalelosTextBox);
            Controls.Add(baseMenorLabel);
            Controls.Add(baseMenorTextBox);
            Controls.Add(baseMayorLabel);
            Controls.Add(baseMayorTextBox);
            Controls.Add(trapecioLabel);
            Name = "TrapecioForm";
            Text = "TrapecioForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label alturaTrapecioLabel;
        private TextBox alturaTrapecioTextBox;
        private Label ladosParalelosLabel;
        private TextBox ladosParalelosTextBox;
        private Label baseMenorLabel;
        private TextBox baseMenorTextBox;
        private Label baseMayorLabel;
        private TextBox baseMayorTextBox;
        private Label trapecioLabel;
        private Button calcularButton;
    }
}