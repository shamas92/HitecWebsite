namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Contributory_Fund_Advances
    {
        [Key]
        public int Advance_ID { get; set; }

        public int? Member_ID { get; set; }

        public decimal? Advance_Amount { get; set; }

        [StringLength(100)]
        public string Approved_By { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Approval_Date { get; set; }

        public decimal? Interest_Rate { get; set; }

        public int? Installments { get; set; }

        public decimal? Installment_Amount { get; set; }

        public int? Remaining_Installments { get; set; }

        public virtual Contributory_Fund_Members Contributory_Fund_Members { get; set; }
    }
}
