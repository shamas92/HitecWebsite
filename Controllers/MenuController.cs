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
        public ActionResult GetNewsMenu()
        {
            try
            {
                // Get news menus with MenuType "News Menu" ordered by SortingOrder
                var newsMenus = db.tblMenus
                    .Where(m => m.MenuType.MenuTypeName == "News Menu")
                    .OrderBy(m => m.SortingOrder)
                    .ToList();

                // For each news menu, get its children recursively if needed
                foreach (var menu in newsMenus)
                {
                    LoadChildMenusRecursively(menu, "News Menu");
                }

                return PartialView("_NewsMenu", newsMenus);
            }
            catch (Exception ex)
            {
                // Log the exception if you have logging configured
                return Content("<!-- News Menu Error: " + ex.Message + " -->");
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
                // Get top-level menus (ParentMenuID is null) with MenuType "Main Menu" ordered by SortingOrder
                var mainMenus = db.tblMenus
                    .Where(m => m.ParentMenuID == null && m.MenuType.MenuTypeName == "Main Menu")
                    .OrderBy(m => m.SortingOrder)
                    .ToList();

                // For each main menu, get its children recursively
                foreach (var menu in mainMenus)
                {
                    LoadChildMenusRecursively(menu, "Main Menu");
                }

                return PartialView("_MainMenuMobile", mainMenus);
            }
            catch (Exception ex)
            {
                // Log the exception if you have logging configured
                return Content("<!-- Menu Error: " + ex.Message + " -->");
            }
        }

        public ActionResult GetMobileTopMenu()
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

                return PartialView("_MobileTopMenu", topMenus);
            }
            catch (Exception ex)
            {
                // Log the exception if you have logging configured
                return Content("<!-- Menu Error: " + ex.Message + " -->");
            }
        }

        private void LoadChildMenusRecursively(tblMenus menu, string menuType)
        {
            // Get all child menus of the current menu with the same MenuType
            var children = db.tblMenus
                .Where(m => m.ParentMenuID == menu.MenuID && m.MenuType.MenuTypeName == menuType)
                .OrderBy(m => m.SortingOrder)
                .ToList();

            if (children.Any())
            {
                menu.ChildMenus = children;

                // Recursively load children of each child
                foreach (var child in children)
                {
                    LoadChildMenusRecursively(child, menuType);
                }
            }
        }

        private bool IsMenuActive(string controller, string action)
        {
            string currentController = (string)RouteData.Values["controller"];
            string currentAction = (string)RouteData.Values["action"];

            return string.Equals(currentController, controller, StringComparison.OrdinalIgnoreCase) &&
                   string.Equals(currentAction, action, StringComparison.OrdinalIgnoreCase);
        }
    }
}