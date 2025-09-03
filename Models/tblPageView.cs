using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HitecCM.Models
{
    [Table("tblPageView")] // map to existing table name
    public partial class tblPageView
    {
        [Key]
        public long PageViewId { get; set; }

        [ForeignKey("VisitSession")]
        public long VisitSessionId { get; set; }

        public int? UserId { get; set; }

        [Required]
        [StringLength(300)]
        public string Path { get; set; }

        public DateTime ViewUtc { get; set; }

        public short StatusCode { get; set; }

        // Navigation
        public virtual tblVisitSession VisitSession { get; set; }
    }
}
