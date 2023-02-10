using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyStore
{
    public class UserList
    {
        public List <UserEx> AllUsers { get; set; } = new List<UserEx>();


        public void AddNewUser(UserEx user) 
        {
            AllUsers.Add(user);
        }
        public UserEx CheckUser(string login, string password)
        {
            foreach (UserEx user in AllUsers)
            {
                if (user.Login == login && user.Password == password)
                {
                    return user;
                }

            }


            return null;
        }

 
    }
}
