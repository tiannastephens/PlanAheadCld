using Microsoft.AspNetCore.Mvc;
using PACAPP.Models;

namespace PACAPP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
