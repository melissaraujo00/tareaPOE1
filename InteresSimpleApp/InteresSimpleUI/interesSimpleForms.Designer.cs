namespace InteresSimpleUI
{
    partial class IteresSimpleForms
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
            components = new System.ComponentModel.Container();
            tituloLabel = new Label();
            capitalLabel = new Label();
            capitalTextBox = new TextBox();
            capitalErrorLabel = new Label();
            tasaInteresTextBox = new TextBox();
            tasaInteresLabel = new Label();
            tasaInteresErrorLabel = new Label();
            tiempoTextBox = new TextBox();
            label1 = new Label();
            CalcularButton = new Button();
            tiempoErrorLabel = new Label();
            provedorError = new ErrorProvider(components);
            resultadoLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)provedorError).BeginInit();
            SuspendLayout();
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Font = new Font("Segoe UI Black", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tituloLabel.Location = new Point(188, 46);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new Size(710, 70);
            tituloLabel.TabIndex = 0;
            tituloLabel.Text = "Calculadora Interes Simple";
            // 
            // capitalLabel
            // 
            capitalLabel.AutoSize = true;
            capitalLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            capitalLabel.Location = new Point(255, 155);
            capitalLabel.Name = "capitalLabel";
            capitalLabel.Size = new Size(107, 32);
            capitalLabel.TabIndex = 1;
            capitalLabel.Text = "Capital: ";
            // 
            // capitalTextBox
            // 
            capitalTextBox.Location = new Point(402, 156);
            capitalTextBox.Name = "capitalTextBox";
            capitalTextBox.Size = new Size(397, 31);
            capitalTextBox.TabIndex = 2;
            capitalTextBox.Validating += capitalTextBox_Validating;
            // 
            // capitalErrorLabel
            // 
            capitalErrorLabel.AutoSize = true;
            capitalErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            capitalErrorLabel.ForeColor = Color.FromArgb(255, 128, 128);
            capitalErrorLabel.Location = new Point(403, 195);
            capitalErrorLabel.Name = "capitalErrorLabel";
            capitalErrorLabel.Size = new Size(0, 25);
            capitalErrorLabel.TabIndex = 3;
            // 
            // tasaInteresTextBox
            // 
            tasaInteresTextBox.Location = new Point(403, 250);
            tasaInteresTextBox.Name = "tasaInteresTextBox";
            tasaInteresTextBox.Size = new Size(397, 31);
            tasaInteresTextBox.TabIndex = 5;
            tasaInteresTextBox.Validating += tasaInteresTextBox_Validating;
            // 
            // tasaInteresLabel
            // 
            tasaInteresLabel.AutoSize = true;
            tasaInteresLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tasaInteresLabel.Location = new Point(163, 247);
            tasaInteresLabel.Name = "tasaInteresLabel";
            tasaInteresLabel.Size = new Size(198, 32);
            tasaInteresLabel.TabIndex = 4;
            tasaInteresLabel.Text = "Tasa de Interes: ";
            // 
            // tasaInteresErrorLabel
            // 
            tasaInteresErrorLabel.AutoSize = true;
            tasaInteresErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            tasaInteresErrorLabel.ForeColor = Color.FromArgb(255, 128, 128);
            tasaInteresErrorLabel.Location = new Point(405, 296);
            tasaInteresErrorLabel.Name = "tasaInteresErrorLabel";
            tasaInteresErrorLabel.Size = new Size(0, 25);
            tasaInteresErrorLabel.TabIndex = 6;
            // 
            // tiempoTextBox
            // 
            tiempoTextBox.Location = new Point(402, 344);
            tiempoTextBox.Name = "tiempoTextBox";
            tiempoTextBox.Size = new Size(227, 31);
            tiempoTextBox.TabIndex = 8;
            tiempoTextBox.Validating += tiempoTextBox_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(104, 341);
            label1.Name = "label1";
            label1.Size = new Size(258, 32);
            label1.TabIndex = 7;
            label1.Text = "Cantidad de Tiempo: ";
            // 
            // CalcularButton
            // 
            CalcularButton.Location = new Point(402, 457);
            CalcularButton.Name = "CalcularButton";
            CalcularButton.Size = new Size(255, 34);
            CalcularButton.TabIndex = 10;
            CalcularButton.Text = "Calcular";
            CalcularButton.UseVisualStyleBackColor = true;
            CalcularButton.Click += CalcularButton_Click;
            // 
            // tiempoErrorLabel
            // 
            tiempoErrorLabel.AutoSize = true;
            tiempoErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            tiempoErrorLabel.ForeColor = Color.FromArgb(255, 128, 128);
            tiempoErrorLabel.Location = new Point(404, 382);
            tiempoErrorLabel.Name = "tiempoErrorLabel";
            tiempoErrorLabel.Size = new Size(0, 25);
            tiempoErrorLabel.TabIndex = 11;
            // 
            // provedorError
            // 
            provedorError.ContainerControl = this;
            // 
            // resultadoLabel
            // 
            resultadoLabel.AutoSize = true;
            resultadoLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultadoLabel.Location = new Point(401, 563);
            resultadoLabel.Name = "resultadoLabel";
            resultadoLabel.Size = new Size(0, 32);
            resultadoLabel.TabIndex = 12;
            // 
            // IteresSimpleForms
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 684);
            Controls.Add(resultadoLabel);
            Controls.Add(tiempoErrorLabel);
            Controls.Add(CalcularButton);
            Controls.Add(tiempoTextBox);
            Controls.Add(label1);
            Controls.Add(tasaInteresErrorLabel);
            Controls.Add(tasaInteresTextBox);
            Controls.Add(tasaInteresLabel);
            Controls.Add(capitalErrorLabel);
            Controls.Add(capitalTextBox);
            Controls.Add(capitalLabel);
            Controls.Add(tituloLabel);
            Name = "IteresSimpleForms";
            Text = "interesSimpleForms";
            FormClosing += IteresSimpleForms_FormClosing;
            ((System.ComponentModel.ISupportInitialize)provedorError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloLabel;
        private Label capitalLabel;
        private TextBox capitalTextBox;
        private Label capitalErrorLabel;
        private TextBox tasaInteresTextBox;
        private Label tasaInteresLabel;
        private Label tasaInteresErrorLabel;
        private TextBox tiempoTextBox;
        private Label label1;
        private Button CalcularButton;
        private Label tiempoErrorLabel;
        private ErrorProvider provedorError;
        private Label resultadoLabel;
    }
}