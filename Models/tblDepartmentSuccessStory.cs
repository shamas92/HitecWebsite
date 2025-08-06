namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblDepartmentSuccessStory")]
    public partial class tblDepartmentSuccessStory
    {
        public int Id { get; set; }

        public int? DepartmentId { get; set; }

        public string PersonName { get; set; }

        public string PersonImage { get; set; }

        public string SuccessDetails { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public virtual tblDepartment tblDepartment { get; set; }
    }
}
