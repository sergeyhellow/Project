using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToyStore
{
    public class LoadListUsers
    {
       

        SqlConnection connection = new SqlConnection(@"Data Source = WIN-QR717S0F3HA\SQLEXPRESS; Initial catalog=Project; Integrated Security=true;");
        SqlDataAdapter adapter;
        DataSet data = new DataSet();
        UserEx user;
        SqlCommand command;



        public LoadListUsers() { }

        public void LoadList(UserList userList)
        {

            adapter = new SqlDataAdapter("select * from Users;", connection);
            adapter.Fill(data);
            DataTable table = data.Tables[0];

            foreach (DataRow row in table.Rows)
            {
                 user = new UserEx()
                {

                    FirstName = row.ItemArray[1].ToString(),
                    LastName = row.ItemArray[2].ToString(),
                    PhoneNumber = row.ItemArray[3].ToString(),
                    Login = row.ItemArray[5].ToString(),
                    Password = row.ItemArray[6].ToString(),
                    Role = (Roles)Enum.Parse(typeof(Roles) ,row.ItemArray[4].ToString())
                };
                userList.AddNewUser(user);
               
            }
            
        }

        public void SaveClient(UserEx user)
        {
            adapter = new SqlDataAdapter();
              
           
         
           
            command = new SqlCommand("insert into Users " +
                                     "values" +
                                     " (@Name,@LastName,@pPhone,@Role,@Login,@Password);", connection);

            command.Parameters.AddWithValue("Name", user.FirstName);
            command.Parameters.AddWithValue("LastName", user.LastName);
            command.Parameters.AddWithValue("Role", user.Role.ToString());
            command.Parameters.AddWithValue("Login", user.Login);
            command.Parameters.AddWithValue("Password", user.Password);




            command.Parameters.Add(new SqlParameter("@pPhone", SqlDbType.NVarChar, 50));
            command.Parameters["@pPhone"].SqlValue = user.PhoneNumber.ToString(); ;




            MessageBox.Show("1");
            connection.Open();
            command.ExecuteNonQuery();
                     MessageBox.Show("2");
            connection.Close();

                     MessageBox.Show("3");








        }




    }
}



           

    

