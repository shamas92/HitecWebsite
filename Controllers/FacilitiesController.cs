using System;
using System.Linq;
using System.Web.Mvc;
using Website.Models;
using HitecCM.Models;

namespace Website.Controllers
{
    public class FacilitiesController : Controller
    {
        // GET: Facilities
        public ActionResult Index()
        {
            return View();
        }

        // GET: Facilities/Transport
        public ActionResult Transport()
        {
            try
            {
                using (var db = new Model1())
                {
                    // Get the first transport record, or create a default if none exists
                    var transportData = db.tblTransports.FirstOrDefault();
                    
                    // Debug: Log what we found
                    System.Diagnostics.Debug.WriteLine($"Transport data found: {transportData != null}");
                    if (transportData != null)
                    {
                        System.Diagnostics.Debug.WriteLine($"Transport Title: {transportData.Title}");
                        System.Diagnostics.Debug.WriteLine($"Transport PageData length: {transportData.PageData?.Length ?? 0}");
                    }
                    
                    // If no data exists, create a placeholder object for the view
                    if (transportData == null)
                    {
                        transportData = new tblTransport
                        {
                            Title = "Transport Facilities",
                            PageData = null
                        };
                    }
                    
                    return View(transportData);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in Transport: {ex.Message}");
                // Return empty model on error
                var emptyModel = new tblTransport
                {
                    Title = "Transport Facilities",
                    PageData = null
                };
                return View(emptyModel);
            }
        }

        // GET: Facilities/Hostel
        public ActionResult Hostel()
        {
            try
            {
                using (var db = new Model1())
                {
                    var hostelData = db.tblHostels.FirstOrDefault();
                    
                    System.Diagnostics.Debug.WriteLine($"Hostel data found: {hostelData != null}");
                    if (hostelData != null)
                    {
                        System.Diagnostics.Debug.WriteLine($"Hostel Title: {hostelData.Title}");
                        System.Diagnostics.Debug.WriteLine($"Hostel PageData length: {hostelData.PageData?.Length ?? 0}");
                    }
                    
                    if (hostelData == null)
                    {
                        hostelData = new tblHostel
                        {
                            Title = "Hostel Facilities",
                            PageData = null
                        };
                    }
                    
                    return View(hostelData);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in Hostel: {ex.Message}");
                var emptyModel = new tblHostel
                {
                    Title = "Hostel Facilities",
                    PageData = null
                };
                return View(emptyModel);
            }
        }

        // GET: Facilities/Sports
        public ActionResult Sports()
        {
            try
            {
                using (var db = new Model1())
                {
                    var sportsData = db.tblSports.FirstOrDefault();
                    
                    System.Diagnostics.Debug.WriteLine($"Sports data found: {sportsData != null}");
                    if (sportsData != null)
                    {
                        System.Diagnostics.Debug.WriteLine($"Sports Title: {sportsData.Title}");
                        System.Diagnostics.Debug.WriteLine($"Sports PageData length: {sportsData.PageData?.Length ?? 0}");
                    }
                    
                    if (sportsData == null)
                    {
                        sportsData = new tblSports
                        {
                            Title = "Sports Facilities",
                            PageData = null
                        };
                    }
                    
                    return View(sportsData);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in Sports: {ex.Message}");
                var emptyModel = new tblSports
                {
                    Title = "Sports Facilities",
                    PageData = null
                };
                return View(emptyModel);
            }
        }

        // GET: Facilities/Cafeteria
        public ActionResult Cafeteria()
        {
            try
            {
                using (var db = new Model1())
                {
                    // First, let's debug what tables we have access to
                    System.Diagnostics.Debug.WriteLine("=== Cafeteria Debug Info ===");
                    
                    // Check if we have any cafeteria records
                    var cafeteriaCount = db.tblCafeterias.Count();
                    System.Diagnostics.Debug.WriteLine($"Total tblCafeteria records: {cafeteriaCount}");
                    
                    tblCafeteria cafeteriaData = null;
                    
                    if (cafeteriaCount > 0)
                    {
                        // Get the first (or latest) cafeteria record
                        cafeteriaData = db.tblCafeterias.OrderByDescending(c => c.CreatedAt).FirstOrDefault();
                        
                        if (cafeteriaData != null)
                        {
                            System.Diagnostics.Debug.WriteLine($"Found cafeteria data - ID: {cafeteriaData.ID}");
                            System.Diagnostics.Debug.WriteLine($"Title: '{cafeteriaData.Title}'");
                            System.Diagnostics.Debug.WriteLine($"HasPageData: {!string.IsNullOrEmpty(cafeteriaData.PageData)}");
                            System.Diagnostics.Debug.WriteLine($"CreatedAt: {cafeteriaData.CreatedAt}");
                            System.Diagnostics.Debug.WriteLine($"UpdatedAt: {cafeteriaData.UpdatedAt}");
                        }
                    }
                    
                    // If no data found, create placeholder with realistic content
                    if (cafeteriaData == null)
                    {
                        System.Diagnostics.Debug.WriteLine("No cafeteria records found, creating placeholder");
                        cafeteriaData = new tblCafeteria
                        {
                            ID = 0,
                            Title = "Cafeteria & Dining Services",
                            PageData = @"<div class='cafeteria-content'>
                                       <h3>University Cafeteria Services</h3>
                                       <p>HITEC University provides comprehensive dining facilities to serve the nutritional needs of our campus community. Our cafeteria offers a variety of meal options in a comfortable and clean environment.</p>
                                       
                                       <div class='row'>
                                           <div class='col-md-6'>
                                               <h4>??? Dining Services</h4>
                                               <ul>
                                                   <li>Daily breakfast, lunch, and dinner services</li>
                                                   <li>Fresh and hygienic food preparation</li>
                                                   <li>Variety of local and continental dishes</li>
                                                   <li>Vegetarian and non-vegetarian options</li>
                                                   <li>Special dietary accommodation upon request</li>
                                               </ul>
                                           </div>
                                           <div class='col-md-6'>
                                               <h4>? Operating Hours</h4>
                                               <ul>
                                                   <li><strong>Breakfast:</strong> 7:00 AM - 10:00 AM</li>
                                                   <li><strong>Lunch:</strong> 12:00 PM - 3:00 PM</li>
                                                   <li><strong>Dinner:</strong> 6:00 PM - 9:00 PM</li>
                                                   <li><strong>Snacks & Beverages:</strong> 10:00 AM - 6:00 PM</li>
                                               </ul>
                                           </div>
                                       </div>
                                       
                                       <h4>?? Affordable Pricing</h4>
                                       <p>We offer subsidized meal plans and affordable pricing for students and staff members. Monthly meal plans and daily payment options are available to suit different needs and budgets.</p>
                                       
                                       <h4>?? Facilities & Amenities</h4>
                                       <ul>
                                           <li>Spacious dining hall with comfortable seating</li>
                                           <li>Air-conditioned environment</li>
                                           <li>Modern kitchen equipment and facilities</li>
                                           <li>Trained and professional staff</li>
                                           <li>Clean and hygienic food preparation areas</li>
                                           <li>Separate areas for different dining preferences</li>
                                       </ul>
                                       
                                       <p>Our cafeteria staff is committed to maintaining high standards of food quality and service to ensure a pleasant dining experience for all members of the university community.</p>
                                       </div>",
                            CreatedAt = DateTime.Now,
                            UpdatedAt = null
                        };
                    }
                    
                    System.Diagnostics.Debug.WriteLine($"Final cafeteria data - Title: '{cafeteriaData.Title}', HasPageData: {!string.IsNullOrEmpty(cafeteriaData.PageData)}");
                    System.Diagnostics.Debug.WriteLine("=== End Cafeteria Debug ===");
                    
                    return View(cafeteriaData);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in Cafeteria: {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Stack Trace: {ex.StackTrace}");
                
                var emptyModel = new tblCafeteria
                {
                    ID = 0,
                    Title = "Cafeteria & Dining Services",
                    PageData = @"<div class='cafeteria-content'>
                               <h3>University Cafeteria Services</h3>
                               <p>HITEC University provides comprehensive dining facilities to serve the nutritional needs of our campus community. Our cafeteria offers a variety of meal options in a comfortable and clean environment.</p>
                               
                               <div class='row'>
                                   <div class='col-md-6'>
                                       <h4>??? Dining Services</h4>
                                       <ul>
                                           <li>Daily breakfast, lunch, and dinner services</li>
                                           <li>Fresh and hygienic food preparation</li>
                                           <li>Variety of local and continental dishes</li>
                                           <li>Vegetarian and non-vegetarian options</li>
                                           <li>Special dietary accommodation upon request</li>
                                       </ul>
                                   </div>
                                   <div class='col-md-6'>
                                       <h4>? Operating Hours</h4>
                                       <ul>
                                           <li><strong>Breakfast:</strong> 7:00 AM - 10:00 AM</li>
                                           <li><strong>Lunch:</strong> 12:00 PM - 3:00 PM</li>
                                           <li><strong>Dinner:</strong> 6:00 PM - 9:00 PM</li>
                                           <li><strong>Snacks & Beverages:</strong> 10:00 AM - 6:00 PM</li>
                                       </ul>
                                   </div>
                               </div>
                               
                               <h4>?? Affordable Pricing</h4>
                               <p>We offer subsidized meal plans and affordable pricing for students and staff members. Monthly meal plans and daily payment options are available to suit different needs and budgets.</p>
                               
                               <h4>?? Facilities & Amenities</h4>
                               <ul>
                                   <li>Spacious dining hall with comfortable seating</li>
                                   <li>Air-conditioned environment</li>
                                   <li>Modern kitchen equipment and facilities</li>
                                   <li>Trained and professional staff</li>
                                   <li>Clean and hygienic food preparation areas</li>
                                   <li>Separate areas for different dining preferences</li>
                               </ul>
                               
                               <p>Our cafeteria staff is committed to maintaining high standards of food quality and service to ensure a pleasant dining experience for all members of the university community.</p>
                               </div>",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                };
                return View(emptyModel);
            }
        }

        // GET: Facilities/UniversityFacilities (Additional action for general facilities)
        public ActionResult UniversityFacilities()
        {
            try
            {
                using (var db = new Model1())
                {
                    var facilities = db.tblUniversityFacilities.ToList();
                    return View(facilities);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in UniversityFacilities: {ex.Message}");
                return View();
            }
        }
    }
}