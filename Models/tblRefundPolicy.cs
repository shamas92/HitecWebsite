namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRefundPolicy")]
    public partial class tblRefundPolicy
    {
        [Key]
        public int PolicyID { get; set; }

        [Required]
        [StringLength(255)]
        public string PolicyTitle { get; set; }

        [Required]
        public string PolicyDescription { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
