namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MechanicalEngineering")]
    public partial class MechanicalEngineering
    {
        [Key]
        public int ProgramID { get; set; }

        [Required]
        [StringLength(50)]
        public string ProgramLevel { get; set; }

        [Required]
        [StringLength(100)]
        public string Department { get; set; }

        [Required]
        [StringLength(255)]
        public string ProgramTitle { get; set; }

        public string ProgramQuote { get; set; }

        [Required]
        public string DescripQon { get; set; }

        public string AdmissionCriteria { get; set; }

        public int? CreditHours { get; set; }

        [StringLength(255)]
        public string ThesisRequirement { get; set; }

        [StringLength(255)]
        public string ResidencyRequirement { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
