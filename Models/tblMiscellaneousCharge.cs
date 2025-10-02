namespace HitecCM.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class tblMiscellaneousCharge
    {
        [Key]
        public int ChargeID { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
