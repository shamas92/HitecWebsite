namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee_Transfers
    {
        [Key]
        public int Transfer_ID { get; set; }

        public int? Employee_ID { get; set; }

        [StringLength(100)]
        public string From_Department { get; set; }

        [StringLength(100)]
        public string To_Department { get; set; }

        [Column(TypeName = "text")]
        public string Transfer_Reason { get; set; }

        [StringLength(50)]
        public string VC_Approval_Status { get; set; }

        public virtual Employee_Appointment_Details Employee_Appointment_Details { get; set; }
    }
}
