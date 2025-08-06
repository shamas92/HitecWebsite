namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EducaQon_Subsidy
    {
        [Key]
        public int Subsidy_ID { get; set; }

        public int? Employee_ID { get; set; }

        [StringLength(50)]
        public string Program { get; set; }

        public int? TuiQon_Fee_Subsidy_Percent { get; set; }

        public bool? Admission_RegistraQon_Fee_Paid { get; set; }

        public int? Bond_DuraQon_Years { get; set; }

        public virtual Employee_Appointment_Details Employee_Appointment_Details { get; set; }
    }
}
