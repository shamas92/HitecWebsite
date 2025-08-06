namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PhD_MathemaQcs
    {
        [Key]
        public int Program_ID { get; set; }

        [StringLength(100)]
        public string Program_Name { get; set; }

        public int? Coursework_Credit_Hours { get; set; }

        public int? Research_Credit_Hours { get; set; }

        [Column(TypeName = "text")]
        public string Entry_Requirements { get; set; }

        [Column(TypeName = "text")]
        public string EvaluaQon_Criteria { get; set; }

        [Column(TypeName = "text")]
        public string Research_Areas { get; set; }
    }
}
