namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblFinancialAssistance")]
    public partial class tblFinancialAssistance
    {
        [Key]
        public int FinancialAssistance { get; set; }

        [Required]
        [StringLength(255)]
        public string CategoryName { get; set; }

        [Required]
        public string CriteriaDescription { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
