namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PEO_PLO_Mapping
    {
        [Key]
        public int Mapping_ID { get; set; }

        public int PEO_ID { get; set; }

        public int PLO_ID { get; set; }

        public virtual Program_EducaQonal_ObjecQves Program_EducaQonal_ObjecQves { get; set; }

        public virtual Program_Learning_Outcomes Program_Learning_Outcomes { get; set; }
    }
}
