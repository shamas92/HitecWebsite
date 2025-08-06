namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Conference_IncenQves
    {
        [Key]
        public int IncenQve_ID { get; set; }

        public int? Employee_ID { get; set; }

        [StringLength(50)]
        public string Conference_Type { get; set; }

        public decimal? Max_Amount { get; set; }

        public virtual Employee_Appointment_Details Employee_Appointment_Details { get; set; }
    }
}
