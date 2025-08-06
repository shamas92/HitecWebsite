namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblNoticeBoard
    {
        [Key]
        public int NoticeBoardID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Date { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NoticeDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ExipreDate { get; set; }

        [StringLength(250)]
        public string Details { get; set; }

        [StringLength(150)]
        public string Link { get; set; }
    }
}
