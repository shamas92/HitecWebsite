namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Hostel_Requests
    {
        [Key]
        public int Request_ID { get; set; }

        [StringLength(100)]
        public string Student_Name { get; set; }

        [StringLength(50)]
        public string RegistraQon_Number { get; set; }

        public int? Hostel_ID { get; set; }

        public bool? Challan_Sent { get; set; }

        [StringLength(255)]
        public string Google_Form_Link { get; set; }

        public bool? Challan_SubmiVed { get; set; }

        public bool? Department_Copy_SubmiVed { get; set; }

        public bool? Accounts_Copy_SubmiVed { get; set; }

        public bool? Seat_Confirmed { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Request_Date { get; set; }

        public virtual Hostel_Info Hostel_Info { get; set; }
    }
}
