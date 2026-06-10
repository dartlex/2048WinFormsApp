namespace _2048WinFormsApp
{
    partial class mainForm
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
            scoreLabel = new Label();
            label2 = new Label();
            playerLabel = new Label();
            userNameLabel = new Label();
            SuspendLayout();
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new Point(71, 20);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(22, 25);
            scoreLabel.TabIndex = 0;
            scoreLabel.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 20);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 1;
            label2.Text = "Счет:";
            // 
            // playerLabel
            // 
            playerLabel.AutoSize = true;
            playerLabel.Location = new Point(206, 20);
            playerLabel.Name = "playerLabel";
            playerLabel.Size = new Size(67, 25);
            playerLabel.TabIndex = 2;
            playerLabel.Text = "Игрок:";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(300, 20);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(19, 25);
            userNameLabel.TabIndex = 3;
            userNameLabel.Text = "-";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 458);
            Controls.Add(userNameLabel);
            Controls.Add(playerLabel);
            Controls.Add(label2);
            Controls.Add(scoreLabel);
            Margin = new Padding(4);
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "2048";
            Load += Form1_Load;
            KeyDown += mainForm_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label scoreLabel;
        private Label label2;
        private Label playerLabel;
        private Label userNameLabel;
    }
}
