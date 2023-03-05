namespace ToyStore.Views
{
    partial class UnregisteredUserForm
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
            this.UnregUserDataGridView = new System.Windows.Forms.DataGridView();
            this.ShowToyButton = new System.Windows.Forms.Button();
            this.priceOrderRadioButton = new System.Windows.Forms.RadioButton();
            this.TypeOrderRadioButton = new System.Windows.Forms.RadioButton();
            this.AgeOrderRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UnregUserDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UnregUserDataGridView
            // 
            this.UnregUserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UnregUserDataGridView.Location = new System.Drawing.Point(12, 132);
            this.UnregUserDataGridView.Name = "UnregUserDataGridView";
            this.UnregUserDataGridView.Size = new System.Drawing.Size(776, 575);
            this.UnregUserDataGridView.TabIndex = 0;
            // 
            // ShowToyButton
            // 
            this.ShowToyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.ShowToyButton.Location = new System.Drawing.Point(106, 85);
            this.ShowToyButton.Name = "ShowToyButton";
            this.ShowToyButton.Size = new System.Drawing.Size(545, 41);
            this.ShowToyButton.TabIndex = 1;
            this.ShowToyButton.Text = "Показать игрушки";
            this.ShowToyButton.UseVisualStyleBackColor = true;
            this.ShowToyButton.Click += new System.EventHandler(this.ShowToyButton_Click);
            // 
            // priceOrderRadioButton
            // 
            this.priceOrderRadioButton.AutoSize = true;
            this.priceOrderRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.priceOrderRadioButton.Location = new System.Drawing.Point(27, 47);
            this.priceOrderRadioButton.Name = "priceOrderRadioButton";
            this.priceOrderRadioButton.Size = new System.Drawing.Size(165, 20);
            this.priceOrderRadioButton.TabIndex = 2;
            this.priceOrderRadioButton.TabStop = true;
            this.priceOrderRadioButton.Text = "Упорядочить по цене";
            this.priceOrderRadioButton.UseVisualStyleBackColor = true;
            // 
            // TypeOrderRadioButton
            // 
            this.TypeOrderRadioButton.AutoSize = true;
            this.TypeOrderRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.TypeOrderRadioButton.Location = new System.Drawing.Point(291, 47);
            this.TypeOrderRadioButton.Name = "TypeOrderRadioButton";
            this.TypeOrderRadioButton.Size = new System.Drawing.Size(164, 20);
            this.TypeOrderRadioButton.TabIndex = 3;
            this.TypeOrderRadioButton.TabStop = true;
            this.TypeOrderRadioButton.Text = "Упорядочить по типу";
            this.TypeOrderRadioButton.UseVisualStyleBackColor = true;
            // 
            // AgeOrderRadioButton
            // 
            this.AgeOrderRadioButton.AutoSize = true;
            this.AgeOrderRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.AgeOrderRadioButton.Location = new System.Drawing.Point(537, 47);
            this.AgeOrderRadioButton.Name = "AgeOrderRadioButton";
            this.AgeOrderRadioButton.Size = new System.Drawing.Size(195, 20);
            this.AgeOrderRadioButton.TabIndex = 4;
            this.AgeOrderRadioButton.TabStop = true;
            this.AgeOrderRadioButton.Text = "Упорядочить по возрасту";
            this.AgeOrderRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(103, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ознакомление с ассортиментом, для покупки или заказа требуется регистрация";
            // 
            // UnregisteredUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 719);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AgeOrderRadioButton);
            this.Controls.Add(this.TypeOrderRadioButton);
            this.Controls.Add(this.priceOrderRadioButton);
            this.Controls.Add(this.ShowToyButton);
            this.Controls.Add(this.UnregUserDataGridView);
            this.Name = "UnregisteredUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UnregisteredUserForm";
            ((System.ComponentModel.ISupportInitialize)(this.UnregUserDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UnregUserDataGridView;
        private System.Windows.Forms.Button ShowToyButton;
        private System.Windows.Forms.RadioButton priceOrderRadioButton;
        private System.Windows.Forms.RadioButton TypeOrderRadioButton;
        private System.Windows.Forms.RadioButton AgeOrderRadioButton;
        private System.Windows.Forms.Label label1;
    }
}