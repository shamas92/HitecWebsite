namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AcademicCalendar")]
    public partial class AcademicCalendar
    {
        [Key]
        public int CalendarID { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        public string DescripQon { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
