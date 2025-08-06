namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblLatePaymentPenalty
    {
        [Key]
        public int PenaltyID { get; set; }

        [Required]
        [StringLength(255)]
        public string TimelineDescription { get; set; }

        [Required]
        public string PenaltyDetail { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
