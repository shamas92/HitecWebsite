namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AcademicDeficiency
    {
        [Key]
        public int DeficiencyID { get; set; }

        [Required]
        [StringLength(50)]
        public string StudentLevel { get; set; }

        [Required]
        public string CondiQonDescripQon { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
