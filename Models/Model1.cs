using HitecCM.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Website.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<AcademicCalendar> AcademicCalendars { get; set; }
        public virtual DbSet<AcademicDeficiency> AcademicDeficiencies { get; set; }
        public virtual DbSet<AdverQsement> AdverQsements { get; set; }
        public virtual DbSet<BiomedicalEngineering> BiomedicalEngineerings { get; set; }
        public virtual DbSet<BS_Islamic_Studies> BS_Islamic_Studies { get; set; }
        public virtual DbSet<BS_MathemaQcs_AI> BS_MathemaQcs_AI { get; set; }
        public virtual DbSet<Business_Programs> Business_Programs { get; set; }
        public virtual DbSet<Cafeteria_Info> Cafeteria_Info { get; set; }
        public virtual DbSet<CivilEngineering> CivilEngineerings { get; set; }
        public virtual DbSet<ClassificaQon_Groups> ClassificaQon_Groups { get; set; }
        public virtual DbSet<Computer_Science> Computer_Sciences { get; set; }
        public virtual DbSet<ComputerEngineering> ComputerEngineerings { get; set; }
        public virtual DbSet<Conference_IncenQves> Conference_IncenQves { get; set; }
        public virtual DbSet<ContactU> ContactUs { get; set; }
        public virtual DbSet<Contributory_Fund_Accounts> Contributory_Fund_Accounts { get; set; }
        public virtual DbSet<Contributory_Fund_Advances> Contributory_Fund_Advances { get; set; }
        public virtual DbSet<Contributory_Fund_ContribuQons> Contributory_Fund_ContribuQons { get; set; }
        public virtual DbSet<Contributory_Fund_Members> Contributory_Fund_Members { get; set; }
        public virtual DbSet<Contributory_Fund_NominaQon> Contributory_Fund_NominaQon { get; set; }
        public virtual DbSet<Contributory_Fund_Senngs> Contributory_Fund_Senngs { get; set; }
        public virtual DbSet<Course_Learning_Outcomes> Course_Learning_Outcomes { get; set; }
        public virtual DbSet<Death_Gratuity> Death_Gratuity { get; set; }
        public virtual DbSet<Download_Categories> Download_Categories { get; set; }
        public virtual DbSet<Download_Items> Download_Items { get; set; }
        public virtual DbSet<EducaQon_Subsidy> EducaQon_Subsidy { get; set; }
        public virtual DbSet<ElectricalEngineering> ElectricalEngineerings { get; set; }
        public virtual DbSet<Employee_Appeals> Employee_Appeals { get; set; }
        public virtual DbSet<Employee_Appointment_Details> Employee_Appointment_Details { get; set; }
        public virtual DbSet<Employee_Breach_Conduct> Employee_Breach_Conduct { get; set; }
        public virtual DbSet<Employee_Conduct_Rules> Employee_Conduct_Rules { get; set; }
        public virtual DbSet<Employee_Contracts> Employee_Contracts { get; set; }
        public virtual DbSet<Employee_Disciplinary_Cases> Employee_Disciplinary_Cases { get; set; }
        public virtual DbSet<Employee_Eligibility_Criteria> Employee_Eligibility_Criteria { get; set; }
        public virtual DbSet<Employee_Inquiry_Procedures> Employee_Inquiry_Procedures { get; set; }
        public virtual DbSet<Employee_Leave_Records> Employee_Leave_Records { get; set; }
        public virtual DbSet<Employee_PenalQes> Employee_PenalQes { get; set; }
        public virtual DbSet<Employee_Transfers> Employee_Transfers { get; set; }
        public virtual DbSet<Employment_Types> Employment_Types { get; set; }
        public virtual DbSet<FeeStructureWithHostel> FeeStructureWithHostels { get; set; }
        public virtual DbSet<Hostel_Info> Hostel_Info { get; set; }
        public virtual DbSet<Hostel_Requests> Hostel_Requests { get; set; }
        public virtual DbSet<Leave_Approvals> Leave_Approvals { get; set; }
        public virtual DbSet<Leave_EnQtlement> Leave_EnQtlement { get; set; }
        public virtual DbSet<Leave_Types> Leave_Types { get; set; }
        public virtual DbSet<MechanicalEngineering> MechanicalEngineerings { get; set; }
        public virtual DbSet<MS_Islamic_Studies> MS_Islamic_Studies { get; set; }
        public virtual DbSet<MS_MathemaQcs> MS_MathemaQcs { get; set; }
        public virtual DbSet<MSRulesAndRegulaQon> MSRulesAndRegulaQons { get; set; }
        public virtual DbSet<PEO_AVainment> PEO_AVainment { get; set; }
        public virtual DbSet<PEO_PLO_Mapping> PEO_PLO_Mapping { get; set; }
        public virtual DbSet<Personal_Loan> Personal_Loan { get; set; }
        public virtual DbSet<PhD_Islamic_Studies> PhD_Islamic_Studies { get; set; }
        public virtual DbSet<PhD_MathemaQcs> PhD_MathemaQcs { get; set; }
        public virtual DbSet<PhDRulesAndRegulaQon> PhDRulesAndRegulaQons { get; set; }
        public virtual DbSet<PLO_AVainment> PLO_AVainment { get; set; }
        public virtual DbSet<PLO_CLO_Mapping> PLO_CLO_Mapping { get; set; }
        public virtual DbSet<PosiQon_Details> PosiQon_Details { get; set; }
        public virtual DbSet<Program_EducaQonal_ObjecQves> Program_EducaQonal_ObjecQves { get; set; }
        public virtual DbSet<Program_Learning_Outcomes> Program_Learning_Outcomes { get; set; }
        public virtual DbSet<PublicaQons_IncenQves> PublicaQons_IncenQves { get; set; }
        public virtual DbSet<ResignaQon_TerminaQon_Process> ResignaQon_TerminaQon_Process { get; set; }
        public virtual DbSet<SelecQon_Board> SelecQon_Board { get; set; }
        public virtual DbSet<SelecQon_CommiVee> SelecQon_CommiVee { get; set; }
        public virtual DbSet<Sport_Info> Sport_Info { get; set; }
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
        public virtual DbSet<tblEventHead> tblEventHeads { get; set; }
        public virtual DbSet<tblEventPhoto> tblEventPhotos { get; set; }
        public virtual DbSet<tblEvent> tblEvents { get; set; }
        public virtual DbSet<tblEventVideo> tblEventVideos { get; set; }
        public virtual DbSet<tblFacilite> tblFacilites { get; set; }
        public virtual DbSet<tblFacilityPhoto> tblFacilityPhotos { get; set; }
        public virtual DbSet<tblFaculty> tblFaculties { get; set; }
        public virtual DbSet<tblFacultiesET> tblFacultiesETs { get; set; }
        public virtual DbSet<tblFAQ> tblFAQs { get; set; }
        public virtual DbSet<tblFeeRefundPolicy> tblFeeRefundPolicies { get; set; }
        public virtual DbSet<tblFinancialAssistance> tblFinancialAssistances { get; set; }
        public virtual DbSet<tblLatePaymentPenalty> tblLatePaymentPenalties { get; set; }
        public virtual DbSet<tblMenus> tblMenus { get; set; }
        public virtual DbSet<tblMenuType> tblMenuTypes { get; set; }
        public virtual DbSet<tblMiscellaneousCharge> tblMiscellaneousCharges { get; set; }
        public virtual DbSet<tblMiscellaneousNote> tblMiscellaneousNotes { get; set; }
        public virtual DbSet<tblNoticeBoard> tblNoticeBoards { get; set; }
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
        public virtual DbSet<tblTransportNote> tblTransportNotes { get; set; }
        public virtual DbSet<tblTransportRefundPolicy> tblTransportRefundPolicies { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }
        public virtual DbSet<Transport_Info> Transport_Info { get; set; }
        public virtual DbSet<UniversityDocument> UniversityDocuments { get; set; }
        public virtual DbSet<Wards_Fee_Concession> Wards_Fee_Concession { get; set; }
        public virtual DbSet<Welfare_Fund> Welfare_Fund { get; set; }
        public virtual DbSet<tblNew> tblNews { get; set; }
        public virtual DbSet<tblNewsHead> tblNewsHeads { get; set; }
        public virtual DbSet<tblNewsPhoto> tblNewsPhotos { get; set; }
        public virtual DbSet<tblProgram> tblPrograms { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BiomedicalEngineering>()
                .Property(e => e.ProgramLevel)
                .IsUnicode(false);

            modelBuilder.Entity<BiomedicalEngineering>()
                .Property(e => e.Department)
                .IsUnicode(false);

            modelBuilder.Entity<BiomedicalEngineering>()
                .Property(e => e.ProgramTitle)
                .IsUnicode(false);

            modelBuilder.Entity<BiomedicalEngineering>()
                .Property(e => e.DescripQon)
                .IsUnicode(false);

            modelBuilder.Entity<BS_Islamic_Studies>()
                .Property(e => e.Program_Name)
                .IsUnicode(false);

            modelBuilder.Entity<BS_Islamic_Studies>()
                .Property(e => e.Focus_Area)
                .IsUnicode(false);

            modelBuilder.Entity<BS_Islamic_Studies>()
                .Property(e => e.Program_ObjecQves)
                .IsUnicode(false);

            modelBuilder.Entity<BS_MathemaQcs_AI>()
                .Property(e => e.Program_Name)
                .IsUnicode(false);

            modelBuilder.Entity<BS_MathemaQcs_AI>()
                .Property(e => e.Focus_Area)
                .IsUnicode(false);

            modelBuilder.Entity<BS_MathemaQcs_AI>()
                .Property(e => e.Special_Features)
                .IsUnicode(false);

            modelBuilder.Entity<Cafeteria_Info>()
                .Property(e => e.LocaQon)
                .IsUnicode(false);

            modelBuilder.Entity<Cafeteria_Info>()
                .Property(e => e.Food_Type)
                .IsUnicode(false);

            modelBuilder.Entity<Cafeteria_Info>()
                .Property(e => e.DescripQon)
                .IsUnicode(false);

            modelBuilder.Entity<Cafeteria_Info>()
                .Property(e => e.Price_Range)
                .IsUnicode(false);

            modelBuilder.Entity<ClassificaQon_Groups>()
                .Property(e => e.Group_Name)
                .IsUnicode(false);

            modelBuilder.Entity<ClassificaQon_Groups>()
                .Property(e => e.DescripQon)
                .IsUnicode(false);

            modelBuilder.Entity<Computer_Science>()
                .Property(e => e.ProgramLevel)
                .IsUnicode(false);

            modelBuilder.Entity<Computer_Science>()
                .Property(e => e.Department)
                .IsUnicode(false);

            modelBuilder.Entity<Computer_Science>()
                .Property(e => e.ProgramTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Computer_Science>()
                .Property(e => e.DescripQon)
                .IsUnicode(false);

            modelBuilder.Entity<Conference_IncenQves>()
                .Property(e => e.Conference_Type)
                .IsUnicode(false);

            modelBuilder.Entity<Conference_IncenQves>()
                .Property(e => e.Max_Amount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Contributory_Fund_Accounts>()
                .Property(e => e.Total_Member_ContribuQon)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Contributory_Fund_Accounts>()
                .Property(e => e.Total_University_ContribuQon)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Contributory_Fund_Accounts>()
                .Property(e => e.Profit_Accrued)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Contributory_Fund_Accounts>()
                .Property(e => e.Advances_Taken)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Contributory_Fund_Accounts>()
                .Property(e => e.Outstanding_Advance)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Contributory_Fund_Advances>()
                .Property(e => e.Advance_Amount)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Contributory_Fund_Advances>()
                .Property(e => e.Approved_By)
                .IsUnicode(false);

            modelBuilder.Entity<Contributory_Fund_Advances>()
                .Property(e => e.Interest_Rate)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Contributory_Fund_Advances>()
                .Property(e => e.Installment_Amount)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Contributory_Fund_ContribuQons>()
                .Property(e => e.Member_ContribuQon)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Contributory_Fund_ContribuQons>()
                .Property(e => e.University_ContribuQon)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Contributory_Fund_ContribuQons>()
                .Property(e => e.Total_ContribuQon)
                .HasPrecision(11, 2);

            modelBuilder.Entity<Contributory_Fund_Members>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Contributory_Fund_NominaQon>()
                .Property(e => e.Nominee_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Contributory_Fund_NominaQon>()
                .Property(e => e.RelaQonship)
                .IsUnicode(false);

            modelBuilder.Entity<Contributory_Fund_NominaQon>()
                .Property(e => e.Nominee_CNIC)
                .IsUnicode(false);

            modelBuilder.Entity<Contributory_Fund_Senngs>()
                .Property(e => e.Member_ContribuQon_Percentage)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Contributory_Fund_Senngs>()
                .Property(e => e.University_ContribuQon_Percentage)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Contributory_Fund_Senngs>()
                .Property(e => e.Max_Advance_Percentage)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Course_Learning_Outcomes>()
                .Property(e => e.CLO_Code)
                .IsUnicode(false);

            modelBuilder.Entity<Course_Learning_Outcomes>()
                .Property(e => e.CLO_DescripQon)
                .IsUnicode(false);

            modelBuilder.Entity<Course_Learning_Outcomes>()
                .HasMany(e => e.PLO_CLO_Mapping)
                .WithRequired(e => e.Course_Learning_Outcomes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Death_Gratuity>()
                .Property(e => e.Cause)
                .IsUnicode(false);

            modelBuilder.Entity<Death_Gratuity>()
                .Property(e => e.Lump_Sum_Payment)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Death_Gratuity>()
                .Property(e => e.Funeral_Grant)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Download_Categories>()
                .Property(e => e.Category_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Download_Categories>()
                .HasMany(e => e.Download_Items)
                .WithRequired(e => e.Download_Categories)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Download_Items>()
                .Property(e => e.Item_Title)
                .IsUnicode(false);

            modelBuilder.Entity<Download_Items>()
                .Property(e => e.File_Link)
                .IsUnicode(false);

            modelBuilder.Entity<EducaQon_Subsidy>()
                .Property(e => e.Program)
                .IsUnicode(false);

            modelBuilder.Entity<Employee_Appeals>()
                .Property(e => e.Appeal_DescripQon)
                .IsUnicode(false);

            modelBuilder.Entity<Employee_Appeals>()
                .Property(e => e.Appeal_Decision)
                .IsUnicode(false);

            modelBuilder.Entity<Employee_Appointment_Details>()
                .Property(e => e.Appointment_Type)
                .IsUnicode(false);

            modelBuilder.Entity<Employee_Appointment_Details>()
                .Property(e => e.Pay_Scale)
                .IsUnicode(false);

            modelBuilder.Entity<Employee_Appointment_Details>()
                .Property(e => e.Appointment_Mode)
                .IsUnicode(false);

            modelBuilder.Entity<Employee_Appointment_Details>()
                .Property(e => e.ConfirmaQon_Status)
                .IsUnicode(false);

            modelBuilder.Entity<Employee_Appointment_Details>()
                .Property(e => e.PromoQon_Eligibility)
                .IsUnicode(false);

            modelBuilder.Entity<Employee_Appointment_Details>()
                .Property(e => e.Increments_Eligible)
                .IsUnicode(false);

            modelBuilder.Entity<Employee_Appointment_Details>()
                .HasMany(e => e.Conference_IncenQves)
                .WithOptional(e => e.Employee_Appointment_Details)
                .HasForeignKey(e => e.Employee_ID);

            modelBuilder.Entity<Employee_Appointment_Details>()
                .HasMany(e => e.Contributory_Fund_Members)
                .WithOptional(e => e.Employee_Appointment_Details)
                .HasForeignKey(e => e.Employee_ID);

            modelBuilder.Entity<Employee_Appointment_Details>()
                .HasMany(e => e.Death_Gratuity)
                .WithOptional(e => e.Employee_Appointment_Details)
                .HasForeignKey(e => e.Employee_ID);

            modelBuilder.Entity<Employee_Appointment_Details>()
                .HasMany(e => e.EducaQon_Subsidy)
                .WithOptional(e => e.Employee_Appointment_Details)
                .HasForeignKey(e => e.Employee_ID);

            modelBuilder.Entity<Employee_Appointment_Details>()
                .HasMany(e => e.Employee_Appeals)
                .WithOptional(e => e.Employee_Appointment_Details)
                .HasForeignKey(e => e.Employee_ID);

            modelBuilder.Entity<Employee_Appointment_Details>()
                .HasMany(e => e.Employee_Disciplinary_Cases)
                .WithOptional(e => e.Employee_Appointment_Details)
                .HasForeignKey(e => e.Employee_ID);

            modelBuilder.Entity<Employee_Appointment_Details>()
                .HasMany(e => e.Employee_Transfers)
                .WithOptional(e => e.Employee_Appointment_Details)
                .HasForeignKey(e => e.Employee_ID);

            modelBuilder.Entity<Employee_Appointment_Details>()
                .HasMany(e => e.Employee_Contracts)
                .WithOptional(e => e.Employee_Appointment_Details)
                .HasForeignKey(e => e.Employee_ID);

            modelBuilder.Entity<Employee_Appointment_Details>()
                .HasMany(e => e.Employee_Leave_Records)
                .WithOptional(e => e.Employee_Appointment_Details)
                .HasForeignKey(e => e.Employee_ID);

            modelBuilder.Entity<Employee_Appointment_Details>()
                .HasMany(e => e.Leave_EnQtlement)
                .WithOptional(e => e.Employee_Appointment_Details)
                .HasForeignKey(e => e.Employee_ID);

            modelBuilder.Entity<Employee_Appointment_Details>()
                .HasMany(e => e.Personal_Loan)
                .WithOptional(e => e.Employee_Appointment_Details)
                .HasForeignKey(e => e.Employee_ID);

            modelBuilder.Entity<Employee_Appointment_Details>()
                .HasMany(e => e.PublicaQons_IncenQves)
                .WithOptional(e => e.Employee_Appointment_Details)
                .HasForeignKey(e => e.Employee_ID);

            modelBuilder.Entity<Employee_Appointment_Details>()
                .HasMany(e => e.Wards_Fee_Concession)
                .WithOptional(e => e.Employee_Appointment_Details)
                .HasForeignKey(e => e.Employee_ID);

            modelBuilder.Entity<Employee_Appointment_Details>()
                .HasMany(e => e.Welfare_Fund)
                .WithOptional(e => e.Employee_Appointment_Details)
                .HasForeignKey(e => e.Employee_ID);

            modelBuilder.Entity<Employee_Breach_Conduct>()
                .Property(e => e.Breach_Type)
                .IsUnicode(false);

            modelBuilder.Entity<Employee_Breach_Conduct>()
                .Property(e => e.Breach_DescripQon)
                .IsUnicode(false);

            modelBuilder.Entity<Employee_Conduct_Rules>()
                .Property(e => e.Rule_Type)
                .IsUnicode(false);

            modelBuilder.Entity<Employee_Conduct_Rules>()
                .Property(e => e.Rule_DescripQon)
                .IsUnicode(false);

            modelBuilder.Entity<Employee_Contracts>()
                .Property(e => e.Contract_Document)
                .IsUnicode(false);

            modelBuilder.Entity<Employee_Disciplinary_Cases>()
                .Property(e => e.Case_Status)
                .IsUnicode(false);

            modelBuilder.Entity<Employee_Disciplinary_Cases>()
                .Property(e => e.Final_Decision)
                .IsUnicode(false);

            modelBuilder.Entity<Employee_Eligibility_Criteria>()
                .Property(e => e.NaQonality)
                .IsUnicode(false);

            modelBuilder.Entity<Employee_Eligibility_Criteria>()
                .Property(e => e.QualificaQon_Req)
                .IsUnicode(false);

            modelBuilder.Entity<Employee_Eligibility_Criteria>()
                .Property(e => e.Document_VerificaQon)
                .IsUnicode(false);

            modelBuilder.Entity<Employee_Eligibility_Criteria>()
                .Property(e => e.Medical_Req)
                .IsUnicode(false);

            modelBuilder.Entity<Employee_Eligibility_Criteria>()
                .Property(e => e.Age_Proof_Req)
                .IsUnicode(false);

            modelBuilder.Entity<Employee_Eligibility_Criteria>()
                .Property(e => e.DisqualificaQons)
                .IsUnicode(false);

            modelBuilder.Entity<Employee_Inquiry_Procedures>()
                .Property(e => e.Step_DescripQon)
                .IsUnicode(false);

            modelBuilder.Entity<Employee_Leave_Records>()
                .Property(e => e.Leave_Status)
                .IsUnicode(false);

            modelBuilder.Entity<Employee_Leave_Records>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<Employee_PenalQes>()
                .Property(e => e.Penalty_Type)
                .IsUnicode(false);

            modelBuilder.Entity<Employee_PenalQes>()
                .Property(e => e.Penalty_DescripQon)
                .IsUnicode(false);

            modelBuilder.Entity<Employee_Transfers>()
                .Property(e => e.From_Department)
                .IsUnicode(false);

            modelBuilder.Entity<Employee_Transfers>()
                .Property(e => e.To_Department)
                .IsUnicode(false);

            modelBuilder.Entity<Employee_Transfers>()
                .Property(e => e.Transfer_Reason)
                .IsUnicode(false);

            modelBuilder.Entity<Employee_Transfers>()
                .Property(e => e.VC_Approval_Status)
                .IsUnicode(false);

            modelBuilder.Entity<Employment_Types>()
                .Property(e => e.Type_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Employment_Types>()
                .Property(e => e.DescripQon)
                .IsUnicode(false);

            modelBuilder.Entity<Hostel_Info>()
                .Property(e => e.Hostel_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Hostel_Info>()
                .Property(e => e.DescripQon)
                .IsUnicode(false);

            modelBuilder.Entity<Hostel_Info>()
                .Property(e => e.FaciliQes)
                .IsUnicode(false);

            modelBuilder.Entity<Hostel_Info>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<Hostel_Requests>()
                .Property(e => e.Student_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Hostel_Requests>()
                .Property(e => e.RegistraQon_Number)
                .IsUnicode(false);

            modelBuilder.Entity<Hostel_Requests>()
                .Property(e => e.Google_Form_Link)
                .IsUnicode(false);

            modelBuilder.Entity<Leave_Approvals>()
                .Property(e => e.Approved_By)
                .IsUnicode(false);

            modelBuilder.Entity<Leave_Approvals>()
                .Property(e => e.Approval_Status)
                .IsUnicode(false);

            modelBuilder.Entity<Leave_Approvals>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<Leave_Types>()
                .Property(e => e.Leave_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Leave_Types>()
                .Property(e => e.DescripQon)
                .IsUnicode(false);

            modelBuilder.Entity<Leave_Types>()
                .Property(e => e.Pay_Status)
                .IsUnicode(false);

            modelBuilder.Entity<MS_Islamic_Studies>()
                .Property(e => e.Program_Name)
                .IsUnicode(false);

            modelBuilder.Entity<MS_Islamic_Studies>()
                .Property(e => e.Focus_Area)
                .IsUnicode(false);

            modelBuilder.Entity<MS_Islamic_Studies>()
                .Property(e => e.Thesis_OpQon)
                .IsUnicode(false);

            modelBuilder.Entity<MS_MathemaQcs>()
                .Property(e => e.Program_Name)
                .IsUnicode(false);

            modelBuilder.Entity<MS_MathemaQcs>()
                .Property(e => e.Thesis_OpQon)
                .IsUnicode(false);

            modelBuilder.Entity<MS_MathemaQcs>()
                .Property(e => e.Research_Areas)
                .IsUnicode(false);

            modelBuilder.Entity<PEO_AVainment>()
                .Property(e => e.Alumni_Feedback_Score)
                .HasPrecision(5, 2);

            modelBuilder.Entity<PEO_AVainment>()
                .Property(e => e.Employer_Feedback_Score)
                .HasPrecision(5, 2);

            modelBuilder.Entity<PEO_AVainment>()
                .Property(e => e.Overall_AVainment)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Personal_Loan>()
                .Property(e => e.Loan_Amount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Personal_Loan>()
                .Property(e => e.Interest_Rate)
                .HasPrecision(4, 2);

            modelBuilder.Entity<Personal_Loan>()
                .Property(e => e.Loan_Type)
                .IsUnicode(false);

            modelBuilder.Entity<Personal_Loan>()
                .Property(e => e.Loan_Status)
                .IsUnicode(false);

            modelBuilder.Entity<PhD_Islamic_Studies>()
                .Property(e => e.Program_Name)
                .IsUnicode(false);

            modelBuilder.Entity<PhD_Islamic_Studies>()
                .Property(e => e.Focus_Area)
                .IsUnicode(false);

            modelBuilder.Entity<PhD_Islamic_Studies>()
                .Property(e => e.Entry_Requirements)
                .IsUnicode(false);

            modelBuilder.Entity<PhD_Islamic_Studies>()
                .Property(e => e.EvaluaQon_Criteria)
                .IsUnicode(false);

            modelBuilder.Entity<PhD_MathemaQcs>()
                .Property(e => e.Program_Name)
                .IsUnicode(false);

            modelBuilder.Entity<PhD_MathemaQcs>()
                .Property(e => e.Entry_Requirements)
                .IsUnicode(false);

            modelBuilder.Entity<PhD_MathemaQcs>()
                .Property(e => e.EvaluaQon_Criteria)
                .IsUnicode(false);

            modelBuilder.Entity<PhD_MathemaQcs>()
                .Property(e => e.Research_Areas)
                .IsUnicode(false);

            modelBuilder.Entity<PLO_AVainment>()
                .Property(e => e.Average_CLO_AVainment)
                .HasPrecision(5, 2);

            modelBuilder.Entity<PLO_CLO_Mapping>()
                .Property(e => e.ContribuQon_Level)
                .IsUnicode(false);

            modelBuilder.Entity<PosiQon_Details>()
                .Property(e => e.PosiQon_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Program_EducaQonal_ObjecQves>()
                .Property(e => e.PEO_Code)
                .IsUnicode(false);

            modelBuilder.Entity<Program_EducaQonal_ObjecQves>()
                .Property(e => e.PEO_DescripQon)
                .IsUnicode(false);

            modelBuilder.Entity<Program_EducaQonal_ObjecQves>()
                .HasMany(e => e.PEO_AVainment)
                .WithRequired(e => e.Program_EducaQonal_ObjecQves)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Program_EducaQonal_ObjecQves>()
                .HasMany(e => e.PEO_PLO_Mapping)
                .WithRequired(e => e.Program_EducaQonal_ObjecQves)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Program_Learning_Outcomes>()
                .Property(e => e.PLO_Code)
                .IsUnicode(false);

            modelBuilder.Entity<Program_Learning_Outcomes>()
                .Property(e => e.PLO_DescripQon)
                .IsUnicode(false);

            modelBuilder.Entity<Program_Learning_Outcomes>()
                .HasMany(e => e.PEO_PLO_Mapping)
                .WithRequired(e => e.Program_Learning_Outcomes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Program_Learning_Outcomes>()
                .HasMany(e => e.PLO_AVainment)
                .WithRequired(e => e.Program_Learning_Outcomes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Program_Learning_Outcomes>()
                .HasMany(e => e.PLO_CLO_Mapping)
                .WithRequired(e => e.Program_Learning_Outcomes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PublicaQons_IncenQves>()
                .Property(e => e.PublicaQon_Type)
                .IsUnicode(false);

            modelBuilder.Entity<PublicaQons_IncenQves>()
                .Property(e => e.IncenQve_Amount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<ResignaQon_TerminaQon_Process>()
                .Property(e => e.Process_Type)
                .IsUnicode(false);

            modelBuilder.Entity<ResignaQon_TerminaQon_Process>()
                .Property(e => e.Reason)
                .IsUnicode(false);

            modelBuilder.Entity<ResignaQon_TerminaQon_Process>()
                .Property(e => e.VC_Approval_Status)
                .IsUnicode(false);

            modelBuilder.Entity<SelecQon_Board>()
                .Property(e => e.Eminent_Scholar)
                .IsUnicode(false);

            modelBuilder.Entity<SelecQon_Board>()
                .Property(e => e.Subject_Expert)
                .IsUnicode(false);

            modelBuilder.Entity<Sport_Info>()
                .Property(e => e.Facility_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Sport_Info>()
                .Property(e => e.DescripQon)
                .IsUnicode(false);

            modelBuilder.Entity<Sport_Info>()
                .Property(e => e.AddiQonal_Info)
                .IsUnicode(false);

            modelBuilder.Entity<tblAccommodation>()
                .Property(e => e.HostelSecurityFee)
                .HasPrecision(10, 2);

            modelBuilder.Entity<tblAccommodation>()
                .Property(e => e.HostelChargesPerMonth)
                .HasPrecision(10, 2);

            modelBuilder.Entity<tblBMEOBECurriculum>()
                .Property(e => e.CurriculumTitle)
                .IsUnicode(false);

            modelBuilder.Entity<tblCsOBECurriculum>()
                .Property(e => e.CurriculumTitle)
                .IsUnicode(false);

            modelBuilder.Entity<tblDepartmentChairperson>()
                .Property(e => e.ChairpersonMessage)
                .IsUnicode(false);

            modelBuilder.Entity<tblDepartmentContact>()
                .Property(e => e.ContactTitle)
                .IsUnicode(false);

            modelBuilder.Entity<tblDepartmentContact>()
                .Property(e => e.ContactInfo)
                .IsUnicode(false);

            modelBuilder.Entity<tblDepartmentFacility>()
                .Property(e => e.FacilityTitle)
                .IsUnicode(false);

            modelBuilder.Entity<tblDepartmentFacility>()
                .Property(e => e.FacilityInfo)
                .IsUnicode(false);

            modelBuilder.Entity<tblDepartmentFacultyAbout>()
                .Property(e => e.DepartmentName)
                .IsUnicode(false);

            modelBuilder.Entity<tblDepartmentFacultyAbout>()
                .Property(e => e.AboutText)
                .IsUnicode(false);

            modelBuilder.Entity<tblDepartmentFAQ>()
                .Property(e => e.Question)
                .IsUnicode(false);

            modelBuilder.Entity<tblDepartmentPastEvent>()
                .Property(e => e.EventTitle)
                .IsUnicode(false);

            modelBuilder.Entity<tblDepartmentPastEvent>()
                .Property(e => e.EventDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblDepartmentProgram>()
                .Property(e => e.ProgramsInfo)
                .IsUnicode(false);

            modelBuilder.Entity<tblDepartmentProgramStudy>()
                .Property(e => e.CourseCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblDepartmentProgramStudy>()
                .Property(e => e.CourseTitle)
                .IsUnicode(false);

            modelBuilder.Entity<tblDepartmentProgramStudy>()
                .Property(e => e.CourseCreditHours)
                .IsUnicode(false);

            modelBuilder.Entity<tblDepartment>()
                .HasMany(e => e.tblFaculties)
                .WithRequired(e => e.tblDepartment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblDepartmentSchemeOfStudy>()
                .Property(e => e.ProgramTitle)
                .IsUnicode(false);

            modelBuilder.Entity<tblDepartmentSchemeOfStudy>()
                .Property(e => e.ProgramStudyTitle)
                .IsUnicode(false);

            modelBuilder.Entity<tblDepartmentSchemeOfStudy>()
                .HasMany(e => e.tblDepartmentProgramStudies)
                .WithOptional(e => e.tblDepartmentSchemeOfStudy)
                .HasForeignKey(e => e.ProgramStudyId);

            modelBuilder.Entity<tblDepartmentSuccessStory>()
                .Property(e => e.PersonName)
                .IsUnicode(false);

            modelBuilder.Entity<tblDepartmentSuccessStory>()
                .Property(e => e.SuccessDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblDepartmentTeachingFaculty>()
                .Property(e => e.TeacherInfo)
                .IsUnicode(false);

            modelBuilder.Entity<tblDepartmentUpcomingEvent>()
                .Property(e => e.EventTitle)
                .IsUnicode(false);

            modelBuilder.Entity<tblDepartmentUpcomingEvent>()
                .Property(e => e.EventDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblEvent>()
                .HasMany(e => e.tblEventPhotos)
                .WithOptional(e => e.tblEvent)
                .WillCascadeOnDelete();

            modelBuilder.Entity<tblEvent>()
                .HasMany(e => e.tblEventVideos)
                .WithOptional(e => e.tblEvent)
                .WillCascadeOnDelete();

            modelBuilder.Entity<tblFacultiesET>()
                .Property(e => e.VisionText)
                .IsUnicode(false);

            modelBuilder.Entity<tblFacultiesET>()
                .Property(e => e.MissionText)
                .IsUnicode(false);

            modelBuilder.Entity<tblPolicyCategory>()
                .Property(e => e.CategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<tblPolicyCategory>()
                .Property(e => e.CategoryDescription)
                .IsUnicode(false);

            modelBuilder.Entity<tblPolicyCategory>()
                .HasMany(e => e.tblPolicyItems)
                .WithOptional(e => e.tblPolicyCategory)
                .HasForeignKey(e => e.CategoryId);

            modelBuilder.Entity<tblPolicyItem>()
                .Property(e => e.ItemTitle)
                .IsUnicode(false);

            modelBuilder.Entity<tblPolicyItem>()
                .Property(e => e.ItemDescription)
                .IsUnicode(false);

            modelBuilder.Entity<tblPolicyItem>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<tblQAC>()
                .Property(e => e.PageTitle)
                .IsUnicode(false);

            modelBuilder.Entity<tblQAC>()
                .Property(e => e.PageText)
                .IsUnicode(false);

            modelBuilder.Entity<tblQACAccreditation>()
                .Property(e => e.PageTitle)
                .IsUnicode(false);

            modelBuilder.Entity<tblQACAccreditation>()
                .Property(e => e.PageText)
                .IsUnicode(false);

            modelBuilder.Entity<tblQACContact>()
                .Property(e => e.PageTitle)
                .IsUnicode(false);

            modelBuilder.Entity<tblQACContact>()
                .Property(e => e.PageText)
                .IsUnicode(false);

            modelBuilder.Entity<tblQACIPE>()
                .Property(e => e.PageTitle)
                .IsUnicode(false);

            modelBuilder.Entity<tblQACIPE>()
                .Property(e => e.PageText)
                .IsUnicode(false);

            modelBuilder.Entity<tblQACOrganogram>()
                .Property(e => e.PageTitle)
                .IsUnicode(false);

            modelBuilder.Entity<tblQACOrganogram>()
                .Property(e => e.PageText)
                .IsUnicode(false);

            modelBuilder.Entity<tblQACPGPR>()
                .Property(e => e.PageTitle)
                .IsUnicode(false);

            modelBuilder.Entity<tblQACPGPR>()
                .Property(e => e.PageText)
                .IsUnicode(false);

            modelBuilder.Entity<tblQACSAR>()
                .Property(e => e.PageTitle)
                .IsUnicode(false);

            modelBuilder.Entity<tblQACSAR>()
                .Property(e => e.PageText)
                .IsUnicode(false);

            modelBuilder.Entity<tblQACSurvay>()
                .Property(e => e.PageTitle)
                .IsUnicode(false);

            modelBuilder.Entity<tblQACSurvay>()
                .Property(e => e.PageText)
                .IsUnicode(false);

            modelBuilder.Entity<tblQAPolicy>()
                .Property(e => e.PageTitle)
                .IsUnicode(false);

            modelBuilder.Entity<tblQAPolicy>()
                .Property(e => e.PageText)
                .IsUnicode(false);

            modelBuilder.Entity<tblSeOBECurriculum>()
                .Property(e => e.CurriculumTitle)
                .IsUnicode(false);

            modelBuilder.Entity<tblTransport>()
                .Property(e => e.TransportChargesPerSemester)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Transport_Info>()
                .Property(e => e.Route_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Transport_Info>()
                .Property(e => e.DescripQon)
                .IsUnicode(false);

            modelBuilder.Entity<Transport_Info>()
                .Property(e => e.PDF_Link)
                .IsUnicode(false);

            modelBuilder.Entity<Wards_Fee_Concession>()
                .Property(e => e.Ward_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Welfare_Fund>()
                .Property(e => e.Monthly_ContribuQon)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Welfare_Fund>()
                .Property(e => e.Purpose)
                .IsUnicode(false);

            modelBuilder.Entity<Welfare_Fund>()
                .Property(e => e.Amount_Granted)
                .HasPrecision(10, 2);

            modelBuilder.Entity<tblQACRIPE>()
                .Property(e => e.PageTitle)
                .IsUnicode(false);

            modelBuilder.Entity<tblQACRIPE>()
                .Property(e => e.PageText)
                .IsUnicode(false);
        }
    }
}
