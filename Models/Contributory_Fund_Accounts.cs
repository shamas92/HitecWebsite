namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Contributory_Fund_Accounts
    {
        [Key]
        public int Account_ID { get; set; }

        public int? Member_ID { get; set; }

        public decimal? Total_Member_ContribuQon { get; set; }

        public decimal? Total_University_ContribuQon { get; set; }

        public decimal? Profit_Accrued { get; set; }

        public decimal? Advances_Taken { get; set; }

        public decimal? Outstanding_Advance { get; set; }

        public bool? Eligible_For_University_ContribuQon { get; set; }

        public virtual Contributory_Fund_Members Contributory_Fund_Members { get; set; }
    }
}
