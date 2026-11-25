# Hitec University Website

An ASP.NET MVC 5 website for publishing public-facing university information. The application serves admissions content, academic calendars, departments and programs, faculty, events, facilities, human resources information, policies, quality assurance, and downloads from a SQL Server database.

## Technology

- C# and ASP.NET MVC 5
- .NET Framework 4.7.2
- Entity Framework 6
- SQL Server
- Razor views, Bootstrap, jQuery

## Run locally

1. Install Visual Studio with the **ASP.NET and web development** workload and the .NET Framework 4.7.2 developer pack.
2. Install or connect to SQL Server and prepare the application database/schema.
3. Open `Website.sln` in Visual Studio.
4. Set a local SQL Server connection string for the `Model1` Entity Framework context in `Web.config`. Do not commit machine-specific connection strings.
5. Restore NuGet packages, then run the `Website` project with IIS Express.

The site expects populated database tables for most content pages; a working database and its schema are not included as a portable local setup in this repository.

## Project areas

- `Controllers/` and `Views/`: public pages and page flows
- `Models/`: Entity Framework models and view models
- `Analytics/`: page-view tracking components
- `Content/` and `Scripts/`: styles, scripts, and static assets
- `App_Start/`: MVC routes, filters, and asset bundles

## Related project

The companion administrative application is [HitecCM](https://github.com/shamas92/HitecCM), which manages university content in the shared data model.

## Notes

This is a legacy ASP.NET MVC application and is intended to be opened and run on Windows with Visual Studio/IIS Express. Replace local database settings and analytics configuration with environment-specific values before deployment. Visual Studio caches, generated build folders, and user-specific files should not be committed.

