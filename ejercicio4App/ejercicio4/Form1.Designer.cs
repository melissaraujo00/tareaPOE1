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
            firstStringLabel = new Label();
            firstStringTextBox = new TextBox();
            secondStringTextBox = new TextBox();
            secondStringLabel = new Label();
            buttonCompString = new Button();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // firstStringLabel
            // 
            firstStringLabel.AutoSize = true;
            firstStringLabel.Location = new Point(124, 69);
            firstStringLabel.Name = "firstStringLabel";
            firstStringLabel.Size = new Size(114, 20);
            firstStringLabel.TabIndex = 0;
            firstStringLabel.Text = "Primera Cadena";
            // 
            // firstStringTextBox
            // 
            firstStringTextBox.Location = new Point(124, 109);
            firstStringTextBox.Name = "firstStringTextBox";
            firstStringTextBox.Size = new Size(125, 27);
            firstStringTextBox.TabIndex = 1;
            // 
            // secondStringTextBox
            // 
            secondStringTextBox.Location = new Point(368, 109);
            secondStringTextBox.Name = "secondStringTextBox";
            secondStringTextBox.Size = new Size(125, 27);
            secondStringTextBox.TabIndex = 3;
            // 
            // secondStringLabel
            // 
            secondStringLabel.AutoSize = true;
            secondStringLabel.Location = new Point(368, 69);
            secondStringLabel.Name = "secondStringLabel";
            secondStringLabel.Size = new Size(121, 20);
            secondStringLabel.TabIndex = 2;
            secondStringLabel.Text = "Segunda Cadena";
            // 
            // buttonCompString
            // 
            buttonCompString.Location = new Point(189, 181);
            buttonCompString.Name = "buttonCompString";
            buttonCompString.Size = new Size(94, 29);
            buttonCompString.TabIndex = 4;
            buttonCompString.Text = "Comparar";
            buttonCompString.UseVisualStyleBackColor = true;
            buttonCompString.MouseClick += buttonCompString_MouseClick;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(313, 185);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 20);
            resultLabel.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 450);
            Controls.Add(resultLabel);
            Controls.Add(buttonCompString);
            Controls.Add(secondStringTextBox);
            Controls.Add(secondStringLabel);
            Controls.Add(firstStringTextBox);
            Controls.Add(firstStringLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstStringLabel;
        private TextBox firstStringTextBox;
        private TextBox secondStringTextBox;
        private Label secondStringLabel;
        private Button buttonCompString;
        private Label resultLabel;
    }
}
