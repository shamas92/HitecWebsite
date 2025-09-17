namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblQACRIPE")]
    public partial class tblQACRIPE
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string PageTitle { get; set; }

        [Column(TypeName = "text")]
        public string PageText { get; set; }

        public string PageImage { get; set; }

        [StringLength(255)]
        public string PdfFileName { get; set; }

        public string PdfFilePath { get; set; }

        public DateTime? UploadedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
