using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToyStore.Model;
using ToyStore.UtilityClasses;

namespace ToyStore.Views
{
    public partial class AddToyForm : Form

    {
        //  private readonly ToyStoreContext _context;

        List<StorrageOfToy> currentBatch = new List<StorrageOfToy>();

        ChekerCompletness cheker=new ChekerCompletness();

        ToyManufacturer ToyManufacturer = new ToyManufacturer();

        AddElements addElements = AddElements.Instance;

        DbService dbService = DbService.Instance;
        public AddToyForm()
        {
            InitializeComponent();
       
            
            UpDateComboBox();

          


        }

      
        private async void AddToy_button_Click(object sender, EventArgs e)
        {
            
            if (cheker.ChekDataCompleteness(tabPage1, "Заполните параметры новой игрушки"))
            {
                decimal weight;

                if (Decimal.TryParse(weighTextBox.Text, out weight));
                else
                {
                    MessageBox.Show("Вес нужно указать числом");
                    return;
                }
                if (await addElements.AddNewToy(toyName_textBox.Text,
                                                 ((ToyManufacturer)Manuf_comboBox.SelectedItem).Id,
                                                 weight,
                                                 ((ToyType)TypToy_comboBox.SelectedItem).Id,
                                                 ((CountryOfOrigin)Country_comboBox.SelectedItem).Id
                                                  ))
                { }
                else
                {
                    MessageBox.Show("Такая игрушка уже есть");
                }

            }
            else 
            {
                return;
            }
        

        }

       private async void UpDateComboBox()
        {
            var listOfCountry = await dbService.SelectCountry();
            listOfCountry.ForEach(c => Country_comboBox.Items.Add(c));



          var listOfManufacturer = await dbService.SelectManufacturer();
           listOfManufacturer.ForEach(m => Manuf_comboBox.Items.Add(m));


            var listOfTypeToy = await dbService.SelectTypeOfToy();
            listOfTypeToy.ForEach(t => TypToy_comboBox.Items.Add(t));

            var listOfToy = (await dbService.SelectToy());
            listOfToy.ForEach(t => ToyToST_comboBox.Items.Add(t));

            (await dbService.SelectToySopplier()).ForEach(t => SoppliersToST_comboBox.Items.Add(t));

        }

        private async void Add_button_Click(object sender, EventArgs e)
        {
            if (cheker.ChekDataCompleteness(tabPage2, "Заполните наименование"))
            {
                switch (directiryPropertycomboBox.SelectedIndex)
                {
                    case 0:

                     if ( await  addElements.AddCountry(name_textBox)==null)MessageBox.Show("Уже есть такой"); ;
                      Directory_listBox.Items.Clear();
                      (await dbService.SelectCountry()).ForEach(c => Directory_listBox.Items.Add(c));


                        break;

                    case 1:
                       if(await addElements.AddSopplier(name_textBox)==null) MessageBox.Show("Уже есть такой"); ;
                        Directory_listBox.Items.Clear();
                        (await dbService.SelectToySopplier()).ForEach(c => Directory_listBox.Items.Add(c));
                        break;

                    case 2:
                      if(await addElements.AddManufacturer(name_textBox)==null) MessageBox.Show("Уже есть такой");
                        Directory_listBox.Items.Clear();
                        (await dbService.SelectManufacturer()).ForEach(c => Directory_listBox.Items.Add(c));
                        break;

                    case 3:

                        break;


                }
            }
                      

        }

        private async void directiryPropertycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Directory_listBox.Items.Clear();
            switch (directiryPropertycomboBox.SelectedIndex)
            {
                case 0:

                  (await dbService.SelectCountry()).ForEach(c=>Directory_listBox.Items.Add(c));
                 
                    break;

                case 1:
                    (await dbService.SelectToySopplier()).ForEach(c => Directory_listBox.Items.Add(c));
                    break;

                case 2:
                    (await dbService.SelectManufacturer()).ForEach(c => Directory_listBox.Items.Add(c));
                    break;
          
            }


        }

        private void addToBatch_button_Click(object sender, EventArgs e)
        {
            
            if (cheker.ChekDataCompleteness(tabPage3, "Не все поля заполнены") == true)
            {
                int amount;
                if (int.TryParse(Amount_numericUpDown.Value.ToString(), out amount))
                {
                }
                else 
                { MessageBox.Show("Что то не так с числом"); 
                }

                currentBatch = addElements.AddToyToBatch((ToyToST_comboBox.SelectedItem as Toy),
                                            SoppliersToST_comboBox.SelectedItem as ToySopplier,
                                            amount,
                                            (DateTime)registration_dateTimePicker.Value,
                                            currentBatch
                                            );
                Batch_label.Text = "Состав партии";
                batchOrStore_dataGridView.DataSource = currentBatch.Select(x => new { Value = x}).ToList();
            }
            else
            {
                return;
            }

        }

        private async void registerBatchToStore_button_Click(object sender, EventArgs e)
        {
           await addElements.AddToyToBatchToStorrage(currentBatch);
        }

        private void ClearBatch_button_Click(object sender, EventArgs e)
        {
            Batch_label.Text = "Состав партии";
            currentBatch.Clear();
            batchOrStore_dataGridView.DataSource = currentBatch.Select(x => new { Value = x }).ToList();
        }

        private async void batchStore_button_Click(object sender, EventArgs e)
        {
            if (Batch_label.Text == "Состав партии")
            {
                await addElements.SelectStorrageOfToy(batchOrStore_dataGridView);
                Batch_label.Text = "На складе";

            }
            else
            {
                Batch_label.Text = "Состав партии";
                batchOrStore_dataGridView.DataSource = currentBatch.Select(x => new { Value = x }).ToList();
            }
        }
    }


}

   

