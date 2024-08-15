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
            pentagonoLabel = new Label();
            trapecioLabel = new Label();
            ladoPentagonoLabel = new Label();
            ladoPentagonoTextBox = new TextBox();
            apotemaPentagonoTextBox = new TextBox();
            apotemaPentagonoLabel = new Label();
            CalcularButton = new Button();
            baseMayorTextBox = new TextBox();
            baseMayorLabel = new Label();
            baseMenorLabel = new Label();
            baseMenorTextBox = new TextBox();
            ladosParalelosLabel = new Label();
            ladosParalelosTextBox = new TextBox();
            alturaTrapecioLabel = new Label();
            alturaTrapecioTextBox = new TextBox();
            SuspendLayout();
            // 
            // pentagonoLabel
            // 
            pentagonoLabel.AutoSize = true;
            pentagonoLabel.Location = new Point(126, 88);
            pentagonoLabel.Name = "pentagonoLabel";
            pentagonoLabel.Size = new Size(80, 20);
            pentagonoLabel.TabIndex = 0;
            pentagonoLabel.Text = "Pentagono";
            // 
            // trapecioLabel
            // 
            trapecioLabel.AutoSize = true;
            trapecioLabel.Location = new Point(532, 88);
            trapecioLabel.Name = "trapecioLabel";
            trapecioLabel.Size = new Size(66, 20);
            trapecioLabel.TabIndex = 1;
            trapecioLabel.Text = "Trapecio";
            // 
            // ladoPentagonoLabel
            // 
            ladoPentagonoLabel.AutoSize = true;
            ladoPentagonoLabel.Location = new Point(44, 159);
            ladoPentagonoLabel.Name = "ladoPentagonoLabel";
            ladoPentagonoLabel.Size = new Size(126, 20);
            ladoPentagonoLabel.TabIndex = 4;
            ladoPentagonoLabel.Text = "Longitud de lado:";
            // 
            // ladoPentagonoTextBox
            // 
            ladoPentagonoTextBox.Location = new Point(176, 159);
            ladoPentagonoTextBox.Name = "ladoPentagonoTextBox";
            ladoPentagonoTextBox.Size = new Size(125, 27);
            ladoPentagonoTextBox.TabIndex = 5;
            // 
            // apotemaPentagonoTextBox
            // 
            apotemaPentagonoTextBox.Location = new Point(176, 221);
            apotemaPentagonoTextBox.Name = "apotemaPentagonoTextBox";
            apotemaPentagonoTextBox.Size = new Size(125, 27);
            apotemaPentagonoTextBox.TabIndex = 7;
            // 
            // apotemaPentagonoLabel
            // 
            apotemaPentagonoLabel.AutoSize = true;
            apotemaPentagonoLabel.Location = new Point(96, 224);
            apotemaPentagonoLabel.Name = "apotemaPentagonoLabel";
            apotemaPentagonoLabel.Size = new Size(74, 20);
            apotemaPentagonoLabel.TabIndex = 6;
            apotemaPentagonoLabel.Text = "Apotema:";
            // 
            // CalcularButton
            // 
            CalcularButton.Location = new Point(137, 317);
            CalcularButton.Name = "CalcularButton";
            CalcularButton.Size = new Size(94, 29);
            CalcularButton.TabIndex = 8;
            CalcularButton.Text = "Calcular";
            CalcularButton.UseVisualStyleBackColor = true;
            CalcularButton.Click += CalcularButton_Click;
            // 
            // baseMayorTextBox
            // 
            baseMayorTextBox.Location = new Point(566, 136);
            baseMayorTextBox.Name = "baseMayorTextBox";
            baseMayorTextBox.Size = new Size(125, 27);
            baseMayorTextBox.TabIndex = 9;
            // 
            // baseMayorLabel
            // 
            baseMayorLabel.AutoSize = true;
            baseMayorLabel.Location = new Point(460, 139);
            baseMayorLabel.Name = "baseMayorLabel";
            baseMayorLabel.Size = new Size(89, 20);
            baseMayorLabel.TabIndex = 10;
            baseMayorLabel.Text = "Base Mayor:";
            // 
            // baseMenorLabel
            // 
            baseMenorLabel.AutoSize = true;
            baseMenorLabel.Location = new Point(460, 183);
            baseMenorLabel.Name = "baseMenorLabel";
            baseMenorLabel.Size = new Size(90, 20);
            baseMenorLabel.TabIndex = 12;
            baseMenorLabel.Text = "Base Menor:";
            // 
            // baseMenorTextBox
            // 
            baseMenorTextBox.Location = new Point(566, 183);
            baseMenorTextBox.Name = "baseMenorTextBox";
            baseMenorTextBox.Size = new Size(125, 27);
            baseMenorTextBox.TabIndex = 11;
            // 
            // ladosParalelosLabel
            // 
            ladosParalelosLabel.AutoSize = true;
            ladosParalelosLabel.Location = new Point(434, 228);
            ladosParalelosLabel.Name = "ladosParalelosLabel";
            ladosParalelosLabel.Size = new Size(116, 20);
            ladosParalelosLabel.TabIndex = 14;
            ladosParalelosLabel.Text = "Lados paralelos:";
            // 
            // ladosParalelosTextBox
            // 
            ladosParalelosTextBox.Location = new Point(566, 228);
            ladosParalelosTextBox.Name = "ladosParalelosTextBox";
            ladosParalelosTextBox.Size = new Size(125, 27);
            ladosParalelosTextBox.TabIndex = 13;
            // 
            // alturaTrapecioLabel
            // 
            alturaTrapecioLabel.AutoSize = true;
            alturaTrapecioLabel.Location = new Point(484, 275);
            alturaTrapecioLabel.Name = "alturaTrapecioLabel";
            alturaTrapecioLabel.Size = new Size(52, 20);
            alturaTrapecioLabel.TabIndex = 16;
            alturaTrapecioLabel.Text = "Altura:";
            // 
            // alturaTrapecioTextBox
            // 
            alturaTrapecioTextBox.Location = new Point(566, 275);
            alturaTrapecioTextBox.Name = "alturaTrapecioTextBox";
            alturaTrapecioTextBox.Size = new Size(125, 27);
            alturaTrapecioTextBox.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(alturaTrapecioLabel);
            Controls.Add(alturaTrapecioTextBox);
            Controls.Add(ladosParalelosLabel);
            Controls.Add(ladosParalelosTextBox);
            Controls.Add(baseMenorLabel);
            Controls.Add(baseMenorTextBox);
            Controls.Add(baseMayorLabel);
            Controls.Add(baseMayorTextBox);
            Controls.Add(CalcularButton);
            Controls.Add(apotemaPentagonoTextBox);
            Controls.Add(apotemaPentagonoLabel);
            Controls.Add(ladoPentagonoTextBox);
            Controls.Add(ladoPentagonoLabel);
            Controls.Add(trapecioLabel);
            Controls.Add(pentagonoLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label pentagonoLabel;
        private Label trapecioLabel;
        private Label ladoPentagonoLabel;
        private TextBox ladoPentagonoTextBox;
        private TextBox apotemaPentagonoTextBox;
        private Label apotemaPentagonoLabel;
        private Button CalcularButton;
        private TextBox baseMayorTextBox;
        private Label baseMayorLabel;
        private Label baseMenorLabel;
        private TextBox baseMenorTextBox;
        private Label ladosParalelosLabel;
        private TextBox ladosParalelosTextBox;
        private Label alturaTrapecioLabel;
        private TextBox alturaTrapecioTextBox;
    }
}
