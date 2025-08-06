namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Contributory_Fund_Senngs
    {
        [Key]
        public int Senng_ID { get; set; }

        public decimal? Member_ContribuQon_Percentage { get; set; }

        public decimal? University_ContribuQon_Percentage { get; set; }

        public int? Minimum_Years_For_Eligibility { get; set; }

        public decimal? Max_Advance_Percentage { get; set; }

        public int? Max_Installments { get; set; }
    }
}
