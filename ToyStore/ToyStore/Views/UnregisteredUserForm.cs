using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToyStore.UtilityClasses;

namespace ToyStore.Views
{
    public partial class UnregisteredUserForm : Form
    {
        Connection connection;
        public UnregisteredUserForm()
        {
            InitializeComponent();
            connection = new Connection();
        }

        private void ShowToyButton_Click(object sender, EventArgs e)
        {
            if (UnregUserDataGridView.Rows.Count > 0)
            {
                ((DataTable)UnregUserDataGridView.DataSource).Rows.Clear();
                ((DataTable)UnregUserDataGridView.DataSource).Columns.Clear();

            }
          

            string selectCom= "select [NameOfToy] as [Название игрушки], TypeOfToy as [Тип игрушки], [AgeOfTargetMin] as [Вотзраст ОТ]  " +
                              "from ToyTypes " +
                              "inner join Toys on ToyTypes.Id = Toys.ToyTypes_FK";
            if (priceOrderRadioButton.Checked)
            {
                selectCom = "select  [NameOfToy] as [Название игрушки], Price as [Цена]" +
                             " from Prices" +
                             " inner join Toys on Prices.Toys_FK = Toys.Id" +
                             " where PriceSettingDate = (select MAX (PriceSettingDate) from Prices where Prices.Toys_FK = Toys.Id)" +
                             " order by Price desc;";


            }

            if (TypeOrderRadioButton.Checked)
            {
                selectCom = "select  TypeOfToy as [Тип игрушки], [NameOfToy] as [Название игрушки] " +
                    "from ToyTypes " +
                    "inner join Toys on ToyTypes.Id = Toys.ToyTypes_FK " +
                    "order by TypeOfToy;";
            }


            if (AgeOrderRadioButton.Checked)
            {
                selectCom = "select   [NameOfToy] as [Название игрушки], AgeOfTargetMin as [Возраст ОТ] " +
                    "from ToyTypes " +
                    "inner join Toys on ToyTypes.Id = Toys.ToyTypes_FK " +
                    "order by AgeOfTargetMin";
            }



            connection.SelectToGrid(selectCom, UnregUserDataGridView);

            
        }
    }
}
