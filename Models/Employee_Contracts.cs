namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee_Contracts
    {
        [Key]
        public int Contract_ID { get; set; }

        public int? Employee_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Start_Date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? End_Date { get; set; }

        public bool? Renewed { get; set; }

        [StringLength(255)]
        public string Contract_Document { get; set; }

        public virtual Employee_Appointment_Details Employee_Appointment_Details { get; set; }
    }
}
