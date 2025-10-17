using System;
using System.Collections.Generic;
using Website.Models;

namespace Website.ViewModels
{
    public class DepartmentEventsViewModel
    {
        public tblDepartment Department { get; set; }
        public string DepartmentCode { get; set; }
        public List<tblEvent> Upcoming { get; set; } = new List<tblEvent>();
        public List<tblEvent> Past { get; set; } = new List<tblEvent>();
    }
}
