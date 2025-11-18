using System.Collections.Generic;
using Website.Models;

namespace Website.ViewModels
{
    public class HomeIndexViewModel
    {
        public List<tblEvent> LatestEvents { get; set; } = new List<tblEvent>();
        public List<tblEvent> UpcomingEvents { get; set; } = new List<tblEvent>();
        // Events for the "Our Recent Events" section (after those shown in Campus News)
        public List<tblEvent> RecentEventsForBottom { get; set; } = new List<tblEvent>();
    }
}
