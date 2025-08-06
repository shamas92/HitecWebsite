namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblFaculty
    {
        [Key]
        public int FacultyID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Date { get; set; }

        public int? UserID { get; set; }

        public int DepartmentID { get; set; }

        public int? DesignationID { get; set; }

        [StringLength(50)]
        public string AdDesignation { get; set; }

        public int? OrderNo { get; set; }

        public int? HRNo { get; set; }

        [StringLength(50)]
        public string Photo { get; set; }

        [StringLength(150)]
        public string FullName { get; set; }

        [StringLength(250)]
        public string Qualification { get; set; }

        [StringLength(50)]
        public string Gender { get; set; }

        [StringLength(250)]
        public string ResearchInterests { get; set; }

        [StringLength(50)]
        public string TelNo { get; set; }

        [StringLength(50)]
        public string Extension { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public bool? StudyLeave { get; set; }

        public bool? Active { get; set; }

        public virtual tblDepartment tblDepartment { get; set; }

        public virtual tblDesignation tblDesignation { get; set; }
    }
}
