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
            ladosParalelosTextBox = new TextBox();
            baseMenorLabel = new Label();
            baseMenorTextBox = new TextBox();
            baseMayorLabel = new Label();
            baseMayorTextBox = new TextBox();
            tituloTrapecioLabel = new Label();
            calcularButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // alturaTrapecioLabel
            // 
            alturaTrapecioLabel.AutoSize = true;
            alturaTrapecioLabel.Location = new Point(178, 241);
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
            baseMenorLabel.Location = new Point(141, 149);
            baseMenorLabel.Name = "baseMenorLabel";
            baseMenorLabel.Size = new Size(90, 20);
            baseMenorLabel.TabIndex = 21;
            baseMenorLabel.Text = "Base Menor:";
            // 
            // baseMenorTextBox
            // 
            baseMenorTextBox.Location = new Point(247, 149);
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
            // tituloTrapecioLabel
            // 
            tituloTrapecioLabel.AutoSize = true;
            tituloTrapecioLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tituloTrapecioLabel.Location = new Point(97, 46);
            tituloTrapecioLabel.Name = "tituloTrapecioLabel";
            tituloTrapecioLabel.Size = new Size(337, 23);
            tituloTrapecioLabel.TabIndex = 17;
            tituloTrapecioLabel.Text = "Calcular Area y Perimetro de un Trapecio";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 198);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 27;
            label1.Text = "Lados paralelos:";
            // 
            // TrapecioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 402);
            Controls.Add(label1);
            Controls.Add(calcularButton);
            Controls.Add(alturaTrapecioLabel);
            Controls.Add(alturaTrapecioTextBox);
            Controls.Add(ladosParalelosTextBox);
            Controls.Add(baseMenorLabel);
            Controls.Add(baseMenorTextBox);
            Controls.Add(baseMayorLabel);
            Controls.Add(baseMayorTextBox);
            Controls.Add(tituloTrapecioLabel);
            Name = "TrapecioForm";
            Text = "TrapecioForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label alturaTrapecioLabel;
        private TextBox alturaTrapecioTextBox;
        private TextBox ladosParalelosTextBox;
        private Label baseMenorLabel;
        private TextBox baseMenorTextBox;
        private Label baseMayorLabel;
        private TextBox baseMayorTextBox;
        private Label tituloTrapecioLabel;
        private Button calcularButton;
        private Label label1;
    }
}