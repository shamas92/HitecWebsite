namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblAccommodation")]
    public partial class tblAccommodation
    {
        [Key]
        public int AccommodationID { get; set; }

        [Required]
        public string Description { get; set; }

        public decimal? HostelSecurityFee { get; set; }

        public decimal? HostelChargesPerMonth { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
