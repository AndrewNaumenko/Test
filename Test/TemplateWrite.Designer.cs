namespace Test
{
    partial class TemplateWrite
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
            this.bAccept = new System.Windows.Forms.Button();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.lAnswer = new System.Windows.Forms.Label();
            this.lQuestion = new System.Windows.Forms.Label();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bAccept
            // 
            this.bAccept.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAccept.Location = new System.Drawing.Point(197, 283);
            this.bAccept.Name = "bAccept";
            this.bAccept.Size = new System.Drawing.Size(184, 71);
            this.bAccept.TabIndex = 24;
            this.bAccept.Text = "Продолжить";
            this.bAccept.UseVisualStyleBackColor = true;
            // 
            // tbAnswer
            // 
            this.tbAnswer.Enabled = false;
            this.tbAnswer.Location = new System.Drawing.Point(12, 194);
            this.tbAnswer.Multiline = true;
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(559, 71);
            this.tbAnswer.TabIndex = 23;
            // 
            // lAnswer
            // 
            this.lAnswer.AutoSize = true;
            this.lAnswer.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lAnswer.Location = new System.Drawing.Point(236, 164);
            this.lAnswer.Name = "lAnswer";
            this.lAnswer.Size = new System.Drawing.Size(123, 27);
            this.lAnswer.TabIndex = 22;
            this.lAnswer.Text = "Ваш ответ:";
            // 
            // lQuestion
            // 
            this.lQuestion.AutoSize = true;
            this.lQuestion.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lQuestion.Location = new System.Drawing.Point(246, 7);
            this.lQuestion.Name = "lQuestion";
            this.lQuestion.Size = new System.Drawing.Size(95, 27);
            this.lQuestion.TabIndex = 21;
            this.lQuestion.Text = "Вопрос:";
            // 
            // tbQuestion
            // 
            this.tbQuestion.Enabled = false;
            this.tbQuestion.Location = new System.Drawing.Point(12, 39);
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(559, 109);
            this.tbQuestion.TabIndex = 20;
            // 
            // TemplateWrite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 379);
            this.Controls.Add(this.bAccept);
            this.Controls.Add(this.tbAnswer);
            this.Controls.Add(this.lAnswer);
            this.Controls.Add(this.lQuestion);
            this.Controls.Add(this.tbQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TemplateWrite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAccept;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Label lAnswer;
        private System.Windows.Forms.Label lQuestion;
        private System.Windows.Forms.TextBox tbQuestion;
    }
}