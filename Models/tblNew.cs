namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("hitecuniCM.tblNews")]
    public partial class tblNew
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblNew()
        {
            tblNewsPhotos = new HashSet<tblNewsPhoto>();
        }

        [Key]
        public int NewsID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Date { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NewsDate { get; set; }

        public int? NewsHeadID { get; set; }

        public int? DepartmentID { get; set; }

        [StringLength(50)]
        public string Thumbnail { get; set; }

        [StringLength(50)]
        public string Venue { get; set; }

        [StringLength(250)]
        public string Title { get; set; }

        public string Details { get; set; }

        public int? Views { get; set; }

        public bool? Active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblNewsPhoto> tblNewsPhotos { get; set; }
    }
}
