namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("hitecuniCM.tblNewsHeads")]
    public partial class tblNewsHead
    {
        [Key]
        public int NewsHeadID { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        public bool? Active { get; set; }
    }
}
