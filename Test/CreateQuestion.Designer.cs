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
            this.lAnswer = new System.Windows.Forms.Label();
            this.lQuestion = new System.Windows.Forms.Label();
            this.lTemplate = new System.Windows.Forms.Label();
            this.lCountAnswers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bCreateQuestion
            // 
            this.bCreateQuestion.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCreateQuestion.Location = new System.Drawing.Point(162, 390);
            this.bCreateQuestion.Name = "bCreateQuestion";
            this.bCreateQuestion.Size = new System.Drawing.Size(152, 48);
            this.bCreateQuestion.TabIndex = 7;
            this.bCreateQuestion.Text = "Создать";
            this.bCreateQuestion.UseVisualStyleBackColor = true;
            // 
            // lAnswer
            // 
            this.lAnswer.AutoSize = true;
            this.lAnswer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lAnswer.Location = new System.Drawing.Point(56, 226);
            this.lAnswer.Name = "lAnswer";
            this.lAnswer.Size = new System.Drawing.Size(289, 19);
            this.lAnswer.TabIndex = 8;
            this.lAnswer.Text = "Введите количество правильных ответов";
            // 
            // lQuestion
            // 
            this.lQuestion.AutoSize = true;
            this.lQuestion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lQuestion.Location = new System.Drawing.Point(56, 115);
            this.lQuestion.Name = "lQuestion";
            this.lQuestion.Size = new System.Drawing.Size(117, 19);
            this.lQuestion.TabIndex = 9;
            this.lQuestion.Text = "Введите вопрос";
            // 
            // lTemplate
            // 
            this.lTemplate.AutoSize = true;
            this.lTemplate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTemplate.Location = new System.Drawing.Point(56, 62);
            this.lTemplate.Name = "lTemplate";
            this.lTemplate.Size = new System.Drawing.Size(131, 19);
            this.lTemplate.TabIndex = 10;
            this.lTemplate.Text = "Выберите шаблон";
            // 
            // lCountAnswers
            // 
            this.lCountAnswers.AutoSize = true;
            this.lCountAnswers.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCountAnswers.Location = new System.Drawing.Point(56, 169);
            this.lCountAnswers.Name = "lCountAnswers";
            this.lCountAnswers.Size = new System.Drawing.Size(302, 19);
            this.lCountAnswers.TabIndex = 11;
            this.lCountAnswers.Text = "Введите количество возможных вариантов";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(56, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Введите правильные ответы";
            // 
            // CreateQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 466);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lCountAnswers);
            this.Controls.Add(this.lTemplate);
            this.Controls.Add(this.lQuestion);
            this.Controls.Add(this.lAnswer);
            this.Controls.Add(this.bCreateQuestion);
            this.Name = "CreateQuestion";
            this.Text = "Создание нового вопроса";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCreateQuestion;
        private System.Windows.Forms.Label lAnswer;
        private System.Windows.Forms.Label lQuestion;
        private System.Windows.Forms.Label lTemplate;
        private System.Windows.Forms.Label lCountAnswers;
        private System.Windows.Forms.Label label1;

    }
}