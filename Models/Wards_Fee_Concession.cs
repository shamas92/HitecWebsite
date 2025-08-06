namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Wards_Fee_Concession
    {
        [Key]
        public int Concession_ID { get; set; }

        public int? Employee_ID { get; set; }

        [StringLength(100)]
        public string Ward_Name { get; set; }

        public int? TuiQon_Fee_Concession_Percent { get; set; }

        public virtual Employee_Appointment_Details Employee_Appointment_Details { get; set; }
    }
}
