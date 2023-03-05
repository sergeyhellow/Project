namespace ToyStore.Views.ManageForms
{
    partial class AfterAutorisationForm
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
            this.Store_button = new System.Windows.Forms.Button();
            this.Admins_forms = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Store_button
            // 
            this.Store_button.Location = new System.Drawing.Point(149, 62);
            this.Store_button.Name = "Store_button";
            this.Store_button.Size = new System.Drawing.Size(480, 92);
            this.Store_button.TabIndex = 0;
            this.Store_button.Text = "Перейти в магазин";
            this.Store_button.UseVisualStyleBackColor = true;
            // 
            // Admins_forms
            // 
            this.Admins_forms.Location = new System.Drawing.Point(149, 175);
            this.Admins_forms.Name = "Admins_forms";
            this.Admins_forms.Size = new System.Drawing.Size(480, 193);
            this.Admins_forms.TabIndex = 1;
            this.Admins_forms.Text = "Административная часть";
            this.Admins_forms.UseVisualStyleBackColor = true;
            this.Admins_forms.Click += new System.EventHandler(this.Admins_forms_Click);
            // 
            // AfterAutorisationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Admins_forms);
            this.Controls.Add(this.Store_button);
            this.Name = "AfterAutorisationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AfterAutorisationFormForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Store_button;
        private System.Windows.Forms.Button Admins_forms;
    }
}