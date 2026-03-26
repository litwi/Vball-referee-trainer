namespace Vball_referee_trainer
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
            this.GenerateButton = new Button();
            CorrectButton = new Button();
            IncorrectButton = new Button();
            SuspendLayout();
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new Point(142, 357);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new Size(111, 39);
            this.GenerateButton.TabIndex = 0;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            // 
            // CorrectButton
            // 
            CorrectButton.Location = new Point(316, 357);
            CorrectButton.Name = "CorrectButton";
            CorrectButton.Size = new Size(109, 39);
            CorrectButton.TabIndex = 1;
            CorrectButton.Text = "Correct";
            CorrectButton.UseVisualStyleBackColor = true;
            // 
            // IncorrectButton
            // 
            IncorrectButton.Location = new Point(458, 357);
            IncorrectButton.Name = "IncorrectButton";
            IncorrectButton.Size = new Size(109, 39);
            IncorrectButton.TabIndex = 2;
            IncorrectButton.Text = "Incorrect";
            IncorrectButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(IncorrectButton);
            Controls.Add(CorrectButton);
            Controls.Add(this.GenerateButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button GenerateButton;
        private Button CorrectButton;
        private Button IncorrectButton;
    }
}
