namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblDepartmentProgram
    {
        public int Id { get; set; }

        public int? DepartmentId { get; set; }

        public string ProgramsInfo { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public virtual tblDepartment tblDepartment { get; set; }
    }
}
