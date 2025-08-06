namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Program_EducaQonal_ObjecQves
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Program_EducaQonal_ObjecQves()
        {
            PEO_AVainment = new HashSet<PEO_AVainment>();
            PEO_PLO_Mapping = new HashSet<PEO_PLO_Mapping>();
        }

        [Key]
        public int PEO_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string PEO_Code { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string PEO_DescripQon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PEO_AVainment> PEO_AVainment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PEO_PLO_Mapping> PEO_PLO_Mapping { get; set; }
    }
}
