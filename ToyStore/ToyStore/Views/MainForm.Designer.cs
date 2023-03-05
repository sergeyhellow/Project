namespace ToyStore
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.login_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.Autorization_button = new System.Windows.Forms.Button();
            this.login_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Registration_linkLabel = new System.Windows.Forms.LinkLabel();
            this.viewing_linkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // login_textBox
            // 
            this.login_textBox.Location = new System.Drawing.Point(193, 218);
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.Size = new System.Drawing.Size(282, 20);
            this.login_textBox.TabIndex = 0;
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(193, 297);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(282, 20);
            this.password_textBox.TabIndex = 1;
            // 
            // Autorization_button
            // 
            this.Autorization_button.Location = new System.Drawing.Point(193, 346);
            this.Autorization_button.Name = "Autorization_button";
            this.Autorization_button.Size = new System.Drawing.Size(282, 43);
            this.Autorization_button.TabIndex = 2;
            this.Autorization_button.Text = "Войти";
            this.Autorization_button.UseVisualStyleBackColor = true;
            this.Autorization_button.Click += new System.EventHandler(this.Autorization_button_Click);
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Location = new System.Drawing.Point(193, 199);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(38, 13);
            this.login_label.TabIndex = 3;
            this.login_label.Text = "Логин";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Location = new System.Drawing.Point(193, 281);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(45, 13);
            this.Password_label.TabIndex = 4;
            this.Password_label.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(169, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Для входа в приложение требуется ввести логин и пароль.\r\nИли зарегистрироваться.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Registration_linkLabel
            // 
            this.Registration_linkLabel.AutoSize = true;
            this.Registration_linkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Registration_linkLabel.Location = new System.Drawing.Point(291, 171);
            this.Registration_linkLabel.Name = "Registration_linkLabel";
            this.Registration_linkLabel.Size = new System.Drawing.Size(91, 16);
            this.Registration_linkLabel.TabIndex = 6;
            this.Registration_linkLabel.TabStop = true;
            this.Registration_linkLabel.Text = "Регистрация";
            this.Registration_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Registration_linkLabel_LinkClicked);
            // 
            // viewing_linkLabel
            // 
            this.viewing_linkLabel.AutoSize = true;
            this.viewing_linkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.viewing_linkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.viewing_linkLabel.Location = new System.Drawing.Point(264, 29);
            this.viewing_linkLabel.Name = "viewing_linkLabel";
            this.viewing_linkLabel.Size = new System.Drawing.Size(145, 17);
            this.viewing_linkLabel.TabIndex = 7;
            this.viewing_linkLabel.TabStop = true;
            this.viewing_linkLabel.Text = "Посмотреть игрушки";
            this.viewing_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.viewing_linkLabel_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 478);
            this.Controls.Add(this.viewing_linkLabel);
            this.Controls.Add(this.Registration_linkLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.Autorization_button);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.login_textBox);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Button Autorization_button;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel Registration_linkLabel;
        private System.Windows.Forms.LinkLabel viewing_linkLabel;
    }
}

