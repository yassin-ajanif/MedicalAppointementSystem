namespace MedicalAppointementDataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MedicalRecord
    {
        [Key]
        public int RecordID { get; set; }

        public int PatientID { get; set; }

        public int? AppointmentID { get; set; }

        [Column(TypeName = "date")]
        public DateTime VisitDate { get; set; }

        public string Symptoms { get; set; }

        public string Diagnosis { get; set; }

        public string Treatment { get; set; }

        public string Notes { get; set; }

        public DateTime? CreatedAt { get; set; }

        public virtual Appointment Appointment { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
