using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Text.RegularExpressions;
using Website.Models;
using System.Data.Entity;

namespace Website.Controllers
{
    public class PolicyController : Controller
    {
        // GET: Policy
        public ActionResult Index()
        {
            try
            {
                System.Diagnostics.Debug.WriteLine("=== Policy Controller - Index Method Started ===");
                
                using (var db = new Model1())
                {
                    System.Diagnostics.Debug.WriteLine("Database context created successfully");
                    
                    // Test database connection
                    System.Diagnostics.Debug.WriteLine($"Connection String: {db.Database.Connection.ConnectionString}");
                    System.Diagnostics.Debug.WriteLine($"Database Connection State: {db.Database.Connection.State}");
                    
                    // Try to open connection explicitly
                    db.Database.Connection.Open();
                    System.Diagnostics.Debug.WriteLine("Database connection opened successfully");
                    
                    // Get the count first to see if table exists and has data
                    var count = db.tblPolicys.Count();
                    System.Diagnostics.Debug.WriteLine($"Total records in tblPolicy: {count}");
                    
                    // Get the actual data
                    var policies = db.tblPolicys
                        .OrderByDescending(p => p.ModifiedDate ?? p.UploadedDate)
                        .ToList();
                    
                    System.Diagnostics.Debug.WriteLine($"Policies retrieved: {policies.Count}");
                    
                    // Log each policy for debugging
                    foreach (var policy in policies)
                    {
                        System.Diagnostics.Debug.WriteLine($"Policy ID: {policy.Id}, Title: {policy.PageTitle}");
                    }

                    ViewBag.Title = "Policies";
                    ViewBag.MetaDescription = "View university policies, procedures, and guidelines from HITEC University";
                    ViewBag.ActivePolicy = "All";
                    ViewBag.DebugInfo = $"Found {policies.Count} policies in database";
                    
                    return View(policies);
                }
            }
            catch (System.Data.SqlClient.SqlException sqlEx)
            {
                System.Diagnostics.Debug.WriteLine($"SQL Exception: {sqlEx.Message}");
                System.Diagnostics.Debug.WriteLine($"SQL Error Number: {sqlEx.Number}");
                System.Diagnostics.Debug.WriteLine($"SQL State: {sqlEx.State}");
                System.Diagnostics.Debug.WriteLine($"SQL Stack Trace: {sqlEx.StackTrace}");
                
                ViewBag.Title = "Policies";
                ViewBag.MetaDescription = "View university policies, procedures, and guidelines from HITEC University";
                ViewBag.ActivePolicy = "All";
                ViewBag.ErrorMessage = $"Database connection error: {sqlEx.Message}";
                
                return View(new List<HitecCM.Models.tblPolicy>());
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException dbEx)
            {
                System.Diagnostics.Debug.WriteLine($"Database Update Exception: {dbEx.Message}");
                System.Diagnostics.Debug.WriteLine($"Inner Exception: {dbEx.InnerException?.Message}");
                
                ViewBag.Title = "Policies";
                ViewBag.MetaDescription = "View university policies, procedures, and guidelines from HITEC University";
                ViewBag.ActivePolicy = "All";
                ViewBag.ErrorMessage = $"Database update error: {dbEx.Message}";
                
                return View(new List<HitecCM.Models.tblPolicy>());
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"General Exception: {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Exception Type: {ex.GetType().Name}");
                System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
                if (ex.InnerException != null)
                {
                    System.Diagnostics.Debug.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                }
                
                ViewBag.Title = "Policies";
                ViewBag.MetaDescription = "View university policies, procedures, and guidelines from HITEC University";
                ViewBag.ActivePolicy = "All";
                ViewBag.ErrorMessage = $"Error: {ex.Message}";
                
                return View(new List<HitecCM.Models.tblPolicy>());
            }
        }

        // GET: Policy/Category/{categoryName}
        public ActionResult Category(string categoryName)
        {
            try
            {
                using (var db = new Model1())
                {
                    var policies = db.tblPolicys
                        .OrderByDescending(p => p.ModifiedDate ?? p.UploadedDate)
                        .ToList();

                    ViewBag.Title = $"Policies - {categoryName}";
                    ViewBag.MetaDescription = $"View {categoryName} policies and guidelines from HITEC University";
                    ViewBag.ActivePolicy = categoryName;
                    
                    return View("Index", policies);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Policy Category Error: {ex.Message}");
                
                ViewBag.Title = $"Policies - {categoryName}";
                ViewBag.MetaDescription = $"View {categoryName} policies and guidelines from HITEC University";
                ViewBag.ActivePolicy = categoryName;
                ViewBag.ErrorMessage = $"Error loading {categoryName}: {ex.Message}";
                
                return View("Index", new List<HitecCM.Models.tblPolicy>());
            }
        }
    }
}