using System.Data.Entity;
using HitecCM.Models;

namespace Website.Models
{
    // Partial class extending DbContext with analytics tables
    public partial class Model1
    {
        public virtual DbSet<tblVisitSession> tblVisitSessions { get; set; }
        public virtual DbSet<tblPageView> tblPageViews { get; set; }
    }
}
