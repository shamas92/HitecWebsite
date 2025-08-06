namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Contributory_Fund_Members
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contributory_Fund_Members()
        {
            Contributory_Fund_Accounts = new HashSet<Contributory_Fund_Accounts>();
            Contributory_Fund_Advances = new HashSet<Contributory_Fund_Advances>();
            Contributory_Fund_ContribuQons = new HashSet<Contributory_Fund_ContribuQons>();
            Contributory_Fund_NominaQon = new HashSet<Contributory_Fund_NominaQon>();
        }

        [Key]
        public int Member_ID { get; set; }

        public int? Employee_ID { get; set; }

        public bool? Is_Confirmed { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_Joined { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_Exited { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contributory_Fund_Accounts> Contributory_Fund_Accounts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contributory_Fund_Advances> Contributory_Fund_Advances { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contributory_Fund_ContribuQons> Contributory_Fund_ContribuQons { get; set; }

        public virtual Employee_Appointment_Details Employee_Appointment_Details { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contributory_Fund_NominaQon> Contributory_Fund_NominaQon { get; set; }
    }
}
