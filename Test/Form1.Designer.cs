namespace Test
{
    partial class Form1
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
            this.butChooseTest = new System.Windows.Forms.Button();
            this.butCreateTest = new System.Windows.Forms.Button();
            this.butDB = new System.Windows.Forms.Button();
            this.labAdminUser = new System.Windows.Forms.Label();
            this.lQuitAdmin = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SuspendLayout();
            // 
            // butChooseTest
            // 
            this.butChooseTest.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butChooseTest.Location = new System.Drawing.Point(131, 80);
            this.butChooseTest.Name = "butChooseTest";
            this.butChooseTest.Size = new System.Drawing.Size(217, 93);
            this.butChooseTest.TabIndex = 0;
            this.butChooseTest.Text = "Выбрать тест";
            this.butChooseTest.UseVisualStyleBackColor = true;
            this.butChooseTest.Click += new System.EventHandler(this.butChooseTest_Click);
            // 
            // butCreateTest
            // 
            this.butCreateTest.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCreateTest.Location = new System.Drawing.Point(131, 199);
            this.butCreateTest.Name = "butCreateTest";
            this.butCreateTest.Size = new System.Drawing.Size(217, 93);
            this.butCreateTest.TabIndex = 1;
            this.butCreateTest.Text = "Создать тест";
            this.butCreateTest.UseVisualStyleBackColor = true;
            this.butCreateTest.Click += new System.EventHandler(this.butCreateTest_Click);
            // 
            // butDB
            // 
            this.butDB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDB.Location = new System.Drawing.Point(131, 318);
            this.butDB.Name = "butDB";
            this.butDB.Size = new System.Drawing.Size(217, 93);
            this.butDB.TabIndex = 2;
            this.butDB.Text = "База данных";
            this.butDB.UseVisualStyleBackColor = true;
            this.butDB.Click += new System.EventHandler(this.butDB_Click);
            // 
            // labAdminUser
            // 
            this.labAdminUser.AutoSize = true;
            this.labAdminUser.Location = new System.Drawing.Point(12, 9);
            this.labAdminUser.Name = "labAdminUser";
            this.labAdminUser.Size = new System.Drawing.Size(157, 13);
            this.labAdminUser.TabIndex = 3;
            this.labAdminUser.Text = "Вы вошли как: Пользователь";
            this.labAdminUser.TextChanged += new System.EventHandler(this.labAdminUser_TextChanged);
            this.labAdminUser.Click += new System.EventHandler(this.labAdminUser_Click);
            // 
            // lQuitAdmin
            // 
            this.lQuitAdmin.AutoSize = true;
            this.lQuitAdmin.Location = new System.Drawing.Point(445, 9);
            this.lQuitAdmin.Name = "lQuitAdmin";
            this.lQuitAdmin.Size = new System.Drawing.Size(39, 13);
            this.lQuitAdmin.TabIndex = 4;
            this.lQuitAdmin.Text = "Выйти";
            this.lQuitAdmin.Visible = false;
            this.lQuitAdmin.Click += new System.EventHandler(this.lQuitAdmin_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 478);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(496, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 500);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lQuitAdmin);
            this.Controls.Add(this.labAdminUser);
            this.Controls.Add(this.butDB);
            this.Controls.Add(this.butCreateTest);
            this.Controls.Add(this.butChooseTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Программа для тестирования";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butChooseTest;
        private System.Windows.Forms.Button butCreateTest;
        private System.Windows.Forms.Button butDB;
        private System.Windows.Forms.Label lQuitAdmin;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label labAdminUser;
    }
}

