namespace HitecCM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    public partial class tblMenuType
    {
        [Key]
        public int MenuTypeID { get; set; }

        [Required] 

        public string MenuTypeName { get; set; }

    }
}
