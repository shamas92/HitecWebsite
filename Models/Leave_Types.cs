namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Leave_Types
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Leave_Types()
        {
            Employee_Leave_Records = new HashSet<Employee_Leave_Records>();
            Leave_EnQtlement = new HashSet<Leave_EnQtlement>();
        }

        [Key]
        public int Leave_Type_ID { get; set; }

        [StringLength(50)]
        public string Leave_Name { get; set; }

        [Column(TypeName = "text")]
        public string DescripQon { get; set; }

        public int? Max_Days_Per_Year { get; set; }

        [StringLength(50)]
        public string Pay_Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee_Leave_Records> Employee_Leave_Records { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Leave_EnQtlement> Leave_EnQtlement { get; set; }
    }
}
