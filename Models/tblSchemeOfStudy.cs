namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblSchemeOfStudy
    {
        public int ID { get; set; }

        public int? DepartmentID { get; set; }

        public int? ProgramID { get; set; }

        [StringLength(250)]
        public string Program { get; set; }

        [StringLength(250)]
        public string Semester { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(250)]
        public string Title { get; set; }

        [StringLength(50)]
        public string CH { get; set; }
    }
}
