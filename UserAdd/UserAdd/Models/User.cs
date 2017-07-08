using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserAdd.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; } 

    }
    public class UserList
    {
        public UserList() {
            Users = new List<User>();
        }
        public List<User> Users { get; set; }

        public User NewUser { get; set; }

    }
}