using System.Web.Mvc;
using System.Linq;
using Website.Models;
using HitecCM.Models;
using System.Data.Entity;
using System.Collections.Generic;
using System.Web;
using System.IO;
using System;

namespace Website.Controllers
{
    public class FacultiesController : Controller
    {
        public ActionResult VisionMission()
        {
            using (var db = new Model1())
            {
                var facultyET = db.tblFacultiesETs.OrderByDescending(f => f.Id).FirstOrDefault();
                if (facultyET == null)
                {
                    // Create a default object to prevent null reference exception
                    facultyET = new tblFacultiesET
                    {
                        Id = 0,
                        VisionText = "",
                        MissionText = "",
                        CreatedDate = null,
                        ModifiedDate = null
                    };
                }
                return View(facultyET);
            }
        }
        public ActionResult DepartmentsAbout(string department)
        {
            if (string.IsNullOrEmpty(department))
            {
                return HttpNotFound("Department code not specified.");
            }

            try
            {
                using (var db = new Model1())
                {
                    // Map department name to code if needed
                    var departmentCode = MapDepartmentNameToCode(department);

                    // Find the department that matches the code from the URL
                    var departmentModel = db.tblDepartments
                        .Include(d => d.tblDepartmentPrograms)
                        .Include(d => d.tblDepartmentTeachingFaculties)
                        .FirstOrDefault(d => d.Code == departmentCode) ??
                        db.tblDepartments
                        .Include(d => d.tblDepartmentPrograms)
                        .Include(d => d.tblDepartmentTeachingFaculties)
                        .FirstOrDefault(d => d.Title.Replace(" ", "-").ToLower() == department.ToLower());

                    if (departmentModel == null)
                    {
                        return HttpNotFound();
                    }

                    return View(departmentModel);
                }
            }
            catch (Exception ex)
            {
                // Log the exception (implement proper logging)
                System.Diagnostics.Debug.WriteLine($"Error in DepartmentsAbout: {ex.Message}");
                return View("Error");
            }
        }


        public ActionResult ChairpersonMessage(string department)
        {
            if (string.IsNullOrEmpty(department))
            {
                return HttpNotFound("Department code not specified.");
            }

            try
            {
                using (var db = new Model1())
                {
                    // Map department name to code if needed
                    var departmentCode = MapDepartmentNameToCode(department);

                    // Find the department with chairperson information
                    var departmentModel = db.tblDepartments
                        .Include(d => d.tblDepartmentChairpersons)
                        .FirstOrDefault(d => d.Code == departmentCode) ??
                        db.tblDepartments
                        .Include(d => d.tblDepartmentChairpersons)
                        .FirstOrDefault(d => d.Title.Replace(" ", "-").ToLower() == department.ToLower());

                    if (departmentModel == null)
                    {
                        return HttpNotFound();
                    }

                    return View(departmentModel);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in ChairpersonMessage: {ex.Message}");
                return View("Error");
            }
        }

        private string MapDepartmentNameToCode(string departmentName)
        {
            if (string.IsNullOrEmpty(departmentName))
                return null;

            // Map department names from URLs to department codes
            var departmentMapping = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "mechanical-engineering", "ME" },
                { "electrical-engineering", "EE" },
                { "computer-engineering", "CE" },
                { "civil-engineering", "CV" },
                { "biomedical-engineering", "BME" },
                { "computer-science", "CS" },
                { "business-administration", "BBA" },
                { "islamic-studies", "IS" },
                { "mathematics", "MATH" }
            };

            return departmentMapping.ContainsKey(departmentName) ? departmentMapping[departmentName] : departmentName;
        }

        public ActionResult TeachingFaculty(string department)
        {
            try
            {
                using (var db = new Model1())
                {
                    var facultyMembers = new List<tblFaculty>();
                    tblDepartment departmentInfo = null;

                    if (!string.IsNullOrEmpty(department))
                    {
                        // Map department name to code if needed
                        var departmentCode = MapDepartmentNameToCode(department);

                        // Get department info by code first, then by name if not found
                        departmentInfo = db.tblDepartments.FirstOrDefault(d => d.Code == departmentCode) ??
                                        db.tblDepartments.FirstOrDefault(d => d.Title.Replace(" ", "-").ToLower() == department.ToLower());

                        if (departmentInfo != null)
                        {
                            // Get faculty members for specific department
                            facultyMembers = db.tblFaculties
                                .Include(f => f.tblDepartment)
                                .Include(f => f.tblDesignation)
                                .Where(f => f.DepartmentID == departmentInfo.DepartmentID && f.Active == true)
                                .OrderBy(f => f.OrderNo)
                                .ThenBy(f => f.FullName)
                                .ToList();
                        }
                    }
                    else
                    {
                        // Get all active faculty members if no department specified
                        facultyMembers = db.tblFaculties
                            .Include(f => f.tblDepartment)
                            .Include(f => f.tblDesignation)
                            .Where(f => f.Active == true)
                            .OrderBy(f => f.tblDepartment.Title)
                            .ThenBy(f => f.OrderNo)
                            .ThenBy(f => f.FullName)
                            .ToList();
                    }

                    ViewBag.Department = departmentInfo;
                    ViewBag.DepartmentCode = department;
                    ViewBag.DepartmentName = departmentInfo?.Title;
                    return View(facultyMembers);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in TeachingFaculty: {ex.Message}");
                return View("Error");
            }
        }

        public ActionResult Programs(string department)
        {
            try
            {
                using (var db = new Model1())
                {
                    var programs = new List<tblDepartmentProgram>();
                    tblDepartment departmentInfo = null;

                    if (!string.IsNullOrEmpty(department))
                    {
                        departmentInfo = db.tblDepartments.FirstOrDefault(d => d.Code == department);

                        if (departmentInfo != null)
                        {
                            programs = db.tblDepartmentPrograms
                                .Where(p => p.DepartmentId == departmentInfo.DepartmentID)
                                .OrderBy(p => p.CreatedDate)
                                .ToList();
                        }
                    }
                    else
                    {
                        programs = db.tblDepartmentPrograms.OrderBy(p => p.CreatedDate).ToList();
                    }

                    ViewBag.Department = departmentInfo;
                    ViewBag.DepartmentCode = department;
                    return View(programs);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in Programs: {ex.Message}");
                return View("Error");
            }
        }

        public ActionResult Facilities(string department)
        {
            try
            {
                using (var db = new Model1())
                {
                    var facilities = new List<tblDepartmentFacility>();
                    tblDepartment departmentInfo = null;

                    if (!string.IsNullOrEmpty(department))
                    {
                        departmentInfo = db.tblDepartments.FirstOrDefault(d => d.Code == department);

                        if (departmentInfo != null)
                        {
                            facilities = db.tblDepartmentFacilities
                                .Where(f => f.DepartmentId == departmentInfo.DepartmentID)
                                .OrderBy(f => f.CreatedDate)
                                .ToList();
                        }
                    }
                    else
                    {
                        facilities = db.tblDepartmentFacilities.OrderBy(f => f.CreatedDate).ToList();
                    }

                    ViewBag.Department = departmentInfo;
                    ViewBag.DepartmentCode = department;
                    return View(facilities);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in Facilities: {ex.Message}");
                return View("Error");
            }
        }

        [HttpPost]
        public JsonResult UploadFacilityImage(HttpPostedFileBase croppedImage)
        {
            try
            {
                if (croppedImage != null && croppedImage.ContentLength > 0)
                {
                    // Validate file type
                    var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif" };
                    var fileExtension = Path.GetExtension(croppedImage.FileName).ToLower();
                    
                    if (!allowedExtensions.Contains(fileExtension))
                    {
                        return Json(new { success = false, message = "Only image files are allowed." });
                    }

                    // Validate file size (max 5MB)
                    if (croppedImage.ContentLength > 5 * 1024 * 1024)
                    {
                        return Json(new { success = false, message = "File size cannot exceed 5MB." });
                    }

                    // Create unique filename
                    var fileName = "facility_" + Guid.NewGuid().ToString() + fileExtension;
                    var uploadPath = Server.MapPath("~/Content/uploads/facilities/");
                    
                    // Create directory if it doesn't exist
                    if (!Directory.Exists(uploadPath))
                    {
                        Directory.CreateDirectory(uploadPath);
                    }

                    var filePath = Path.Combine(uploadPath, fileName);
                    
                    // Save the file
                    croppedImage.SaveAs(filePath);
                    
                    // Here you would typically save the file info to database
                    // For now, we'll just return success
                    var relativeUrl = "/Content/uploads/facilities/" + fileName;
                    
                    return Json(new { 
                        success = true, 
                        message = "Image uploaded successfully!", 
                        imageUrl = relativeUrl,
                        fileName = fileName
                    });
                }
                else
                {
                    return Json(new { success = false, message = "No file was uploaded." });
                }
            }
            catch (Exception ex)
            {
                // Log the exception (you might want to use a logging framework)
                System.Diagnostics.Debug.WriteLine($"Upload error: {ex.Message}");
                return Json(new { success = false, message = "An error occurred while uploading the image." });
            }
        }

        public ActionResult SchemeOfStudies(string department)
        {
            try
            {
                using (var db = new Model1())
                {
                    var schemeOfStudies = new List<tblDepartmentSchemeOfStudy>();
                    tblDepartment departmentInfo = null;

                    if (!string.IsNullOrEmpty(department))
                    {
                        departmentInfo = db.tblDepartments.FirstOrDefault(d => d.Code == department);

                        if (departmentInfo != null)
                        {
                            schemeOfStudies = db.tblDepartmentSchemeOfStudies
                                .Where(s => s.DepartmentId == departmentInfo.DepartmentID)
                                .OrderBy(s => s.CreatedDate)
                                .ToList();
                        }
                    }
                    else
                    {
                        schemeOfStudies = db.tblDepartmentSchemeOfStudies.OrderBy(s => s.CreatedDate).ToList();
                    }

                    ViewBag.Department = departmentInfo;
                    ViewBag.DepartmentCode = department;
                    return View(schemeOfStudies);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in SchemeOfStudies: {ex.Message}");
                return View("Error");
            }
        }

        public ActionResult PastEvents(string department)
        {
            try
            {
                using (var db = new Model1())
                {
                    var pastEvents = new List<tblDepartmentPastEvent>();
                    tblDepartment departmentInfo = null;

                    if (!string.IsNullOrEmpty(department))
                    {
                        departmentInfo = db.tblDepartments.FirstOrDefault(d => d.Code == department);

                        if (departmentInfo != null)
                        {
                            pastEvents = db.tblDepartmentPastEvents
                                .Where(e => e.DepartmentId == departmentInfo.DepartmentID)
                                .OrderByDescending(e => e.EventDate)
                                .ToList();
                        }
                    }
                    else
                    {
                        pastEvents = db.tblDepartmentPastEvents.OrderByDescending(e => e.EventDate).ToList();
                    }

                    ViewBag.Department = departmentInfo;
                    ViewBag.DepartmentCode = department;
                    return View(pastEvents);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in PastEvents: {ex.Message}");
                return View("Error");
            }
        }

        public ActionResult UpcomingEvents(string department)
        {
            try
            {
                using (var db = new Model1())
                {
                    var upcomingEvents = new List<tblDepartmentUpcomingEvent>();
                    tblDepartment departmentInfo = null;

                    if (!string.IsNullOrEmpty(department))
                    {
                        departmentInfo = db.tblDepartments.FirstOrDefault(d => d.Code == department);

                        if (departmentInfo != null)
                        {
                            upcomingEvents = db.tblDepartmentUpcomingEvents
                                .Where(e => e.DepartmentId == departmentInfo.DepartmentID)
                                .Where(e => e.EventDate >= DateTime.Today)
                                .OrderBy(e => e.EventDate)
                                .ToList();
                        }
                    }
                    else
                    {
                        upcomingEvents = db.tblDepartmentUpcomingEvents
                            .Where(e => e.EventDate >= DateTime.Today)
                            .OrderBy(e => e.EventDate)
                            .ToList();
                    }

                    ViewBag.Department = departmentInfo;
                    ViewBag.DepartmentCode = department;
                    return View(upcomingEvents);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in UpcomingEvents: {ex.Message}");
                return View("Error");
            }
        }

        public ActionResult SuccessStories(string department)
        {
            try
            {
                using (var db = new Model1())
                {
                    var successStories = new List<tblSuccessStory>();
                    tblDepartment departmentInfo = null;



                    if (!string.IsNullOrEmpty(department))
                    {
                        // Map department name to code if needed
                        var departmentCode = MapDepartmentNameToCode(department);

                        // Get department info by code first, then by name if not found
                        departmentInfo = db.tblDepartments.FirstOrDefault(d => d.Code == departmentCode) ??
                                        db.tblDepartments.FirstOrDefault(d => d.Title.Replace(" ", "-").ToLower() == department.ToLower());

                        if (departmentInfo != null)
                        {
                            successStories = db.tblSuccessStories
                                .Where(s => s.DepartmentID == departmentInfo.DepartmentID && (s.Active == true || s.Active == null))
                                .OrderBy(s => s.FullName)
                                .ToList();
                        }
                    }
                    else
                    {
                        successStories = db.tblSuccessStories
                            .Where(s => s.Active == true || s.Active == null)
                            .OrderBy(s => s.FullName)
                            .ToList();
                    }

                    ViewBag.Department = departmentInfo;
                    ViewBag.DepartmentCode = department;
                    ViewBag.DepartmentName = departmentInfo?.Title;
                    ViewBag.Title = departmentInfo != null ?
                        $"{departmentInfo.Title} - Success Stories" :
                        "Success Stories";

                    return View(successStories);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in SuccessStories: {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
                return View("Error");
            }
        }

        public ActionResult FAQs(string department)
        {
            try
            {
                using (var db = new Model1())
                {
                    var faqs = new List<tblDepartmentFAQ>();
                    tblDepartment departmentInfo = null;

                    if (!string.IsNullOrEmpty(department))
                    {
                        departmentInfo = db.tblDepartments.FirstOrDefault(d => d.Code == department);

                        if (departmentInfo != null)
                        {
                            faqs = db.tblDepartmentFAQs
                                .Where(f => f.DepartmentId == departmentInfo.DepartmentID)
                                .OrderBy(f => f.CreatedDate)
                                .ToList();
                        }
                    }
                    else
                    {
                        faqs = db.tblDepartmentFAQs.OrderBy(f => f.CreatedDate).ToList();
                    }

                    ViewBag.Department = departmentInfo;
                    ViewBag.DepartmentCode = department;
                    return View(faqs);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in FAQs: {ex.Message}");
                return View("Error");
            }
        }

        public ActionResult Contacts(string department)
        {
            try
            {
                using (var db = new Model1())
                {
                    var contacts = new List<tblDepartmentContact>();
                    tblDepartment departmentInfo = null;

                    if (!string.IsNullOrEmpty(department))
                    {
                        departmentInfo = db.tblDepartments.FirstOrDefault(d => d.Code == department);

                        if (departmentInfo != null)
                        {
                            contacts = db.tblDepartmentContacts
                                .Where(c => c.DepartmentId == departmentInfo.DepartmentID)
                                .OrderBy(c => c.CreatedDate)
                                .ToList();
                        }
                    }
                    else
                    {
                        contacts = db.tblDepartmentContacts.OrderBy(c => c.CreatedDate).ToList();
                    }

                    ViewBag.Department = departmentInfo;
                    ViewBag.DepartmentCode = department;
                    return View(contacts);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in Contacts: {ex.Message}");
                return View("Error");
            }
        }
    }
}