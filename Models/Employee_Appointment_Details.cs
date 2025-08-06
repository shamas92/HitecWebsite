namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee_Appointment_Details
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee_Appointment_Details()
        {
            Conference_IncenQves = new HashSet<Conference_IncenQves>();
            Contributory_Fund_Members = new HashSet<Contributory_Fund_Members>();
            Death_Gratuity = new HashSet<Death_Gratuity>();
            EducaQon_Subsidy = new HashSet<EducaQon_Subsidy>();
            Employee_Appeals = new HashSet<Employee_Appeals>();
            Employee_Disciplinary_Cases = new HashSet<Employee_Disciplinary_Cases>();
            Employee_Transfers = new HashSet<Employee_Transfers>();
            Employee_Contracts = new HashSet<Employee_Contracts>();
            Employee_Leave_Records = new HashSet<Employee_Leave_Records>();
            Leave_EnQtlement = new HashSet<Leave_EnQtlement>();
            Personal_Loan = new HashSet<Personal_Loan>();
            PublicaQons_IncenQves = new HashSet<PublicaQons_IncenQves>();
            Wards_Fee_Concession = new HashSet<Wards_Fee_Concession>();
            Welfare_Fund = new HashSet<Welfare_Fund>();
        }

        [Key]
        public int Appointment_ID { get; set; }

        [StringLength(50)]
        public string Appointment_Type { get; set; }

        [StringLength(50)]
        public string Pay_Scale { get; set; }

        [StringLength(50)]
        public string Appointment_Mode { get; set; }

        public int? ProbaQon_Period { get; set; }

        [StringLength(50)]
        public string ConfirmaQon_Status { get; set; }

        [StringLength(100)]
        public string PromoQon_Eligibility { get; set; }

        [StringLength(100)]
        public string Increments_Eligible { get; set; }

        public bool? Transferable { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Conference_IncenQves> Conference_IncenQves { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contributory_Fund_Members> Contributory_Fund_Members { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Death_Gratuity> Death_Gratuity { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EducaQon_Subsidy> EducaQon_Subsidy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee_Appeals> Employee_Appeals { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee_Disciplinary_Cases> Employee_Disciplinary_Cases { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee_Transfers> Employee_Transfers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee_Contracts> Employee_Contracts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee_Leave_Records> Employee_Leave_Records { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Leave_EnQtlement> Leave_EnQtlement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Personal_Loan> Personal_Loan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PublicaQons_IncenQves> PublicaQons_IncenQves { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wards_Fee_Concession> Wards_Fee_Concession { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Welfare_Fund> Welfare_Fund { get; set; }
    }
}
