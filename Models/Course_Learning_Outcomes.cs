namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Course_Learning_Outcomes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Course_Learning_Outcomes()
        {
            PLO_CLO_Mapping = new HashSet<PLO_CLO_Mapping>();
        }

        [Key]
        public int CLO_ID { get; set; }

        public int Course_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string CLO_Code { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string CLO_DescripQon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PLO_CLO_Mapping> PLO_CLO_Mapping { get; set; }
    }
}
