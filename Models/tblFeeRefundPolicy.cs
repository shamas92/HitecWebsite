namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblFeeRefundPolicy")]
    public partial class tblFeeRefundPolicy
    {
        [Key]
        public int PolicyID { get; set; }

        [Required]
        [StringLength(50)]
        public string ProgramType { get; set; }

        [Required]
        [StringLength(255)]
        public string TimelineDescription { get; set; }

        [Required]
        [StringLength(255)]
        public string RefundPercentage { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
