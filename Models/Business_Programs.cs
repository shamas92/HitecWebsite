namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Business_Programs
    {
        [Key]
        public int Program_ID { get; set; }

        [StringLength(200)]
        public string Program_Name { get; set; }

        public string DescripQon { get; set; }

        [StringLength(50)]
        public string DuraQon { get; set; }

        public int? Credit_Hours { get; set; }

        [StringLength(500)]
        public string SpecializaQons { get; set; }

        [StringLength(1000)]
        public string AddiQonal_Requirements { get; set; }
    }
}
