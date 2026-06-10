namespace _2048WinFormsApp
{
    partial class StartMenu
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
            startButton = new Button();
            welcomeWordsLabel = new Label();
            showResultsButton = new Button();
            inputNameTextBox = new TextBox();
            inputLabel = new Label();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Location = new Point(138, 162);
            startButton.Name = "startButton";
            startButton.Size = new Size(216, 64);
            startButton.TabIndex = 0;
            startButton.Text = "Начать";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // welcomeWordsLabel
            // 
            welcomeWordsLabel.AutoSize = true;
            welcomeWordsLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            welcomeWordsLabel.Location = new Point(49, 29);
            welcomeWordsLabel.Name = "welcomeWordsLabel";
            welcomeWordsLabel.Size = new Size(387, 38);
            welcomeWordsLabel.TabIndex = 1;
            welcomeWordsLabel.Text = "Добро пожаловать в 2048!";
            // 
            // showResultsButton
            // 
            showResultsButton.Location = new Point(138, 244);
            showResultsButton.Name = "showResultsButton";
            showResultsButton.Size = new Size(216, 64);
            showResultsButton.TabIndex = 2;
            showResultsButton.Text = "Показать предыдущие результаты";
            showResultsButton.UseVisualStyleBackColor = true;
            showResultsButton.Click += showResultsButton_Click;
            // 
            // inputNameTextBox
            // 
            inputNameTextBox.Location = new Point(174, 108);
            inputNameTextBox.Name = "inputNameTextBox";
            inputNameTextBox.Size = new Size(150, 31);
            inputNameTextBox.TabIndex = 3;
            // 
            // inputLabel
            // 
            inputLabel.AutoSize = true;
            inputLabel.Location = new Point(49, 114);
            inputLabel.Name = "inputLabel";
            inputLabel.Size = new Size(118, 25);
            inputLabel.TabIndex = 4;
            inputLabel.Text = "Введите имя:";
            // 
            // StartMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 529);
            Controls.Add(inputLabel);
            Controls.Add(inputNameTextBox);
            Controls.Add(showResultsButton);
            Controls.Add(welcomeWordsLabel);
            Controls.Add(startButton);
            Name = "StartMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "2048";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startButton;
        private Label welcomeWordsLabel;
        private Button showResultsButton;
        private Label inputLabel;
        public TextBox inputNameTextBox;
    }
}