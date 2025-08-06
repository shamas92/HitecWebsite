namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BiomedicalEngineering")]
    public partial class BiomedicalEngineering
    {
        [Key]
        public int ProgramID { get; set; }

        [StringLength(50)]
        public string ProgramLevel { get; set; }

        [StringLength(100)]
        public string Department { get; set; }

        [StringLength(200)]
        public string ProgramTitle { get; set; }

        [Column(TypeName = "text")]
        public string DescripQon { get; set; }

        public int? CreditHours { get; set; }
    }
}
