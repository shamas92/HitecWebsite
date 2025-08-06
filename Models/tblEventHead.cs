namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblEventHead
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblEventHead()
        {
            tblEvents = new HashSet<tblEvent>();
        }

        [Key]
        public int EventHeadID { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        public bool? Active { get; set; }

        [Column("_Order")]
        public int? C_Order { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEvent> tblEvents { get; set; }
    }
}
