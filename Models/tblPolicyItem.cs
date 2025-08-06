namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblPolicyItem
    {
        public int Id { get; set; }

        public int? CategoryId { get; set; }

        [Required]
        [StringLength(500)]
        public string ItemTitle { get; set; }

        [Column(TypeName = "text")]
        public string ItemDescription { get; set; }

        public string FilePath { get; set; }

        [StringLength(255)]
        public string FileName { get; set; }

        public int? DisplayOrder { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public virtual tblPolicyCategory tblPolicyCategory { get; set; }
    }
}
