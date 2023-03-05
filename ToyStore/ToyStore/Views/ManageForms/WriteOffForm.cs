using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToyStore.UtilityClasses;

namespace ToyStore.Views.ManageForms
{
    public partial class WriteOffForm : Form
    {
        AddElements addElements = AddElements.Instance;
        DbService DbService = DbService.Instance;   
        private BindingSource bindingSource1 = new BindingSource();
        public WriteOffForm()
        {
            InitializeComponent();
         
            Store_dataGridView.DoubleClick += Store_dataGridView_DoubleClick;
           
        }

        private void Store_dataGridView_DoubleClick(object sender, EventArgs e)
        {
         
            int row = Store_dataGridView.CurrentRow.Index;

            Toy_textBox.Text = Store_dataGridView[0, row].Value.ToString();
            Sopll_textBox.Text = Store_dataGridView[1, row].Value.ToString();
            Amount_textBox3.Text = Store_dataGridView[2, row].Value.ToString();
           

        }


        

        private async void showStorrage_button_Click(object sender, EventArgs e)
        {

           
            await addElements.SelectStorrageOfToy(bindingSource1);

           Store_dataGridView.DataSource = bindingSource1;
           

        }

        private void Store_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // Toy_textBox.Text=Store_dataGridView.

        }

        private async void registerBatchToStore_button_Click(object sender, EventArgs e)
        {
           

            try
            {
                if (int.Parse(Amount_textBox3.Text) < 0)
                {
                   
                    MessageBox.Show("Количество не менее нуля");
                    return;
                }
                if (MessageBox.Show("Применям изменения?\n" +
                    $"Новое количество игрушки {Sopll_textBox.Text} с ИД {Toy_textBox.Text}\n" +
                    $" теперь будет: {int.Parse(Amount_textBox3.Text)} ", "Редактируем количество", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                   await DbService.Edit_Click(int.Parse(Toy_textBox.Text), int.Parse(Amount_textBox3.Text));
                   await addElements.SelectStorrageOfToy(bindingSource1);
                   Store_dataGridView.DataSource = bindingSource1;
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
    }
}
