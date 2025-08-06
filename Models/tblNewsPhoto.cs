namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("hitecuniCM.tblNewsPhotos")]
    public partial class tblNewsPhoto
    {
        [Key]
        public int NewsPhotoID { get; set; }

        public int? NewsID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Date { get; set; }

        [StringLength(50)]
        public string Photo { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public virtual tblNew tblNew { get; set; }
    }
}
