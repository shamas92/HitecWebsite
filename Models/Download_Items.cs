namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Download_Items
    {
        [Key]
        public int Item_ID { get; set; }

        public int Category_ID { get; set; }

        [Required]
        [StringLength(255)]
        public string Item_Title { get; set; }

        [Required]
        [StringLength(500)]
        public string File_Link { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Upload_Date { get; set; }

        public virtual Download_Categories Download_Categories { get; set; }
    }
}
