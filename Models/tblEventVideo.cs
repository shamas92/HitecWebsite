namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblEventVideo
    {
        [Key]
        public int EventVideoID { get; set; }

        public int? EventID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Date { get; set; }

        [StringLength(50)]
        public string GoogleDriveFileID { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public virtual tblEvent tblEvent { get; set; }
    }
}
