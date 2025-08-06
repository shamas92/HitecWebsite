namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employment_Types
    {
        [Key]
        public int EmploymentType_ID { get; set; }

        [StringLength(100)]
        public string Type_Name { get; set; }

        [Column(TypeName = "text")]
        public string DescripQon { get; set; }
    }
}
