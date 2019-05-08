namespace Test
{
    partial class Results
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lResulteTime = new System.Windows.Forms.Label();
            this.lResulteRightAnswers = new System.Windows.Forms.Label();
            this.lResulteWrongAnswers = new System.Windows.Forms.Label();
            this.lResulteScores = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bAccept
            // 
            this.bAccept.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAccept.Location = new System.Drawing.Point(192, 278);
            this.bAccept.Name = "bAccept";
            this.bAccept.Size = new System.Drawing.Size(184, 71);
            this.bAccept.TabIndex = 4;
            this.bAccept.Text = "Продолжить";
            this.bAccept.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 27);
            this.label1.TabIndex = 15;
            this.label1.Text = "Время прохождения теста:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 27);
            this.label2.TabIndex = 16;
            this.label2.Text = "Правильных ответов:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(26, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 27);
            this.label3.TabIndex = 17;
            this.label3.Text = "Неправильных ответов:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(26, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 27);
            this.label4.TabIndex = 18;
            this.label4.Text = "Набранных баллов:";
            // 
            // lResulteTime
            // 
            this.lResulteTime.AutoSize = true;
            this.lResulteTime.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lResulteTime.Location = new System.Drawing.Point(349, 35);
            this.lResulteTime.Name = "lResulteTime";
            this.lResulteTime.Size = new System.Drawing.Size(0, 27);
            this.lResulteTime.TabIndex = 19;
            // 
            // lResulteRightAnswers
            // 
            this.lResulteRightAnswers.AutoSize = true;
            this.lResulteRightAnswers.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lResulteRightAnswers.Location = new System.Drawing.Point(349, 93);
            this.lResulteRightAnswers.Name = "lResulteRightAnswers";
            this.lResulteRightAnswers.Size = new System.Drawing.Size(0, 27);
            this.lResulteRightAnswers.TabIndex = 20;
            // 
            // lResulteWrongAnswers
            // 
            this.lResulteWrongAnswers.AutoSize = true;
            this.lResulteWrongAnswers.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lResulteWrongAnswers.Location = new System.Drawing.Point(349, 155);
            this.lResulteWrongAnswers.Name = "lResulteWrongAnswers";
            this.lResulteWrongAnswers.Size = new System.Drawing.Size(0, 27);
            this.lResulteWrongAnswers.TabIndex = 21;
            // 
            // lResulteScores
            // 
            this.lResulteScores.AutoSize = true;
            this.lResulteScores.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lResulteScores.Location = new System.Drawing.Point(349, 208);
            this.lResulteScores.Name = "lResulteScores";
            this.lResulteScores.Size = new System.Drawing.Size(0, 27);
            this.lResulteScores.TabIndex = 22;
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 387);
            this.Controls.Add(this.lResulteScores);
            this.Controls.Add(this.lResulteWrongAnswers);
            this.Controls.Add(this.lResulteRightAnswers);
            this.Controls.Add(this.lResulteTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bAccept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Results";
            this.Text = "Результаты";
            this.Load += new System.EventHandler(this.Results_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAccept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lResulteTime;
        private System.Windows.Forms.Label lResulteRightAnswers;
        private System.Windows.Forms.Label lResulteWrongAnswers;
        private System.Windows.Forms.Label lResulteScores;
    }
}