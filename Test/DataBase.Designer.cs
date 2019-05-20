namespace Test
{
    partial class DataBase
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
            this.rbUser = new System.Windows.Forms.RadioButton();
            this.rbTest = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bdelTest = new System.Windows.Forms.Button();
            this.lResulteScores = new System.Windows.Forms.Label();
            this.lResulteWrongAnswers = new System.Windows.Forms.Label();
            this.lResulteRightAnswers = new System.Windows.Forms.Label();
            this.lResulteTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.lResultDate = new System.Windows.Forms.Label();
            this.ldate = new System.Windows.Forms.Label();
            this.bdelUser = new System.Windows.Forms.Button();
            this.bEditTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbUser
            // 
            this.rbUser.AutoSize = true;
            this.rbUser.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbUser.Location = new System.Drawing.Point(12, 12);
            this.rbUser.Name = "rbUser";
            this.rbUser.Size = new System.Drawing.Size(150, 27);
            this.rbUser.TabIndex = 21;
            this.rbUser.TabStop = true;
            this.rbUser.Text = "Пользователи";
            this.rbUser.UseVisualStyleBackColor = true;
            this.rbUser.CheckedChanged += new System.EventHandler(this.rbUser_CheckedChanged);
            // 
            // rbTest
            // 
            this.rbTest.AutoSize = true;
            this.rbTest.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbTest.Location = new System.Drawing.Point(12, 45);
            this.rbTest.Name = "rbTest";
            this.rbTest.Size = new System.Drawing.Size(81, 27);
            this.rbTest.TabIndex = 22;
            this.rbTest.TabStop = true;
            this.rbTest.Text = "Тесты";
            this.rbTest.UseVisualStyleBackColor = true;
            this.rbTest.CheckedChanged += new System.EventHandler(this.rbTest_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 78);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(214, 433);
            this.listBox1.TabIndex = 23;
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // bdelTest
            // 
            this.bdelTest.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bdelTest.Location = new System.Drawing.Point(236, 403);
            this.bdelTest.Name = "bdelTest";
            this.bdelTest.Size = new System.Drawing.Size(150, 54);
            this.bdelTest.TabIndex = 25;
            this.bdelTest.Text = "Удалить тест";
            this.bdelTest.UseVisualStyleBackColor = true;
            this.bdelTest.Click += new System.EventHandler(this.bdelTest_Click);
            // 
            // lResulteScores
            // 
            this.lResulteScores.AutoSize = true;
            this.lResulteScores.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lResulteScores.Location = new System.Drawing.Point(447, 349);
            this.lResulteScores.Name = "lResulteScores";
            this.lResulteScores.Size = new System.Drawing.Size(0, 19);
            this.lResulteScores.TabIndex = 33;
            // 
            // lResulteWrongAnswers
            // 
            this.lResulteWrongAnswers.AutoSize = true;
            this.lResulteWrongAnswers.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lResulteWrongAnswers.Location = new System.Drawing.Point(447, 321);
            this.lResulteWrongAnswers.Name = "lResulteWrongAnswers";
            this.lResulteWrongAnswers.Size = new System.Drawing.Size(0, 19);
            this.lResulteWrongAnswers.TabIndex = 32;
            // 
            // lResulteRightAnswers
            // 
            this.lResulteRightAnswers.AutoSize = true;
            this.lResulteRightAnswers.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lResulteRightAnswers.Location = new System.Drawing.Point(447, 290);
            this.lResulteRightAnswers.Name = "lResulteRightAnswers";
            this.lResulteRightAnswers.Size = new System.Drawing.Size(0, 19);
            this.lResulteRightAnswers.TabIndex = 31;
            // 
            // lResulteTime
            // 
            this.lResulteTime.AutoSize = true;
            this.lResulteTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lResulteTime.Location = new System.Drawing.Point(447, 260);
            this.lResulteTime.Name = "lResulteTime";
            this.lResulteTime.Size = new System.Drawing.Size(0, 19);
            this.lResulteTime.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(232, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "Набранных баллов:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(232, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "Неправильных ответов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(232, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "Правильных ответов:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(232, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "Время прохождения теста:";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(236, 84);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(333, 160);
            this.listBox2.TabIndex = 34;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // lResultDate
            // 
            this.lResultDate.AutoSize = true;
            this.lResultDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lResultDate.Location = new System.Drawing.Point(447, 377);
            this.lResultDate.Name = "lResultDate";
            this.lResultDate.Size = new System.Drawing.Size(0, 19);
            this.lResultDate.TabIndex = 36;
            // 
            // ldate
            // 
            this.ldate.AutoSize = true;
            this.ldate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ldate.Location = new System.Drawing.Point(232, 377);
            this.ldate.Name = "ldate";
            this.ldate.Size = new System.Drawing.Size(177, 19);
            this.ldate.TabIndex = 35;
            this.ldate.Text = "Дата прохождения теста:";
            // 
            // bdelUser
            // 
            this.bdelUser.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bdelUser.Location = new System.Drawing.Point(416, 405);
            this.bdelUser.Name = "bdelUser";
            this.bdelUser.Size = new System.Drawing.Size(153, 54);
            this.bdelUser.TabIndex = 37;
            this.bdelUser.Text = "Удалить пользователя";
            this.bdelUser.UseVisualStyleBackColor = true;
            this.bdelUser.Click += new System.EventHandler(this.bdelUser_Click);
            // 
            // bEditTest
            // 
            this.bEditTest.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bEditTest.Location = new System.Drawing.Point(236, 463);
            this.bEditTest.Name = "bEditTest";
            this.bEditTest.Size = new System.Drawing.Size(333, 54);
            this.bEditTest.TabIndex = 38;
            this.bEditTest.Text = "Редактировать тест";
            this.bEditTest.UseVisualStyleBackColor = true;
            this.bEditTest.Click += new System.EventHandler(this.bEditTest_Click);
            // 
            // DataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 521);
            this.Controls.Add(this.bEditTest);
            this.Controls.Add(this.bdelUser);
            this.Controls.Add(this.lResultDate);
            this.Controls.Add(this.ldate);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.lResulteScores);
            this.Controls.Add(this.lResulteWrongAnswers);
            this.Controls.Add(this.lResulteRightAnswers);
            this.Controls.Add(this.lResulteTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bdelTest);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.rbTest);
            this.Controls.Add(this.rbUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DataBase";
            this.Text = "База данных";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbUser;
        private System.Windows.Forms.RadioButton rbTest;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bdelTest;
        private System.Windows.Forms.Label lResulteScores;
        private System.Windows.Forms.Label lResulteWrongAnswers;
        private System.Windows.Forms.Label lResulteRightAnswers;
        private System.Windows.Forms.Label lResulteTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label lResultDate;
        private System.Windows.Forms.Label ldate;
        private System.Windows.Forms.Button bdelUser;
        private System.Windows.Forms.Button bEditTest;
    }
}