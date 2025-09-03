using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HitecCM.Models
{
    [Table("tblVisitSession")] // map to existing table name
    public partial class tblVisitSession
    {
        public tblVisitSession()
        {
            PageViewItems = new HashSet<tblPageView>();
        }

        [Key]
        public long VisitSessionId { get; set; }

        [Required]
        [StringLength(64)]
        public string SessionKey { get; set; }

        public int? UserId { get; set; }

        public DateTime FirstSeenUtc { get; set; }

        public DateTime LastSeenUtc { get; set; }

        public int PageViews { get; set; }

        [MaxLength(32)]
        public byte[] IpHash { get; set; }

        [StringLength(256)]
        public string UserAgent { get; set; }

        [StringLength(255)]
        public string ReferrerHost { get; set; }

        public bool IsBot { get; set; }

        // Navigation
        [InverseProperty("VisitSession")]
        public virtual ICollection<tblPageView> PageViewItems { get; set; }
    }
}
