using MedicalAppointementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MedicalAppointementSystem.Controllers
{  
   

    public class AppointementController : Controller
    {
        // GET: Appointement


        public ActionResult Index()
        {
           
            ViewData["Appointments"] = Getappointements();
            ViewData["WeekDays"] = GetWeekDays();
            ViewData["slotCounts"] = GetSlotCounts();
            ViewData["Tooltip"] = GetTooltipOptions();
            ViewData["DayStartHour"] = GetDayStartHour();
            ViewData["DayEndHour"] = GetDayEndHour();
            ViewData["WorkStartHour"] = GetWorkStartHour();
            ViewData["WorkEndHour"] = GetWorkEndHour();

            return View();
        }



        private List<AppointmentData> Getappointements()
        {
             List<AppointmentData> Appointments = new List<AppointmentData>
    {
       new AppointmentData
        {
            Id = 1,
            Subject = "Meeting",
            StartTime = new DateTime(2025, 5, 25, 10, 0, 0),
            EndTime = new DateTime(2025, 5, 25, 11, 0, 0),
            IsAllDay = false
        },};

            return Appointments;
        }
        private List<object> GetWeekDays()
        {
            return new List<object>
        {
            new { text = "Sunday", value = "0" },
            new { text = "Monday", value = "1" },
            new { text = "Tuesday", value = "2" },
            new { text = "Wednesday", value = "3" },
            new { text = "Thursday", value = "4" },
            new { text = "Friday", value = "5" },
            new { text = "Saturday", value = "6" }
        };
        }

        private List<object> GetSlotCounts()
        {
            return new List<object>
    {
        new { Text = "1 Hour", Value = "1" },
        new { Text = "30 min", Value = "2" },
        new { Text = "15 min", Value = "4" },
        new { Text = "10 min", Value = "6" },
        new { Text = "5 min" , Value =  "12" }

    };
        }

        private List<object> GetTooltipOptions()
        {
            return new List<object>
    {
        new { Text = "On", Value = "On" },
        new { Text = "Off", Value = "Off" }
    };
        }

        private DateTime GetDayStartHour()
        {
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 9, 0, 0); // 9:00 AM
        }

        private DateTime GetDayEndHour()
        {
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 18, 0, 0); // 6:00 PM
        }

        private DateTime GetWorkStartHour()
        {
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 9, 0, 0); // 9:00 AM
        }

        private DateTime GetWorkEndHour()
        {
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 19, 0, 0); // 7:00 PM
        }


    }
}