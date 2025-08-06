namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sport_Info
    {
        [Key]
        public int Facility_ID { get; set; }

        [StringLength(100)]
        public string Facility_Name { get; set; }

        [Column(TypeName = "text")]
        public string DescripQon { get; set; }

        public int? Capacity { get; set; }

        [StringLength(255)]
        public string AddiQonal_Info { get; set; }
    }
}
