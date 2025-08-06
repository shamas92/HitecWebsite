namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblSeOBECurriculum")]
    public partial class tblSeOBECurriculum
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string CurriculumTitle { get; set; }

        [StringLength(255)]
        public string PdfFileName { get; set; }

        public string PdfFilePath { get; set; }

        public DateTime? UploadedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
