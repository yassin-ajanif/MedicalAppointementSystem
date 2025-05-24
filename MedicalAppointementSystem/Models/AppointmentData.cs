using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedicalAppointementSystem.Models
{
    public class AppointmentData
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Location { get; set; } // Optional
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsAllDay { get; set; }
        public string RecurrenceRule { get; set; } // Optional
    }
}