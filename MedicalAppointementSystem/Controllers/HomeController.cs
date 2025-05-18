using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using MedicalAppointementBusinessLayer;
using MedicalAppointementBusinessLayer.Interfaces;


namespace MedicalAppointementSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userService;

        public HomeController(IUserService userService)
        {
            _userService = userService;
        }

        public ActionResult Index()
        {
            var username = _userService.GetAllUsers();

            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
