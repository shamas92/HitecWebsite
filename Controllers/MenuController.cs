using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using HitecCM.Models;
using Website.Models;

namespace Website.Controllers
{
    public class MenuController : Controller
    {
        private Model1 db = new Model1();

        public ActionResult GetTopMenu()
        {
            try
            {
                // Get top-level menus (ParentMenuID is null) with MenuType "Top Menu" ordered by SortingOrder
                var topMenus = db.tblMenus
                    .Where(m => m.ParentMenuID == null && m.MenuType.MenuTypeName == "Top Menu")
                    .OrderBy(m => m.SortingOrder)
                    .ToList();

                // For each top menu, get its children recursively
                foreach (var menu in topMenus)
                {
                    LoadChildMenusRecursively(menu, "Top Menu");
                }

                return PartialView("_TopMenu", topMenus);
            }
            catch (Exception ex)
            {
                // Log the exception if you have logging configured
                return Content("<!-- Menu Error: " + ex.Message + " -->");
            }
        }
        
        
        public ActionResult GetMiddleMenu()
        {
            try
            {
                // Get middle-level menus (ParentMenuID is null) with MenuType "Middle Menu" ordered by SortingOrder
                var middleMenus = db.tblMenus
                    .Where(m => m.ParentMenuID == null && m.MenuType.MenuTypeName == "Middle Menu")
                    .OrderBy(m => m.SortingOrder)
                    .ToList();

                // For each top menu, get its children recursively
                foreach (var menu in middleMenus)
                {
                    LoadChildMenusRecursively(menu, "Middle Menu");
                }

                return PartialView("_MiddleMenu", middleMenus);
            }
            catch (Exception ex)
            {
                // Log the exception if you have logging configured
                return Content("<!-- Menu Error: " + ex.Message + " -->");
            }
        }

        public ActionResult GetMainMenu()
        {
            try
            {
                // Get top-level menus (ParentMenuID is null) with MenuType "Main Menu" ordered by SortingOrder
                var mainMenus = db.tblMenus
                    .Where(m => m.ParentMenuID == null && m.MenuType.MenuTypeName == "Main Menu")
                    .OrderBy(m => m.SortingOrder)
                    .ToList();

                // For each main menu, get its children recursively
                foreach (var menu in mainMenus)
                {
                    LoadChildMenusRecursively(menu, "Main Menu");
                    
                    // Debug: Log menu structure
                    System.Diagnostics.Debug.WriteLine($"Main Menu: {menu.MenuName} - Children: {menu.ChildMenus?.Count ?? 0}");
                    if (menu.ChildMenus != null)
                    {
                        foreach (var child in menu.ChildMenus)
                        {
                            System.Diagnostics.Debug.WriteLine($"  Child: {child.MenuName} - Grandchildren: {child.ChildMenus?.Count ?? 0}");
                        }
                    }
                }

                return PartialView("_MainMenu", mainMenus);
            }
            catch (Exception ex)
            {
                // Log the exception if you have logging configured
                return Content("<!-- Menu Error: " + ex.Message + " -->");
            }
        }

        public ActionResult GetMobileMainMenu()
        {
            try
            {
                // Get top-level menus (ParentMenuID is null) with MenuType "Main Menu" for mobile (same as main menu)
                var mobileMenus = db.tblMenus
                    .Where(m => m.ParentMenuID == null && m.MenuType.MenuTypeName == "Main Menu")
                    .OrderBy(m => m.SortingOrder)
                    .ToList();

                // For each mobile menu, get its children recursively
                foreach (var menu in mobileMenus)
                {
                    LoadChildMenusRecursively(menu, "Main Menu");
                }

                return PartialView("_MainMenuMobile", mobileMenus);
            }
            catch (Exception ex)
            {
                // Log the exception if you have logging configured
                return Content("<!-- Menu Error: " + ex.Message + " -->");
            }
        }

        /// <summary>
        /// Recursively loads all child menus for a given menu
        /// </summary>
        /// <param name="menu">The parent menu</param>
        /// <param name="menuTypeName">The menu type name to filter by</param>
        private void LoadChildMenusRecursively(tblMenus menu, string menuTypeName)
        {
            // Load immediate children
            menu.ChildMenus = db.tblMenus
                .Where(m => m.ParentMenuID == menu.MenuID && m.MenuType.MenuTypeName == menuTypeName)
                .OrderBy(m => m.SortingOrder)
                .ToList();

            // Recursively load children for each child menu
            foreach (var childMenu in menu.ChildMenus)
            {
                LoadChildMenusRecursively(childMenu, menuTypeName);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
} 