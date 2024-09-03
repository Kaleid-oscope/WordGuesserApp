namespace WordGuessApplication
{
    partial class Form1
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            click = new Button();
            Answer = new TextBox();
            Result = new Label();
            Choice = new Label();
            History = new ListBox();
            Prompts = new ListBox();
            SuspendLayout();
            // 
            // click
            // 
            click.BackColor = Color.DarkSeaGreen;
            click.FlatStyle = FlatStyle.Flat;
            click.Font = new Font("Segoe UI", 12F);
            click.ForeColor = Color.White;
            click.Location = new Point(227, 152);
            click.Name = "click";
            click.Size = new Size(151, 86);
            click.TabIndex = 0;
            click.Text = "Run";
            click.UseVisualStyleBackColor = false;
            click.Click += button1_Click;
            // 
            // Answer
            // 
            Answer.Font = new Font("Segoe UI", 14F);
            Answer.Location = new Point(227, 69);
            Answer.Name = "Answer";
            Answer.Size = new Size(151, 32);
            Answer.TabIndex = 1;
            Answer.TextChanged += Answer_TextChanged;
            // 
            // Result
            // 
            Result.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Result.Location = new Point(227, 113);
            Result.Name = "Result";
            Result.Size = new Size(151, 21);
            Result.TabIndex = 2;
            Result.Text = "Results here...";
            Result.TextAlign = ContentAlignment.MiddleCenter;
            Result.Click += label1_Click;
            // 
            // Choice
            // 
            Choice.BackColor = SystemColors.ButtonHighlight;
            Choice.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Choice.Location = new Point(12, 9);
            Choice.Name = "Choice";
            Choice.Size = new Size(139, 229);
            Choice.TabIndex = 5;
            Choice.Text = "Choices: \r\nApple\r\nBanana\r\nAvocado\r\nApricot\r\nPeach\r\nOrange\r\nMango\r\n";
            Choice.Click += label3_Click;
            // 
            // History
            // 
            History.Font = new Font("Segoe UI", 10F);
            History.FormattingEnabled = true;
            History.ItemHeight = 17;
            History.Location = new Point(470, 209);
            History.Name = "History";
            History.Size = new Size(318, 191);
            History.TabIndex = 6;
            History.SelectedIndexChanged += AnswerList_SelectedIndexChanged;
            // 
            // Prompts
            // 
            Prompts.Font = new Font("Segoe UI", 10F);
            Prompts.FormattingEnabled = true;
            Prompts.ItemHeight = 17;
            Prompts.Location = new Point(470, 12);
            Prompts.Name = "Prompts";
            Prompts.Size = new Size(318, 191);
            Prompts.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(Prompts);
            Controls.Add(History);
            Controls.Add(Choice);
            Controls.Add(Result);
            Controls.Add(Answer);
            Controls.Add(click);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button click;
        private TextBox Answer;
        private Label Result;
        private Label Choice;
        private ListBox History;
        private ListBox Prompts;
    }
}
