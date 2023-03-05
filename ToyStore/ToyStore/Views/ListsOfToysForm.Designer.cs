namespace ToyStore.Views
{
    partial class ListsOfToysForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SelectedToy_dataGridView = new System.Windows.Forms.DataGridView();
            this.TypeOfSelect_label = new System.Windows.Forms.Label();
            this.typeOfSelect_listBox = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SelectToys_dataGridView = new System.Windows.Forms.DataGridView();
            this.serch_button = new System.Windows.Forms.Button();
            this.Exp_comboBox1 = new System.Windows.Forms.ComboBox();
            this.manufacturer_comboBox = new System.Windows.Forms.ComboBox();
            this.typeToy_comboBox = new System.Windows.Forms.ComboBox();
            this.soppliers_comboBox = new System.Windows.Forms.ComboBox();
            this.country_comboBox = new System.Windows.Forms.ComboBox();
            this.priceMin_textBox = new System.Windows.Forms.TextBox();
            this.priceMax_textBox = new System.Windows.Forms.TextBox();
            this.maxDateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.minDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.maxDate_label = new System.Windows.Forms.Label();
            this.minDate_label = new System.Windows.Forms.Label();
            this.priceMax_label = new System.Windows.Forms.Label();
            this.priceMin_label = new System.Windows.Forms.Label();
            this.country_label = new System.Windows.Forms.Label();
            this.soppliers_label = new System.Windows.Forms.Label();
            this.TypeToy_label = new System.Windows.Forms.Label();
            this.Manufacturer_label = new System.Windows.Forms.Label();
            this.SaerchParam_label = new System.Windows.Forms.Label();
            this.searchParametr_comboBox = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedToy_dataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectToys_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1254, 673);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SelectedToy_dataGridView);
            this.tabPage1.Controls.Add(this.TypeOfSelect_label);
            this.tabPage1.Controls.Add(this.typeOfSelect_listBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1759, 647);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Просмотр списков";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // SelectedToy_dataGridView
            // 
            this.SelectedToy_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SelectedToy_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectedToy_dataGridView.Location = new System.Drawing.Point(349, 28);
            this.SelectedToy_dataGridView.Name = "SelectedToy_dataGridView";
            this.SelectedToy_dataGridView.Size = new System.Drawing.Size(880, 613);
            this.SelectedToy_dataGridView.TabIndex = 3;
            // 
            // TypeOfSelect_label
            // 
            this.TypeOfSelect_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.TypeOfSelect_label.Location = new System.Drawing.Point(7, 61);
            this.TypeOfSelect_label.Name = "TypeOfSelect_label";
            this.TypeOfSelect_label.Size = new System.Drawing.Size(223, 53);
            this.TypeOfSelect_label.TabIndex = 2;
            this.TypeOfSelect_label.Text = "Показать список игрушек (двойной клик)";
            // 
            // typeOfSelect_listBox
            // 
            this.typeOfSelect_listBox.BackColor = System.Drawing.SystemColors.Menu;
            this.typeOfSelect_listBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.typeOfSelect_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.typeOfSelect_listBox.FormattingEnabled = true;
            this.typeOfSelect_listBox.ItemHeight = 18;
            this.typeOfSelect_listBox.Items.AddRange(new object[] {
            "1. По дате оприходования",
            "2. В алфавитном порядке\t",
            "3. По весу",
            "4. По стоимости",
            "5. По дате продажи",
            "6. Самый дорогой тип игрушек",
            "7. Самый дешевый тип  игрушек",
            "8. Средняя цена по каждому типу игрушек",
            "9. Средя цена всех типов",
            "10. Игрушка, которую лучше всего раскупают (стоимость, производитель, возраст) "});
            this.typeOfSelect_listBox.Location = new System.Drawing.Point(6, 128);
            this.typeOfSelect_listBox.Name = "typeOfSelect_listBox";
            this.typeOfSelect_listBox.Size = new System.Drawing.Size(322, 216);
            this.typeOfSelect_listBox.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SelectToys_dataGridView);
            this.tabPage2.Controls.Add(this.serch_button);
            this.tabPage2.Controls.Add(this.Exp_comboBox1);
            this.tabPage2.Controls.Add(this.manufacturer_comboBox);
            this.tabPage2.Controls.Add(this.typeToy_comboBox);
            this.tabPage2.Controls.Add(this.soppliers_comboBox);
            this.tabPage2.Controls.Add(this.country_comboBox);
            this.tabPage2.Controls.Add(this.priceMin_textBox);
            this.tabPage2.Controls.Add(this.priceMax_textBox);
            this.tabPage2.Controls.Add(this.maxDateTimePicker2);
            this.tabPage2.Controls.Add(this.minDateTimePicker);
            this.tabPage2.Controls.Add(this.maxDate_label);
            this.tabPage2.Controls.Add(this.minDate_label);
            this.tabPage2.Controls.Add(this.priceMax_label);
            this.tabPage2.Controls.Add(this.priceMin_label);
            this.tabPage2.Controls.Add(this.country_label);
            this.tabPage2.Controls.Add(this.soppliers_label);
            this.tabPage2.Controls.Add(this.TypeToy_label);
            this.tabPage2.Controls.Add(this.Manufacturer_label);
            this.tabPage2.Controls.Add(this.SaerchParam_label);
            this.tabPage2.Controls.Add(this.searchParametr_comboBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1246, 647);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Поиск по параметрам";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SelectToys_dataGridView
            // 
            this.SelectToys_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SelectToys_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectToys_dataGridView.Location = new System.Drawing.Point(579, 90);
            this.SelectToys_dataGridView.Name = "SelectToys_dataGridView";
            this.SelectToys_dataGridView.Size = new System.Drawing.Size(632, 508);
            this.SelectToys_dataGridView.TabIndex = 22;
            // 
            // serch_button
            // 
            this.serch_button.Location = new System.Drawing.Point(340, 226);
            this.serch_button.Name = "serch_button";
            this.serch_button.Size = new System.Drawing.Size(223, 118);
            this.serch_button.TabIndex = 21;
            this.serch_button.Text = "Поиск по выбранным парметрам ==>";
            this.serch_button.UseVisualStyleBackColor = true;
            this.serch_button.Click += new System.EventHandler(this.serch_button_Click);
            // 
            // Exp_comboBox1
            // 
            this.Exp_comboBox1.FormattingEnabled = true;
            this.Exp_comboBox1.Location = new System.Drawing.Point(15, 554);
            this.Exp_comboBox1.Name = "Exp_comboBox1";
            this.Exp_comboBox1.Size = new System.Drawing.Size(250, 21);
            this.Exp_comboBox1.TabIndex = 19;
            // 
            // manufacturer_comboBox
            // 
            this.manufacturer_comboBox.FormattingEnabled = true;
            this.manufacturer_comboBox.Location = new System.Drawing.Point(18, 129);
            this.manufacturer_comboBox.Name = "manufacturer_comboBox";
            this.manufacturer_comboBox.Size = new System.Drawing.Size(250, 21);
            this.manufacturer_comboBox.TabIndex = 17;
            // 
            // typeToy_comboBox
            // 
            this.typeToy_comboBox.FormattingEnabled = true;
            this.typeToy_comboBox.Location = new System.Drawing.Point(18, 197);
            this.typeToy_comboBox.Name = "typeToy_comboBox";
            this.typeToy_comboBox.Size = new System.Drawing.Size(250, 21);
            this.typeToy_comboBox.TabIndex = 16;
            // 
            // soppliers_comboBox
            // 
            this.soppliers_comboBox.FormattingEnabled = true;
            this.soppliers_comboBox.Location = new System.Drawing.Point(18, 276);
            this.soppliers_comboBox.Name = "soppliers_comboBox";
            this.soppliers_comboBox.Size = new System.Drawing.Size(250, 21);
            this.soppliers_comboBox.TabIndex = 15;
            // 
            // country_comboBox
            // 
            this.country_comboBox.FormattingEnabled = true;
            this.country_comboBox.Location = new System.Drawing.Point(18, 346);
            this.country_comboBox.Name = "country_comboBox";
            this.country_comboBox.Size = new System.Drawing.Size(250, 21);
            this.country_comboBox.TabIndex = 14;
            // 
            // priceMin_textBox
            // 
            this.priceMin_textBox.Location = new System.Drawing.Point(18, 412);
            this.priceMin_textBox.Name = "priceMin_textBox";
            this.priceMin_textBox.Size = new System.Drawing.Size(112, 20);
            this.priceMin_textBox.TabIndex = 13;
            // 
            // priceMax_textBox
            // 
            this.priceMax_textBox.Location = new System.Drawing.Point(244, 412);
            this.priceMax_textBox.Name = "priceMax_textBox";
            this.priceMax_textBox.Size = new System.Drawing.Size(100, 20);
            this.priceMax_textBox.TabIndex = 12;
            // 
            // maxDateTimePicker2
            // 
            this.maxDateTimePicker2.Location = new System.Drawing.Point(244, 483);
            this.maxDateTimePicker2.Name = "maxDateTimePicker2";
            this.maxDateTimePicker2.Size = new System.Drawing.Size(152, 20);
            this.maxDateTimePicker2.TabIndex = 11;
            // 
            // minDateTimePicker
            // 
            this.minDateTimePicker.Location = new System.Drawing.Point(15, 483);
            this.minDateTimePicker.Name = "minDateTimePicker";
            this.minDateTimePicker.Size = new System.Drawing.Size(152, 20);
            this.minDateTimePicker.TabIndex = 10;
            // 
            // maxDate_label
            // 
            this.maxDate_label.AutoSize = true;
            this.maxDate_label.Location = new System.Drawing.Point(241, 467);
            this.maxDate_label.Name = "maxDate_label";
            this.maxDate_label.Size = new System.Drawing.Size(109, 13);
            this.maxDate_label.TabIndex = 9;
            this.maxDate_label.Text = "Дата продажи макс";
            // 
            // minDate_label
            // 
            this.minDate_label.AutoSize = true;
            this.minDate_label.Location = new System.Drawing.Point(12, 467);
            this.minDate_label.Name = "minDate_label";
            this.minDate_label.Size = new System.Drawing.Size(103, 13);
            this.minDate_label.TabIndex = 8;
            this.minDate_label.Text = "Дата продажи мин";
            // 
            // priceMax_label
            // 
            this.priceMax_label.AutoSize = true;
            this.priceMax_label.Location = new System.Drawing.Point(241, 396);
            this.priceMax_label.Name = "priceMax_label";
            this.priceMax_label.Size = new System.Drawing.Size(61, 13);
            this.priceMax_label.TabIndex = 7;
            this.priceMax_label.Text = "Макс цена";
            // 
            // priceMin_label
            // 
            this.priceMin_label.AutoSize = true;
            this.priceMin_label.Location = new System.Drawing.Point(15, 396);
            this.priceMin_label.Name = "priceMin_label";
            this.priceMin_label.Size = new System.Drawing.Size(55, 13);
            this.priceMin_label.TabIndex = 6;
            this.priceMin_label.Text = "Мин цена";
            // 
            // country_label
            // 
            this.country_label.AutoSize = true;
            this.country_label.Location = new System.Drawing.Point(15, 330);
            this.country_label.Name = "country_label";
            this.country_label.Size = new System.Drawing.Size(117, 13);
            this.country_label.TabIndex = 5;
            this.country_label.Text = "Стран производитель";
            // 
            // soppliers_label
            // 
            this.soppliers_label.AutoSize = true;
            this.soppliers_label.Location = new System.Drawing.Point(15, 260);
            this.soppliers_label.Name = "soppliers_label";
            this.soppliers_label.Size = new System.Drawing.Size(110, 13);
            this.soppliers_label.TabIndex = 4;
            this.soppliers_label.Text = "Поставщик игрушек";
            // 
            // TypeToy_label
            // 
            this.TypeToy_label.AutoSize = true;
            this.TypeToy_label.Location = new System.Drawing.Point(15, 181);
            this.TypeToy_label.Name = "TypeToy_label";
            this.TypeToy_label.Size = new System.Drawing.Size(71, 13);
            this.TypeToy_label.TabIndex = 3;
            this.TypeToy_label.Text = "Вид игрушек";
            // 
            // Manufacturer_label
            // 
            this.Manufacturer_label.AutoSize = true;
            this.Manufacturer_label.Location = new System.Drawing.Point(15, 113);
            this.Manufacturer_label.Name = "Manufacturer_label";
            this.Manufacturer_label.Size = new System.Drawing.Size(86, 13);
            this.Manufacturer_label.TabIndex = 2;
            this.Manufacturer_label.Text = "Производитель";
            // 
            // SaerchParam_label
            // 
            this.SaerchParam_label.AutoSize = true;
            this.SaerchParam_label.Location = new System.Drawing.Point(12, 27);
            this.SaerchParam_label.Name = "SaerchParam_label";
            this.SaerchParam_label.Size = new System.Drawing.Size(105, 13);
            this.SaerchParam_label.TabIndex = 1;
            this.SaerchParam_label.Text = "Параметры поиска";
            // 
            // searchParametr_comboBox
            // 
            this.searchParametr_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchParametr_comboBox.FormattingEnabled = true;
            this.searchParametr_comboBox.Items.AddRange(new object[] {
            "Найти игрушки в пределах заданной цены, можно указать вид игрушек",
            "Найти игрушки выбранного производителя",
            "Найти все игрушки с датой заданной датой оприходования на склад",
            "Найти все игрушки с заданным весом, вцелом и по производителю",
            "Найти все игрушки поступившие от заданного постащика",
            "Найти долю игрушек дешевле указанной цены и для возраста, младше указанного",
            "Оcобый поиск № 1 - игрушки от заданного поcтав-ка, чья стоимость больше, чем стои" +
                "мость аданной игрушки, поступишей из заданной страны",
            "Оcобый поиск № 2 - доля дешевых игрушек вцелом и по поставщику ",
            "Особый поиск № 3- средняя цена игруше проданных за определенный период",
            "Особый поиск № 4- найти все игрушки , чья стоимость выше, чем средняя стоимость и" +
                "грушек заданного производителя",
            "Особый поиск № 5- самый популярный вид игрушки для указанного возраста и в целом"});
            this.searchParametr_comboBox.Location = new System.Drawing.Point(15, 43);
            this.searchParametr_comboBox.Name = "searchParametr_comboBox";
            this.searchParametr_comboBox.Size = new System.Drawing.Size(1196, 21);
            this.searchParametr_comboBox.TabIndex = 0;
            this.searchParametr_comboBox.SelectedIndexChanged += new System.EventHandler(this.searchParametr_comboBox_SelectedIndexChanged_1);
            // 
            // ListsOfToysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 688);
            this.Controls.Add(this.tabControl1);
            this.Name = "ListsOfToysForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListsOfToysForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SelectedToy_dataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectToys_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label TypeOfSelect_label;
        private System.Windows.Forms.ListBox typeOfSelect_listBox;
        private System.Windows.Forms.DataGridView SelectedToy_dataGridView;
        private System.Windows.Forms.Label SaerchParam_label;
        private System.Windows.Forms.ComboBox searchParametr_comboBox;
        private System.Windows.Forms.Label priceMin_label;
        private System.Windows.Forms.Label country_label;
        private System.Windows.Forms.Label soppliers_label;
        private System.Windows.Forms.Label TypeToy_label;
        private System.Windows.Forms.Label Manufacturer_label;
        private System.Windows.Forms.Label maxDate_label;
        private System.Windows.Forms.Label minDate_label;
        private System.Windows.Forms.Label priceMax_label;
        private System.Windows.Forms.DateTimePicker maxDateTimePicker2;
        private System.Windows.Forms.DateTimePicker minDateTimePicker;
        private System.Windows.Forms.TextBox priceMin_textBox;
        private System.Windows.Forms.TextBox priceMax_textBox;
        private System.Windows.Forms.ComboBox manufacturer_comboBox;
        private System.Windows.Forms.ComboBox typeToy_comboBox;
        private System.Windows.Forms.ComboBox soppliers_comboBox;
        private System.Windows.Forms.ComboBox country_comboBox;
        private System.Windows.Forms.ComboBox Exp_comboBox1;
        private System.Windows.Forms.Button serch_button;
        private System.Windows.Forms.DataGridView SelectToys_dataGridView;
    }
}