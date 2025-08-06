namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblAccommodationRefundPolicy")]
    public partial class tblAccommodationRefundPolicy
    {
        [Key]
        public int RefundPolicyID { get; set; }

        [Required]
        [StringLength(255)]
        public string Deadline { get; set; }

        [Required]
        [StringLength(255)]
        public string RefundAmount { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
