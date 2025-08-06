namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblFacilityPhotos")]
    public partial class tblFacilityPhoto
    {
        [Key]
        public int FacilityPhotosID { get; set; }

        public int FacilityID { get; set; }

        [StringLength(50)]
        public string Photo { get; set; }

        public virtual tblFacilite tblFacilite { get; set; }
    }
}
