namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblDepartmentPastEvent
    {
        public int Id { get; set; }

        public int? DepartmentId { get; set; }

        public string EventTitle { get; set; }

        public string EventImage { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EventDate { get; set; }

        public string EventDetails { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public virtual tblDepartment tblDepartment { get; set; }
    }
}
