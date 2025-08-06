namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Contributory_Fund_NominaQon
    {
        [Key]
        public int NominaQon_ID { get; set; }

        public int? Member_ID { get; set; }

        [StringLength(100)]
        public string Nominee_Name { get; set; }

        [StringLength(50)]
        public string RelaQonship { get; set; }

        [StringLength(20)]
        public string Nominee_CNIC { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NominaQon_Date { get; set; }

        public virtual Contributory_Fund_Members Contributory_Fund_Members { get; set; }
    }
}
