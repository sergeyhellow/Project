using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToyStore.Forms;

namespace ToyStore
{
    public partial class AutorizationForm : Form
    {
        RegistrationForm registrationForm;
        public AutorizationForm()
        {
            InitializeComponent();
        }

        private void Registration_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registrationForm = new RegistrationForm();
            this.Visible = false;
            if (registrationForm.ShowDialog() == DialogResult.OK)
            {
                userData.AddNewUser(registrationForm.NewUser);
            }
            this.Visible = true;
        }
    }
}
