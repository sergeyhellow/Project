using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToyStore.Forms;
using ToyStore.UtilityClasses;
using ToyStore.Views;
using ToyStore.Views.ManageForms;

namespace ToyStore
{
    public partial class MainForm : Form
    {
        RegistrationForm registrationForm;
        UserList userList;
        LoadListUsers loadedList;
        ChekerCompletness cheker = new ChekerCompletness();
        ShopForm shopForm;
        AfterAutorisationForm afterAutorisation;
        UserEx user;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Registration_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registrationForm = new RegistrationForm();
            this.Visible = false;
            if (registrationForm.ShowDialog() == DialogResult.OK)
            {
                
            }
            this.Visible = true;
        }

        private void viewing_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UnregisteredUserForm UnregUserForm = new UnregisteredUserForm();
            this.Visible = false;
            if (UnregUserForm.ShowDialog() == DialogResult.OK)
            {

            }
            this.Visible = true;

        }

        private void Autorization_button_Click(object sender, EventArgs e)
        {

            if (cheker.ChekDataCompleteness(this, "Укажите логин и пароль"))
            {

                user = new UserEx()
                {
                    Login = login_textBox.Text,
                    Password = password_textBox.Text


                };

                userList = new UserList();
                loadedList = new LoadListUsers();
                loadedList.LoadList(userList);
                user = userList.CheckUser(user.Login, user.Password);
                if (user == null)
                {
                    MessageBox.Show("Вы не зарегистрированы, для совершения покупок нужно зарегистрироваться");
                }
                else
                {
                    MessageBox.Show($"Здравствуйте {user.FirstName} {user.LastName}");
                    if (user.Role == Roles.Buyer)
                    {
                        shopForm = new ShopForm(user);
                        this.Visible = false;
                        if (shopForm.ShowDialog() == DialogResult.OK)
                        {

                        }
                        this.Visible = true;
                    }
                    else
                    {
                        afterAutorisation=new AfterAutorisationForm(user);  
                        ThreadPool.QueueUserWorkItem(new WaitCallback(AdminEnter));

                    }

                }

            }
        

        }

        private void AdminEnter(object obj)
        {
          
            afterAutorisation = new AfterAutorisationForm(user);
            afterAutorisation.ShowDialog();
        }
    }
}
