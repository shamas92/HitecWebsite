namespace HitecCM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblPolicy")]
    public partial class tblPolicy
    {
        [Key]
        public int Id { get; set; }

        [StringLength(255)]
        public string PageTitle { get; set; }

        [Column(TypeName = "text")]
        public string PageData { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? UploadedDate { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
    }
}