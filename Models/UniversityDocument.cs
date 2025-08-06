namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UniversityDocument
    {
        [Key]
        public int DocumentID { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [Required]
        public string FilePath { get; set; }

        public string DescripQon { get; set; }

        public DateTime? UploadDate { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}
