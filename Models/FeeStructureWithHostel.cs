namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FeeStructureWithHostel")]
    public partial class FeeStructureWithHostel
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string FeeType { get; set; }

        [StringLength(255)]
        public string ProgramName { get; set; }

        [StringLength(50)]
        public string AdmissionRegistraQonFee { get; set; }

        [StringLength(50)]
        public string SecurityDeposit { get; set; }

        [StringLength(50)]
        public string SemesterFee { get; set; }

        [StringLength(255)]
        public string Remarks { get; set; }

        [StringLength(100)]
        public string HostelCategory { get; set; }

        [StringLength(50)]
        public string BoysHostelFee { get; set; }

        [StringLength(50)]
        public string GirlsHostelFee { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
