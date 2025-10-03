using HitecCM.Models;
using System.Data.Entity;

namespace Website.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        // Core/site tables that still exist
        public virtual DbSet<AcademicCalendar> AcademicCalendars { get; set; }
        public virtual DbSet<AdverQsement> AdverQsements { get; set; }

        public virtual DbSet<tblAbout> tblAbouts { get; set; }
        public virtual DbSet<tblAccommodation> tblAccommodations { get; set; }
        public virtual DbSet<tblAccommodationNote> tblAccommodationNotes { get; set; }
        public virtual DbSet<tblAccommodationRefundPolicy> tblAccommodationRefundPolicies { get; set; }
        public virtual DbSet<tblBMEOBECurriculum> tblBMEOBECurriculums { get; set; }
        public virtual DbSet<tblCsOBECurriculum> tblCsOBECurriculums { get; set; }
        public virtual DbSet<tblDepartmentChairperson> tblDepartmentChairpersons { get; set; }
        public virtual DbSet<tblDepartmentContact> tblDepartmentContacts { get; set; }
        public virtual DbSet<tblDepartmentFacility> tblDepartmentFacilities { get; set; }
        public virtual DbSet<tblDepartmentFacultyAbout> tblDepartmentFacultyAbouts { get; set; }
        public virtual DbSet<tblDepartmentFAQ> tblDepartmentFAQs { get; set; }
        public virtual DbSet<tblDepartmentPastEvent> tblDepartmentPastEvents { get; set; }
        public virtual DbSet<tblDepartmentProgram> tblDepartmentPrograms { get; set; }
        public virtual DbSet<tblDepartmentProgramStudy> tblDepartmentProgramStudies { get; set; }
        public virtual DbSet<tblDepartment> tblDepartments { get; set; }
        public virtual DbSet<tblDepartmentSchemeOfStudy> tblDepartmentSchemeOfStudies { get; set; }
        public virtual DbSet<tblDepartmentTeachingFaculty> tblDepartmentTeachingFaculties { get; set; }
        public virtual DbSet<tblDepartmentUpcomingEvent> tblDepartmentUpcomingEvents { get; set; }
        public virtual DbSet<tblDesignation> tblDesignations { get; set; }
        public virtual DbSet<tblDownload> tblDownloads { get; set; }
        public virtual DbSet<tblDownloadsNew> tblDownloadsNews { get; set; }
        public virtual DbSet<tblEventHead> tblEventHeads { get; set; }
        public virtual DbSet<tblEventPhoto> tblEventPhotos { get; set; }
        public virtual DbSet<tblEvent> tblEvents { get; set; }
        public virtual DbSet<tblEventVideo> tblEventVideos { get; set; }
        public virtual DbSet<tblFacilite> tblFacilites { get; set; }
        public virtual DbSet<tblFacilityPhoto> tblFacilityPhotos { get; set; }
        public virtual DbSet<tblFacilityImage> tblFacilityImages { get; set; }
        public virtual DbSet<tblFaculty> tblFaculties { get; set; }
        public virtual DbSet<tblFacultiesET> tblFacultiesETs { get; set; }
        public virtual DbSet<tblFAQ> tblFAQs { get; set; }
        public virtual DbSet<tblFeeRefundPolicy> tblFeeRefundPolicies { get; set; }
        public virtual DbSet<tblFinancialAssistance> tblFinancialAssistances { get; set; }
        public virtual DbSet<tblLatePaymentPenalty> tblLatePaymentPenalties { get; set; }
        public virtual DbSet<tblMenus> tblMenus { get; set; }
        public virtual DbSet<tblMenuType> tblMenuTypes { get; set; }
        public virtual DbSet<tblMiscellaneousCharge> tblMiscellaneousCharges { get; set; }
        public virtual DbSet<tblNoticeBoard> tblNoticeBoards { get; set; }
        public virtual DbSet<tblPolicy> tblPolicys { get; set; }
        public virtual DbSet<tblPolicyCategory> tblPolicyCategories { get; set; }
        public virtual DbSet<tblPolicyItem> tblPolicyItems { get; set; }
        public virtual DbSet<tblQAC> tblQACs { get; set; }
        public virtual DbSet<tblQACAccreditation> tblQACAccreditations { get; set; }
        public virtual DbSet<tblQACAnnualActivityCalender> tblQACAnnualActivityCalenders { get; set; }
        public virtual DbSet<tblQACContact> tblQACContacts { get; set; }
        public virtual DbSet<tblQACIPE> tblQACIPEs { get; set; }
        public virtual DbSet<tblQACOrganogram> tblQACOrganograms { get; set; }
        public virtual DbSet<tblQACPGPR> tblQACPGPRs { get; set; }
        public virtual DbSet<tblQACRIPE> tblQACRIPEs { get; set; }
        public virtual DbSet<tblQACSAR> tblQACSARs { get; set; }
        public virtual DbSet<tblQACSurvay> tblQACSurvays { get; set; }
        public virtual DbSet<tblQAPolicy> tblQAPolicies { get; set; }
        public virtual DbSet<tblRefundPolicy> tblRefundPolicies { get; set; }
        public virtual DbSet<tblSchemeOfStudy> tblSchemeOfStudies { get; set; }
        public virtual DbSet<tblSeOBECurriculum> tblSeOBECurriculums { get; set; }
        public virtual DbSet<tblSuccessStory> tblSuccessStories { get; set; }
        public virtual DbSet<tblTransport> tblTransports { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }
        public virtual DbSet<tblNew> tblNews { get; set; }
        public virtual DbSet<tblNewsHead> tblNewsHeads { get; set; }
        public virtual DbSet<tblNewsPhoto> tblNewsPhotos { get; set; }
        public virtual DbSet<tblProgram> tblPrograms { get; set; }
        public virtual DbSet<FeeStructureWithHostel> FeeStructureWithHostels { get; set; }

        // Newly added content models (HitecCM.Models)
        public virtual DbSet<tblUniversityFacilities> tblUniversityFacilities { get; set; }
        public virtual DbSet<tblSports> tblSports { get; set; }
        public virtual DbSet<tblRulesRegulationsMS> tblRulesRegulationsMS { get; set; }
        public virtual DbSet<tblRulesRegulationsPhd> tblRulesRegulationsPhd { get; set; }
        public virtual DbSet<tblHrPerks> tblHrPerks { get; set; }
        public virtual DbSet<tblHrContributoryFund> tblHrContributoryFunds { get; set; }
        public virtual DbSet<tblHrClassificationServices> tblHrClassificationServices { get; set; }
        public virtual DbSet<tblHrDiscipline> tblHrDisciplines { get; set; }
        public virtual DbSet<tblHrESTR> tblHrESTRs { get; set; }
        public virtual DbSet<tblHrLeaves> tblHrLeaves { get; set; }
        public virtual DbSet<tblHostel> tblHostels { get; set; }
        public virtual DbSet<tblAcademicRegulation> tblAcademicRegulations { get; set; }
        public virtual DbSet<tblAcademicDeficiency> tblAcademicDeficiencies { get; set; }
        public virtual DbSet<tblCafeteria> tblCafeterias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Intentionally minimal: rely on data annotations and conventions.
            // Keep relationships configured by navigation properties in models.
            base.OnModelCreating(modelBuilder);
        }
    }
}
