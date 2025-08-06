namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BS_Islamic_Studies
    {
        [Key]
        public int Program_ID { get; set; }

        [StringLength(100)]
        public string Program_Name { get; set; }

        [Column(TypeName = "text")]
        public string Focus_Area { get; set; }

        [Column(TypeName = "text")]
        public string Program_ObjecQves { get; set; }
    }
}
