using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserAdd.Models;

namespace UserAdd.Controllers
{
    public class HomeController : Controller
    {
        static UserRepository _userRepository = new UserRepository();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult CreateUser()
        {
           
            return View("AddUser");
        }

        public ActionResult AddUser(User user)
        {
            _userRepository.AddUser(user);
            return View("SinglUser", user);
        }
     
        public ActionResult ViewAddUser()
        {
            return View("UserList", _userRepository.Users);
        }
    }
    public class UserRepository
    {
        private List<User> _users = new List<User>();

        public void AddUser(User user)
        {
            _users.Add(user);
        }
        public List<User> Users
        {
            get
            {
                return _users;
            }
        }
    }
}