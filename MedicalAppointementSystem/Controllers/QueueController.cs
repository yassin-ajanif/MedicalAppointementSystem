﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedicalAppointementSystem.Controllers
{
    public class QueueController : Controller
    {
        // GET: Queue
        public ActionResult Index()
        {
            return View();
        }
    }
}