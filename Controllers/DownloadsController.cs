using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Text.RegularExpressions;
using Website.Models;
using System.Data.Entity;

namespace Website.Controllers
{
    public class DownloadsController : Controller
    {
        // GET: Downloads/Test - Test database connectivity
        public ActionResult Test()
        {
            var result = new System.Text.StringBuilder();
            
            try
            {
                result.AppendLine("=== Database Connection Test ===");
                
                using (var db = new Model1())
                {
                    result.AppendLine($"? Database context created");
                    result.AppendLine($"Connection String: {db.Database.Connection.ConnectionString}");
                    
                    // Test connection
                    db.Database.Connection.Open();
                    result.AppendLine($"? Database connection opened successfully");
                    result.AppendLine($"Connection State: {db.Database.Connection.State}");
                    
                    // Test if table exists
                    var tableExists = db.Database.SqlQuery<int>("SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'tblDownloadsNew'").FirstOrDefault();
                    result.AppendLine($"Table exists check: {(tableExists > 0 ? "? YES" : "? NO")}");
                    
                    if (tableExists > 0)
                    {
                        // Get record count
                        var count = db.Database.SqlQuery<int>("SELECT COUNT(*) FROM tblDownloadsNew").FirstOrDefault();
                        result.AppendLine($"Total records: {count}");
                        
                        if (count > 0)
                        {
                            // Get sample data using raw SQL
                            var sampleData = db.Database.SqlQuery<dynamic>("SELECT TOP 3 Id, PageTitle, UploadedDate, ModifiedDate FROM tblDownloadsNew ORDER BY ModifiedDate DESC").ToList();
                            result.AppendLine($"Sample records retrieved: {sampleData.Count}");
                            
                            // Test Entity Framework access
                            try
                            {
                                var efCount = db.tblDownloadsNews.Count();
                                result.AppendLine($"? Entity Framework access successful: {efCount} records");
                                
                                var efSample = db.tblDownloadsNews.Take(1).FirstOrDefault();
                                if (efSample != null)
                                {
                                    result.AppendLine($"? Sample EF record - ID: {efSample.Id}, Title: {efSample.PageTitle}");
                                }
                            }
                            catch (Exception efEx)
                            {
                                result.AppendLine($"? Entity Framework access failed: {efEx.Message}");
                            }
                        }
                    }
                }
                
                result.AppendLine("=== Test Completed Successfully ===");
            }
            catch (Exception ex)
            {
                result.AppendLine($"? ERROR: {ex.Message}");
                result.AppendLine($"Exception Type: {ex.GetType().Name}");
                if (ex.InnerException != null)
                {
                    result.AppendLine($"Inner Exception: {ex.InnerException.Message}");
                }
            }
            
            ViewBag.TestResult = result.ToString();
            return View();
        }

        // GET: Downloads
        public ActionResult Index()
        {
            try
            {
                System.Diagnostics.Debug.WriteLine("=== Downloads Controller - Index Method Started ===");
                
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
                    var count = db.tblDownloadsNews.Count();
                    System.Diagnostics.Debug.WriteLine($"Total records in tblDownloadsNews: {count}");
                    
                    // Get the actual data
                    var downloads = db.tblDownloadsNews
                        .OrderByDescending(d => d.ModifiedDate ?? d.UploadedDate)
                        .ToList();
                    
                    System.Diagnostics.Debug.WriteLine($"Downloads retrieved: {downloads.Count}");
                    
                    // Log each download for debugging
                    foreach (var download in downloads)
                    {
                        System.Diagnostics.Debug.WriteLine($"Download ID: {download.Id}, Title: {download.PageTitle}");
                    }

                    ViewBag.Title = "Downloads";
                    ViewBag.MetaDescription = "Download important documents, forms, and resources from HITEC University";
                    ViewBag.ActiveDownload = "All";
                    ViewBag.DebugInfo = $"Found {downloads.Count} downloads in database";
                    
                    return View(downloads);
                }
            }
            catch (System.Data.SqlClient.SqlException sqlEx)
            {
                System.Diagnostics.Debug.WriteLine($"SQL Exception: {sqlEx.Message}");
                System.Diagnostics.Debug.WriteLine($"SQL Error Number: {sqlEx.Number}");
                System.Diagnostics.Debug.WriteLine($"SQL State: {sqlEx.State}");
                System.Diagnostics.Debug.WriteLine($"SQL Stack Trace: {sqlEx.StackTrace}");
                
                ViewBag.Title = "Downloads";
                ViewBag.MetaDescription = "Download important documents, forms, and resources from HITEC University";
                ViewBag.ActiveDownload = "All";
                ViewBag.ErrorMessage = $"Database connection error: {sqlEx.Message}";
                
                return View(new List<HitecCM.Models.tblDownloadsNew>());
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException dbEx)
            {
                System.Diagnostics.Debug.WriteLine($"Database Update Exception: {dbEx.Message}");
                System.Diagnostics.Debug.WriteLine($"Inner Exception: {dbEx.InnerException?.Message}");
                
                ViewBag.Title = "Downloads";
                ViewBag.MetaDescription = "Download important documents, forms, and resources from HITEC University";
                ViewBag.ActiveDownload = "All";
                ViewBag.ErrorMessage = $"Database update error: {dbEx.Message}";
                
                return View(new List<HitecCM.Models.tblDownloadsNew>());
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"General Exception: {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Exception Type: {ex.GetType().Name}");
                System.Diagnostics.Debug.WriteLine($"Stack Trace: {ex.StackTrace}");
                if (ex.InnerException != null)
                {
                    System.Diagnostics.Debug.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                }
                
                ViewBag.Title = "Downloads";
                ViewBag.MetaDescription = "Download important documents, forms, and resources from HITEC University";
                ViewBag.ActiveDownload = "All";
                ViewBag.ErrorMessage = $"Error: {ex.Message}";
                
                return View(new List<HitecCM.Models.tblDownloadsNew>());
            }
        }

        // GET: Downloads/Category/{categoryName}
        public ActionResult Category(string categoryName)
        {
            try
            {
                using (var db = new Model1())
                {
                    var downloads = db.tblDownloadsNews
                        .OrderByDescending(d => d.ModifiedDate ?? d.UploadedDate)
                        .ToList();

                    ViewBag.Title = $"Downloads - {categoryName}";
                    ViewBag.MetaDescription = $"Download {categoryName} documents and resources from HITEC University";
                    ViewBag.ActiveDownload = categoryName;
                    
                    return View("Index", downloads);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Downloads Category Error: {ex.Message}");
                
                ViewBag.Title = $"Downloads - {categoryName}";
                ViewBag.MetaDescription = $"Download {categoryName} documents and resources from HITEC University";
                ViewBag.ActiveDownload = categoryName;
                ViewBag.ErrorMessage = $"Error loading {categoryName}: {ex.Message}";
                
                return View("Index", new List<HitecCM.Models.tblDownloadsNew>());
            }
        }
    }
}