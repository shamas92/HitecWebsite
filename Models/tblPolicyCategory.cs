namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblPolicyCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPolicyCategory()
        {
            tblPolicyItems = new HashSet<tblPolicyItem>();
        }

        public int Id { get; set; }

        [StringLength(100)]
        public string CategoryName { get; set; }

        [Column(TypeName = "text")]
        public string CategoryDescription { get; set; }

        public int? DisplayOrder { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPolicyItem> tblPolicyItems { get; set; }
    }
}
