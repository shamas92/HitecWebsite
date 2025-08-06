namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SelecQon_CommiVee
    {
        [Key]
        public int CommiVee_ID { get; set; }

        public bool? Dean_PSO_Present { get; set; }

        public bool? Chairperson_Present { get; set; }

        public bool? Registrar_Present { get; set; }

        public bool? Treasurer_Present { get; set; }
    }
}
