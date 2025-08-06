namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblDepartment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblDepartment()
        {
            tblDepartmentChairpersons = new HashSet<tblDepartmentChairperson>();
            tblDepartmentContacts = new HashSet<tblDepartmentContact>();
            tblDepartmentFacilities = new HashSet<tblDepartmentFacility>();
            tblDepartmentFacultyAbouts = new HashSet<tblDepartmentFacultyAbout>();
            tblDepartmentFAQs = new HashSet<tblDepartmentFAQ>();
            tblDepartmentPastEvents = new HashSet<tblDepartmentPastEvent>();
            tblDepartmentPrograms = new HashSet<tblDepartmentProgram>();
            tblDepartmentTeachingFaculties = new HashSet<tblDepartmentTeachingFaculty>();
            tblDepartmentSchemeOfStudies = new HashSet<tblDepartmentSchemeOfStudy>();
            tblDepartmentUpcomingEvents = new HashSet<tblDepartmentUpcomingEvent>();
            tblDepartmentSuccessStories = new HashSet<tblDepartmentSuccessStory>();
            tblFaculties = new HashSet<tblFaculty>();
        }

        [Key]
        public int DepartmentID { get; set; }

        [Column("_Order")]
        public int? C_Order { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(50)]
        public string Banner { get; set; }

        public string About { get; set; }

        [StringLength(50)]
        public string HODPhoto { get; set; }

        public string HODMessage { get; set; }

        public string Programs { get; set; }

        public string Contacts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDepartmentChairperson> tblDepartmentChairpersons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDepartmentContact> tblDepartmentContacts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDepartmentFacility> tblDepartmentFacilities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDepartmentFacultyAbout> tblDepartmentFacultyAbouts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDepartmentFAQ> tblDepartmentFAQs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDepartmentPastEvent> tblDepartmentPastEvents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDepartmentProgram> tblDepartmentPrograms { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDepartmentTeachingFaculty> tblDepartmentTeachingFaculties { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDepartmentSchemeOfStudy> tblDepartmentSchemeOfStudies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDepartmentUpcomingEvent> tblDepartmentUpcomingEvents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDepartmentSuccessStory> tblDepartmentSuccessStories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblFaculty> tblFaculties { get; set; }
    }
}
