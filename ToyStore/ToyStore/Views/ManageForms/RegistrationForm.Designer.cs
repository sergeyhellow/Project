namespace ToyStore.Forms
{
    partial class RegistrationForm
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
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Name_label = new System.Windows.Forms.Label();
            this.Name2Nd_label = new System.Windows.Forms.Label();
            this.SecondName_textBox = new System.Windows.Forms.TextBox();
            this.phone_label = new System.Windows.Forms.Label();
            this.Login_label = new System.Windows.Forms.Label();
            this.Login_textBox = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.registration_button = new System.Windows.Forms.Button();
            this.Phone_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(199, 48);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(215, 20);
            this.Name_textBox.TabIndex = 0;
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Location = new System.Drawing.Point(61, 51);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(102, 13);
            this.Name_label.TabIndex = 1;
            this.Name_label.Text = "Введите Ваше имя";
            // 
            // Name2Nd_label
            // 
            this.Name2Nd_label.AutoSize = true;
            this.Name2Nd_label.Location = new System.Drawing.Point(61, 113);
            this.Name2Nd_label.Name = "Name2Nd_label";
            this.Name2Nd_label.Size = new System.Drawing.Size(132, 13);
            this.Name2Nd_label.TabIndex = 3;
            this.Name2Nd_label.Text = "Укажите Вашу фамилию";
            // 
            // SecondName_textBox
            // 
            this.SecondName_textBox.Location = new System.Drawing.Point(199, 106);
            this.SecondName_textBox.Name = "SecondName_textBox";
            this.SecondName_textBox.Size = new System.Drawing.Size(215, 20);
            this.SecondName_textBox.TabIndex = 2;
            // 
            // phone_label
            // 
            this.phone_label.AutoSize = true;
            this.phone_label.Location = new System.Drawing.Point(61, 178);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(98, 13);
            this.phone_label.TabIndex = 5;
            this.phone_label.Text = "Укажите телефон";
            // 
            // Login_label
            // 
            this.Login_label.AutoSize = true;
            this.Login_label.Location = new System.Drawing.Point(61, 242);
            this.Login_label.Name = "Login_label";
            this.Login_label.Size = new System.Drawing.Size(108, 13);
            this.Login_label.TabIndex = 7;
            this.Login_label.Text = "Укажите Ваш логин";
            // 
            // Login_textBox
            // 
            this.Login_textBox.Location = new System.Drawing.Point(199, 239);
            this.Login_textBox.Name = "Login_textBox";
            this.Login_textBox.Size = new System.Drawing.Size(211, 20);
            this.Login_textBox.TabIndex = 6;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(61, 320);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(91, 13);
            this.password_label.TabIndex = 9;
            this.password_label.Text = "Укажите пароль";
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(199, 313);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(211, 20);
            this.password_textBox.TabIndex = 8;
            // 
            // registration_button
            // 
            this.registration_button.Location = new System.Drawing.Point(199, 363);
            this.registration_button.Name = "registration_button";
            this.registration_button.Size = new System.Drawing.Size(208, 72);
            this.registration_button.TabIndex = 10;
            this.registration_button.Text = "Зарегистрироваться";
            this.registration_button.UseVisualStyleBackColor = true;
            this.registration_button.Click += new System.EventHandler(this.registration_button_Click);
            // 
            // Phone_maskedTextBox
            // 
            this.Phone_maskedTextBox.BeepOnError = true;
            this.Phone_maskedTextBox.Location = new System.Drawing.Point(199, 178);
            this.Phone_maskedTextBox.Mask = "0(000)000-00-00";
            this.Phone_maskedTextBox.Name = "Phone_maskedTextBox";
            this.Phone_maskedTextBox.Size = new System.Drawing.Size(211, 20);
            this.Phone_maskedTextBox.TabIndex = 3;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 515);
            this.Controls.Add(this.Phone_maskedTextBox);
            this.Controls.Add(this.registration_button);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.Login_label);
            this.Controls.Add(this.Login_textBox);
            this.Controls.Add(this.phone_label);
            this.Controls.Add(this.Name2Nd_label);
            this.Controls.Add(this.SecondName_textBox);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.Name_textBox);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReigstrationForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrationForm_FormClosing);
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.Label Name2Nd_label;
        private System.Windows.Forms.TextBox SecondName_textBox;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.Label Login_label;
        private System.Windows.Forms.TextBox Login_textBox;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Button registration_button;
        private System.Windows.Forms.MaskedTextBox Phone_maskedTextBox;
    }
}