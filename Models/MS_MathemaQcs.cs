namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MS_MathemaQcs
    {
        [Key]
        public int Program_ID { get; set; }

        [StringLength(100)]
        public string Program_Name { get; set; }

        public int? Coursework_Credit_Hours { get; set; }

        public int? Thesis_Credit_Hours { get; set; }

        [StringLength(200)]
        public string Thesis_OpQon { get; set; }

        [Column(TypeName = "text")]
        public string Research_Areas { get; set; }
    }
}
