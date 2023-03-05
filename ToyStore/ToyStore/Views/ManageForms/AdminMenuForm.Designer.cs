namespace ToyStore.Views.ManageForms
{
    partial class AdminMenuForm
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
            this.AddNewToy_butt = new System.Windows.Forms.Button();
            this.listOfiToys_button = new System.Windows.Forms.Button();
            this.SerachOfToys_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddNewToy_butt
            // 
            this.AddNewToy_butt.Location = new System.Drawing.Point(23, 49);
            this.AddNewToy_butt.Name = "AddNewToy_butt";
            this.AddNewToy_butt.Size = new System.Drawing.Size(331, 80);
            this.AddNewToy_butt.TabIndex = 0;
            this.AddNewToy_butt.Text = "Работа со справочниками, оприходование партий на склад";
            this.AddNewToy_butt.UseVisualStyleBackColor = true;
            this.AddNewToy_butt.Click += new System.EventHandler(this.AddNewToy_butt_Click);
            // 
            // listOfiToys_button
            // 
            this.listOfiToys_button.Location = new System.Drawing.Point(23, 191);
            this.listOfiToys_button.Name = "listOfiToys_button";
            this.listOfiToys_button.Size = new System.Drawing.Size(331, 50);
            this.listOfiToys_button.TabIndex = 1;
            this.listOfiToys_button.Text = "Посмотреть списки игрушек";
            this.listOfiToys_button.UseVisualStyleBackColor = true;
            this.listOfiToys_button.Click += new System.EventHandler(this.listOfiToys_button_Click);
            // 
            // SerachOfToys_button
            // 
            this.SerachOfToys_button.Location = new System.Drawing.Point(23, 273);
            this.SerachOfToys_button.Name = "SerachOfToys_button";
            this.SerachOfToys_button.Size = new System.Drawing.Size(331, 51);
            this.SerachOfToys_button.TabIndex = 2;
            this.SerachOfToys_button.Text = "Списать товар";
            this.SerachOfToys_button.UseVisualStyleBackColor = true;
            this.SerachOfToys_button.Click += new System.EventHandler(this.SerachOfToys_button_Click);
            // 
            // AdminMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 450);
            this.Controls.Add(this.SerachOfToys_button);
            this.Controls.Add(this.listOfiToys_button);
            this.Controls.Add(this.AddNewToy_butt);
            this.Name = "AdminMenuForm";
            this.Text = "AdminMenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddNewToy_butt;
        private System.Windows.Forms.Button listOfiToys_button;
        private System.Windows.Forms.Button SerachOfToys_button;
    }
}