namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cafeteria_Info
    {
        [Key]
        public int Cafeteria_ID { get; set; }

        [StringLength(100)]
        public string LocaQon { get; set; }

        [StringLength(100)]
        public string Food_Type { get; set; }

        [Column(TypeName = "text")]
        public string DescripQon { get; set; }

        [StringLength(50)]
        public string Price_Range { get; set; }

        public bool? Hygiene_CommiVee { get; set; }
    }
}
