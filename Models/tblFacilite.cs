namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblFacilite
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblFacilite()
        {
            tblFacilityPhotos = new HashSet<tblFacilityPhoto>();
        }

        [Key]
        public int FacilityID { get; set; }

        [Column("_Order")]
        public int? C_Order { get; set; }

        public int? DepartmentID { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(50)]
        public string Banner { get; set; }

        public string Details { get; set; }

        public bool? Active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblFacilityPhoto> tblFacilityPhotos { get; set; }
    }
}
