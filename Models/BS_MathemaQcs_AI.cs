namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BS_MathemaQcs_AI
    {
        [Key]
        public int Program_ID { get; set; }

        [StringLength(150)]
        public string Program_Name { get; set; }

        public int? Launch_Year { get; set; }

        [Column(TypeName = "text")]
        public string Focus_Area { get; set; }

        [Column(TypeName = "text")]
        public string Special_Features { get; set; }
    }
}
