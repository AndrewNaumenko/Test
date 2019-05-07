namespace Test
{
    partial class ChooseTest
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
            this.bCreate = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lCchooseTopic = new System.Windows.Forms.Label();
            this.CBchooseTopic = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbFathername = new System.Windows.Forms.TextBox();
            this.lbTestName = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bCreate
            // 
            this.bCreate.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCreate.Location = new System.Drawing.Point(337, 222);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(153, 54);
            this.bCreate.TabIndex = 10;
            this.bCreate.Text = "Начать";
            this.bCreate.UseVisualStyleBackColor = true;
            this.bCreate.Click += new System.EventHandler(this.bCreate_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(315, 75);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(184, 20);
            this.tbName.TabIndex = 9;
            // 
            // lCchooseTopic
            // 
            this.lCchooseTopic.AutoSize = true;
            this.lCchooseTopic.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCchooseTopic.Location = new System.Drawing.Point(13, 23);
            this.lCchooseTopic.Name = "lCchooseTopic";
            this.lCchooseTopic.Size = new System.Drawing.Size(112, 19);
            this.lCchooseTopic.TabIndex = 8;
            this.lCchooseTopic.Text = "Выберите Тему";
            // 
            // CBchooseTopic
            // 
            this.CBchooseTopic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBchooseTopic.FormattingEnabled = true;
            this.CBchooseTopic.Location = new System.Drawing.Point(131, 21);
            this.CBchooseTopic.Name = "CBchooseTopic";
            this.CBchooseTopic.Size = new System.Drawing.Size(174, 21);
            this.CBchooseTopic.TabIndex = 7;
            this.CBchooseTopic.SelectedIndexChanged += new System.EventHandler(this.CBchooseTopic_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(311, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Пользователь:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(312, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(311, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(312, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Отчество";
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(316, 130);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(184, 20);
            this.tbSurname.TabIndex = 15;
            // 
            // tbFathername
            // 
            this.tbFathername.Location = new System.Drawing.Point(316, 184);
            this.tbFathername.Name = "tbFathername";
            this.tbFathername.Size = new System.Drawing.Size(184, 20);
            this.tbFathername.TabIndex = 16;
            // 
            // lbTestName
            // 
            this.lbTestName.FormattingEnabled = true;
            this.lbTestName.Location = new System.Drawing.Point(17, 51);
            this.lbTestName.Name = "lbTestName";
            this.lbTestName.Size = new System.Drawing.Size(288, 225);
            this.lbTestName.TabIndex = 17;
            // 
            // ChooseTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 297);
            this.Controls.Add(this.lbTestName);
            this.Controls.Add(this.tbFathername);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bCreate);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lCchooseTopic);
            this.Controls.Add(this.CBchooseTopic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChooseTest";
            this.Text = "Выбрать тест";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCreate;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lCchooseTopic;
        private System.Windows.Forms.ComboBox CBchooseTopic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbFathername;
        private System.Windows.Forms.ListBox lbTestName;
    }
}