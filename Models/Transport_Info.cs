namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Transport_Info
    {
        [Key]
        public int Route_ID { get; set; }

        [StringLength(100)]
        public string Route_Name { get; set; }

        [Column(TypeName = "text")]
        public string DescripQon { get; set; }

        [StringLength(255)]
        public string PDF_Link { get; set; }
    }
}
