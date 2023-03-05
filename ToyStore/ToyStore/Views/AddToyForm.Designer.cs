namespace ToyStore.Views
{
    partial class AddToyForm
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
            this.toyName_textBox = new System.Windows.Forms.TextBox();
            this.ToyName_label = new System.Windows.Forms.Label();
            this.Weight_label = new System.Windows.Forms.Label();
            this.weighTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Manuf_label = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.Country_label = new System.Windows.Forms.Label();
            this.Manuf_comboBox = new System.Windows.Forms.ComboBox();
            this.TypToy_comboBox = new System.Windows.Forms.ComboBox();
            this.Country_comboBox = new System.Windows.Forms.ComboBox();
            this.AddToy_button = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Directory_listBox = new System.Windows.Forms.ListBox();
            this.name_label = new System.Windows.Forms.Label();
            this.selectedValueLabel = new System.Windows.Forms.Label();
            this.Add_button = new System.Windows.Forms.Button();
            this.directiryPropertycomboBox = new System.Windows.Forms.ComboBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ClearBatch_button = new System.Windows.Forms.Button();
            this.batchStore_button = new System.Windows.Forms.Button();
            this.Batch_label = new System.Windows.Forms.Label();
            this.registerBatchToStore_button = new System.Windows.Forms.Button();
            this.addToBatch_button = new System.Windows.Forms.Button();
            this.batchOrStore_dataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.registration_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Amount_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SoppliersToST_comboBox = new System.Windows.Forms.ComboBox();
            this.ToyToST_comboBox = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batchOrStore_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Amount_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // toyName_textBox
            // 
            this.toyName_textBox.Location = new System.Drawing.Point(190, 76);
            this.toyName_textBox.Name = "toyName_textBox";
            this.toyName_textBox.Size = new System.Drawing.Size(371, 20);
            this.toyName_textBox.TabIndex = 0;
            // 
            // ToyName_label
            // 
            this.ToyName_label.AutoSize = true;
            this.ToyName_label.Location = new System.Drawing.Point(6, 83);
            this.ToyName_label.Name = "ToyName_label";
            this.ToyName_label.Size = new System.Drawing.Size(103, 13);
            this.ToyName_label.TabIndex = 1;
            this.ToyName_label.Text = "Укажите название";
            // 
            // Weight_label
            // 
            this.Weight_label.AutoSize = true;
            this.Weight_label.Location = new System.Drawing.Point(6, 127);
            this.Weight_label.Name = "Weight_label";
            this.Weight_label.Size = new System.Drawing.Size(132, 13);
            this.Weight_label.TabIndex = 3;
            this.Weight_label.Text = "Укажите вес, в граммах";
            // 
            // weighTextBox
            // 
            this.weighTextBox.Location = new System.Drawing.Point(190, 120);
            this.weighTextBox.Name = "weighTextBox";
            this.weighTextBox.Size = new System.Drawing.Size(371, 20);
            this.weighTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Укажите характеристики игрушки";
            // 
            // Manuf_label
            // 
            this.Manuf_label.AutoSize = true;
            this.Manuf_label.Location = new System.Drawing.Point(6, 179);
            this.Manuf_label.Name = "Manuf_label";
            this.Manuf_label.Size = new System.Drawing.Size(137, 13);
            this.Manuf_label.TabIndex = 5;
            this.Manuf_label.Text = "Выберите производителя";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(6, 230);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(122, 13);
            this.Type.TabIndex = 6;
            this.Type.Text = "Выберите тип игрушки";
            // 
            // Country_label
            // 
            this.Country_label.AutoSize = true;
            this.Country_label.Location = new System.Drawing.Point(6, 287);
            this.Country_label.Name = "Country_label";
            this.Country_label.Size = new System.Drawing.Size(176, 13);
            this.Country_label.TabIndex = 7;
            this.Country_label.Text = "Выберите страну происхождения";
            // 
            // Manuf_comboBox
            // 
            this.Manuf_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Manuf_comboBox.FormattingEnabled = true;
            this.Manuf_comboBox.Location = new System.Drawing.Point(190, 179);
            this.Manuf_comboBox.Name = "Manuf_comboBox";
            this.Manuf_comboBox.Size = new System.Drawing.Size(371, 21);
            this.Manuf_comboBox.TabIndex = 8;
            // 
            // TypToy_comboBox
            // 
            this.TypToy_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypToy_comboBox.FormattingEnabled = true;
            this.TypToy_comboBox.Location = new System.Drawing.Point(190, 230);
            this.TypToy_comboBox.Name = "TypToy_comboBox";
            this.TypToy_comboBox.Size = new System.Drawing.Size(371, 21);
            this.TypToy_comboBox.TabIndex = 9;
            // 
            // Country_comboBox
            // 
            this.Country_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Country_comboBox.FormattingEnabled = true;
            this.Country_comboBox.Location = new System.Drawing.Point(190, 284);
            this.Country_comboBox.Name = "Country_comboBox";
            this.Country_comboBox.Size = new System.Drawing.Size(371, 21);
            this.Country_comboBox.TabIndex = 10;
            // 
            // AddToy_button
            // 
            this.AddToy_button.Location = new System.Drawing.Point(9, 343);
            this.AddToy_button.Name = "AddToy_button";
            this.AddToy_button.Size = new System.Drawing.Size(552, 39);
            this.AddToy_button.TabIndex = 11;
            this.AddToy_button.Text = "Добавить  игрушку";
            this.AddToy_button.UseVisualStyleBackColor = true;
            this.AddToy_button.Click += new System.EventHandler(this.AddToy_button_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(901, 550);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.AddToy_button);
            this.tabPage1.Controls.Add(this.toyName_textBox);
            this.tabPage1.Controls.Add(this.Country_comboBox);
            this.tabPage1.Controls.Add(this.ToyName_label);
            this.tabPage1.Controls.Add(this.TypToy_comboBox);
            this.tabPage1.Controls.Add(this.weighTextBox);
            this.tabPage1.Controls.Add(this.Manuf_comboBox);
            this.tabPage1.Controls.Add(this.Weight_label);
            this.tabPage1.Controls.Add(this.Country_label);
            this.tabPage1.Controls.Add(this.Manuf_label);
            this.tabPage1.Controls.Add(this.Type);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(893, 524);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавление игрушки";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Directory_listBox);
            this.tabPage2.Controls.Add(this.name_label);
            this.tabPage2.Controls.Add(this.selectedValueLabel);
            this.tabPage2.Controls.Add(this.Add_button);
            this.tabPage2.Controls.Add(this.directiryPropertycomboBox);
            this.tabPage2.Controls.Add(this.name_textBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(893, 524);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавить поставщика/производителя";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Directory_listBox
            // 
            this.Directory_listBox.FormattingEnabled = true;
            this.Directory_listBox.Location = new System.Drawing.Point(442, 61);
            this.Directory_listBox.Name = "Directory_listBox";
            this.Directory_listBox.Size = new System.Drawing.Size(379, 277);
            this.Directory_listBox.TabIndex = 5;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.name_label.Location = new System.Drawing.Point(38, 136);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(164, 17);
            this.name_label.TabIndex = 4;
            this.name_label.Text = "Укажите наименование";
            // 
            // selectedValueLabel
            // 
            this.selectedValueLabel.AutoSize = true;
            this.selectedValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.selectedValueLabel.Location = new System.Drawing.Point(41, 25);
            this.selectedValueLabel.Name = "selectedValueLabel";
            this.selectedValueLabel.Size = new System.Drawing.Size(261, 17);
            this.selectedValueLabel.TabIndex = 3;
            this.selectedValueLabel.Text = "Выберете что добавляем в справочик";
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(45, 265);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(269, 67);
            this.Add_button.TabIndex = 2;
            this.Add_button.Text = "Добавить";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // directiryPropertycomboBox
            // 
            this.directiryPropertycomboBox.FormattingEnabled = true;
            this.directiryPropertycomboBox.Items.AddRange(new object[] {
            "Страна производитель",
            "Поставщик",
            "Производитель"});
            this.directiryPropertycomboBox.Location = new System.Drawing.Point(41, 61);
            this.directiryPropertycomboBox.Name = "directiryPropertycomboBox";
            this.directiryPropertycomboBox.Size = new System.Drawing.Size(273, 21);
            this.directiryPropertycomboBox.TabIndex = 1;
            this.directiryPropertycomboBox.SelectedIndexChanged += new System.EventHandler(this.directiryPropertycomboBox_SelectedIndexChanged);
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(41, 156);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(273, 20);
            this.name_textBox.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ClearBatch_button);
            this.tabPage3.Controls.Add(this.batchStore_button);
            this.tabPage3.Controls.Add(this.Batch_label);
            this.tabPage3.Controls.Add(this.registerBatchToStore_button);
            this.tabPage3.Controls.Add(this.addToBatch_button);
            this.tabPage3.Controls.Add(this.batchOrStore_dataGridView);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.registration_dateTimePicker);
            this.tabPage3.Controls.Add(this.Amount_numericUpDown);
            this.tabPage3.Controls.Add(this.SoppliersToST_comboBox);
            this.tabPage3.Controls.Add(this.ToyToST_comboBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(893, 524);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Оприходование на склад";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ClearBatch_button
            // 
            this.ClearBatch_button.Location = new System.Drawing.Point(15, 365);
            this.ClearBatch_button.Name = "ClearBatch_button";
            this.ClearBatch_button.Size = new System.Drawing.Size(277, 43);
            this.ClearBatch_button.TabIndex = 13;
            this.ClearBatch_button.Text = "Очистить партию";
            this.ClearBatch_button.UseVisualStyleBackColor = true;
            this.ClearBatch_button.Click += new System.EventHandler(this.ClearBatch_button_Click);
            // 
            // batchStore_button
            // 
            this.batchStore_button.Location = new System.Drawing.Point(437, 49);
            this.batchStore_button.Name = "batchStore_button";
            this.batchStore_button.Size = new System.Drawing.Size(368, 40);
            this.batchStore_button.TabIndex = 12;
            this.batchStore_button.Text = "Показать: Склад/Партия";
            this.batchStore_button.UseVisualStyleBackColor = true;
            this.batchStore_button.Click += new System.EventHandler(this.batchStore_button_Click);
            // 
            // Batch_label
            // 
            this.Batch_label.AutoSize = true;
            this.Batch_label.Location = new System.Drawing.Point(376, 103);
            this.Batch_label.Name = "Batch_label";
            this.Batch_label.Size = new System.Drawing.Size(35, 13);
            this.Batch_label.TabIndex = 11;
            this.Batch_label.Text = "label6";
            // 
            // registerBatchToStore_button
            // 
            this.registerBatchToStore_button.Location = new System.Drawing.Point(15, 414);
            this.registerBatchToStore_button.Name = "registerBatchToStore_button";
            this.registerBatchToStore_button.Size = new System.Drawing.Size(277, 68);
            this.registerBatchToStore_button.TabIndex = 10;
            this.registerBatchToStore_button.Text = "Оприходовать парию на склад";
            this.registerBatchToStore_button.UseVisualStyleBackColor = true;
            this.registerBatchToStore_button.Click += new System.EventHandler(this.registerBatchToStore_button_Click);
            // 
            // addToBatch_button
            // 
            this.addToBatch_button.Location = new System.Drawing.Point(15, 293);
            this.addToBatch_button.Name = "addToBatch_button";
            this.addToBatch_button.Size = new System.Drawing.Size(277, 65);
            this.addToBatch_button.TabIndex = 9;
            this.addToBatch_button.Text = "Добавить в формируемую партию";
            this.addToBatch_button.UseVisualStyleBackColor = true;
            this.addToBatch_button.Click += new System.EventHandler(this.addToBatch_button_Click);
            // 
            // batchOrStore_dataGridView
            // 
            this.batchOrStore_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.batchOrStore_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.batchOrStore_dataGridView.Location = new System.Drawing.Point(327, 119);
            this.batchOrStore_dataGridView.Name = "batchOrStore_dataGridView";
            this.batchOrStore_dataGridView.Size = new System.Drawing.Size(545, 363);
            this.batchOrStore_dataGridView.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Дата приема";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Укажите количетство";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Укажите поставщика";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберите игрушку для оприходования на склад";
            // 
            // registration_dateTimePicker
            // 
            this.registration_dateTimePicker.Location = new System.Drawing.Point(15, 249);
            this.registration_dateTimePicker.Name = "registration_dateTimePicker";
            this.registration_dateTimePicker.Size = new System.Drawing.Size(156, 20);
            this.registration_dateTimePicker.TabIndex = 3;
            // 
            // Amount_numericUpDown
            // 
            this.Amount_numericUpDown.Location = new System.Drawing.Point(15, 161);
            this.Amount_numericUpDown.Name = "Amount_numericUpDown";
            this.Amount_numericUpDown.Size = new System.Drawing.Size(294, 20);
            this.Amount_numericUpDown.TabIndex = 2;
            // 
            // SoppliersToST_comboBox
            // 
            this.SoppliersToST_comboBox.FormattingEnabled = true;
            this.SoppliersToST_comboBox.Location = new System.Drawing.Point(15, 106);
            this.SoppliersToST_comboBox.Name = "SoppliersToST_comboBox";
            this.SoppliersToST_comboBox.Size = new System.Drawing.Size(294, 21);
            this.SoppliersToST_comboBox.TabIndex = 1;
            // 
            // ToyToST_comboBox
            // 
            this.ToyToST_comboBox.FormattingEnabled = true;
            this.ToyToST_comboBox.Location = new System.Drawing.Point(15, 49);
            this.ToyToST_comboBox.Name = "ToyToST_comboBox";
            this.ToyToST_comboBox.Size = new System.Drawing.Size(294, 21);
            this.ToyToST_comboBox.TabIndex = 0;
            // 
            // AddToyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 574);
            this.Controls.Add(this.tabControl1);
            this.Name = "AddToyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddToyForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batchOrStore_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Amount_numericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox toyName_textBox;
        private System.Windows.Forms.Label ToyName_label;
        private System.Windows.Forms.Label Weight_label;
        private System.Windows.Forms.TextBox weighTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Manuf_label;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label Country_label;
        private System.Windows.Forms.ComboBox Manuf_comboBox;
        private System.Windows.Forms.ComboBox TypToy_comboBox;
        private System.Windows.Forms.ComboBox Country_comboBox;
        private System.Windows.Forms.Button AddToy_button;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label selectedValueLabel;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.ComboBox directiryPropertycomboBox;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.ListBox Directory_listBox;
        private System.Windows.Forms.DataGridView batchOrStore_dataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker registration_dateTimePicker;
        private System.Windows.Forms.NumericUpDown Amount_numericUpDown;
        private System.Windows.Forms.ComboBox SoppliersToST_comboBox;
        private System.Windows.Forms.ComboBox ToyToST_comboBox;
        private System.Windows.Forms.Button batchStore_button;
        private System.Windows.Forms.Label Batch_label;
        private System.Windows.Forms.Button registerBatchToStore_button;
        private System.Windows.Forms.Button addToBatch_button;
        private System.Windows.Forms.Button ClearBatch_button;
    }
}