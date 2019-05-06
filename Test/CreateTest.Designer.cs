namespace Test
{
    partial class CreateTest
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
            this.CBchooseTopic = new System.Windows.Forms.ComboBox();
            this.lCchooseTopic = new System.Windows.Forms.Label();
            this.lCreateTopic = new System.Windows.Forms.Label();
            this.tbCreateTopic = new System.Windows.Forms.TextBox();
            this.tbNameTest = new System.Windows.Forms.TextBox();
            this.lNameTest = new System.Windows.Forms.Label();
            this.bCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CBchooseTopic
            // 
            this.CBchooseTopic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBchooseTopic.FormattingEnabled = true;
            this.CBchooseTopic.Location = new System.Drawing.Point(36, 43);
            this.CBchooseTopic.Name = "CBchooseTopic";
            this.CBchooseTopic.Size = new System.Drawing.Size(121, 21);
            this.CBchooseTopic.TabIndex = 0;
            // 
            // lCchooseTopic
            // 
            this.lCchooseTopic.AutoSize = true;
            this.lCchooseTopic.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCchooseTopic.Location = new System.Drawing.Point(36, 21);
            this.lCchooseTopic.Name = "lCchooseTopic";
            this.lCchooseTopic.Size = new System.Drawing.Size(112, 19);
            this.lCchooseTopic.TabIndex = 1;
            this.lCchooseTopic.Text = "Выберите Тему";
            // 
            // lCreateTopic
            // 
            this.lCreateTopic.AutoSize = true;
            this.lCreateTopic.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCreateTopic.Location = new System.Drawing.Point(192, 21);
            this.lCreateTopic.Name = "lCreateTopic";
            this.lCreateTopic.Size = new System.Drawing.Size(170, 19);
            this.lCreateTopic.TabIndex = 2;
            this.lCreateTopic.Text = "Введите название темы";
            // 
            // tbCreateTopic
            // 
            this.tbCreateTopic.Location = new System.Drawing.Point(196, 44);
            this.tbCreateTopic.Name = "tbCreateTopic";
            this.tbCreateTopic.Size = new System.Drawing.Size(166, 20);
            this.tbCreateTopic.TabIndex = 3;
            // 
            // tbNameTest
            // 
            this.tbNameTest.Location = new System.Drawing.Point(36, 104);
            this.tbNameTest.Name = "tbNameTest";
            this.tbNameTest.Size = new System.Drawing.Size(326, 20);
            this.tbNameTest.TabIndex = 5;
            // 
            // lNameTest
            // 
            this.lNameTest.AutoSize = true;
            this.lNameTest.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lNameTest.Location = new System.Drawing.Point(32, 81);
            this.lNameTest.Name = "lNameTest";
            this.lNameTest.Size = new System.Drawing.Size(170, 19);
            this.lNameTest.TabIndex = 4;
            this.lNameTest.Text = "Введите название теста";
            // 
            // bCreate
            // 
            this.bCreate.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCreate.Location = new System.Drawing.Point(121, 335);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(152, 48);
            this.bCreate.TabIndex = 6;
            this.bCreate.Text = "Создать";
            this.bCreate.UseVisualStyleBackColor = true;
            // 
            // CreateTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 418);
            this.Controls.Add(this.bCreate);
            this.Controls.Add(this.tbNameTest);
            this.Controls.Add(this.lNameTest);
            this.Controls.Add(this.tbCreateTopic);
            this.Controls.Add(this.lCreateTopic);
            this.Controls.Add(this.lCchooseTopic);
            this.Controls.Add(this.CBchooseTopic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateTest";
            this.Text = "Создание теста";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBchooseTopic;
        private System.Windows.Forms.Label lCchooseTopic;
        private System.Windows.Forms.Label lCreateTopic;
        private System.Windows.Forms.TextBox tbCreateTopic;
        private System.Windows.Forms.TextBox tbNameTest;
        private System.Windows.Forms.Label lNameTest;
        private System.Windows.Forms.Button bCreate;
    }
}