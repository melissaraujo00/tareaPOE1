namespace Ejercicio3
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
            label1 = new Label();
            CalculartextBox = new TextBox();
            Resultadolabel = new Label();
            Calcularbutton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.Location = new Point(167, 95);
            label1.Name = "label1";
            label1.Size = new Size(286, 19);
            label1.TabIndex = 0;
            label1.Text = "Calcular cifras de una cadena de numeros";
            // 
            // CalculartextBox
            // 
            CalculartextBox.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            CalculartextBox.Location = new Point(191, 126);
            CalculartextBox.Multiline = true;
            CalculartextBox.Name = "CalculartextBox";
            CalculartextBox.Size = new Size(236, 62);
            CalculartextBox.TabIndex = 1;
            // 
            // Resultadolabel
            // 
            Resultadolabel.AutoSize = true;
            Resultadolabel.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            Resultadolabel.Location = new Point(272, 207);
            Resultadolabel.Name = "Resultadolabel";
            Resultadolabel.Size = new Size(85, 19);
            Resultadolabel.TabIndex = 2;
            Resultadolabel.Text = "Respuesta:";
            // 
            // Calcularbutton
            // 
            Calcularbutton.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            Calcularbutton.Location = new Point(191, 201);
            Calcularbutton.Name = "Calcularbutton";
            Calcularbutton.Size = new Size(75, 31);
            Calcularbutton.TabIndex = 3;
            Calcularbutton.Text = "Calcular";
            Calcularbutton.UseVisualStyleBackColor = true;
            Calcularbutton.Click += Calcularbutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Calcularbutton);
            Controls.Add(Resultadolabel);
            Controls.Add(CalculartextBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox CalculartextBox;
        private Label Resultadolabel;
        private Button Calcularbutton;
    }
}
