namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Hostel_Info
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hostel_Info()
        {
            Hostel_Requests = new HashSet<Hostel_Requests>();
        }

        [Key]
        public int Hostel_ID { get; set; }

        [StringLength(100)]
        public string Hostel_Name { get; set; }

        public int? Capacity { get; set; }

        [Column(TypeName = "text")]
        public string DescripQon { get; set; }

        [StringLength(255)]
        public string FaciliQes { get; set; }

        [StringLength(10)]
        public string Gender { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hostel_Requests> Hostel_Requests { get; set; }
    }
}
