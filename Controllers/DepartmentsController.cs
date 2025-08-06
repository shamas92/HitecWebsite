using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Website.Models;

namespace Website.Controllers
{
    public class DepartmentsController : Controller
    {
        // GET: Departments
        public ActionResult Index()
        {
            using (var db = new Model1())
            {
                var departments = db.tblDepartments
                    .OrderBy(d => d.C_Order)
                    .ThenBy(d => d.Title)
                    .ToList();
                return View(departments);
            }
        }

        // GET: Departments/GetAll
        public ActionResult GetAll()
        {
            using (var db = new Model1())
            {
                var departments = db.tblDepartments
                    .OrderBy(d => d.C_Order)
                    .ThenBy(d => d.Title)
                    .ToList();
                return Json(departments, JsonRequestBehavior.AllowGet);
            }
        }

        // GET: Departments/Details/5
        public ActionResult Details(int id)
        {
            using (var db = new Model1())
            {
                var department = db.tblDepartments
                    .Include(d => d.tblDepartmentChairpersons)
                    .Include(d => d.tblDepartmentContacts)
                    .Include(d => d.tblDepartmentFacilities)
                    .Include(d => d.tblDepartmentFacultyAbouts)
                    .Include(d => d.tblDepartmentFAQs)
                    .Include(d => d.tblDepartmentPastEvents)
                    .Include(d => d.tblDepartmentPrograms)
                    .Include(d => d.tblDepartmentTeachingFaculties)
                    .Include(d => d.tblDepartmentSchemeOfStudies)
                    .Include(d => d.tblDepartmentUpcomingEvents)
                    .Include(d => d.tblDepartmentSuccessStories)
                    .Include(d => d.tblFaculties)
                    .FirstOrDefault(d => d.DepartmentID == id);

                if (department == null)
                {
                    return HttpNotFound();
                }

                return View(department);
            }
        }

        // GET: Departments/GetById/5
        public ActionResult GetById(int id)
        {
            using (var db = new Model1())
            {
                var department = db.tblDepartments
                    .Include(d => d.tblDepartmentChairpersons)
                    .Include(d => d.tblDepartmentContacts)
                    .Include(d => d.tblDepartmentFacilities)
                    .Include(d => d.tblDepartmentFacultyAbouts)
                    .Include(d => d.tblDepartmentFAQs)
                    .Include(d => d.tblDepartmentPastEvents)
                    .Include(d => d.tblDepartmentPrograms)
                    .Include(d => d.tblDepartmentTeachingFaculties)
                    .Include(d => d.tblDepartmentSchemeOfStudies)
                    .Include(d => d.tblDepartmentUpcomingEvents)
                    .Include(d => d.tblDepartmentSuccessStories)
                    .Include(d => d.tblFaculties)
                    .FirstOrDefault(d => d.DepartmentID == id);

                if (department == null)
                {
                    return HttpNotFound();
                }

                return Json(department, JsonRequestBehavior.AllowGet);
            }
        }

        // GET: Departments/GetByCode/code
        public ActionResult GetByCode(string code)
        {
            using (var db = new Model1())
            {
                var department = db.tblDepartments
                    .Include(d => d.tblDepartmentChairpersons)
                    .Include(d => d.tblDepartmentContacts)
                    .Include(d => d.tblDepartmentFacilities)
                    .Include(d => d.tblDepartmentFacultyAbouts)
                    .Include(d => d.tblDepartmentFAQs)
                    .Include(d => d.tblDepartmentPastEvents)
                    .Include(d => d.tblDepartmentPrograms)
                    .Include(d => d.tblDepartmentTeachingFaculties)
                    .Include(d => d.tblDepartmentSchemeOfStudies)
                    .Include(d => d.tblDepartmentUpcomingEvents)
                    .Include(d => d.tblDepartmentSuccessStories)
                    .Include(d => d.tblFaculties)
                    .FirstOrDefault(d => d.Code == code);

                if (department == null)
                {
                    return HttpNotFound();
                }

                return Json(department, JsonRequestBehavior.AllowGet);
            }
        }
    }
} 