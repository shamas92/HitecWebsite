namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblSuccessStory
    {
        public int ID { get; set; }

        public int? DepartmentID { get; set; }

        [StringLength(50)]
        public string Photo { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        [StringLength(50)]
        public string RegistrationNo { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string MobileNo { get; set; }

        [StringLength(50)]
        public string AltMobileNo { get; set; }

        [StringLength(50)]
        public string Organization { get; set; }

        [StringLength(50)]
        public string Department { get; set; }

        [StringLength(50)]
        public string Designation { get; set; }

        [StringLength(50)]
        public string Qualification { get; set; }

        [StringLength(250)]
        public string Linkedin { get; set; }

        [StringLength(250)]
        public string Facebook { get; set; }

        [StringLength(250)]
        public string Twitter { get; set; }

        [StringLength(250)]
        public string Instagram { get; set; }

        [StringLength(250)]
        public string Youtube { get; set; }

        public string Details { get; set; }

        public bool? Active { get; set; }
    }
}
