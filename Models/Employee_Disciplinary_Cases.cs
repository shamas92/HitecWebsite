namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee_Disciplinary_Cases
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee_Disciplinary_Cases()
        {
            Employee_Appeals = new HashSet<Employee_Appeals>();
        }

        [Key]
        public int Case_ID { get; set; }

        public int? Employee_ID { get; set; }

        public int? Breach_ID { get; set; }

        [StringLength(50)]
        public string Case_Status { get; set; }

        public bool? Inquiry_CommiVee_Assigned { get; set; }

        [StringLength(255)]
        public string Final_Decision { get; set; }

        public int? Penalty_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_IniQated { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_Closed { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee_Appeals> Employee_Appeals { get; set; }

        public virtual Employee_Appointment_Details Employee_Appointment_Details { get; set; }

        public virtual Employee_Breach_Conduct Employee_Breach_Conduct { get; set; }

        public virtual Employee_PenalQes Employee_PenalQes { get; set; }
    }
}
