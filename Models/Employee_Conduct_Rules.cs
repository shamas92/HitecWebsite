namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee_Conduct_Rules
    {
        [Key]
        public int Rule_ID { get; set; }

        [StringLength(50)]
        public string Rule_Type { get; set; }

        [Column(TypeName = "text")]
        public string Rule_DescripQon { get; set; }
    }
}
