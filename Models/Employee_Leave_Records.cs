namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee_Leave_Records
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee_Leave_Records()
        {
            Leave_Approvals = new HashSet<Leave_Approvals>();
        }

        [Key]
        public int Leave_Record_ID { get; set; }

        public int? Employee_ID { get; set; }

        public int? Leave_Type_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Start_Date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? End_Date { get; set; }

        public int? Total_Days { get; set; }

        [StringLength(50)]
        public string Leave_Status { get; set; }

        [Column(TypeName = "text")]
        public string Remarks { get; set; }

        public virtual Employee_Appointment_Details Employee_Appointment_Details { get; set; }

        public virtual Leave_Types Leave_Types { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Leave_Approvals> Leave_Approvals { get; set; }
    }
}
