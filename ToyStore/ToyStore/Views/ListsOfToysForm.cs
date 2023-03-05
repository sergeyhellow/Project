using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToyStore.Model;
using ToyStore.UtilityClasses;

namespace ToyStore.Views
{
    public partial class ListsOfToysForm : Form
    {
        ToyStoreContext _context = new ToyStoreContext();
       
        SelectAny selectAny=new SelectAny();

        SelectService selectService = SelectService.Instance;


        private readonly DbService data = DbService.Instance;
        public ListsOfToysForm()
        {
            InitializeComponent();
            typeOfSelect_listBox.MouseDoubleClick += TypeOfSelect_listBox_MouseDoubleClick;
            searchParametr_comboBox.SelectedIndexChanged += SearchParametr_comboBox_SelectedIndexChanged;
           
            this.Load += ListsOfToysForm_Load;
           
        }

        private async void SearchParametr_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (searchParametr_comboBox.SelectedIndex)
            {
              case 0:
                    SetStandartNamesToLabels();

                    soppliers_comboBox.Enabled = false;
                    manufacturer_comboBox.Enabled = false;
                    country_comboBox.Enabled = false;
                    typeToy_comboBox.Enabled = true;
                    priceMin_textBox.Enabled = true;
                    priceMax_textBox.Enabled = true;
                    break;
                
                case 1:
                    SetStandartNamesToLabels();
                    priceMax_label.Text = "";
                    priceMin_label.Text = "";
                    soppliers_comboBox.Enabled = false;

                    manufacturer_comboBox.Items.Clear();
                    (await data.SelectManufacturer()).ForEach(m => manufacturer_comboBox.Items.Add(m));
                    manufacturer_comboBox.Enabled = true;
                    country_comboBox.Enabled = false;
                    typeToy_comboBox.Enabled = false;
                    priceMin_textBox.Enabled = false;
                    priceMax_textBox.Enabled = false;

                    break;
                case 2:
                    SetStandartNamesToLabels();
                    priceMax_label.Text = "";
                    priceMin_label.Text = "";
                    soppliers_comboBox.Enabled = false;
                    manufacturer_comboBox.Enabled = false;
                    country_comboBox.Enabled = false;
                    typeToy_comboBox.Enabled = false;
                    priceMin_textBox.Enabled = false;
                    priceMax_textBox.Enabled = false;


                    break;
                case 3:
                    SetStandartNamesToLabels();
                    priceMax_label.Text = "Максимальный вес"; 
                    priceMin_label.Text = "Минимальный вес";

                    soppliers_comboBox.Enabled = false;
                    manufacturer_comboBox.Enabled = true;
                    country_comboBox.Enabled = false;
                    typeToy_comboBox.Enabled = false;
                    priceMin_textBox.Enabled = true;
                    priceMax_textBox.Enabled = true;


                    break;
                case 4:
                    SetStandartNamesToLabels();
                    priceMax_label.Text = "";
                    priceMin_label.Text = "";
                    soppliers_comboBox.Enabled = true;
                    manufacturer_comboBox.Enabled = false;
                    country_comboBox.Enabled = false;
                    typeToy_comboBox.Enabled = false;
                    priceMin_textBox.Enabled = false;
                    priceMax_textBox.Enabled = false;

                    break;
                case 5:
                    SetStandartNamesToLabels();
                    priceMax_label.Text = "Укажите границу возраста"; 
                    priceMin_label.Text = "Укажите границу цены";
                    soppliers_comboBox.Enabled = false;
                    manufacturer_comboBox.Enabled = false;
                    country_comboBox.Enabled = false;
                    typeToy_comboBox.Enabled = false;
                    priceMin_textBox.Enabled = true;
                    priceMax_textBox.Enabled = true;
                    break;

                case 6:
                    SetStandartNamesToLabels();
                    priceMin_textBox.Enabled = false;
                    priceMax_textBox.Enabled = false;
                    manufacturer_comboBox.Enabled = true;
                    soppliers_comboBox.Enabled = true;
                    country_comboBox.Enabled = true;
                    typeToy_comboBox.Enabled = false;
                    Manufacturer_label.Text = "Укажите игрушку для сравнения";
                    manufacturer_comboBox.Items.Clear();
                    (await selectService.SelectToy()).ForEach(m => manufacturer_comboBox.Items.Add(m));

                    break;
                case 7:
                    SetStandartNamesToLabels();
                    soppliers_comboBox.Enabled = true;
                    typeToy_comboBox.Enabled = false;
                    country_comboBox.Enabled = false;
                    manufacturer_comboBox.Enabled = false;
                    priceMin_textBox.Enabled = true;
                    priceMax_textBox.Enabled = true;
                    priceMin_label.Text = "Предел цены";
                    priceMax_textBox.Enabled = false;
                    priceMax_label.Text = "";
                                      
                    break;


                case 8:
                    SetStandartNamesToLabels();
                    typeToy_comboBox.Enabled = false;
                    country_comboBox.Enabled = false;
                    manufacturer_comboBox.Enabled = false;
                    priceMin_textBox.Enabled = false;
                    priceMax_textBox.Enabled = false;
                    
                    priceMax_textBox.Enabled = false;
                    priceMax_label.Text = "";

                    break;

                case 9:
                    SetStandartNamesToLabels();
                    typeToy_comboBox.Enabled = false;
                    country_comboBox.Enabled = false;
                    soppliers_comboBox.Enabled = false;
                    manufacturer_comboBox.Enabled = true;
                    manufacturer_comboBox.Items.Clear();
                    (await data.SelectManufacturer()).ForEach(m => manufacturer_comboBox.Items.Add(m));
                    
                    priceMin_textBox.Enabled = false;
                    priceMax_textBox.Enabled = false;

                   

                    break;


                case 10:
                    SetStandartNamesToLabels();
                    typeToy_comboBox.Enabled = false;
                    country_comboBox.Enabled = false;
                    soppliers_comboBox.Enabled = false;
                    manufacturer_comboBox.Enabled = false;
                      priceMin_textBox.Enabled = true;
                    priceMax_textBox.Enabled = false;
                    priceMax_label.Text = "";
                    priceMin_label.Text = "Укажите минимальный возраст, для которого подходит игрушка";



                    break;



            }

        }
        private async void ListsOfToysForm_Load(object sender, EventArgs e)
        {
            (await data.SelectManufacturer()).ForEach(m => manufacturer_comboBox.Items.Add(m));
            (await data.SelectToySopplier()).ForEach(m => soppliers_comboBox.Items.Add(m));
            (await data.SelectTypeOfToy()).ForEach(m => typeToy_comboBox.Items.Add(m));
            (await data.SelectCountry()).ForEach(c=>country_comboBox.Items.Add(c));

        }

       
        private async void TypeOfSelect_listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {


            SelectedToy_dataGridView.DataSource = null;
        

            switch (typeOfSelect_listBox.SelectedIndex)
            {
            case 0: // reWriteSelecSerw

                    try
                    {
                        await selectService.SelectByOderDateOfRegister(SelectedToy_dataGridView);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                          

                    break;
               
            case 1:// reWrite
                    try
                    {
                        await selectService.SelectByAlphabeticalOder(SelectedToy_dataGridView);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }




                    break;
            
            case 2:// reWrite

                    try
                    {
                        await selectService.SelectOderByWeight(SelectedToy_dataGridView);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }



                    break;
            
            case 3:// reWrite

                    try
                    {

                        await selectService.SelectOderByPrice(SelectedToy_dataGridView);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    break;

            case 4: //reWrite

                    try
                    {
                        await selectService.SelectOderBySaleDate(SelectedToy_dataGridView);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    break;


                case 5:// reWrite
                    // самый дорогой вид

                    try
                    {
                        await selectService.SelectMostExpenciveType(SelectedToy_dataGridView);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    break;

                case 6: //reWrite
                    // самый дешевый вид
                    try
                    {
                        await selectService.SelectMostCheapType(SelectedToy_dataGridView);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    break;

                           case 7://reWrite
                    // средння по каждому типу
                    try
                    {
                        await selectService.SelectAveragePriceOfTypes(SelectedToy_dataGridView);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                    break;

                     case 8:// средння всех типов
                    try
                    {
                        await selectService.SelectAveragePriceOfAllTypes(SelectedToy_dataGridView);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    break;

                  case 9:
                    try
                    {
                        await selectService.SelectMostPopularToy(SelectedToy_dataGridView);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;


            }


          
        }

        private async void serch_button_Click(object sender, EventArgs e)
        {
           
            decimal minP;
            decimal maxP;

            decimal.TryParse(priceMin_textBox.Text.ToString(), out minP);
            decimal.TryParse(priceMax_textBox.Text.ToString(), out maxP);

            switch (searchParametr_comboBox.SelectedIndex)
            {
                

                case 0:// находим игрушки в пределах заданной цены


                    if (await selectService.ToySelectedByPriceAndType(SelectToys_dataGridView, minP, maxP, ((ToyType)typeToy_comboBox.SelectedItem))==true)
                    
                    {
                        
                    }
                    else
                    {             
                        MessageBox.Show("Неизвестная ошибка");
                    }
                    break;
                                       

                case 1:
                    try
                    {
                        await selectService.SelectToyByManufacture((manufacturer_comboBox.SelectedItem as ToyManufacturer).Id, SelectToys_dataGridView, (int)minP, (int)maxP);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + " Укажите производителя" ) ;
                    }
                    
                  
                    break;

                case 2:
                    try
                    {
                        await selectService.SelectByDateToStorrage(SelectToys_dataGridView, minDateTimePicker.Value, maxDateTimePicker2.Value);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    break;

                case 3:
                    if (manufacturer_comboBox.SelectedItem == null)
                    {
                        try
                        {
                            await selectService.SelectWeightManuf(SelectToys_dataGridView, (int)minP, (int)maxP);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                    else
                    {
                        try
                        {
                            await selectService.SelectWeightManuf((manufacturer_comboBox.SelectedItem as ToyManufacturer).Id, SelectToys_dataGridView, (int)minP, (int)maxP);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                   
                    break;

                case 4:
                    try
                    {
                        await selectService.SelectBySopplier(((ToySopplier)soppliers_comboBox.SelectedItem).Id, SelectToys_dataGridView);
                      
                      
                      
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "Выберете поставщика");
                    }

                    break;

                case 5 :


                    if ((await selectService.SelectShaereOfCheapToys((int)minP, (int)maxP, SelectToys_dataGridView))==true)
                    {
                       
                    }
                    else 
                    {
                        MessageBox.Show("Укажите параметры");
                    }   
                        
                    break;


                case 6:
                    try
                    {
                        await (selectService.SelectBySopplierAnotherToyAndCountry(((ToySopplier)soppliers_comboBox.SelectedItem).Id,
                                                                                    ((Toy)manufacturer_comboBox.SelectedItem).Id,
                                                                                    ((CountryOfOrigin)country_comboBox.SelectedItem).Id,
                                                                                    SelectToys_dataGridView));
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message + " Укажите параметры");
                    }
                    
                    break;
                case 7:

                    try
                    {
                        await (selectService.SelectShareOfCheapAllAndSopplier(minP, SelectToys_dataGridView, ((ToySopplier)soppliers_comboBox.SelectedItem).Id));
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + " Укажите параметры");
                    }


                    break;
                case 8:
                    if (await selectService.SelectAveragePriceToPeriod(minDateTimePicker.Value, maxDateTimePicker2.Value, SelectToys_dataGridView))
                    {

                    }
                    else 
                    {
                        MessageBox.Show("Продаж за этот период не было");
                    }

                    break;

                case 9:// выбор игрушек, чья цена выше чем средняя цена данного производителя


                    try
                    {
                        await selectService.SelectToysPriceMoreThenManufact(((ToyManufacturer)manufacturer_comboBox.SelectedItem).Id, SelectToys_dataGridView);
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + " Укажите производителя");
                    }
                    break;


                case 10:
                    if(priceMin_textBox.Text=="")
                    { minP = -1; }

                    if (await selectService.SelectMostPopularToyForAge((int)minP, SelectToys_dataGridView))
                    {

                    }
                    else
                    {
                        MessageBox.Show("Укажите параметр");
                    }
                    break;





            }

        }

        private void exLabel_Click(object sender, EventArgs e)
        {

        }

        private void searchParametr_comboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        if(searchParametr_comboBox.SelectedIndex==2)
            {
                maxDate_label.Text = "Дата конца периода";
                minDate_label.Text = "Дата начала периода";
                    
            }


        }

        private void SetStandartNamesToLabels()
        {

            priceMax_label.Text = "Максимальная цена";
            priceMin_label.Text = "Минимальая цена";
            Manufacturer_label.Text = "Производитель";
            TypeToy_label.Text = "Вид игрушек";
            soppliers_label.Text = "Поставщик игрушек";
            country_label.Text = "Страна производитель";
            priceMax_label.Text = "Максимальная цена";
            priceMin_label.Text = "Минимальная цена";

        }


    }
    }


