namespace Test
{
    partial class CreateQuestion
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
            this.bCreateQuestion = new System.Windows.Forms.Button();
            this.lQuestion = new System.Windows.Forms.Label();
            this.lTemplate = new System.Windows.Forms.Label();
            this.lRightAnswer = new System.Windows.Forms.Label();
            this.cbTemplate = new System.Windows.Forms.ComboBox();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.tbRightAnswer = new System.Windows.Forms.TextBox();
            this.lWrongAnswers = new System.Windows.Forms.Label();
            this.tbWrong1 = new System.Windows.Forms.TextBox();
            this.tbWrong2 = new System.Windows.Forms.TextBox();
            this.tbWrong3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbScore = new System.Windows.Forms.ComboBox();
            this.lScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bCreateQuestion
            // 
            this.bCreateQuestion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCreateQuestion.Location = new System.Drawing.Point(74, 386);
            this.bCreateQuestion.Name = "bCreateQuestion";
            this.bCreateQuestion.Size = new System.Drawing.Size(152, 48);
            this.bCreateQuestion.TabIndex = 7;
            this.bCreateQuestion.Text = "Добавить новый вопрос";
            this.bCreateQuestion.UseVisualStyleBackColor = true;
            this.bCreateQuestion.Click += new System.EventHandler(this.bCreateQuestion_Click);
            // 
            // lQuestion
            // 
            this.lQuestion.AutoSize = true;
            this.lQuestion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lQuestion.Location = new System.Drawing.Point(12, 101);
            this.lQuestion.Name = "lQuestion";
            this.lQuestion.Size = new System.Drawing.Size(117, 19);
            this.lQuestion.TabIndex = 9;
            this.lQuestion.Text = "Введите вопрос";
            // 
            // lTemplate
            // 
            this.lTemplate.AutoSize = true;
            this.lTemplate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTemplate.Location = new System.Drawing.Point(12, 22);
            this.lTemplate.Name = "lTemplate";
            this.lTemplate.Size = new System.Drawing.Size(179, 19);
            this.lTemplate.TabIndex = 10;
            this.lTemplate.Text = "Выберите шаблон ответа";
            // 
            // lRightAnswer
            // 
            this.lRightAnswer.AutoSize = true;
            this.lRightAnswer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lRightAnswer.Location = new System.Drawing.Point(12, 213);
            this.lRightAnswer.Name = "lRightAnswer";
            this.lRightAnswer.Size = new System.Drawing.Size(195, 19);
            this.lRightAnswer.TabIndex = 12;
            this.lRightAnswer.Text = "Введите правильный ответ";
            // 
            // cbTemplate
            // 
            this.cbTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTemplate.FormattingEnabled = true;
            this.cbTemplate.Items.AddRange(new object[] {
            "Написать ответ",
            "Выбрать один из вариантов ответов",
            "Выбрать один ответ"});
            this.cbTemplate.Location = new System.Drawing.Point(222, 22);
            this.cbTemplate.Name = "cbTemplate";
            this.cbTemplate.Size = new System.Drawing.Size(234, 21);
            this.cbTemplate.TabIndex = 13;
            this.cbTemplate.SelectedIndexChanged += new System.EventHandler(this.cbTemplate_SelectedIndexChanged);
            // 
            // tbQuestion
            // 
            this.tbQuestion.Location = new System.Drawing.Point(209, 102);
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(247, 92);
            this.tbQuestion.TabIndex = 14;
            // 
            // tbRightAnswer
            // 
            this.tbRightAnswer.Location = new System.Drawing.Point(16, 235);
            this.tbRightAnswer.Name = "tbRightAnswer";
            this.tbRightAnswer.Size = new System.Drawing.Size(440, 20);
            this.tbRightAnswer.TabIndex = 17;
            // 
            // lWrongAnswers
            // 
            this.lWrongAnswers.AutoSize = true;
            this.lWrongAnswers.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lWrongAnswers.Location = new System.Drawing.Point(12, 268);
            this.lWrongAnswers.Name = "lWrongAnswers";
            this.lWrongAnswers.Size = new System.Drawing.Size(220, 19);
            this.lWrongAnswers.TabIndex = 20;
            this.lWrongAnswers.Text = "Введите неправильные ответы";
            // 
            // tbWrong1
            // 
            this.tbWrong1.Location = new System.Drawing.Point(16, 299);
            this.tbWrong1.Name = "tbWrong1";
            this.tbWrong1.Size = new System.Drawing.Size(440, 20);
            this.tbWrong1.TabIndex = 21;
            // 
            // tbWrong2
            // 
            this.tbWrong2.Location = new System.Drawing.Point(16, 325);
            this.tbWrong2.Name = "tbWrong2";
            this.tbWrong2.Size = new System.Drawing.Size(440, 20);
            this.tbWrong2.TabIndex = 22;
            // 
            // tbWrong3
            // 
            this.tbWrong3.Location = new System.Drawing.Point(16, 351);
            this.tbWrong3.Name = "tbWrong3";
            this.tbWrong3.Size = new System.Drawing.Size(440, 20);
            this.tbWrong3.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(232, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 48);
            this.button1.TabIndex = 24;
            this.button1.Text = "Завершить создание теста";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbScore
            // 
            this.cbScore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbScore.FormattingEnabled = true;
            this.cbScore.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbScore.Location = new System.Drawing.Point(222, 59);
            this.cbScore.Name = "cbScore";
            this.cbScore.Size = new System.Drawing.Size(234, 21);
            this.cbScore.TabIndex = 26;
            // 
            // lScore
            // 
            this.lScore.AutoSize = true;
            this.lScore.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lScore.Location = new System.Drawing.Point(12, 59);
            this.lScore.Name = "lScore";
            this.lScore.Size = new System.Drawing.Size(204, 19);
            this.lScore.TabIndex = 25;
            this.lScore.Text = "Баллов за правильный ответ";
            // 
            // CreateQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 484);
            this.Controls.Add(this.cbScore);
            this.Controls.Add(this.lScore);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbWrong3);
            this.Controls.Add(this.tbWrong2);
            this.Controls.Add(this.tbWrong1);
            this.Controls.Add(this.lWrongAnswers);
            this.Controls.Add(this.tbRightAnswer);
            this.Controls.Add(this.tbQuestion);
            this.Controls.Add(this.cbTemplate);
            this.Controls.Add(this.lRightAnswer);
            this.Controls.Add(this.lTemplate);
            this.Controls.Add(this.lQuestion);
            this.Controls.Add(this.bCreateQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateQuestion";
            this.Text = "Создание нового вопроса";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCreateQuestion;
        private System.Windows.Forms.Label lQuestion;
        private System.Windows.Forms.Label lTemplate;
        private System.Windows.Forms.Label lRightAnswer;
        private System.Windows.Forms.ComboBox cbTemplate;
        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.TextBox tbRightAnswer;
        private System.Windows.Forms.Label lWrongAnswers;
        private System.Windows.Forms.TextBox tbWrong1;
        private System.Windows.Forms.TextBox tbWrong2;
        private System.Windows.Forms.TextBox tbWrong3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbScore;
        private System.Windows.Forms.Label lScore;

    }
}