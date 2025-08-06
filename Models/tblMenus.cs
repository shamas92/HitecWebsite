namespace HitecCM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblMenus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblMenus()
        {
            ChildMenus = new HashSet<tblMenus>();
        }

        [Key]
        public int MenuID { get; set; }

        [Required]
        [StringLength(255)]
        public string MenuName { get; set; }

        public string MenuLink { get; set; }

        public int? SortingOrder { get; set; }

        public int? ParentMenuID { get; set; }

        [Required(ErrorMessage = "Menu Type is required")]
        public int MenuTypeID { get; set; }

        // Navigation properties
        [ForeignKey("MenuTypeID")]
        public virtual tblMenuType MenuType { get; set; }

        [ForeignKey("ParentMenuID")]
        public virtual tblMenus ParentMenu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMenus> ChildMenus { get; set; }
    }
} 