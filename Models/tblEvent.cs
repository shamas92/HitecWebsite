namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblEvent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblEvent()
        {
            tblEventPhotos = new HashSet<tblEventPhoto>();
            tblEventVideos = new HashSet<tblEventVideo>();
        }

        [Key]
        public int EventID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Date { get; set; }

        public bool? AlumniEvent { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EventDate { get; set; }

        public int? EventHeadID { get; set; }

        public int? DepartmentID { get; set; }

        [StringLength(50)]
        public string Venue { get; set; }

        [StringLength(250)]
        public string Title { get; set; }

        [StringLength(50)]
        public string Banner { get; set; }

        public string Details { get; set; }

        public int? Views { get; set; }

        public bool? Active { get; set; }

        public virtual tblEventHead tblEventHead { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEventPhoto> tblEventPhotos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEventVideo> tblEventVideos { get; set; }
    }
}
