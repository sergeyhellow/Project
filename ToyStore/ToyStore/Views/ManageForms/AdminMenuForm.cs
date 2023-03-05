using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToyStore.Views;

namespace ToyStore.Views.ManageForms
{
    public partial class AdminMenuForm : Form
    {
        public AdminMenuForm()
        {
            InitializeComponent();
        }

        private void AddNewToy_butt_Click(object sender, EventArgs e)
        {
            AddToyForm addToyForm = new AddToyForm();
            addToyForm.ShowDialog();
        }

        private void listOfiToys_button_Click(object sender, EventArgs e)
        {
            ListsOfToysForm listsOfToysForm = new ListsOfToysForm();
            listsOfToysForm.ShowDialog();
        }

        private void SerachOfToys_button_Click(object sender, EventArgs e)
        {
            WriteOffForm writeOffForm = new WriteOffForm();
            writeOffForm.ShowDialog();
        }
    }
}
