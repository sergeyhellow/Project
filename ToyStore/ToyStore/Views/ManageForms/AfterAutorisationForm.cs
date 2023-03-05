using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToyStore.Views.ManageForms
{
    public partial class AfterAutorisationForm : Form
    {
        UserEx currentUser;
        public AfterAutorisationForm(UserEx user)
        {
            InitializeComponent();
            currentUser=user;   
            Store_button.Click += Store_button_Click;

        }

        private void Store_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(currentUser.ToString() + "Магазин пока не сделан");
        }

        private void Admins_forms_Click(object sender, EventArgs e)
        {
           
            AdminMenuForm adminMenuForm = new AdminMenuForm();
            adminMenuForm.ShowDialog();
        }
    }
}
