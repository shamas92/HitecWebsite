namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AdverQsement")]
    public partial class AdverQsement
    {
        [Key]
        public int AdID { get; set; }

        [Required]
        [StringLength(255)]
        public string ImagePath { get; set; }

        [StringLength(500)]
        public string DescripQon { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
