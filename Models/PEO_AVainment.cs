namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PEO_AVainment
    {
        [Key]
        public int AVainment_ID { get; set; }

        public int PEO_ID { get; set; }

        public decimal? Alumni_Feedback_Score { get; set; }

        public decimal? Employer_Feedback_Score { get; set; }

        public decimal? Overall_AVainment { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Assessment_Year { get; set; }

        public virtual Program_EducaQonal_ObjecQves Program_EducaQonal_ObjecQves { get; set; }
    }
}
