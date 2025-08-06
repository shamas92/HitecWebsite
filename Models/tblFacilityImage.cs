namespace Website.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("tblFacilityImages")]
    public partial class tblFacilityImage
    {
        [Key]
        public int Id { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        [StringLength(255)]
        public string FileName { get; set; }

        [Required]
        [StringLength(500)]
        public string FilePath { get; set; }

        [StringLength(100)]
        public string FileType { get; set; }

        public long? FileSize { get; set; }

        public int? Width { get; set; }

        public int? Height { get; set; }

        [StringLength(50)]
        public string Department { get; set; }

        public DateTime? UploadedDate { get; set; }

        [StringLength(100)]
        public string UploadedBy { get; set; }

        public bool IsActive { get; set; } = true;

        public int? SortOrder { get; set; }
    }
}