namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ClassificaQon_Groups
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClassificaQon_Groups()
        {
            PosiQon_Details = new HashSet<PosiQon_Details>();
        }

        [Key]
        public int Group_ID { get; set; }

        [StringLength(100)]
        public string Group_Name { get; set; }

        [Column(TypeName = "text")]
        public string DescripQon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PosiQon_Details> PosiQon_Details { get; set; }
    }
}
