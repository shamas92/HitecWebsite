namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee_PenalQes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee_PenalQes()
        {
            Employee_Disciplinary_Cases = new HashSet<Employee_Disciplinary_Cases>();
        }

        [Key]
        public int Penalty_ID { get; set; }

        [StringLength(50)]
        public string Penalty_Type { get; set; }

        [Column(TypeName = "text")]
        public string Penalty_DescripQon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee_Disciplinary_Cases> Employee_Disciplinary_Cases { get; set; }
    }
}
