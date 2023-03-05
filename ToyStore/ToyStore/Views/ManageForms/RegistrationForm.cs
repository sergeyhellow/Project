using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToyStore.UtilityClasses;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ToyStore.Forms
{
    public partial class RegistrationForm : Form
    {
        LoadListUsers loadedList;
        UserList userList;
        ChekerCompletness completness;
        UserEx user;
        public RegistrationForm()
        {
            InitializeComponent();
            loadedList = new LoadListUsers();
            userList = new UserList();  
            loadedList.LoadList(userList);
         
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void registration_button_Click(object sender, EventArgs e)
        {
            completness = new ChekerCompletness();
            
            if (completness.ChekDataCompleteness(this, "Не все поля заполнены"))
            {
                Phone_maskedTextBox.Mask = "00000000000";// так избежал ошибки при записи в базу, оставив юзерфрендли
               user = new UserEx()
                {
                    FirstName = Name_textBox.Text,
                    LastName = SecondName_textBox.Text,
                    PhoneNumber = Phone_maskedTextBox.Text.ToString(),
                    Login = Login_textBox.Text,
                    Password = password_textBox.Text,
                    Role = Roles.Buyer

                };
                Phone_maskedTextBox.Mask = "0(000)000-00-00";
                if (userList.CheckUser(user.Login, user.Password) != null)

                {
                    MessageBox.Show($"Пользователь с таким логином {user.Login} уже зарегистрирован");

                }
                else
                {
                    userList.AddNewUser(user);
                   
                    MessageBox.Show("Регистрация пройдена успешно");

                   
                }
                

            }

        }

        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (user != null)
            {
                loadedList.SaveClient(user);
            }
        }
    }
    }

