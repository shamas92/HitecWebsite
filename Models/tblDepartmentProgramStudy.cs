namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblDepartmentProgramStudy")]
    public partial class tblDepartmentProgramStudy
    {
        public int Id { get; set; }

        public int? ProgramStudyId { get; set; }

        public string CourseCode { get; set; }

        public string CourseTitle { get; set; }

        public string CourseCreditHours { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public virtual tblDepartmentSchemeOfStudy tblDepartmentSchemeOfStudy { get; set; }
    }
}
