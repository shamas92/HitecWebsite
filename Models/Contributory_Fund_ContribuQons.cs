namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Contributory_Fund_ContribuQons
    {
        [Key]
        public int ContribuQon_ID { get; set; }

        public int? Member_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ContribuQon_Month { get; set; }

        public decimal? Member_ContribuQon { get; set; }

        public decimal? University_ContribuQon { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? Total_ContribuQon { get; set; }

        public virtual Contributory_Fund_Members Contributory_Fund_Members { get; set; }
    }
}
