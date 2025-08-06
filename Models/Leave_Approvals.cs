namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Leave_Approvals
    {
        [Key]
        public int Approval_ID { get; set; }

        public int? Leave_Record_ID { get; set; }

        [StringLength(100)]
        public string Approved_By { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Approval_Date { get; set; }

        [StringLength(50)]
        public string Approval_Status { get; set; }

        [Column(TypeName = "text")]
        public string Remarks { get; set; }

        public virtual Employee_Leave_Records Employee_Leave_Records { get; set; }
    }
}
