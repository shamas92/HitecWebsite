namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Leave_EnQtlement
    {
        [Key]
        public int EnQtlement_ID { get; set; }

        public int? Employee_ID { get; set; }

        public int? Leave_Type_ID { get; set; }

        public int? Year { get; set; }

        public int? Total_EnQtled_Days { get; set; }

        public int? Days_Availed { get; set; }

        public int? Remaining_Days { get; set; }

        public virtual Employee_Appointment_Details Employee_Appointment_Details { get; set; }

        public virtual Leave_Types Leave_Types { get; set; }
    }
}
