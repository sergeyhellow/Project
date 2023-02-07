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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Name_label = new System.Windows.Forms.Label();
            this.Name2Nd_label = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.phone_label = new System.Windows.Forms.Label();
            this.Login_label = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.registration_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.Phone_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(199, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 20);
            this.textBox1.TabIndex = 0;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(199, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(215, 20);
            this.textBox2.TabIndex = 2;
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
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(199, 239);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(211, 20);
            this.textBox4.TabIndex = 6;
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
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(199, 313);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(211, 20);
            this.textBox5.TabIndex = 8;
            // 
            // registration_button
            // 
            this.registration_button.Location = new System.Drawing.Point(199, 363);
            this.registration_button.Name = "registration_button";
            this.registration_button.Size = new System.Drawing.Size(208, 72);
            this.registration_button.TabIndex = 10;
            this.registration_button.Text = "Зарегистрироваться";
            this.registration_button.UseVisualStyleBackColor = true;
            // 
            // cancel_button
            // 
            this.cancel_button.ForeColor = System.Drawing.Color.Crimson;
            this.cancel_button.Location = new System.Drawing.Point(152, 479);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(290, 24);
            this.cancel_button.TabIndex = 11;
            this.cancel_button.Text = "Отмена";
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // Phone_maskedTextBox
            // 
            this.Phone_maskedTextBox.Location = new System.Drawing.Point(199, 178);
            this.Phone_maskedTextBox.Mask = "0 (000) 000-00-00";
            this.Phone_maskedTextBox.Name = "Phone_maskedTextBox";
            this.Phone_maskedTextBox.Size = new System.Drawing.Size(211, 20);
            this.Phone_maskedTextBox.TabIndex = 12;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 515);
            this.Controls.Add(this.Phone_maskedTextBox);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.registration_button);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.Login_label);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.phone_label);
            this.Controls.Add(this.Name2Nd_label);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.textBox1);
            this.Name = "RegistrationForm";
            this.Text = "ReigstrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.Label Name2Nd_label;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.Label Login_label;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button registration_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.MaskedTextBox Phone_maskedTextBox;
    }
}