namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblFAQ
    {
        [Key]
        public int FAQID { get; set; }

        public int? DepartmentID { get; set; }

        [StringLength(250)]
        public string Question { get; set; }

        public string Answer { get; set; }
    }
}
