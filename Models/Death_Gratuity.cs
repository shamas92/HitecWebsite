namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Death_Gratuity
    {
        [Key]
        public int Gratuity_ID { get; set; }

        public int? Employee_ID { get; set; }

        [StringLength(50)]
        public string Cause { get; set; }

        public decimal? Lump_Sum_Payment { get; set; }

        public decimal? Funeral_Grant { get; set; }

        public int? Leave_Encashment_Months { get; set; }

        public virtual Employee_Appointment_Details Employee_Appointment_Details { get; set; }
    }
}
