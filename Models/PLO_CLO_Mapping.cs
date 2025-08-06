namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PLO_CLO_Mapping
    {
        [Key]
        public int Mapping_ID { get; set; }

        public int PLO_ID { get; set; }

        public int CLO_ID { get; set; }

        [StringLength(20)]
        public string ContribuQon_Level { get; set; }

        public virtual Course_Learning_Outcomes Course_Learning_Outcomes { get; set; }

        public virtual Program_Learning_Outcomes Program_Learning_Outcomes { get; set; }
    }
}
