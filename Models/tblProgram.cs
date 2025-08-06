namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("hitecuniCM.tblPrograms")]
    public partial class tblProgram
    {
        public int ID { get; set; }

        public int? DepartmentID { get; set; }

        public int? Order_No { get; set; }

        [StringLength(50)]
        public string Title { get; set; }
    }
}
