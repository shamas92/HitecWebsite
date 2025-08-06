namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ResignaQon_TerminaQon_Process
    {
        [Key]
        public int Process_ID { get; set; }

        [StringLength(50)]
        public string Process_Type { get; set; }

        public int? NoQce_Period_Days { get; set; }

        public bool? Payment_In_Lieu { get; set; }

        [Column(TypeName = "text")]
        public string Reason { get; set; }

        public bool? Clearance_Required { get; set; }

        public bool? Exit_Interview_Done { get; set; }

        [StringLength(50)]
        public string VC_Approval_Status { get; set; }
    }
}
