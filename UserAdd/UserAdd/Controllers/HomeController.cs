using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserAdd.Models;
using Dapper;
using UserAdd.Repositories;

namespace UserAdd.Controllers
{
    public class HomeController : Controller
    {
        static UserRepository _userRepository = new UserRepository();
        public ActionResult Index()
        {
            return View(_userRepository.Users);
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

        public ActionResult EditContact(int id)
        {
            return View("EditUser", _userRepository.GetContact(id));
        }

        public ActionResult DeleteContact(int id)
        {
            _userRepository.Delete(id);
            return View("Index", _userRepository.Users);
        }

        public ActionResult ChangeUser(User user)
        {
            _userRepository.EditContact(user);
            return View("UserList", _userRepository.Users);
        }

        [HttpGet]
        public ActionResult Search()
        {
            return PartialView("_SearchFormPartial");
        }

        [HttpPost]
        public ActionResult Search(string query)
        {
            if (query != null)
            {
                try
                {
                    var searchlist = _userRepository.Search(query);

               
                  

                    return PartialView("_SearchResultsPartial", searchlist);
                }
                catch (Exception e)
                {
                    // handle exception
                }
            }
            return PartialView("Error");
        }
    }
    
}