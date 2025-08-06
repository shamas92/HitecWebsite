namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblFacultiesET")]
    public partial class tblFacultiesET
    {
        public int Id { get; set; }



        [Column(TypeName = "text")]
        public string VisionText { get; set; }

        [Column(TypeName = "text")]
        public string MissionText { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
