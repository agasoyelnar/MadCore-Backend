using MadCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MadCore.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {

            return View();
        }


    }
}
