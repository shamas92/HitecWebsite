namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee_Inquiry_Procedures
    {
        [Key]
        public int Inquiry_Step_ID { get; set; }

        public int? Step_Number { get; set; }

        [Column(TypeName = "text")]
        public string Step_DescripQon { get; set; }
    }
}
