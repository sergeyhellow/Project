namespace ToyStore.Views.ManageForms
{
    partial class WriteOffForm
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
            this.Batch_label = new System.Windows.Forms.Label();
            this.registerBatchToStore_button = new System.Windows.Forms.Button();
            this.showStorrage_button = new System.Windows.Forms.Button();
            this.Store_dataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.registration_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Toy_textBox = new System.Windows.Forms.TextBox();
            this.Sopll_textBox = new System.Windows.Forms.TextBox();
            this.Amount_textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Store_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Batch_label
            // 
            this.Batch_label.AutoSize = true;
            this.Batch_label.Location = new System.Drawing.Point(35, 33);
            this.Batch_label.Name = "Batch_label";
            this.Batch_label.Size = new System.Drawing.Size(24, 13);
            this.Batch_label.TabIndex = 25;
            this.Batch_label.Text = "ИД";
            // 
            // registerBatchToStore_button
            // 
            this.registerBatchToStore_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.registerBatchToStore_button.Location = new System.Drawing.Point(693, 314);
            this.registerBatchToStore_button.Name = "registerBatchToStore_button";
            this.registerBatchToStore_button.Size = new System.Drawing.Size(277, 99);
            this.registerBatchToStore_button.TabIndex = 24;
            this.registerBatchToStore_button.Text = "Зафиксировать изменения в количетсве товара";
            this.registerBatchToStore_button.UseVisualStyleBackColor = true;
            this.registerBatchToStore_button.Click += new System.EventHandler(this.registerBatchToStore_button_Click);
            // 
            // showStorrage_button
            // 
            this.showStorrage_button.Location = new System.Drawing.Point(693, 199);
            this.showStorrage_button.Name = "showStorrage_button";
            this.showStorrage_button.Size = new System.Drawing.Size(277, 65);
            this.showStorrage_button.TabIndex = 23;
            this.showStorrage_button.Text = "Показать склад";
            this.showStorrage_button.UseVisualStyleBackColor = true;
            this.showStorrage_button.Click += new System.EventHandler(this.showStorrage_button_Click);
            // 
            // Store_dataGridView
            // 
            this.Store_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Store_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Store_dataGridView.Location = new System.Drawing.Point(12, 110);
            this.Store_dataGridView.Name = "Store_dataGridView";
            this.Store_dataGridView.Size = new System.Drawing.Size(629, 463);
            this.Store_dataGridView.TabIndex = 22;
            this.Store_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Store_dataGridView_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Дата приема";
            // 
            // registration_dateTimePicker
            // 
            this.registration_dateTimePicker.Location = new System.Drawing.Point(38, 227);
            this.registration_dateTimePicker.Name = "registration_dateTimePicker";
            this.registration_dateTimePicker.Size = new System.Drawing.Size(156, 20);
            this.registration_dateTimePicker.TabIndex = 17;
            // 
            // Toy_textBox
            // 
            this.Toy_textBox.Location = new System.Drawing.Point(29, 49);
            this.Toy_textBox.Name = "Toy_textBox";
            this.Toy_textBox.Size = new System.Drawing.Size(66, 20);
            this.Toy_textBox.TabIndex = 28;
            // 
            // Sopll_textBox
            // 
            this.Sopll_textBox.Location = new System.Drawing.Point(151, 49);
            this.Sopll_textBox.Name = "Sopll_textBox";
            this.Sopll_textBox.Size = new System.Drawing.Size(207, 20);
            this.Sopll_textBox.TabIndex = 29;
            // 
            // Amount_textBox3
            // 
            this.Amount_textBox3.ForeColor = System.Drawing.Color.Red;
            this.Amount_textBox3.Location = new System.Drawing.Point(427, 49);
            this.Amount_textBox3.Name = "Amount_textBox3";
            this.Amount_textBox3.Size = new System.Drawing.Size(147, 20);
            this.Amount_textBox3.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Название (не редактируется на складе)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(424, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Указать новое количество товара";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Двойной клик выбора редкатируемой строки";
            // 
            // WriteOffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 611);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Amount_textBox3);
            this.Controls.Add(this.Sopll_textBox);
            this.Controls.Add(this.Toy_textBox);
            this.Controls.Add(this.Batch_label);
            this.Controls.Add(this.registerBatchToStore_button);
            this.Controls.Add(this.showStorrage_button);
            this.Controls.Add(this.Store_dataGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.registration_dateTimePicker);
            this.Name = "WriteOffForm";
            this.Text = "WriteOffForm";
            ((System.ComponentModel.ISupportInitialize)(this.Store_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Batch_label;
        private System.Windows.Forms.Button registerBatchToStore_button;
        private System.Windows.Forms.Button showStorrage_button;
        private System.Windows.Forms.DataGridView Store_dataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker registration_dateTimePicker;
        private System.Windows.Forms.TextBox Toy_textBox;
        private System.Windows.Forms.TextBox Sopll_textBox;
        private System.Windows.Forms.TextBox Amount_textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}