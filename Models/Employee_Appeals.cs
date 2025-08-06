namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee_Appeals
    {
        [Key]
        public int Appeal_ID { get; set; }

        public int? Case_ID { get; set; }

        public int? Employee_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Appeal_Date { get; set; }

        [Column(TypeName = "text")]
        public string Appeal_DescripQon { get; set; }

        [StringLength(255)]
        public string Appeal_Decision { get; set; }

        public virtual Employee_Disciplinary_Cases Employee_Disciplinary_Cases { get; set; }

        public virtual Employee_Appointment_Details Employee_Appointment_Details { get; set; }
    }
}
