namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblTransport")]
    public partial class tblTransport
    {
        [Key]
        public int TransportID { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [StringLength(500)]
        public string CoverageAreas { get; set; }

        public decimal? TransportChargesPerSemester { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
