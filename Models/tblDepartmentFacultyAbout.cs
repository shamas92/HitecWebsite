namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblDepartmentFacultyAbout")]
    public partial class tblDepartmentFacultyAbout
    {
        public int Id { get; set; }

        public int? DepartmentId { get; set; }

        [StringLength(255)]
        public string DepartmentName { get; set; }

        public string DepartmentImage { get; set; }

        [Column(TypeName = "text")]
        public string AboutText { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public virtual tblDepartment tblDepartment { get; set; }
    }
}
