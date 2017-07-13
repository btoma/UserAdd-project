using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using UserAdd.Models;

namespace UserAdd.Repositories
{
    public class UserRepository
    {


        public void AddUser(User user)
        {
            AddUserContext context = new AddUserContext();
            context.Users.Add(user);
            context.SaveChanges();
            context.Dispose();
        

        }
        public List<User> Users
        {
            get
            {
                
                using (AddUserContext context = new AddUserContext()) {
                    return context.Users.ToList();
                }
                                           
               
            }
        }

        public void EditContact(User user)
        {
            using (AddUserContext context = new AddUserContext())
            {
                context.Users.Attach(user);
                context.Entry(user).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public User GetContact(int id)
        {
            AddUserContext context = new AddUserContext();
            return context.Users.Where(u => u.ID == id).First();

          
        }
        public void Delete(int id)
        {
            using (AddUserContext context = new AddUserContext())
            {
                context.Users.Remove(context.Users.First(u => u.ID == id));
                context.SaveChanges();
            }
            
        }

        public List<User> Search(string query)
        {
            AddUserContext context = new AddUserContext();
            var queryz = context.Users.Where(x => x.FirstName.ToUpper().Contains(query.ToUpper()));
            return queryz.ToList();
        }

    }
}