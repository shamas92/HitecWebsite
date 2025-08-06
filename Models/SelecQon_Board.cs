namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SelecQon_Board
    {
        [Key]
        public int Board_ID { get; set; }

        public bool? VC_Present { get; set; }

        public bool? Dean_Present { get; set; }

        public bool? Chairperson_Present { get; set; }

        [StringLength(255)]
        public string Eminent_Scholar { get; set; }

        [StringLength(255)]
        public string Subject_Expert { get; set; }

        public bool? Registrar_Present { get; set; }

        public bool? Quorum_Met { get; set; }
    }
}
