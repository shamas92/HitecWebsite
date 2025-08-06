namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PLO_AVainment
    {
        [Key]
        public int AVainment_ID { get; set; }

        public int PLO_ID { get; set; }

        public decimal? Average_CLO_AVainment { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Assessment_Year { get; set; }

        public virtual Program_Learning_Outcomes Program_Learning_Outcomes { get; set; }
    }
}
