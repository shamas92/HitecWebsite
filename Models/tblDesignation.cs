namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblDesignation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblDesignation()
        {
            tblFaculties = new HashSet<tblFaculty>();
        }

        [Key]
        public int DesignationID { get; set; }

        [Column("_Order")]
        public int? C_Order { get; set; }

        [StringLength(50)]
        public string Designation { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblFaculty> tblFaculties { get; set; }
    }
}
