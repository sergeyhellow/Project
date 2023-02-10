using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyStore
{
    public enum Roles
    {
        Admin,
        Buyer

    }
    public class User
    {
       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Roles Role { get; set; }

    
        public User() { }

        public User(string firstName, string lastName, string phoneNumber, string login, string password, Roles role)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Login = login;
            Password = password;
            Role = role;
        }

        


        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Role} ";
        }

    }
}
