namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Program_Learning_Outcomes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Program_Learning_Outcomes()
        {
            PEO_PLO_Mapping = new HashSet<PEO_PLO_Mapping>();
            PLO_AVainment = new HashSet<PLO_AVainment>();
            PLO_CLO_Mapping = new HashSet<PLO_CLO_Mapping>();
        }

        [Key]
        public int PLO_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string PLO_Code { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string PLO_DescripQon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PEO_PLO_Mapping> PEO_PLO_Mapping { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PLO_AVainment> PLO_AVainment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PLO_CLO_Mapping> PLO_CLO_Mapping { get; set; }
    }
}
