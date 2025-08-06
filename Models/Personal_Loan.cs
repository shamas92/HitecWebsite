namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Personal_Loan
    {
        [Key]
        public int Loan_ID { get; set; }

        public int? Employee_ID { get; set; }

        public decimal? Loan_Amount { get; set; }

        public decimal? Interest_Rate { get; set; }

        public int? Installments { get; set; }

        [StringLength(50)]
        public string Loan_Type { get; set; }

        [StringLength(50)]
        public string Loan_Status { get; set; }

        public virtual Employee_Appointment_Details Employee_Appointment_Details { get; set; }
    }
}
