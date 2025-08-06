namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PhDRulesAndRegulaQon
    {
        [Key]
        public int RuleID { get; set; }

        [Required]
        [StringLength(255)]
        public string Category { get; set; }

        [StringLength(255)]
        public string SubCategory { get; set; }

        [Required]
        public string RuleDescripQon { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
