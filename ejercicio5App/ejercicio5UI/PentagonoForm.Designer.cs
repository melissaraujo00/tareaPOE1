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
            apotemaPentagonoTextBox = new TextBox();
            apotemaPentagonoLabel = new Label();
            ladoPentagonoTextBox = new TextBox();
            ladoPentagonoLabel = new Label();
            pentagonoLabel = new Label();
            SuspendLayout();
            // 
            // apotemaPentagonoTextBox
            // 
            apotemaPentagonoTextBox.Location = new Point(230, 188);
            apotemaPentagonoTextBox.Name = "apotemaPentagonoTextBox";
            apotemaPentagonoTextBox.Size = new Size(155, 27);
            apotemaPentagonoTextBox.TabIndex = 12;
            // 
            // apotemaPentagonoLabel
            // 
            apotemaPentagonoLabel.AutoSize = true;
            apotemaPentagonoLabel.Location = new Point(150, 191);
            apotemaPentagonoLabel.Name = "apotemaPentagonoLabel";
            apotemaPentagonoLabel.Size = new Size(74, 20);
            apotemaPentagonoLabel.TabIndex = 11;
            apotemaPentagonoLabel.Text = "Apotema:";
            // 
            // ladoPentagonoTextBox
            // 
            ladoPentagonoTextBox.Location = new Point(230, 126);
            ladoPentagonoTextBox.Name = "ladoPentagonoTextBox";
            ladoPentagonoTextBox.Size = new Size(155, 27);
            ladoPentagonoTextBox.TabIndex = 10;
            // 
            // ladoPentagonoLabel
            // 
            ladoPentagonoLabel.AutoSize = true;
            ladoPentagonoLabel.Location = new Point(98, 126);
            ladoPentagonoLabel.Name = "ladoPentagonoLabel";
            ladoPentagonoLabel.Size = new Size(126, 20);
            ladoPentagonoLabel.TabIndex = 9;
            ladoPentagonoLabel.Text = "Longitud de lado:";
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
            // PentagonoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 370);
            Controls.Add(apotemaPentagonoTextBox);
            Controls.Add(apotemaPentagonoLabel);
            Controls.Add(ladoPentagonoTextBox);
            Controls.Add(ladoPentagonoLabel);
            Controls.Add(pentagonoLabel);
            Name = "PentagonoForm";
            Text = "PentagonoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox apotemaPentagonoTextBox;
        private Label apotemaPentagonoLabel;
        private TextBox ladoPentagonoTextBox;
        private Label ladoPentagonoLabel;
        private Label pentagonoLabel;
    }
}