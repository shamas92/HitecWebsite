using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace HitecCM.Controllers
{
    public class OfficesController : Controller
    {
        private static readonly List<OfficeInfo> Offices = new List<OfficeInfo>
        {
            new OfficeInfo { Id = "admission", Name = "Admission", Desc = "Handles student admissions, application processing, and enrollment services for all academic programs.", FullDesc = "The Admission Office at HITEC University is responsible for managing the entire admission process for prospective students. Our dedicated team assists applicants through every step of the enrollment journey, from initial inquiries to final registration. We process applications for undergraduate, postgraduate, and PhD programs across all faculties.", Phone = "+92-51-9047851", Email = "admissions@hitecuni.edu.pk", Location = "Admin Block, Ground Floor" },
            new OfficeInfo { Id = "exam", Name = "Exam", Desc = "Manages examination schedules, result compilation, and academic record maintenance.", FullDesc = "The Examination Office coordinates all academic assessments at HITEC University. We are responsible for scheduling midterm and final examinations, ensuring fair conduct during exams, compiling results, and maintaining official academic transcripts. Students can obtain their transcripts, verify results, and address any examination-related queries through this office.", Phone = "+92-51-9047852", Email = "exam@hitecuni.edu.pk", Location = "Admin Block, First Floor" },
            new OfficeInfo { Id = "accounts", Name = "Accounts", Desc = "Oversees financial operations including fee collection, scholarships, and financial aid processing.", FullDesc = "The Accounts Office manages all financial transactions at HITEC University. We handle fee collection, process scholarship disbursements, manage financial aid applications, and maintain accurate financial records. Students can pay their tuition fees, apply for payment plans, and obtain fee receipts from this office.", Phone = "+92-51-9047853", Email = "accounts@hitecuni.edu.pk", Location = "Admin Block, Ground Floor" },
            new OfficeInfo { Id = "admin", Name = "Admin", Desc = "Coordinates administrative functions, facility management, and general university operations.", FullDesc = "The Administration Office serves as the central hub for university operations. We coordinate facility management, oversee campus maintenance, manage human resources, and ensure smooth day-to-day operations. This office also handles official correspondence, event coordination, and visitor management.", Phone = "+92-51-9047854", Email = "admin@hitecuni.edu.pk", Location = "Admin Block, Second Floor" },
            new OfficeInfo { Id = "dsa", Name = "DSA", Desc = "Directorate of Student Affairs manages student welfare, activities, and campus life programs.", FullDesc = "The Directorate of Student Affairs (DSA) is dedicated to enhancing student life at HITEC University. We organize co-curricular activities, sports events, cultural programs, and student societies. Our office also addresses student grievances, provides counseling services, and ensures a positive campus environment for all students.", Phone = "+92-51-9047855", Email = "dsa@hitecuni.edu.pk", Location = "Student Center, First Floor" },
            new OfficeInfo { Id = "qac", Name = "QA&C", Desc = "Quality Assurance & Compliance ensures academic standards and regulatory compliance.", FullDesc = "The Quality Assurance & Compliance (QA&C) Office ensures that HITEC University maintains the highest academic standards. We conduct regular program reviews, faculty evaluations, and institutional audits. Our office works closely with HEC and other regulatory bodies to ensure compliance with national and international quality benchmarks.", Phone = "+92-51-9047856", Email = "qac@hitecuni.edu.pk", Location = "Academic Block, Third Floor" },
            new OfficeInfo { Id = "library", Name = "Library", Desc = "Provides access to academic resources, research materials, and digital databases.", FullDesc = "The HITEC University Library is a state-of-the-art facility providing comprehensive academic resources. We offer an extensive collection of books, journals, research papers, and digital databases. Students and faculty can access online resources, utilize study spaces, and receive research assistance from our trained librarians.", Phone = "+92-51-9047857", Email = "library@hitecuni.edu.pk", Location = "Library Building" },
            new OfficeInfo { Id = "hope", Name = "HOPE", Desc = "HITEC Outreach Program for Education offers professional development and skill enhancement courses.", FullDesc = "HITEC Outreach Program for Education (HOPE) extends learning opportunities beyond traditional academics. We offer professional development courses, skill enhancement workshops, and certification programs. HOPE serves students, alumni, and the community with programs designed to enhance employability and lifelong learning.", Phone = "+92-51-9047858", Email = "hope@hitecuni.edu.pk", Location = "HOPE Academy Building" },
            new OfficeInfo { Id = "oric", Name = "ORIC", Desc = "Office of Research, Innovation & Commercialization promotes research activities and industry collaboration.", FullDesc = "The Office of Research, Innovation & Commercialization (ORIC) fosters a culture of research excellence at HITEC University. We support faculty and students in securing research grants, facilitate industry partnerships, promote innovation and entrepreneurship, and assist in commercializing research outcomes. ORIC also organizes research conferences and workshops.", Phone = "+92-51-9047859", Email = "oric@hitecuni.edu.pk", Location = "Research Block, Ground Floor" },
            new OfficeInfo { Id = "dasr", Name = "DASR", Desc = "Directorate of Academics, Scholarships & Registration handles academic affairs and scholarship programs.", FullDesc = "The Directorate of Academics, Scholarships & Registration (DASR) manages core academic operations at HITEC University. We handle course registration, academic scheduling, degree verification, and scholarship administration. Students can apply for merit-based and need-based scholarships, request academic transcripts, and resolve registration issues through this office.", Phone = "+92-51-9047860", Email = "dasr@hitecuni.edu.pk", Location = "Admin Block, First Floor" }
        };

        public static List<OfficeInfo> GetAllOffices()
        {
            return Offices;
        }

        public ActionResult Index()
        {
            return View(Offices);
        }

        public ActionResult Details(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return RedirectToAction("Index");
            }

            var office = Offices.FirstOrDefault(o => o.Id.Equals(id, System.StringComparison.OrdinalIgnoreCase));
            if (office == null)
            {
                return HttpNotFound();
            }

            ViewBag.AllOffices = Offices;
            return View(office);
        }
    }

    public class OfficeInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string FullDesc { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
    }
}
