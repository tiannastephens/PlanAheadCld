using Microsoft.AspNetCore.Mvc;
using PACAPP.Models;

namespace PACAPP.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult User()
        {
            return View();
        }

        //CREATE
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(User u)
        {
            return RedirectToAction("UserDetails");
        }

        //READ 
        public IActionResult UserDetails(int Id)
        {
            User u = new User();
            u.Id = 1;
            u.UserName = "Juice";
            u.Password = "JJ";
            return View(u);
        }

        //UPDATE
        [HttpGet]
        public IActionResult Edit(int id)
        {
            User u = new User();
            u.Id = 1;
            u.UserName = "Juice";
            u.Password = "JJ";
            return View(u);
        }
        [HttpPost]
        public IActionResult Edit(User u)
        {
            return RedirectToAction("UserDetails");
        }
    }
}
