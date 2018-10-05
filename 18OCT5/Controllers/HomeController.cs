using _18OCT5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _18OCT5.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index3()
        {
            return "Hello World";
        }

        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult RSVP()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RSVP(GuestResponse gr)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", gr);
            }
            else
            {
                return View();
            }
        }
    }
}