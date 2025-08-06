namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee_Eligibility_Criteria
    {
        [Key]
        public int Criteria_ID { get; set; }

        [StringLength(100)]
        public string NaQonality { get; set; }

        [Column(TypeName = "text")]
        public string QualificaQon_Req { get; set; }

        [Column(TypeName = "text")]
        public string Document_VerificaQon { get; set; }

        [StringLength(100)]
        public string Medical_Req { get; set; }

        [Column(TypeName = "text")]
        public string Age_Proof_Req { get; set; }

        [Column(TypeName = "text")]
        public string DisqualificaQons { get; set; }
    }
}
