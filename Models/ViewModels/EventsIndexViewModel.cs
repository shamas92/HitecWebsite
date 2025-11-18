using System;
using System.Collections.Generic;
using Website.Models;

namespace Website.ViewModels
{
    public class EventsIndexViewModel
    {
        public IEnumerable<tblEvent> Items { get; set; } = new List<tblEvent>();
        public IEnumerable<tblEventHead> Heads { get; set; } = new List<tblEventHead>();

        // Filters
        public string Q { get; set; }
        public bool? Alumni { get; set; }
        public int? HeadId { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public string When { get; set; } // all | upcoming | past
        public string Sort { get; set; } // date_desc (default), date_asc, views_desc, views_asc, title_asc

        // Paging
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public int TotalPages => PageSize <= 0 ? 0 : (int)Math.Ceiling((double)TotalCount / PageSize);
    }
}
