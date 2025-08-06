namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblDepartmentSchemeOfStudy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblDepartmentSchemeOfStudy()
        {
            tblDepartmentProgramStudies = new HashSet<tblDepartmentProgramStudy>();
        }

        public int Id { get; set; }

        public int? DepartmentId { get; set; }

        public string ProgramTitle { get; set; }

        public int? ProgramStudyID { get; set; }

        public string ProgramStudyTitle { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDepartmentProgramStudy> tblDepartmentProgramStudies { get; set; }

        public virtual tblDepartment tblDepartment { get; set; }
    }
}
