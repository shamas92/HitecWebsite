namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblQAC")]
    public partial class tblQAC
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string PageTitle { get; set; }

        [Column(TypeName = "text")]
        public string PageText { get; set; }

        public DateTime? UploadedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
