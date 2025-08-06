namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PosiQon_Details
    {
        [Key]
        public int PosiQon_ID { get; set; }

        public int? Group_ID { get; set; }

        [StringLength(100)]
        public string PosiQon_Name { get; set; }

        public virtual ClassificaQon_Groups ClassificaQon_Groups { get; set; }
    }
}
