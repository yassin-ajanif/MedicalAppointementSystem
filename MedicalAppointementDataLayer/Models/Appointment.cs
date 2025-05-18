namespace MedicalAppointementDataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Appointment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Appointment()
        {
            MedicalRecords = new HashSet<MedicalRecord>();
        }

        public int AppointmentID { get; set; }

        public int PatientID { get; set; }

        [Column(TypeName = "date")]
        public DateTime AppointmentDate { get; set; }

        public TimeSpan StartTime { get; set; }

        public TimeSpan EndTime { get; set; }

        public int AppointmentStatusID { get; set; }

        public DateTime? CreatedAt { get; set; }

        public virtual Patient Patient { get; set; }

        public virtual AppointmentStatus AppointmentStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicalRecord> MedicalRecords { get; set; }
    }
}
