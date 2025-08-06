namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblEventPhotos")]
    public partial class tblEventPhoto
    {
        [Key]
        public int EventPhotoID { get; set; }

        public int? EventID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Date { get; set; }

        [StringLength(50)]
        public string Photo { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public virtual tblEvent tblEvent { get; set; }
    }
}
