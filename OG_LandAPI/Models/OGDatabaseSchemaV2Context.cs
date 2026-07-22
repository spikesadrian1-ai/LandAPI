using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OG_LandAPI.Models
{
    public partial class OGDatabaseSchemaV2Context : DbContext
    {

        public OGDatabaseSchemaV2Context()
        {
        }

        public OGDatabaseSchemaV2Context(DbContextOptions<OGDatabaseSchemaV2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Burdens> Burdens { get; set; }
        public virtual DbSet<ChainOfTitleForm> ChainOfTitleForm { get; set; }
        public virtual DbSet<CheckDetails> CheckDetails { get; set; }
        public virtual DbSet<CheckMasterMainForm> CheckMasterMainForm { get; set; }
        public virtual DbSet<ContractGasMktForm> ContractGasMktForm { get; set; }
        public virtual DbSet<ContractMainForm2> ContractMainForm2 { get; set; }
        public virtual DbSet<ContractTractMainForm> ContractTractMainForm { get; set; }
        public virtual DbSet<CotTractConnection> CotTractConnection { get; set; }
        public virtual DbSet<CountyMasterMainForm> CountyMasterMainForm { get; set; }

        public virtual DbSet<DefaultBankMasters> DefaultBankMasters { get; set; }
        public virtual DbSet<DistrictMasterMain> DistrictMasterMain { get; set; }
        public virtual DbSet<DoideckDetails> DoideckDetails { get; set; }
        public virtual DbSet<DoideckMain> DoideckMain { get; set; }
        public virtual DbSet<DoimainForm> DoimainForm { get; set; }
        public virtual DbSet<DraftMasterMain> DraftMasterMain { get; set; }
        public virtual DbSet<DropDownLists> DropDownLists { get; set; }
        public virtual DbSet<DropDownLists2> DropDownLists2 { get; set; }
        public virtual DbSet<EasementMainForm> EasementMainForm { get; set; }
        public virtual DbSet<FilingInformation> FilingInformation { get; set; }
        public virtual DbSet<FormationMasterMain> FormationMasterMain { get; set; }
        public virtual DbSet<GrantorsGrantees> GrantorsGrantees { get; set; }
        public virtual DbSet<LeaseAcreageForm> LeaseAcreageForm { get; set; }
        public virtual DbSet<LeaseMainForm2> LeaseMainForm2 { get; set; }
        public virtual DbSet<LeaseSeismicForm> LeaseSeismicForm { get; set; }
        public virtual DbSet<NewPayment> NewPayment { get; set; }
        public virtual DbSet<Npri> Npri { get; set; }
        public virtual DbSet<Nri> Nri { get; set; }
        public virtual DbSet<OwnerAddressesMain> OwnerAddressesMain { get; set; }
         public virtual DbSet<OwnerConnection> OwnerConnection { get; set; }
        public virtual DbSet<OwnerDetails> OwnerDetails { get; set; }
        public virtual DbSet<OwnersContactInfo> OwnersContactInfo { get; set; }
        public virtual DbSet<PaymentObligations> PaymentObligations { get; set; }
        public virtual DbSet<PostalMainForm> PostalMainForm { get; set; }
        public virtual DbSet<PropertyMainForm> PropertyMainForm { get; set; }
        public virtual DbSet<PropertyTractConnection> PropertyTractConnection { get; set; }
        public virtual DbSet<ProspectMainForm> ProspectMainForm { get; set; }
        public virtual DbSet<RecordingInformation> RecordingInformation { get; set; }
        public virtual DbSet<RegionMasterMainForm> RegionMasterMainForm { get; set; }
        public virtual DbSet<Registration> Registration { get; set; }
        public virtual DbSet<RowMainForm> RowMainForm { get; set; }
        public virtual DbSet<Royalty> Royalty { get; set; }
        public virtual DbSet<SignInPage> SignInPage { get; set; }
        public virtual DbSet<SpecialObligations> SpecialObligations { get; set; }
        public virtual DbSet<SpecialProvisions> SpecialProvisions { get; set; }
        public virtual DbSet<StateMainForm> StateMainForm { get; set; }
        public virtual DbSet<StatusOfLeaseDropdown> StatusOfLeaseDropdown { get; set; }
        public virtual DbSet<SuamainForm> SuamainForm { get; set; }
        public virtual DbSet<SubTractMaster> SubTractMaster { get; set; }
        public virtual DbSet<SubTractTypeDropdown> SubTractTypeDropdown { get; set; }
        public virtual DbSet<SurfaceOwnership> SurfaceOwnership { get; set; }
        public virtual DbSet<SurveyTwnRngSecMasterMain> SurveyTwnRngSecMasterMain { get; set; }
        public virtual DbSet<TractDeedRefForm> TractDeedRefForm { get; set; }
        public virtual DbSet<TractMainForm> TractMainForm { get; set; }
        public virtual DbSet<TractOwnership> TractOwnership { get; set; }
        public virtual DbSet<TractsEasementConnection> TractsEasementConnection { get; set; }
        public virtual DbSet<TractsLeaseConnection> TractsLeaseConnection { get; set; }
        public virtual DbSet<TractsRowconnection> TractsRowconnection { get; set; }
        public virtual DbSet<TractsSuaconnection> TractsSuaconnection { get; set; }
        public virtual DbSet<TwnRngSecCrossRefs> TwnRngSecCrossRefs { get; set; }
        public virtual DbSet<UnitInterestsForm> UnitInterestsForm { get; set; }
        public virtual DbSet<UnitLegalForm> UnitLegalForm { get; set; }
        public virtual DbSet<UnitMainForm> UnitMainForm { get; set; }
        public virtual DbSet<UnitMoreForm> UnitMoreForm { get; set; }
        public virtual DbSet<UnitOtherForm> UnitOtherForm { get; set; }
        public virtual DbSet<WellEasementConnection> WellEasementConnection { get; set; }
        public virtual DbSet<WellLeaseConnection> WellLeaseConnection { get; set; }
        public virtual DbSet<WellMainForm2> WellMainForm2 { get; set; }
        public virtual DbSet<WellRowconnection> WellRowconnection { get; set; }
        public virtual DbSet<WellSuaconnection> WellSuaconnection { get; set; }
        public virtual DbSet<WellTractsConnection> WellTractsConnection { get; set; }
        public virtual DbSet<WideckDetails> WideckDetails { get; set; }
        public virtual DbSet<WideckInterest> WideckInterest { get; set; }
        public virtual DbSet<WideckMaster> WideckMaster { get; set; }


        /// <summary>
        /// DATA CONNECTION
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("OldConnection");
                //optionsBuilder.UseSqlServer("DevConnection");
                //optionsBuilder.UseSqlServer("OldDevConnection");
                optionsBuilder.UseSqlServer("Test"); // Null ExceptionError
            }
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Burdens>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BurdenAmount)
                    .HasColumnName("Burden_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.BurdenInterest)
                    .HasColumnName("Burden_Interest")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.BurdenType).HasColumnName("Burden_Type");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnName("Effective_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ExpireDate)
                    .HasColumnName("Expire_Date")
                    .HasColumnType("date");

                entity.Property(e => e.FullInterest).HasColumnName("Full_Interest");

                entity.Property(e => e.InterestFormula).HasColumnName("Interest_Formula");

                entity.Property(e => e.LeaseId).HasColumnName("Lease_ID");

                entity.Property(e => e.OwnerId).HasColumnName("Owner_ID");

                entity.Property(e => e.RoyId).HasColumnName("ROY_ID");

                entity.Property(e => e.SubTractId).HasColumnName("SubTract_ID");

                entity.Property(e => e.TractId).HasColumnName("Tract_ID");

                entity.Property(e => e.WellId).HasColumnName("Well_ID");
            });

            modelBuilder.Entity<ChainOfTitleForm>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BriefDescription).HasColumnName("Brief_Description");

                entity.Property(e => e.CotId).HasColumnName("COT_ID");

                entity.Property(e => e.CountyId).HasColumnName("County_ID");

                entity.Property(e => e.EffectiveDate).HasColumnName("Effective_Date");

                entity.Property(e => e.ExpirationDate).HasColumnName("Expiration_Date");

                entity.Property(e => e.GranteeInfo).HasColumnName("Grantee_Info");

                entity.Property(e => e.GrantorInfo).HasColumnName("Grantor_Info");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InstrumentDate).HasColumnName("Instrument_Date");

                entity.Property(e => e.InstrumentId).HasColumnName("Instrument_ID");

                entity.Property(e => e.LeaseId).HasColumnName("Lease_ID");

                entity.Property(e => e.LegalDescription).HasColumnName("Legal_Description");

                entity.Property(e => e.OtherDate1).HasColumnName("Other_Date_1");

                entity.Property(e => e.OtherDate2).HasColumnName("Other_Date_2");

                entity.Property(e => e.Search1).HasColumnName("Search_1");

                entity.Property(e => e.Search2).HasColumnName("Search_2");

                entity.Property(e => e.Search3).HasColumnName("Search_3");

                entity.Property(e => e.Search4).HasColumnName("Search_4");

                entity.Property(e => e.StateId).HasColumnName("State_ID");

                entity.Property(e => e.TractId).HasColumnName("Tract_ID");

                entity.Property(e => e.TypeOfInstrument).HasColumnName("Type_Of_Instrument");
            });

            modelBuilder.Entity<CheckDetails>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcctDate)
                    .HasColumnName("Acct_Date")
                    .HasColumnType("date");

                entity.Property(e => e.AcctPeriod).HasColumnName("Acct_Period");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BankFees)
                    .HasColumnName("Bank_Fees")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ChartOfAcctId).HasColumnName("Chart_Of_Acct_ID");

                entity.Property(e => e.CheckDetsPk).HasColumnName("Check_Dets_PK");

                entity.Property(e => e.CheckId).HasColumnName("Check_ID");

                entity.Property(e => e.DueDate)
                    .HasColumnName("Due_Date")
                    .HasColumnType("date");

                entity.Property(e => e.JibDeduction)
                    .HasColumnName("JIB_Deduction")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.LeaseId).HasColumnName("Lease_ID");

                entity.Property(e => e.MineralInterest)
                    .HasColumnName("Mineral_Interest")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.MktExpenses)
                    .HasColumnName("Mkt_Expenses")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OtherTaxes)
                    .HasColumnName("Other_Taxes")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OwnerId).HasColumnName("Owner_ID");

                entity.Property(e => e.PayRegardless).HasColumnName("Pay_Regardless");

                entity.Property(e => e.PaymentCode).HasColumnName("Payment_Code");

                entity.Property(e => e.RecoupAmount)
                    .HasColumnName("Recoup_Amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RevenueInterest)
                    .HasColumnName("Revenue_Interest")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.SeveranceTax)
                    .HasColumnName("Severance_Tax")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TractId).HasColumnName("Tract_ID");

                entity.Property(e => e.WellId).HasColumnName("Well_ID");

                entity.Property(e => e._1099Type).HasColumnName("1099_Type");
            });

            modelBuilder.Entity<CheckMasterMainForm>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNo).HasColumnName("Account_No");

                entity.Property(e => e.AcctDate)
                    .HasColumnName("Acct_Date")
                    .HasColumnType("date");

                entity.Property(e => e.BankCharges)
                    .HasColumnName("Bank_Charges")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CertifiedMailDate)
                    .HasColumnName("Certified_Mail_Date")
                    .HasColumnType("date");

                entity.Property(e => e.CertifiedMailNo).HasColumnName("Certified_Mail_No");

                entity.Property(e => e.CheckDate)
                    .HasColumnName("Check_Date")
                    .HasColumnType("date");

                entity.Property(e => e.CheckNumber).HasColumnName("Check_Number");

                entity.Property(e => e.CheckStatus).HasColumnName("Check_Status");

                entity.Property(e => e.DepBankId).HasColumnName("Dep_Bank_ID");

                entity.Property(e => e.DraftDate)
                    .HasColumnName("Draft_Date")
                    .HasColumnType("date");

                entity.Property(e => e.DraftIdNumber).HasColumnName("Draft_ID_Number");

                entity.Property(e => e.FederalTaxWithheld)
                    .HasColumnName("Federal_Tax_Withheld")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LeaseId).HasColumnName("Lease_ID");

                entity.Property(e => e.ManualCheck).HasColumnName("Manual_Check");

                entity.Property(e => e.NewDraftCheckNo).HasColumnName("New_Draft_Check_No");

                entity.Property(e => e.PaidDate)
                    .HasColumnName("Paid_Date")
                    .HasColumnType("date");

                entity.Property(e => e.PayeeId).HasColumnName("Payee_ID");

                entity.Property(e => e.PayorBankNo).HasColumnName("Payor_Bank_No");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.PropertyType).HasColumnName("Property_Type");

                entity.Property(e => e.Search1).HasColumnName("Search_1");

                entity.Property(e => e.Search2).HasColumnName("Search_2");

                entity.Property(e => e.Search3).HasColumnName("Search_3");

                entity.Property(e => e.Search4).HasColumnName("Search_4");

                entity.Property(e => e.TotalAmount)
                    .HasColumnName("Total_Amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TractId).HasColumnName("Tract_ID");

                entity.Property(e => e.TypeOfCheck).HasColumnName("Type_Of_Check");

                entity.Property(e => e.VoidedBy).HasColumnName("Voided_By");

                entity.Property(e => e.VoidedDate)
                    .HasColumnName("Voided_Date")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<ContractGasMktForm>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CountyId)
                    .IsRequired()
                    .HasColumnName("County_ID");

                entity.Property(e => e.Fees).IsRequired();

                entity.Property(e => e.PriceRedeterminationClause).HasColumnName("Price_Redetermination_Clause");

                entity.Property(e => e.PriceRedeterminationDate).HasColumnName("Price_Redetermination_Date");

                entity.Property(e => e.PriceSettlement)
                    .IsRequired()
                    .HasColumnName("Price_Settlement");
            });

            modelBuilder.Entity<ContractMainForm2>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcctDeptId).HasColumnName("Acct_Dept_ID");

                entity.Property(e => e.AcquiredDate)
                    .HasColumnName("Acquired_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActualAdverseConditionDays).HasColumnName("Actual_Adverse_Condition_Days");

                entity.Property(e => e.AdditionalLeaseDays).HasColumnName("Additional_Lease_Days");

                entity.Property(e => e.AllAfe).HasColumnName("All_AFE");

                entity.Property(e => e.AllLeases).HasColumnName("All_Leases");

                entity.Property(e => e.AllTracts).HasColumnName("All_Tracts");

                entity.Property(e => e.AllWells).HasColumnName("All_Wells");

                entity.Property(e => e.ApprovedDate)
                    .HasColumnName("Approved_Date")
                    .HasColumnType("date");

                entity.Property(e => e.AssignmentClause).HasColumnName("Assignment_Clause");

                entity.Property(e => e.BasinId).HasColumnName("Basin_ID");

                entity.Property(e => e.BeginOperDate)
                    .HasColumnName("Begin_Oper_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ClosingDate)
                    .HasColumnName("Closing_Date")
                    .HasColumnType("date");

                entity.Property(e => e.Consideration).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ContractDate)
                    .HasColumnName("Contract_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ContractDescription).HasColumnName("Contract_Description");

                entity.Property(e => e.ContractId).HasColumnName("Contract_ID");

                entity.Property(e => e.ContractLegalDescription).HasColumnName("Contract_Legal_Description");

                entity.Property(e => e.ContractStatus).HasColumnName("Contract_Status");

                entity.Property(e => e.ContractTerm).HasColumnName("Contract_Term");

                entity.Property(e => e.ContractType).HasColumnName("Contract_Type");

                entity.Property(e => e.CountyId).HasColumnName("County_ID");

                entity.Property(e => e.CountyId1).HasColumnName("CountyID");

                entity.Property(e => e.CountyId2).HasColumnName("County_ID_2");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Date1)
                    .HasColumnName("Date_1")
                    .HasColumnType("date");

                entity.Property(e => e.Date2)
                    .HasColumnName("Date_2")
                    .HasColumnType("date");

                entity.Property(e => e.Date3)
                    .HasColumnName("Date_3")
                    .HasColumnType("date");

                entity.Property(e => e.Date4)
                    .HasColumnName("Date_4")
                    .HasColumnType("date");

                entity.Property(e => e.Date5)
                    .HasColumnName("Date_5")
                    .HasColumnType("date");

                entity.Property(e => e.Date6)
                    .HasColumnName("Date_6")
                    .HasColumnType("date");

                entity.Property(e => e.DescriptionMemo).HasColumnName("Description_Memo");

                entity.Property(e => e.DistrictId).HasColumnName("District_ID");

                entity.Property(e => e.DivestedDate)
                    .HasColumnName("Divested_Date")
                    .HasColumnType("date");

                entity.Property(e => e.DrlgBeginDate)
                    .HasColumnName("Drlg_Begin_Date")
                    .HasColumnType("date");

                entity.Property(e => e.DrlgEndingDate)
                    .HasColumnName("Drlg_Ending_Date")
                    .HasColumnType("date");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnName("Effective_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ExpireDate)
                    .HasColumnName("Expire_Date")
                    .HasColumnType("date");

                entity.Property(e => e.Fees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Field1).HasColumnName("Field_1");

                entity.Property(e => e.Field2).HasColumnName("Field_2");

                entity.Property(e => e.Field3).HasColumnName("Field_3");

                entity.Property(e => e.Field4).HasColumnName("Field_4");

                entity.Property(e => e.Field5).HasColumnName("Field_5");

                entity.Property(e => e.Field6).HasColumnName("Field_6");

                entity.Property(e => e.InHouse).HasColumnName("In_House");

                entity.Property(e => e.InputDate)
                    .HasColumnName("Input_Date")
                    .HasColumnType("date");

                entity.Property(e => e.Interest).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LastAmended)
                    .HasColumnName("Last_Amended")
                    .HasColumnType("date");

                entity.Property(e => e.LeaseId).HasColumnName("Lease_ID");

                entity.Property(e => e.MainCompany).HasColumnName("Main_Company");

                entity.Property(e => e.MapReference).HasColumnName("Map_Reference");

                entity.Property(e => e.MaximumExtensionDays).HasColumnName("Maximum_Extension_Days");

                entity.Property(e => e.MinimumAcres)
                    .HasColumnName("Minimum_Acres")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.MinimumAcresRequired)
                    .HasColumnName("Minimum_Acres_Required")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.MinimumAdverseConditionDays).HasColumnName("Minimum_Adverse_Condition_Days");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.NextNotifyDate)
                    .HasColumnName("Next_Notify_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NotifyDays).HasColumnName("Notify_Days");

                entity.Property(e => e.ObligationDate)
                    .HasColumnName("Obligation_Date")
                    .HasColumnType("date");

                entity.Property(e => e.OptionDays).HasColumnName("Option_Days");

                entity.Property(e => e.OptionEffDate)
                    .HasColumnName("Option_Eff_Date")
                    .HasColumnType("date");

                entity.Property(e => e.OptionExpire).HasColumnName("Option_Expire");

                entity.Property(e => e.OptionNotes).HasColumnName("Option_Notes");

                entity.Property(e => e.OptionPeriod).HasColumnName("Option_Period");

                entity.Property(e => e.OptionalAssignmentClause).HasColumnName("Optional_Assignment_Clause");

                entity.Property(e => e.OtherAmount1)
                    .HasColumnName("Other_Amount_1")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OtherAmount2)
                    .HasColumnName("Other_Amount_2")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PerpetualOptionClause).HasColumnName("Perpetual_Option_Clause");

                entity.Property(e => e.PerpetualPeriod)
                    .HasColumnName("Perpetual_Period")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PricePerAcre)
                    .HasColumnName("Price_Per_Acre")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PricePerLease)
                    .HasColumnName("Price_Per_Lease")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PricePerMile)
                    .HasColumnName("Price_Per_Mile")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PricePerSection)
                    .HasColumnName("Price_Per_Section")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PricePerShotHole)
                    .HasColumnName("Price_Per_Shot_Hole")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PricePerSurvey)
                    .HasColumnName("Price_Per_Survey")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PriceRedeterminationClause).HasColumnName("Price_Redetermination_Clause");

                entity.Property(e => e.PriceRedeterminationDate)
                    .HasColumnName("Price_Redetermination_Date")
                    .HasColumnType("date");

                entity.Property(e => e.PriceSettlement)
                    .HasColumnName("Price_Settlement")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.PropertyType).HasColumnName("Property_Type");

                entity.Property(e => e.ProspectId).HasColumnName("Prospect_ID");

                entity.Property(e => e.RecordingInformation).HasColumnName("Recording_Information");

                entity.Property(e => e.RegionId).HasColumnName("Region_ID");

                entity.Property(e => e.RevisedDate)
                    .HasColumnName("Revised_Date")
                    .HasColumnType("date");

                entity.Property(e => e.SearchMemo1).HasColumnName("Search_Memo_1");

                entity.Property(e => e.SearchMemo2).HasColumnName("Search_Memo_2");

                entity.Property(e => e.SignatureDate)
                    .HasColumnName("Signature_Date")
                    .HasColumnType("date");

                entity.Property(e => e.SpecialProvisionsNotes).HasColumnName("Special_Provisions_Notes");

                entity.Property(e => e.StateId).HasColumnName("State_ID");

                entity.Property(e => e.StateId2).HasColumnName("State_ID_2");

                entity.Property(e => e.StatusCode).HasColumnName("Status_Code");

                entity.Property(e => e.SubTractId).HasColumnName("SubTract_ID");

                entity.Property(e => e.SubType).HasColumnName("Sub_Type");

                entity.Property(e => e.TotalAcres)
                    .HasColumnName("Total_Acres")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.TotalMiles).HasColumnName("Total_Miles");

                entity.Property(e => e.TotalSections).HasColumnName("Total_Sections");

                entity.Property(e => e.TotalShotHoles).HasColumnName("Total_Shot_Holes");

                entity.Property(e => e.TotalSurveys).HasColumnName("Total_Surveys");

                entity.Property(e => e.TractId).HasColumnName("Tract_ID");

                entity.Property(e => e.UnitId).HasColumnName("Unit_ID");

                entity.Property(e => e.WellIdNo).HasColumnName("Well_ID_No");
            });

            modelBuilder.Entity<ContractTractMainForm>(entity =>
            {
                entity.ToTable("Contract_TractMainForm");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Consideration).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ContractDescription).HasColumnName("Contract_Description");

                entity.Property(e => e.ContractId).HasColumnName("Contract_ID");

                entity.Property(e => e.ContractStatus).HasColumnName("Contract_Status");

                entity.Property(e => e.ContractType).HasColumnName("Contract_Type");

                entity.Property(e => e.FormationType).HasColumnName("Formation_Type");

                entity.Property(e => e.LeaseId).HasColumnName("Lease_ID");

                entity.Property(e => e.SubType).HasColumnName("Sub_Type");

                entity.Property(e => e.TractId).HasColumnName("Tract_ID");
            });

            modelBuilder.Entity<CotTractConnection>(entity =>
            {
                entity.ToTable("COT_TractConnection");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CotId).HasColumnName("COT_ID");

                entity.Property(e => e.TractId).HasColumnName("Tract_ID");
            });

            modelBuilder.Entity<CountyMasterMainForm>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CountyId).HasColumnName("County_ID");

                entity.Property(e => e.CountyName).HasColumnName("County_Name");

                entity.Property(e => e.StateId)
                    .HasColumnName("State_ID")
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<DefaultBankMasters>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddressLine1).HasColumnName("Address_Line_1");

                entity.Property(e => e.AddressLine2).HasColumnName("Address_Line_2");

                entity.Property(e => e.AddressLine3).HasColumnName("Address_Line_3");

                entity.Property(e => e.BankId).HasColumnName("Bank_ID");

                entity.Property(e => e.BankName).HasColumnName("Bank_Name");

                entity.Property(e => e.LeaseId).HasColumnName("Lease_ID");

                entity.Property(e => e.OwnerId).HasColumnName("Owner_ID");

                entity.Property(e => e.PerAccount)
                    .HasColumnName("Per_Account")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PerCheck)
                    .HasColumnName("Per_Check")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PerDeposit)
                    .HasColumnName("Per_Deposit")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PerPayee)
                    .HasColumnName("Per_Payee")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SubTractId).HasColumnName("SubTract_ID");

                entity.Property(e => e.TractId).HasColumnName("Tract_ID");

                entity.Property(e => e.UnitId).HasColumnName("Unit_ID");

                entity.Property(e => e.WellId).HasColumnName("Well_ID");

                entity.Property(e => e.Zip).HasColumnName("ZIP");
            });

            modelBuilder.Entity<DistrictMasterMain>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DistrictId)
                    .HasColumnName("District_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.DistrictName).HasColumnName("District_Name");
            });

            modelBuilder.Entity<DoideckDetails>(entity =>
            {
                entity.ToTable("DOIDeckDetails");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnName("Effective_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ExpireDate)
                    .HasColumnName("Expire_Date")
                    .HasColumnType("date");

                entity.Property(e => e.InterestFormula).HasColumnName("Interest_Formula");

                entity.Property(e => e.InterestType).HasColumnName("Interest_Type");

                entity.Property(e => e.NoPay).HasColumnName("No_Pay");

                entity.Property(e => e.OtherDate)
                    .HasColumnName("Other_Date")
                    .HasColumnType("date");

                entity.Property(e => e.OwnerId).HasColumnName("Owner_ID");

                entity.Property(e => e.PayMarketingCosts).HasColumnName("Pay_Marketing_Costs");

                entity.Property(e => e.PayOtherTax1).HasColumnName("Pay_Other_Tax_1");

                entity.Property(e => e.PayOtherTax2).HasColumnName("Pay_Other_Tax_2");

                entity.Property(e => e.PayRegardless).HasColumnName("Pay_Regardless");

                entity.Property(e => e.PaySeveranceTax).HasColumnName("Pay_Severance_Tax");

                entity.Property(e => e.PayWpt).HasColumnName("Pay_WPT");

                entity.Property(e => e.SignDate)
                    .HasColumnName("Sign_Date")
                    .HasColumnType("date");

                entity.Property(e => e.SuspenseCode).HasColumnName("Suspense_Code");

                entity.Property(e => e.WellId).HasColumnName("Well_ID");
            });

            modelBuilder.Entity<DoideckMain>(entity =>
            {
                entity.ToTable("DOIDeckMain");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClosingStatement).HasColumnName("Closing_Statement");

                entity.Property(e => e.DeckId).HasColumnName("Deck_ID");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnName("Effective_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ExpireDate)
                    .HasColumnName("Expire_Date")
                    .HasColumnType("date");

                entity.Property(e => e.OpeningStatement).HasColumnName("Opening_Statement");

                entity.Property(e => e.OwnerId).HasColumnName("Owner_ID");

                entity.Property(e => e.PayoutCode).HasColumnName("Payout_Code");

                entity.Property(e => e.WellId).HasColumnName("Well_ID");
            });

            modelBuilder.Entity<DoimainForm>(entity =>
            {
                entity.ToTable("DOIMainForm");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClosingStatement).HasColumnName("Closing_Statement");

                entity.Property(e => e.CurrentOperator).HasColumnName("Current_Operator");

                entity.Property(e => e.CurrentStatus).HasColumnName("Current_Status");

                entity.Property(e => e.DoiDate)
                    .HasColumnName("DOI_Date")
                    .HasColumnType("date");

                entity.Property(e => e.DoiId).HasColumnName("DOI_ID");

                entity.Property(e => e.DoiName).HasColumnName("DOI_Name");

                entity.Property(e => e.DoiType).HasColumnName("DOI_Type");

                entity.Property(e => e.OpeningStatement).HasColumnName("Opening_Statement");

                entity.Property(e => e.OriginalOperator).HasColumnName("Original_Operator");

                entity.Property(e => e.UnitCalcType).HasColumnName("Unit_Calc_Type");

                entity.Property(e => e.UnitId).HasColumnName("Unit_ID");

                entity.Property(e => e.WellId).HasColumnName("Well_ID");
            });

            modelBuilder.Entity<DraftMasterMain>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BankFees)
                    .HasColumnName("Bank_Fees")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BankIdNo).HasColumnName("Bank_ID_No");

                entity.Property(e => e.DatePaid).HasColumnName("Date_Paid");

                entity.Property(e => e.DraftAmount)
                    .HasColumnName("Draft_Amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DraftDate).HasColumnName("Draft_Date");

                entity.Property(e => e.DraftFormId).HasColumnName("Draft_Form_ID");

                entity.Property(e => e.DraftNo).HasColumnName("Draft_No");

                entity.Property(e => e.DueDays).HasColumnName("Due_Days");

                entity.Property(e => e.PaidById).HasColumnName("Paid_By_ID");

                entity.Property(e => e.PayeeId).HasColumnName("Payee_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.PropertyType).HasColumnName("Property_Type");
            });

            modelBuilder.Entity<DropDownLists>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AcquisitionCode).HasColumnName("Acquisition_Code");

                entity.Property(e => e.AcreageType)
                    .HasColumnName("Acreage_Type")
                    .HasMaxLength(50);

                entity.Property(e => e.AddressType).HasColumnName("Address_Type");

                entity.Property(e => e.BasinId).HasColumnName("Basin_ID");

                entity.Property(e => e.ContractStatus).HasColumnName("Contract_Status");

                entity.Property(e => e.ContractType).HasColumnName("Contract_Type");

                entity.Property(e => e.DeckType).HasColumnName("Deck_Type");

                entity.Property(e => e.FederalLeaseFlag).HasColumnName("Federal_Lease_Flag");

                entity.Property(e => e.FormationType).HasColumnName("Formation_Type");

                entity.Property(e => e.GeneralClass).HasColumnName("General_Class");

                entity.Property(e => e.HbpFlag)
                    .HasColumnName("HBP_Flag")
                    .HasMaxLength(50);

                entity.Property(e => e.InstrumentCode).HasColumnName("Instrument_Code");

                entity.Property(e => e.InterestType).HasColumnName("Interest_Type");

                entity.Property(e => e.LeaseForm).HasColumnName("Lease_Form");

                entity.Property(e => e.LeaseStatus).HasColumnName("Lease_Status");

                entity.Property(e => e.LeaseType).HasColumnName("Lease_Type");

                entity.Property(e => e.LocationData).HasColumnName("Location_Data");

                entity.Property(e => e.NoPayCode).HasColumnName("No_Pay_Code");

                entity.Property(e => e.ObligationType).HasColumnName("Obligation_Type");

                entity.Property(e => e.OrriReductionType).HasColumnName("ORRI_Reduction_Type");

                entity.Property(e => e.OrriType).HasColumnName("ORRI_Type");

                entity.Property(e => e.PaymentType).HasColumnName("Payment_Type");

                entity.Property(e => e.PayoutCode).HasColumnName("Payout_Code");

                entity.Property(e => e.PhoneType).HasColumnName("Phone_Type");

                entity.Property(e => e.PropertyType).HasColumnName("Property_Type");

                entity.Property(e => e.SpecialProvisionCode).HasColumnName("Special_Provision_Code");

                entity.Property(e => e.SubType).HasColumnName("Sub_Type");

                entity.Property(e => e.SuspenseCode).HasColumnName("Suspense_Code");

                entity.Property(e => e.TaxIdType).HasColumnName("Tax_ID_Type");

                entity.Property(e => e.TenureCode).HasColumnName("Tenure_Code");

                entity.Property(e => e.TractStatus).HasColumnName("Tract_Status");

                entity.Property(e => e.TractType).HasColumnName("Tract_Type");

                entity.Property(e => e.TypeOfInstrument).HasColumnName("Type_of_Instrument");

                entity.Property(e => e.TypeOfLand).HasColumnName("Type_of_Land");

                entity.Property(e => e.UnitCalcType).HasColumnName("Unit_Calc_Type");

                entity.Property(e => e.WellStatus).HasColumnName("Well_Status");

                entity.Property(e => e.WellType).HasColumnName("Well_Type");
            });

            modelBuilder.Entity<DropDownLists2>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AcquiredFrom).HasColumnName("Acquired_From");

                entity.Property(e => e.CarrierId).HasColumnName("Carrier_ID");

                entity.Property(e => e.CurrentOperator).HasColumnName("Current_Operator");

                entity.Property(e => e.InsuranceType).HasColumnName("Insurance_Type");

                entity.Property(e => e.LandmanId).HasColumnName("Landman_ID");

                entity.Property(e => e.MainCompany).HasColumnName("Main Company");

                entity.Property(e => e.OperatorId).HasColumnName("Operator_ID");

                entity.Property(e => e.PreviousOperator).HasColumnName("Previous_Operator");

                entity.Property(e => e.ResponsibleParty).HasColumnName("Responsible_Party");

                entity.Property(e => e.SoldTo).HasColumnName("Sold_To");

                entity.Property(e => e.TimberType).HasColumnName("Timber_Type");
            });

            modelBuilder.Entity<EasementMainForm>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcquiredDate)
                    .HasColumnName("Acquired_Date")
                    .HasColumnType("date");

                entity.Property(e => e.AcquisitionAmount)
                    .HasColumnName("Acquisition_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.AcquisitionCode).HasColumnName("Acquisition_Code");

                entity.Property(e => e.AcreageNotes).HasColumnName("Acreage_Notes");

                entity.Property(e => e.AddlBankFees)
                    .HasColumnName("Addl_Bank_Fees")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.AdvanceRoyaltyPerAcre)
                    .HasColumnName("Advance_Royalty_Per_Acre")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.AdvancedRoyalty)
                    .HasColumnName("Advanced_Royalty")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.AlternateEasementName).HasColumnName("Alternate_Easement_Name");

                entity.Property(e => e.AreaName).HasColumnName("Area_Name");

                entity.Property(e => e.BasinId).HasColumnName("Basin_ID");

                entity.Property(e => e.BonusPerAcre)
                    .HasColumnName("Bonus_Per_Acre")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.BonusPerAcreToExtend)
                    .HasColumnName("Bonus_Per_Acre_to_Extend")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.BonusToExtend)
                    .HasColumnName("Bonus_To_Extend")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.BounsDeferred)
                    .HasColumnName("Bouns_Deferred")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.BrokerCosts)
                    .HasColumnName("Broker_Costs")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.CheckOn)
                    .HasColumnName("Check_On")
                    .HasColumnType("date");

                entity.Property(e => e.ConsiderationAmount)
                    .HasColumnName("Consideration_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.CountyId).HasColumnName("County_ID");

                entity.Property(e => e.CountyId2).HasColumnName("County_ID_2");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Damages)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Developed)
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.DistrictId).HasColumnName("District_ID");

                entity.Property(e => e.Divested).HasColumnType("date");

                entity.Property(e => e.EasementDate)
                    .HasColumnName("Easement_Date")
                    .HasColumnType("date");

                entity.Property(e => e.EasementForm).HasColumnName("Easement_Form");

                entity.Property(e => e.EasementId).HasColumnName("Easement_ID");

                entity.Property(e => e.EasementLegalDescription).HasColumnName("Easement_Legal_Description");

                entity.Property(e => e.EasementName).HasColumnName("Easement_Name");

                entity.Property(e => e.EasementStatus).HasColumnName("Easement_Status");

                entity.Property(e => e.EasementType).HasColumnName("Easement_Type");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnName("Effective_Date")
                    .HasColumnType("date");

                entity.Property(e => e.EnityGrossUndev)
                    .HasColumnName("Enity_Gross_Undev")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityExpiredInterest)
                    .HasColumnName("Entity_Expired_Interest")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityGrossAcres)
                    .HasColumnName("Entity_Gross_Acres")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityGrossDeveloped)
                    .HasColumnName("Entity_Gross_Developed")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityGrossHbp)
                    .HasColumnName("Entity_Gross_HBP")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityGrossOther)
                    .HasColumnName("Entity_Gross_Other")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityGrossSurface)
                    .HasColumnName("Entity_Gross_Surface")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityGrossSurfaceDeveloped)
                    .HasColumnName("Entity_Gross_Surface_Developed")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityNetAcres)
                    .HasColumnName("Entity_Net_Acres")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityNetDev)
                    .HasColumnName("Entity_Net_Dev")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityNetHbp)
                    .HasColumnName("Entity_Net_HBP")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityNetSurface)
                    .HasColumnName("Entity_Net_Surface")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityNetSurfaceDeveloped)
                    .HasColumnName("Entity_Net_Surface_Developed")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityNetUndeveloped)
                    .HasColumnName("Entity_Net_Undeveloped")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityNotes).HasColumnName("Entity_Notes");

                entity.Property(e => e.EntityNriGas)
                    .HasColumnName("Entity_NRI_Gas")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityNriOil)
                    .HasColumnName("Entity_NRI_Oil")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityNriOther)
                    .HasColumnName("Entity_NRI_Other")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityOpRights)
                    .HasColumnName("Entity_Op_Rights")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityOrriGas)
                    .HasColumnName("Entity_ORRI_Gas")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityOrriOil)
                    .HasColumnName("Entity_ORRI_Oil")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityOrriOther)
                    .HasColumnName("Entity_ORRI_Other")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityOtherGas)
                    .HasColumnName("Entity_Other_Gas")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityOtherOil)
                    .HasColumnName("Entity_Other_Oil")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityOtherOther)
                    .HasColumnName("Entity_Other_Other")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityRoyaltyGas)
                    .HasColumnName("Entity_Royalty_Gas")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityRoyaltyOil)
                    .HasColumnName("Entity_Royalty_Oil")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityRoyaltyOther)
                    .HasColumnName("Entity_Royalty_Other")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityShareAcquisitionAmount)
                    .HasColumnName("Entity_Share_Acquisition_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareAdvancedRoyalty)
                    .HasColumnName("ENTITY_SHARE_Advanced_Royalty")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareBonusToExtend)
                    .HasColumnName("ENTITY_SHARE_Bonus_To_Extend")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareBrokerCosts)
                    .HasColumnName("ENTITY_SHARE_Broker_Costs")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareDamages)
                    .HasColumnName("ENTITY_SHARE_Damages")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareOfBonus)
                    .HasColumnName("Entity_Share_Of_Bonus")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareOfRentals)
                    .HasColumnName("Entity_Share_Of_Rentals")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareProductionRoyalty)
                    .HasColumnName("ENTITY_SHARE_Production_Royalty")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareProductionRoyaltyAmount)
                    .HasColumnName("Entity_Share_Production_Royalty_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareRentalAmount)
                    .HasColumnName("Entity_Share_Rental_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareShutInAmount)
                    .HasColumnName("Entity_Share_Shut_In_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareShutInCosts)
                    .HasColumnName("ENTITY_SHARE_Shut_In_Costs")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareSurfaceFeeAmount)
                    .HasColumnName("Entity_Share_Surface_Fee_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ExpenseInterest)
                    .HasColumnName("Expense_Interest")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.ExpirationDate)
                    .HasColumnName("Expiration_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ExpireDate)
                    .HasColumnName("Expire_Date")
                    .HasColumnType("date");

                entity.Property(e => e.FedStateLeaseNo).HasColumnName("FedState_Lease_No");

                entity.Property(e => e.FederalLeaseFlag).HasColumnName("Federal_Lease_Flag");

                entity.Property(e => e.FieldBroker).HasColumnName("Field_Broker");

                entity.Property(e => e.FrequencyInMonths).HasColumnName("Frequency_In_Months");

                entity.Property(e => e.GrossAcres)
                    .HasColumnName("Gross_Acres")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.HbpAcres)
                    .HasColumnName("HBP_Acres")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.HbpFlag).HasColumnName("HBP_Flag");

                entity.Property(e => e.IncludeInTotalGrossAcres)
                    .HasColumnName("Include_in_Total_Gross_Acres")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.InputDate)
                    .HasColumnName("Input_Date")
                    .HasColumnType("date");

                entity.Property(e => e.InstrumentCode).HasColumnName("Instrument_Code");

                entity.Property(e => e.InstrumentFlag).HasColumnName("Instrument_Flag");

                entity.Property(e => e.LandType).HasColumnName("Land_Type");

                entity.Property(e => e.LeaseholdInterest)
                    .HasColumnName("Leasehold_Interest")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.LesseeId).HasColumnName("Lessee_ID");

                entity.Property(e => e.LessorId).HasColumnName("Lessor_ID");

                entity.Property(e => e.MaximumShutInDays).HasColumnName("Maximum_Shut_In_Days");

                entity.Property(e => e.MinRoyDue)
                    .HasColumnName("Min_Roy_Due")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.MineralOwnership).HasColumnName("Mineral_Ownership");

                entity.Property(e => e.MineralOwnershipDecimal)
                    .HasColumnName("Mineral_OwnershipDecimal")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.MmsLeaseNo).HasColumnName("MMS_Lease_No");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.NetAcres)
                    .HasColumnName("Net_Acres")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.NetDev)
                    .HasColumnName("Net_Dev")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.NetHbp)
                    .HasColumnName("Net_HBP")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.NetOther)
                    .HasColumnName("Net_Other")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.NetOtherEntity)
                    .HasColumnName("Net_Other_Entity")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.NetOutside)
                    .HasColumnName("Net_Outside")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.NetSurface)
                    .HasColumnName("Net_Surface")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.NetSurfaceDeveloped)
                    .HasColumnName("Net_Surface_Developed")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.NetUndeveloped)
                    .HasColumnName("Net_Undeveloped")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.NextRentalDue)
                    .HasColumnName("Next_Rental_Due")
                    .HasColumnType("date");

                entity.Property(e => e.NotesOnAcreage).HasColumnName("Notes_on_Acreage");

                entity.Property(e => e.Nri)
                    .HasColumnName("NRI")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.ORRI)
                    .HasColumnName("O_R_R_I")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.OkToPay).HasColumnName("OK_to_Pay");

                entity.Property(e => e.OperatingRights)
                    .HasColumnName("Operating_Rights")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.OperatorLeaseNo).HasColumnName("Operator_Lease_No");

                entity.Property(e => e.OptAmountPerAcre)
                    .HasColumnName("Opt_Amount_Per_Acre")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.OptExpireDate)
                    .HasColumnName("Opt_Expire_Date")
                    .HasColumnType("date");

                entity.Property(e => e.OptExpireDays).HasColumnName("Opt_Expire_Days");

                entity.Property(e => e.OptExtAmntPerAcre)
                    .HasColumnName("Opt_Ext_Amnt_Per_Acre")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.OptPeriod).HasColumnName("Opt_Period");

                entity.Property(e => e.OptPrepaidAmountPerAcre)
                    .HasColumnName("Opt_Prepaid_Amount_Per_Acre")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.OptToExtend).HasColumnName("Opt_To_Extend");

                entity.Property(e => e.OptToExtendDays).HasColumnName("Opt_To_Extend_Days");

                entity.Property(e => e.OptionConvBonusPerAcre)
                    .HasColumnName("Option_Conv_Bonus_Per_Acre")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.OriginalEasementNo).HasColumnName("Original_Easement_No");

                entity.Property(e => e.Orri1)
                    .HasColumnName("ORRI")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.OrriMemo).HasColumnName("ORRI_Memo");

                entity.Property(e => e.Other)
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.OtherAcreage)
                    .HasColumnName("Other_Acreage")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.OtherDate)
                    .HasColumnName("Other_Date")
                    .HasColumnType("date");

                entity.Property(e => e.OtherLeaseBurdens)
                    .HasColumnName("Other_Lease_Burdens")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.OutsideAcreage)
                    .HasColumnName("Outside_Acreage")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.OwnerId).HasColumnName("Owner_ID");

                entity.Property(e => e.PaidUp).HasColumnName("Paid_Up");

                entity.Property(e => e.PayoutCode).HasColumnName("Payout_Code");

                entity.Property(e => e.PoolingType).HasColumnName("Pooling_Type");

                entity.Property(e => e.PrimaryTerm).HasColumnName("Primary_Term");

                entity.Property(e => e.ProductionRoyalty)
                    .HasColumnName("Production_Royalty")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ProductionRoyaltyPerAcre)
                    .HasColumnName("Production_Royalty_Per_Acre")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ProjectGroupName).HasColumnName("Project_Group_Name");

                entity.Property(e => e.ProspectId).HasColumnName("Prospect_ID");

                entity.Property(e => e.PughHorizon).HasColumnName("Pugh_Horizon");

                entity.Property(e => e.PughHorizonExpDate)
                    .HasColumnName("Pugh_Horizon_Exp_Date")
                    .HasColumnType("date");

                entity.Property(e => e.PughVert).HasColumnName("Pugh_Vert");

                entity.Property(e => e.PughVertExpDate)
                    .HasColumnName("Pugh_Vert_Exp_Date")
                    .HasColumnType("date");

                entity.Property(e => e.RecordTitle)
                    .HasColumnName("Record_Title")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.RecordingInformation).HasColumnName("Recording_Information");

                entity.Property(e => e.RegionId).HasColumnName("Region_ID");

                entity.Property(e => e.RenewalLease).HasColumnName("Renewal_Lease");

                entity.Property(e => e.RentalDueDate)
                    .HasColumnName("Rental_Due_Date")
                    .HasColumnType("date");

                entity.Property(e => e.RentalPerAcre)
                    .HasColumnName("Rental_Per_ACre")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ResponsibleParty).HasColumnName("Responsible_Party");

                entity.Property(e => e.Royalty)
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.RoyaltyIntMemo).HasColumnName("Royalty_Int_Memo");

                entity.Property(e => e.Search1).HasColumnName("Search_1");

                entity.Property(e => e.Search2).HasColumnName("Search_2");

                entity.Property(e => e.Search3).HasColumnName("Search_3");

                entity.Property(e => e.Search4).HasColumnName("Search_4");

                entity.Property(e => e.Search5).HasColumnName("Search_5");

                entity.Property(e => e.Search6).HasColumnName("Search_6");

                entity.Property(e => e.SecondExpDate)
                    .HasColumnName("Second_Exp_Date")
                    .HasColumnType("date");

                entity.Property(e => e.SecondExpirationDate)
                    .HasColumnName("Second_Expiration_Date")
                    .HasColumnType("date");

                entity.Property(e => e.SeismicOptionNotes).HasColumnName("Seismic_Option_Notes");

                entity.Property(e => e.SeismicPermitExpirationDate)
                    .HasColumnName("Seismic_Permit_Expiration_Date")
                    .HasColumnType("date");

                entity.Property(e => e.SeismicPermitExpirationDays).HasColumnName("Seismic_Permit_Expiration_Days");

                entity.Property(e => e.SeismicPermitExtensionDays).HasColumnName("Seismic_Permit_Extension_Days");

                entity.Property(e => e.ShutInAmount)
                    .HasColumnName("Shut_In_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ShutInClause).HasColumnName("Shut_In_Clause");

                entity.Property(e => e.ShutInCosts)
                    .HasColumnName("Shut_In_Costs")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ShutInDays).HasColumnName("Shut_In_Days");

                entity.Property(e => e.ShutInPerAcre)
                    .HasColumnName("Shut_In_Per_Acre")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ShutInProvision).HasColumnName("Shut_In_Provision");

                entity.Property(e => e.ShutInTerm)
                    .HasColumnName("Shut_In_Term")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.SpecialProvisionNotes).HasColumnName("Special_Provision_Notes");

                entity.Property(e => e.StateId).HasColumnName("State_ID");

                entity.Property(e => e.StateId2).HasColumnName("State_ID_2");

                entity.Property(e => e.StatusCode).HasColumnName("Status_Code");

                entity.Property(e => e.SurfaceFeeAmount)
                    .HasColumnName("Surface_Fee_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.SurfaceFeeAmountPerAcre)
                    .HasColumnName("Surface_Fee_Amount_Per_Acre")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.SurfaceOwnership).HasColumnName("Surface_Ownership");

                entity.Property(e => e.SurfaceOwnershipDecimal)
                    .HasColumnName("Surface_OwnershipDecimal")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.SurfacedDeveloped)
                    .HasColumnName("Surfaced_Developed")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.Surrendered).HasColumnType("date");

                entity.Property(e => e.TermMonths).HasColumnName("Term_Months");

                entity.Property(e => e.TermOption).HasColumnName("Term_Option");

                entity.Property(e => e.TopLease).HasColumnName("Top_Lease");

                entity.Property(e => e.TotalAcreage)
                    .HasColumnName("Total_Acreage")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.TotalAmountAdvancedRoyalty)
                    .HasColumnName("TOTAL_AMOUNT_Advanced_Royalty")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalAmountBonusToExtend)
                    .HasColumnName("TOTAL_AMOUNT_Bonus_To_Extend")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalAmountBrokerCosts)
                    .HasColumnName("TOTAL_AMOUNT_Broker_Costs")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalAmountDamages)
                    .HasColumnName("TOTAL_AMOUNT_Damages")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalAmountProductionRoyalty)
                    .HasColumnName("TOTAL_AMOUNT_Production_Royalty")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalAmountShutInCosts)
                    .HasColumnName("TOTAL_AMOUNT_Shut_In_Costs")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalBonusAmount)
                    .HasColumnName("Total_Bonus_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalBonusPaid)
                    .HasColumnName("Total_Bonus_Paid")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalNumberOfPayment).HasColumnName("Total_Number_Of_Payment");

                entity.Property(e => e.TotalRentalAmount)
                    .HasColumnName("Total_Rental_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalSurface)
                    .HasColumnName("Total_Surface")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.TractId).HasColumnName("Tract_ID");

                entity.Property(e => e.TractOwnerPk).HasColumnName("TractOwnerPK");

                entity.Property(e => e.TransferDate)
                    .HasColumnName("Transfer_Date")
                    .HasColumnType("date");

                entity.Property(e => e.Undeveloped)
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.WasTheSeismicPermitExtended).HasColumnName("Was_the_Seismic_Permit_Extended");

                entity.Property(e => e.WellIdNo).HasColumnName("Well_ID_No");

                entity.Property(e => e.WorkingInterest)
                    .HasColumnName("Working_Interest")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");
            });

            modelBuilder.Entity<FilingInformation>(entity =>
            {
                entity.ToTable("Filing_Information");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CotId).HasColumnName("COT_ID");

                entity.Property(e => e.CountyId).HasColumnName("County_ID");

                entity.Property(e => e.FilingDate)
                    .HasColumnName("Filing_Date")
                    .HasColumnType("date");

                entity.Property(e => e.GranteeId).HasColumnName("Grantee_ID");

                entity.Property(e => e.GrantorId).HasColumnName("Grantor_ID");

                entity.Property(e => e.LeaseId).HasColumnName("Lease_ID");

                entity.Property(e => e.QuickNote).HasColumnName("Quick_Note");

                entity.Property(e => e.RecordingDate)
                    .HasColumnName("Recording_Date")
                    .HasColumnType("date");

                entity.Property(e => e.StateId).HasColumnName("State_ID");

                entity.Property(e => e.TractId).HasColumnName("Tract_ID");
            });

            modelBuilder.Entity<FormationMasterMain>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active).HasMaxLength(50);

                entity.Property(e => e.AvgDepth).HasColumnName("Avg_Depth");

                entity.Property(e => e.AvgThickness)
                    .HasColumnName("Avg_Thickness")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BonusPerAcre)
                    .HasColumnName("Bonus_Per_Acre")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BrokerId)
                    .HasColumnName("Broker_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.CountyId)
                    .HasColumnName("County_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.DamagesPerAcre)
                    .HasColumnName("Damages_Per_Acre")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.FormDescription).HasColumnName("Form_Description");

                entity.Property(e => e.FormId)
                    .HasColumnName("Form_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.FormationId)
                    .HasColumnName("Formation_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.FormationType)
                    .HasColumnName("Formation_Type")
                    .HasMaxLength(50);

                entity.Property(e => e.GeologistName).HasColumnName("Geologist_Name");

                entity.Property(e => e.InstrumentCode)
                    .HasColumnName("Instrument_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.LeaseStatus)
                    .HasColumnName("Lease_Status")
                    .HasMaxLength(50);

                entity.Property(e => e.LeaseTermMonths).HasColumnName("Lease_TermMonths");

                entity.Property(e => e.LeaseTermYrs).HasColumnName("Lease_TermYrs");

                entity.Property(e => e.LeaseType)
                    .HasColumnName("Lease_Type")
                    .HasMaxLength(50);

                entity.Property(e => e.LesseeId)
                    .HasColumnName("Lessee_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.MainProduct).HasColumnName("Main_Product");

                entity.Property(e => e.MinimumRoyalty)
                    .HasColumnName("Minimum_Royalty")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.OperatorId)
                    .HasColumnName("Operator_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.PaidUp)
                    .HasColumnName("Paid_Up")
                    .HasMaxLength(50);

                entity.Property(e => e.PughClause).HasColumnName("Pugh_Clause");

                entity.Property(e => e.RentFrequency).HasColumnName("Rent_Frequency");

                entity.Property(e => e.RentPerAcre)
                    .HasColumnName("Rent_Per_Acre")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RoyaltyInterestText)
                    .HasColumnName("Royalty_InterestText")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ShutInPerAcre)
                    .HasColumnName("Shut_In_Per_Acre")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StateId)
                    .HasColumnName("State_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.TopLease).HasColumnName("Top_Lease");

                entity.Property(e => e.TypeOfRock)
                    .HasColumnName("Type_of_Rock")
                    .HasMaxLength(50);

                entity.Property(e => e.VerticalPugh).HasColumnName("Vertical_Pugh");

                entity.Property(e => e.WellId).HasColumnName("Well_ID");
            });

            modelBuilder.Entity<GrantorsGrantees>(entity =>
            {
                entity.ToTable("Grantors_Grantees");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BankAcctNo).HasColumnName("Bank_Acct_No");

                entity.Property(e => e.BankFees)
                    .HasColumnName("Bank_Fees")
                    .HasColumnType("money");

                entity.Property(e => e.BankId).HasColumnName("Bank_ID");

                entity.Property(e => e.Doi)
                    .HasColumnName("DOI")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.DoiText)
                    .HasColumnName("DOI_Text")
                    .HasMaxLength(50);

                entity.Property(e => e.ExcessRoyalty)
                    .HasColumnName("Excess_Royalty")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ExcessRoyaltyText)
                    .HasColumnName("Excess_Royalty_Text")
                    .HasMaxLength(50);

                entity.Property(e => e.GranteeId).HasColumnName("Grantee_ID");

                entity.Property(e => e.GrantorId).HasColumnName("Grantor_ID");

                entity.Property(e => e.GrossAcresMineralsMi)
                    .HasColumnName("Gross_Acres_Minerals_MI")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.GrossAcresMineralsSi)
                    .HasColumnName("Gross_Acres_Minerals_SI")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.MineralInterestMi)
                    .HasColumnName("Mineral_Interest_MI")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.MineralInterestTextMi).HasColumnName("Mineral_Interest_Text_MI");

                entity.Property(e => e.NetAcresMineralsMi)
                    .HasColumnName("Net_Acres_Minerals_MI")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NetAcresSurfaceSi)
                    .HasColumnName("Net_Acres_Surface_SI")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NetProfits)
                    .HasColumnName("Net_Profits")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NetProfitsText).HasColumnName("Net_Profits_Text");

                entity.Property(e => e.Npri)
                    .HasColumnName("NPRI")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NpriText)
                    .HasColumnName("NPRI_Text")
                    .HasMaxLength(50);

                entity.Property(e => e.Orri)
                    .HasColumnName("ORRI")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.OrriText).HasColumnName("ORRI_Text");

                entity.Property(e => e.Other).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.OtherText)
                    .HasColumnName("Other_Text")
                    .HasMaxLength(50);

                entity.Property(e => e.PaymentObligation).HasColumnName("Payment_Obligation");

                entity.Property(e => e.PaymentObligationText).HasColumnName("Payment_Obligation_Text");

                entity.Property(e => e.Royalty).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.RoyaltyInterestText).HasColumnName("Royalty_Interest_Text");

                entity.Property(e => e.Special).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.SpecialText)
                    .HasColumnName("Special_Text")
                    .HasMaxLength(50);

                entity.Property(e => e.Subsidence).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.SubsidenceText)
                    .HasColumnName("Subsidence_Text")
                    .HasMaxLength(50);

                entity.Property(e => e.SurfaceInterestSi)
                    .HasColumnName("Surface_Interest_SI")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.SurfaceInterestTextSi).HasColumnName("Surface_Interest_Text_SI");

                entity.Property(e => e.Wi)
                    .HasColumnName("WI")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.WiText)
                    .HasColumnName("WI_Text")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LeaseAcreageForm>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcreageNotes).HasColumnName("Acreage_Notes");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Developed).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.HbpAcres)
                    .HasColumnName("HBP_Acres")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MineralOwnership).HasColumnName("Mineral_Ownership");

                entity.Property(e => e.MineralOwnershipDecimal)
                    .HasColumnName("Mineral_OwnershipDecimal")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.OtherAcreage)
                    .HasColumnName("Other_Acreage")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OutsideAcreage)
                    .HasColumnName("Outside_Acreage")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SurfaceOwnership).HasColumnName("Surface_Ownership");

                entity.Property(e => e.SurfaceOwnershipDecimal)
                    .HasColumnName("Surface_OwnershipDecimal")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SurfacedDeveloped)
                    .HasColumnName("Surfaced_Developed")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalAcreage)
                    .HasColumnName("Total_Acreage")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalSurface)
                    .HasColumnName("Total_Surface")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TractId).HasColumnName("Tract_ID");

                entity.Property(e => e.TractOwnerPk).HasColumnName("TractOwnerPK");

                entity.Property(e => e.Undeveloped).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<LeaseMainForm2>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcquiredDate)
                    .HasColumnName("Acquired_Date")
                    .HasColumnType("date");

                entity.Property(e => e.AcquisitionAmount)
                    .HasColumnName("Acquisition_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.AcquisitionCode).HasColumnName("Acquisition_Code");

                entity.Property(e => e.AcreageNotes).HasColumnName("Acreage_Notes");

                entity.Property(e => e.AddlBankFees)
                    .HasColumnName("Addl_Bank_Fees")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.AdvanceRoyaltyPerAcre)
                    .HasColumnName("Advance_Royalty_Per_Acre")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.AdvancedRoyalty)
                    .HasColumnName("Advanced_Royalty")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.AlternateLeaseName).HasColumnName("Alternate_Lease_Name");

                entity.Property(e => e.AreaName).HasColumnName("Area_Name");

                entity.Property(e => e.BasinId).HasColumnName("Basin_ID");

                entity.Property(e => e.BonusPerAcre)
                    .HasColumnName("Bonus_Per_Acre")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.BonusPerAcreToExtend)
                    .HasColumnName("Bonus_Per_Acre_to_Extend")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.BonusToExtend)
                    .HasColumnName("Bonus_To_Extend")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.BounsDeferred)
                    .HasColumnName("Bouns_Deferred")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.BrokerCosts)
                    .HasColumnName("Broker_Costs")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.CheckOn)
                    .HasColumnName("Check_On")
                    .HasColumnType("date");

                entity.Property(e => e.ConsiderationAmount)
                    .HasColumnName("Consideration_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.CountyId).HasColumnName("County_ID");

                entity.Property(e => e.CountyId2).HasColumnName("County_ID_2");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Damages)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Developed)
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.DistrictId).HasColumnName("District_ID");

                entity.Property(e => e.Divested).HasColumnType("date");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnName("Effective_Date")
                    .HasColumnType("date");

                entity.Property(e => e.EnityGrossUndev)
                    .HasColumnName("Enity_Gross_Undev")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityExpiredInterest)
                    .HasColumnName("Entity_Expired_Interest")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityGrossAcres)
                    .HasColumnName("Entity_Gross_Acres")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityGrossDeveloped)
                    .HasColumnName("Entity_Gross_Developed")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityGrossHbp)
                    .HasColumnName("Entity_Gross_HBP")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityGrossOther)
                    .HasColumnName("Entity_Gross_Other")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityGrossSurface)
                    .HasColumnName("Entity_Gross_Surface")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityGrossSurfaceDeveloped)
                    .HasColumnName("Entity_Gross_Surface_Developed")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityNetAcres)
                    .HasColumnName("Entity_Net_Acres")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityNetDev)
                    .HasColumnName("Entity_Net_Dev")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityNetHbp)
                    .HasColumnName("Entity_Net_HBP")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityNetSurface)
                    .HasColumnName("Entity_Net_Surface")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityNetSurfaceDeveloped)
                    .HasColumnName("Entity_Net_Surface_Developed")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityNetUndeveloped)
                    .HasColumnName("Entity_Net_Undeveloped")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityNotes).HasColumnName("Entity_Notes");

                entity.Property(e => e.EntityNriGas)
                    .HasColumnName("Entity_NRI_Gas")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityNriOil)
                    .HasColumnName("Entity_NRI_Oil")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityNriOther)
                    .HasColumnName("Entity_NRI_Other")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityOpRights)
                    .HasColumnName("Entity_Op_Rights")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityOrriGas)
                    .HasColumnName("Entity_ORRI_Gas")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityOrriOil)
                    .HasColumnName("Entity_ORRI_Oil")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityOrriOther)
                    .HasColumnName("Entity_ORRI_Other")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityOtherGas)
                    .HasColumnName("Entity_Other_Gas")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityOtherOil)
                    .HasColumnName("Entity_Other_Oil")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityOtherOther)
                    .HasColumnName("Entity_Other_Other")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityRoyaltyGas)
                    .HasColumnName("Entity_Royalty_Gas")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityRoyaltyOil)
                    .HasColumnName("Entity_Royalty_Oil")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityRoyaltyOther)
                    .HasColumnName("Entity_Royalty_Other")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityShareAcquisitionAmount)
                    .HasColumnName("Entity_Share_Acquisition_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareAdvancedRoyalty)
                    .HasColumnName("ENTITY_SHARE_Advanced_Royalty")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareBonusToExtend)
                    .HasColumnName("ENTITY_SHARE_Bonus_To_Extend")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareBrokerCosts)
                    .HasColumnName("ENTITY_SHARE_Broker_Costs")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareDamages)
                    .HasColumnName("ENTITY_SHARE_Damages")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareOfBonus)
                    .HasColumnName("Entity_Share_Of_Bonus")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareOfRentals)
                    .HasColumnName("Entity_Share_Of_Rentals")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareProductionRoyalty)
                    .HasColumnName("ENTITY_SHARE_Production_Royalty")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareProductionRoyaltyAmount)
                    .HasColumnName("Entity_Share_Production_Royalty_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareRentalAmount)
                    .HasColumnName("Entity_Share_Rental_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareShutInAmount)
                    .HasColumnName("Entity_Share_Shut_In_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareShutInCosts)
                    .HasColumnName("ENTITY_SHARE_Shut_In_Costs")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareSurfaceFeeAmount)
                    .HasColumnName("Entity_Share_Surface_Fee_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ExpenseInterest)
                    .HasColumnName("Expense_Interest")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.ExpirationDate)
                    .HasColumnName("Expiration_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ExpireDate)
                    .HasColumnName("Expire_Date")
                    .HasColumnType("date");

                entity.Property(e => e.FedStateLeaseNo).HasColumnName("FedState_Lease_No");

                entity.Property(e => e.FederalLeaseFlag).HasColumnName("Federal_Lease_Flag");

                entity.Property(e => e.FieldBroker).HasColumnName("Field_Broker");

                entity.Property(e => e.FrequencyInMonths).HasColumnName("Frequency_In_Months");

                entity.Property(e => e.GrossAcres)
                    .HasColumnName("Gross_Acres")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.HbpAcres)
                    .HasColumnName("HBP_Acres")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.HbpFlag).HasColumnName("HBP_Flag");

                entity.Property(e => e.IncludeInTotalGrossAcres)
                    .HasColumnName("Include_in_Total_Gross_Acres")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.InputDate)
                    .HasColumnName("Input_Date")
                    .HasColumnType("date");

                entity.Property(e => e.InstrumentCode).HasColumnName("Instrument_Code");

                entity.Property(e => e.InstrumentFlag).HasColumnName("Instrument_Flag");

                entity.Property(e => e.LandType).HasColumnName("Land_Type");

                entity.Property(e => e.LeaseDate)
                    .HasColumnName("Lease_Date")
                    .HasColumnType("date");

                entity.Property(e => e.LeaseForm).HasColumnName("Lease_Form");

                entity.Property(e => e.LeaseId).HasColumnName("Lease_ID");

                entity.Property(e => e.LeaseName).HasColumnName("Lease_Name");

                entity.Property(e => e.LeaseStatus).HasColumnName("Lease_Status");

                entity.Property(e => e.LeaseType).HasColumnName("Lease_Type");

                entity.Property(e => e.LeaseholdInterest)
                    .HasColumnName("Leasehold_Interest")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.LegalDescription).HasColumnName("Legal_Description");

                entity.Property(e => e.LesseeId).HasColumnName("Lessee_ID");

                entity.Property(e => e.LessorId).HasColumnName("Lessor_ID");

                entity.Property(e => e.MaximumShutInDays).HasColumnName("Maximum_Shut_In_Days");

                entity.Property(e => e.MinRoyDue)
                    .HasColumnName("Min_Roy_Due")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.MineralOwnership).HasColumnName("Mineral_Ownership");

                entity.Property(e => e.MineralOwnershipDecimal)
                    .HasColumnName("Mineral_OwnershipDecimal")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.MmsLeaseNo).HasColumnName("MMS_Lease_No");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.NetAcres)
                    .HasColumnName("Net_Acres")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.NetDev)
                    .HasColumnName("Net_Dev")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.NetHbp)
                    .HasColumnName("Net_HBP")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.NetOther)
                    .HasColumnName("Net_Other")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.NetOtherEntity)
                    .HasColumnName("Net_Other_Entity")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.NetOutside)
                    .HasColumnName("Net_Outside")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.NetSurface)
                    .HasColumnName("Net_Surface")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.NetSurfaceDeveloped)
                    .HasColumnName("Net_Surface_Developed")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.NetUndeveloped)
                    .HasColumnName("Net_Undeveloped")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.NextRentalDue)
                    .HasColumnName("Next_Rental_Due")
                    .HasColumnType("date");

                entity.Property(e => e.NotesOnAcreage).HasColumnName("Notes_on_Acreage");

                entity.Property(e => e.Nri)
                    .HasColumnName("NRI")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.ORRI)
                    .HasColumnName("O_R_R_I")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.OkToPay).HasColumnName("OK_to_Pay");

                entity.Property(e => e.OperatingRights)
                    .HasColumnName("Operating_Rights")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.OperatorLeaseNo).HasColumnName("Operator_Lease_No");

                entity.Property(e => e.OptAmountPerAcre)
                    .HasColumnName("Opt_Amount_Per_Acre")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.OptExpireDate)
                    .HasColumnName("Opt_Expire_Date")
                    .HasColumnType("date");

                entity.Property(e => e.OptExpireDays).HasColumnName("Opt_Expire_Days");

                entity.Property(e => e.OptExtAmntPerAcre)
                    .HasColumnName("Opt_Ext_Amnt_Per_Acre")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.OptPeriod).HasColumnName("Opt_Period");

                entity.Property(e => e.OptPrepaidAmountPerAcre)
                    .HasColumnName("Opt_Prepaid_Amount_Per_Acre")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.OptToExtend).HasColumnName("Opt_To_Extend");

                entity.Property(e => e.OptToExtendDays).HasColumnName("Opt_To_Extend_Days");

                entity.Property(e => e.OptionConvBonusPerAcre)
                    .HasColumnName("Option_Conv_Bonus_Per_Acre")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.OriginalLeaseNo).HasColumnName("Original_Lease_No");

                entity.Property(e => e.Orri1)
                    .HasColumnName("ORRI")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.OrriMemo).HasColumnName("ORRI_Memo");

                entity.Property(e => e.Other)
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.OtherAcreage)
                    .HasColumnName("Other_Acreage")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.OtherDate)
                    .HasColumnName("Other_Date")
                    .HasColumnType("date");

                entity.Property(e => e.OtherLeaseBurdens)
                    .HasColumnName("Other_Lease_Burdens")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.OutsideAcreage)
                    .HasColumnName("Outside_Acreage")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.OwnerId).HasColumnName("Owner_ID");

                entity.Property(e => e.PaidUp).HasColumnName("Paid_Up");

                entity.Property(e => e.PayoutCode).HasColumnName("Payout_Code");

                entity.Property(e => e.PoolingType).HasColumnName("Pooling_Type");

                entity.Property(e => e.PrimaryTerm).HasColumnName("Primary_Term");

                entity.Property(e => e.ProductionRoyalty)
                    .HasColumnName("Production_Royalty")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ProductionRoyaltyPerAcre)
                    .HasColumnName("Production_Royalty_Per_Acre")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ProjectGroupName).HasColumnName("Project_Group_Name");

                entity.Property(e => e.ProspectId).HasColumnName("Prospect_ID");

                entity.Property(e => e.PughHorizon).HasColumnName("Pugh_Horizon");

                entity.Property(e => e.PughHorizonExpDate)
                    .HasColumnName("Pugh_Horizon_Exp_Date")
                    .HasColumnType("date");

                entity.Property(e => e.PughVert).HasColumnName("Pugh_Vert");

                entity.Property(e => e.PughVertExpDate)
                    .HasColumnName("Pugh_Vert_Exp_Date")
                    .HasColumnType("date");

                entity.Property(e => e.RecordTitle)
                    .HasColumnName("Record_Title")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.RecordingInformation).HasColumnName("Recording_Information");

                entity.Property(e => e.RegionId).HasColumnName("Region_ID");

                entity.Property(e => e.RenewalLease).HasColumnName("Renewal_Lease");

                entity.Property(e => e.RentalDueDate)
                    .HasColumnName("Rental_Due_Date")
                    .HasColumnType("date");

                entity.Property(e => e.RentalPerAcre)
                    .HasColumnName("Rental_Per_ACre")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ResponsibleParty).HasColumnName("Responsible_Party");

                entity.Property(e => e.Royalty)
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.RoyaltyIntMemo).HasColumnName("Royalty_Int_Memo");

                entity.Property(e => e.RoyaltyInterest)
                    .HasColumnName("Royalty_Interest")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.Search1).HasColumnName("Search_1");

                entity.Property(e => e.Search2).HasColumnName("Search_2");

                entity.Property(e => e.Search3).HasColumnName("Search_3");

                entity.Property(e => e.Search4).HasColumnName("Search_4");

                entity.Property(e => e.Search5).HasColumnName("Search_5");

                entity.Property(e => e.Search6).HasColumnName("Search_6");

                entity.Property(e => e.SecondExpDate)
                    .HasColumnName("Second_Exp_Date")
                    .HasColumnType("date");

                entity.Property(e => e.SecondExpirationDate)
                    .HasColumnName("Second_Expiration_Date")
                    .HasColumnType("date");

                entity.Property(e => e.SeismicOptionNotes).HasColumnName("Seismic_Option_Notes");

                entity.Property(e => e.SeismicPermitExpirationDate)
                    .HasColumnName("Seismic_Permit_Expiration_Date")
                    .HasColumnType("date");

                entity.Property(e => e.SeismicPermitExpirationDays).HasColumnName("Seismic_Permit_Expiration_Days");

                entity.Property(e => e.SeismicPermitExtensionDays).HasColumnName("Seismic_Permit_Extension_Days");

                entity.Property(e => e.ShutInAmount)
                    .HasColumnName("Shut_In_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ShutInClause).HasColumnName("Shut_In_Clause");

                entity.Property(e => e.ShutInCosts)
                    .HasColumnName("Shut_In_Costs")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ShutInDays).HasColumnName("Shut_In_Days");

                entity.Property(e => e.ShutInPerAcre)
                    .HasColumnName("Shut_In_Per_Acre")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ShutInProvision).HasColumnName("Shut_In_Provision");

                entity.Property(e => e.ShutInTerm)
                    .HasColumnName("Shut_In_Term")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.SpecialProvisionNotes).HasColumnName("Special_Provision_Notes");

                entity.Property(e => e.StateId).HasColumnName("State_ID");

                entity.Property(e => e.StateId2).HasColumnName("State_ID_2");

                entity.Property(e => e.StatusCode).HasColumnName("Status_Code");

                entity.Property(e => e.SurfaceFeeAmount)
                    .HasColumnName("Surface_Fee_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.SurfaceFeeAmountPerAcre)
                    .HasColumnName("Surface_Fee_Amount_Per_Acre")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.SurfaceOwnership).HasColumnName("Surface_Ownership");

                entity.Property(e => e.SurfaceOwnershipDecimal)
                    .HasColumnName("Surface_OwnershipDecimal")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.SurfacedDeveloped)
                    .HasColumnName("Surfaced_Developed")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.Surrendered).HasColumnType("date");

                entity.Property(e => e.TermMonths).HasColumnName("Term_Months");

                entity.Property(e => e.TermOption).HasColumnName("Term_Option");

                entity.Property(e => e.TopLease).HasColumnName("Top_Lease");

                entity.Property(e => e.TotalAcreage)
                    .HasColumnName("Total_Acreage")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.TotalAmountAdvancedRoyalty)
                    .HasColumnName("TOTAL_AMOUNT_Advanced_Royalty")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalAmountBonusToExtend)
                    .HasColumnName("TOTAL_AMOUNT_Bonus_To_Extend")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalAmountBrokerCosts)
                    .HasColumnName("TOTAL_AMOUNT_Broker_Costs")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalAmountDamages)
                    .HasColumnName("TOTAL_AMOUNT_Damages")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalAmountProductionRoyalty)
                    .HasColumnName("TOTAL_AMOUNT_Production_Royalty")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalAmountShutInCosts)
                    .HasColumnName("TOTAL_AMOUNT_Shut_In_Costs")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalBonusAmount)
                    .HasColumnName("Total_Bonus_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalBonusPaid)
                    .HasColumnName("Total_Bonus_Paid")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalNumberOfPayment).HasColumnName("Total_Number_Of_Payment");

                entity.Property(e => e.TotalRentalAmount)
                    .HasColumnName("Total_Rental_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalSurface)
                    .HasColumnName("Total_Surface")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.TractId).HasColumnName("Tract_ID");

                entity.Property(e => e.TractOwnerPk).HasColumnName("TractOwnerPK");

                entity.Property(e => e.TransferDate)
                    .HasColumnName("Transfer_Date")
                    .HasColumnType("date");

                entity.Property(e => e.Undeveloped)
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.WasTheSeismicPermitExtended).HasColumnName("Was_the_Seismic_Permit_Extended");

                entity.Property(e => e.WellIdNo).HasColumnName("Well_ID_No");

                entity.Property(e => e.WorkingInterest)
                    .HasColumnName("Working_Interest")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");
            });

            modelBuilder.Entity<LeaseSeismicForm>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcreConvBonus).HasColumnName("Acre_ConvBonus");

                entity.Property(e => e.AcreExtension).HasColumnName("Acre_Extension");

                entity.Property(e => e.AcreOption).HasColumnName("Acre_Option");

                entity.Property(e => e.AcrePrepaid).HasColumnName("Acre_Prepaid");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.OptionExpireDate).HasColumnName("Option_Expire_Date");

                entity.Property(e => e.OptionPeriod).HasColumnName("Option_Period");

                entity.Property(e => e.SeismicOptionExpirationDays).HasColumnName("Seismic_Option_Expiration_Days");

                entity.Property(e => e.SeismicOptionExtensionDays).HasColumnName("Seismic_Option_Extension_Days");

                entity.Property(e => e.SeismicOptionNotes).HasColumnName("Seismic_Option_Notes");

                entity.Property(e => e.SeismicPermitExpirationDate).HasColumnName("Seismic_Permit_Expiration_Date");

                entity.Property(e => e.SeismicPermitExpirationDays).HasColumnName("Seismic_Permit_Expiration_Days");

                entity.Property(e => e.SeismicPermitExtensionDays).HasColumnName("Seismic_Permit_Extension_Days");

                entity.Property(e => e.TractId).HasColumnName("Tract_ID");

                entity.Property(e => e.TractOwnerPk).HasColumnName("TractOwnerPK");

                entity.Property(e => e.WasTheSeismicPermitExtended).HasColumnName("Was_the_Seismic_Permit_Extended");
            });

            modelBuilder.Entity<NewPayment>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BankAccountNo)
                    .IsRequired()
                    .HasColumnName("Bank_Account_No");

                entity.Property(e => e.BankFees)
                    .IsRequired()
                    .HasColumnName("Bank_Fees");

                entity.Property(e => e.BankId)
                    .IsRequired()
                    .HasColumnName("Bank_ID");

                entity.Property(e => e.DueDate).HasColumnName("Due_Date");

                entity.Property(e => e.IncludeNotesOnDeck).HasColumnName("Include_Notes_On_Deck");

                entity.Property(e => e.LegalDescription)
                    .IsRequired()
                    .HasColumnName("Legal_Description");

                entity.Property(e => e.NetAmountDue)
                    .IsRequired()
                    .HasColumnName("Net_Amount_Due");

                entity.Property(e => e.PayLessorDirect).HasColumnName("Pay_Lessor_Direct");

                entity.Property(e => e.PayeeId)
                    .IsRequired()
                    .HasColumnName("Payee_ID");

                entity.Property(e => e.PaymentType)
                    .IsRequired()
                    .HasColumnName("Payment_Type");

                entity.Property(e => e.PropertyId)
                    .IsRequired()
                    .HasColumnName("Property_ID");

                entity.Property(e => e.PropertyType)
                    .IsRequired()
                    .HasColumnName("Property_Type");

                entity.Property(e => e.ResponsiblePartyId)
                    .IsRequired()
                    .HasColumnName("Responsible_Party_ID");

                entity.Property(e => e.SubTractId)
                    .IsRequired()
                    .HasColumnName("SubTract_ID");

                entity.Property(e => e.SuspenseCode)
                    .IsRequired()
                    .HasColumnName("Suspense_Code");

                entity.Property(e => e.TractId)
                    .IsRequired()
                    .HasColumnName("Tract_ID");
            });

            modelBuilder.Entity<Npri>(entity =>
            {
                entity.ToTable("NPRI");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EasementId).HasColumnName("Easement_ID");

                entity.Property(e => e.FullInterest).HasColumnName("Full_Interest");

                entity.Property(e => e.Interest).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.LeaseId).HasColumnName("Lease_ID");

                entity.Property(e => e.NpriFormula).HasColumnName("NPRI_Formula");

                entity.Property(e => e.NpriOwnerId).HasColumnName("NPRI_Owner_ID");

                entity.Property(e => e.OwnerId).HasColumnName("Owner_ID");

                entity.Property(e => e.PrId).HasColumnName("PR_ID");

                entity.Property(e => e.RowId).HasColumnName("ROW_ID");

                entity.Property(e => e.SuaId).HasColumnName("SUA_ID");

                entity.Property(e => e.SuspenseCode).HasColumnName("Suspense_Code");

                entity.Property(e => e.TractId).HasColumnName("Tract_ID");

                entity.Property(e => e.WellId).HasColumnName("Well_ID");
            });

            modelBuilder.Entity<Nri>(entity =>
            {
                entity.ToTable("NRI");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LeaseId).HasColumnName("Lease_ID");

                entity.Property(e => e.LeaseWorking).HasColumnName("Lease_Working");

                entity.Property(e => e.Nri1)
                    .HasColumnName("NRI")
                    .HasColumnType("money");

                entity.Property(e => e.OwnerId).HasColumnName("Owner_ID");

                entity.Property(e => e.SubTractId).HasColumnName("SubTract_ID");

                entity.Property(e => e.TractId).HasColumnName("Tract_ID");

                entity.Property(e => e.WellId).HasColumnName("Well_ID");

                entity.Property(e => e.WorkingInterest)
                    .HasColumnName("Working_Interest")
                    .HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<OwnerAddressesMain>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountingDeptIdNo).HasColumnName("Accounting_Dept_ID_No");

                entity.Property(e => e.AddressType).HasColumnName("Address_Type");

                entity.Property(e => e.BankAccountNo).HasColumnName("Bank_Account_No");

                entity.Property(e => e.Business2).HasColumnName("Business_2");

                entity.Property(e => e.ContactName).HasColumnName("Contact_Name");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.DefaultBankId).HasColumnName("Default_Bank_ID");

                entity.Property(e => e.ExpenseExempt).HasColumnName("Expense_Exempt");

                entity.Property(e => e.FedTaxWithhold).HasColumnName("Fed_Tax_Withhold");

                entity.Property(e => e.FedTaxWithholding)
                    .HasColumnName("Fed_Tax_Withholding")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FileAs).HasColumnName("File_As");

                entity.Property(e => e.FullName).HasColumnName("Full_Name");

                entity.Property(e => e.GeneralClass).HasColumnName("General_Class");

                entity.Property(e => e.InHouseOwner).HasColumnName("In_House_Owner");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.NextContactDate).HasColumnName("Next_Contact_Date");

                entity.Property(e => e.NoPayCode).HasColumnName("No_Pay_Code");

                entity.Property(e => e.NonEmployeeComp)
                    .HasColumnName("Non_Employee_Comp")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OriginalIdNo).HasColumnName("Original_ID_No");

                entity.Property(e => e.OtherExempt).HasColumnName("Other_Exempt");

                entity.Property(e => e.OwnerId).HasColumnName("Owner_ID");

                entity.Property(e => e.Rentals).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Royalties).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Send1099).HasColumnName("Send_1099");

                entity.Property(e => e.SevTaxExempt).HasColumnName("Sev_Tax_Exempt");

                entity.Property(e => e.SpouseSsn).HasColumnName("Spouse_SSN");

                entity.Property(e => e.SuspenseCode).HasColumnName("Suspense_Code");

                entity.Property(e => e.TaxId).HasColumnName("Tax_ID");

                entity.Property(e => e.TaxIdType).HasColumnName("Tax_ID_Type");

                entity.Property(e => e.TenureCode).HasColumnName("Tenure_Code");

                entity.Property(e => e.TractId).HasColumnName("Tract_ID");

                entity.Property(e => e.TractOwnerPk).HasColumnName("TractOwnerPK");

                entity.Property(e => e.WebPage).HasColumnName("Web_Page");
            });

            modelBuilder.Entity<OwnerConnection>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EasementId).HasColumnName("Easement_ID");

                entity.Property(e => e.OwnerId).HasColumnName("Owner_ID");

                entity.Property(e => e.RowId).HasColumnName("ROW_ID");

                entity.Property(e => e.SuaId).HasColumnName("SUA_ID");
            });

            modelBuilder.Entity<OwnerDetails>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FullName).HasColumnName("Full_Name");

                entity.Property(e => e.OwnerId).HasColumnName("Owner_ID");
            });

            modelBuilder.Entity<OwnersContactInfo>(entity =>
            {
                entity.ToTable("Owners_ContactInfo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.AddressType)
                    .IsRequired()
                    .HasColumnName("Address_Type")
                    .HasMaxLength(450);

                entity.Property(e => e.Business)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.Home)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.OwnerId)
                    .IsRequired()
                    .HasColumnName("Owner_ID")
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<PaymentObligations>(entity =>
            {
                entity.ToTable("Payment_Obligations");

                entity.Property(e => e.AdditionalBankFees).HasColumnName("Additional_Bank_Fees");

                entity.Property(e => e.BankAccountNo)
                    .HasColumnName("Bank_Account_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.BankId).HasColumnName("Bank_ID");

                entity.Property(e => e.BeginningDueDate)
                    .HasColumnName("Beginning_Due_Date")
                    .HasColumnType("date");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.EasementId).HasColumnName("Easement_ID");

                entity.Property(e => e.EndingDate)
                    .HasColumnName("Ending_Date")
                    .HasColumnType("date");

                entity.Property(e => e.IncludeNotesOnCheck).HasColumnName("Include_Notes_on_Check");

                entity.Property(e => e.LeaseId).HasColumnName("Lease_ID");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.ModifiedDate).HasColumnName("Modified_Date");

                entity.Property(e => e.NetAmount)
                    .HasColumnName("Net_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.OkToPay).HasColumnName("Ok_To_Pay");

                entity.Property(e => e.OwnerId).HasColumnName("Owner_ID");

                entity.Property(e => e.PayRegardlessOfLeaseStateOfPayment).HasColumnName("Pay_Regardless_of_Lease_State_of_Payment");

                entity.Property(e => e.PayeeId).HasColumnName("Payee_ID");

                entity.Property(e => e.PaymentType).HasColumnName("Payment_Type");

                entity.Property(e => e.PeriodFrequency).HasColumnName("Period_Frequency");

                entity.Property(e => e.Ppi).HasColumnName("PPI");

                entity.Property(e => e.Recommendation).HasMaxLength(50);

                entity.Property(e => e.RecoupablePayment).HasColumnName("Recoupable_Payment");

                entity.Property(e => e.RecurringPayment).HasColumnName("Recurring_Payment");

                entity.Property(e => e.ResponsibleParty).HasColumnName("Responsible_Party");

                entity.Property(e => e.RowId).HasColumnName("ROW_ID");

                entity.Property(e => e.SuaId).HasColumnName("SUA_ID");

                entity.Property(e => e.SubTractId).HasColumnName("SubTract_ID");

                entity.Property(e => e.SuspenseCode).HasColumnName("Suspense_Code");

                entity.Property(e => e.TractId).HasColumnName("Tract_ID");

                entity.Property(e => e.WellId).HasColumnName("Well_ID");
            });

            modelBuilder.Entity<PostalMainForm>(entity =>
            {
                entity.HasKey(e => e.PostalId);

                entity.Property(e => e.PostalId).HasColumnName("Postal_ID");

                entity.Property(e => e.PostalArea).HasColumnName("Postal_Area");

                entity.Property(e => e.PostalCode).HasColumnName("Postal_Code");
            });

            modelBuilder.Entity<PropertyMainForm>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcctIdNo).HasColumnName("Acct_ID_No");

                entity.Property(e => e.AcctIdNo2).HasColumnName("Acct_ID_No2");

                entity.Property(e => e.Acquired).HasColumnType("date");

                entity.Property(e => e.AgentAddress).HasColumnName("Agent_Address");

                entity.Property(e => e.AgentName).HasColumnName("Agent_Name");

                entity.Property(e => e.AgentPhone).HasColumnName("Agent_Phone");

                entity.Property(e => e.ApprDistributonYear)
                    .HasColumnName("Appr_Distributon_Year")
                    .HasColumnType("date");

                entity.Property(e => e.ApprDistrictId).HasColumnName("Appr_District_ID");

                entity.Property(e => e.AreaName).HasColumnName("Area_Name");

                entity.Property(e => e.AverageAge).HasColumnName("Average_Age");

                entity.Property(e => e.AverageGirth).HasColumnName("Average_Girth");

                entity.Property(e => e.AverageHeight).HasColumnName("Average_Height");

                entity.Property(e => e.BeginDate)
                    .HasColumnName("Begin_Date")
                    .HasColumnType("date");

                entity.Property(e => e.CarrierId).HasColumnName("Carrier_ID");

                entity.Property(e => e.CattleOk).HasColumnName("Cattle_OK");

                entity.Property(e => e.CountyId).HasColumnName("County_ID");

                entity.Property(e => e.Current).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeedAcres)
                    .HasColumnName("Deed_Acres")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.Divested).HasColumnType("date");

                entity.Property(e => e.ElectricityOn).HasColumnName("Electricity_On");

                entity.Property(e => e.EndDate)
                    .HasColumnName("End_Date")
                    .HasColumnType("date");

                entity.Property(e => e.EstimatedNumberOfTrees).HasColumnName("Estimated_Number_Of_Trees");

                entity.Property(e => e.EstimatedTimberValue)
                    .HasColumnName("Estimated_Timber_Value")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ExpirationDate)
                    .HasColumnName("Expiration_Date")
                    .HasColumnType("date");

                entity.Property(e => e.Field1).HasColumnName("Field_1");

                entity.Property(e => e.Field2).HasColumnName("Field_2");

                entity.Property(e => e.Field3).HasColumnName("Field_3");

                entity.Property(e => e.Field4).HasColumnName("Field_4");

                entity.Property(e => e.FieldName).HasColumnName("Field_Name");

                entity.Property(e => e.ForSale).HasColumnName("For_Sale");

                entity.Property(e => e.GasOn).HasColumnName("Gas_On");

                entity.Property(e => e.GranteeId).HasColumnName("Grantee_ID");

                entity.Property(e => e.GrantorId).HasColumnName("Grantor_ID");

                entity.Property(e => e.GrossAcresOrriAcres)
                    .HasColumnName("Gross_Acres_ORRI_Acres")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.GrossAcresOtherAcres)
                    .HasColumnName("Gross_Acres_Other_Acres")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.GrossAcresRoyaltyAcres)
                    .HasColumnName("Gross_Acres_Royalty_Acres")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.GrossAcresSubsidenceAcres)
                    .HasColumnName("Gross_Acres_Subsidence_Acres")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.GrossAcresSurfaceAcres)
                    .HasColumnName("Gross_Acres_Surface_Acres")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.GrossAcresTotalMineralAcres)
                    .HasColumnName("Gross_Acres_Total_Mineral_Acres")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.HuntingNotes).HasColumnName("Hunting_Notes");

                entity.Property(e => e.HuntingRate).HasColumnName("Hunting_Rate");

                entity.Property(e => e.HuntingUnit).HasColumnName("Hunting_Unit");

                entity.Property(e => e.ImprovementValue)
                    .HasColumnName("Improvement_Value")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InsuranceCost)
                    .HasColumnName("Insurance_Cost")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InsuranceDescription).HasColumnName("Insurance_Description");

                entity.Property(e => e.InsuranceNotes).HasColumnName("Insurance_Notes");

                entity.Property(e => e.InsuranceType).HasColumnName("Insurance_Type");

                entity.Property(e => e.Interest).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.InterestType).HasColumnName("Interest_Type");

                entity.Property(e => e.IsDamaged).HasColumnName("Is_Damaged");

                entity.Property(e => e.IsUnsecured).HasColumnName("Is_Unsecured");

                entity.Property(e => e.IsVacant).HasColumnName("Is_Vacant");

                entity.Property(e => e.LandValue)
                    .HasColumnName("Land_Value")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LastCutBy).HasColumnName("Last_Cut_By");

                entity.Property(e => e.LastCutDate)
                    .HasColumnName("Last_Cut_Date")
                    .HasColumnType("date");

                entity.Property(e => e.LeaseRoyaltyAcres)
                    .HasColumnName("Lease_Royalty_Acres")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.LeasedMineralAcres)
                    .HasColumnName("Leased_Mineral_Acres")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.LeasedOrriAcres)
                    .HasColumnName("Leased_ORRI_Acres")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.LeasedOtherAcres)
                    .HasColumnName("Leased_Other_Acres")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.LegalDescription).HasColumnName("Legal_Description");

                entity.Property(e => e.LoanNumber).HasColumnName("Loan_Number");

                entity.Property(e => e.MaxUnits).HasColumnName("Max_Units");

                entity.Property(e => e.MineralInterest)
                    .HasColumnName("Mineral_Interest")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.MortgageCompanyId).HasColumnName("Mortgage_Company_ID");

                entity.Property(e => e.NetAcresOrriAcres)
                    .HasColumnName("Net_Acres_ORRI_Acres")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NetAcresOtherAcres)
                    .HasColumnName("Net_Acres_Other_Acres")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NetAcresRoyaltyAcres)
                    .HasColumnName("Net_Acres_Royalty_Acres")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NetAcresSubsidenceAcres)
                    .HasColumnName("Net_Acres_Subsidence_Acres")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NetAcresSurfaceAcres)
                    .HasColumnName("Net_Acres_Surface_Acres")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NetAcresTotalMineralAcres)
                    .HasColumnName("Net_Acres_Total_Mineral_Acres")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NetLeaseRoyaltyAcres)
                    .HasColumnName("Net_Lease_Royalty_Acres")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NetLeasedMineralAcres)
                    .HasColumnName("Net_Leased_Mineral_Acres")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NetLeasedOrriAcres)
                    .HasColumnName("Net_Leased_ORRI_Acres")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NetLeasedOtherAcres)
                    .HasColumnName("Net_Leased_Other_Acres")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NetOrriAcresProducing)
                    .HasColumnName("Net_ORRI_Acres_Producing")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NetOtherAcresProducing)
                    .HasColumnName("Net_Other_Acres_Producing")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NetProducingMineralAcres)
                    .HasColumnName("Net_Producing_Mineral_Acres")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NetProducingRoyaltyAcres)
                    .HasColumnName("Net_Producing_Royalty_Acres")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NetRevenueInterest)
                    .HasColumnName("Net_Revenue_Interest")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NextCutBy).HasColumnName("Next_Cut_By");

                entity.Property(e => e.NextCutDate)
                    .HasColumnName("Next_Cut_Date")
                    .HasColumnType("date");

                entity.Property(e => e.Original).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OrriAcresProducing)
                    .HasColumnName("ORRI_Acres_Producing")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.OrriInterest)
                    .HasColumnName("ORRI_Interest")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.OtherAcresProducing)
                    .HasColumnName("Other_Acres_Producing")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.OtherInterest1)
                    .HasColumnName("Other_Interest_1")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.OtherInterest2)
                    .HasColumnName("Other_Interest_2")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.OtherInterest3)
                    .HasColumnName("Other_Interest_3")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.OtherInterest4)
                    .HasColumnName("Other_Interest_4")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ProducingMineralAcres)
                    .HasColumnName("Producing_Mineral_Acres")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ProducingRoyaltyAcres)
                    .HasColumnName("Producing_Royalty_Acres")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.PropertyType).HasColumnName("Property_Type");

                entity.Property(e => e.ProspectId).HasColumnName("Prospect_ID");

                entity.Property(e => e.RecordingInformation).HasColumnName("Recording_Information");

                entity.Property(e => e.RegionId).HasColumnName("Region_ID");

                entity.Property(e => e.RoyaltyInterest)
                    .HasColumnName("Royalty_Interest")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.SoldTo).HasColumnName("Sold_To");

                entity.Property(e => e.SpecialProvisionsNotes).HasColumnName("Special_Provisions_Notes");

                entity.Property(e => e.StateId).HasColumnName("State_ID");

                entity.Property(e => e.SubsidenceInterest)
                    .HasColumnName("Subsidence_Interest")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.SurfaceInterest)
                    .HasColumnName("Surface_Interest")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.SurfaceOwnershipType).HasColumnName("Surface_Ownership_Type");

                entity.Property(e => e.SurveyTwnRng).HasColumnName("Survey_Twn_Rng");

                entity.Property(e => e.TaxAmount1)
                    .HasColumnName("Tax_Amount_1")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TaxAmount2)
                    .HasColumnName("Tax_Amount_2")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TaxAmount3)
                    .HasColumnName("Tax_Amount_3")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TaxAmount4)
                    .HasColumnName("Tax_Amount_4")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TaxRemarks).HasColumnName("Tax_Remarks");

                entity.Property(e => e.TaxYear).HasColumnName("Tax_Year");

                entity.Property(e => e.TimberRemarks).HasColumnName("Timber_Remarks");

                entity.Property(e => e.WaterOn).HasColumnName("Water_On");

                entity.Property(e => e.Zip).HasColumnName("ZIP");
            });

            modelBuilder.Entity<PropertyTractConnection>(entity =>
            {
                entity.ToTable("Property_TractConnection");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.PropertyType).HasColumnName("Property_Type");

                entity.Property(e => e.TractId).HasColumnName("Tract_ID");
            });

            modelBuilder.Entity<ProspectMainForm>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BonusPerAcre)
                    .HasColumnName("Bonus_Per_Acre")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BrokerFees)
                    .HasColumnName("Broker_Fees")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BrokerFeesPerAcre)
                    .HasColumnName("Broker_Fees_Per_Acre")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CountyId).HasColumnName("County_ID");

                entity.Property(e => e.CountyId2).HasColumnName("County_ID_2");

                entity.Property(e => e.DistrictId).HasColumnName("District_ID");

                entity.Property(e => e.Field1).HasColumnName("Field_1");

                entity.Property(e => e.Field2).HasColumnName("Field_2");

                entity.Property(e => e.Field3).HasColumnName("Field_3");

                entity.Property(e => e.Field4).HasColumnName("Field_4");

                entity.Property(e => e.GrossAcres)
                    .HasColumnName("Gross_Acres")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.LandmanId).HasColumnName("Landman_ID");

                entity.Property(e => e.LeasedByOthers)
                    .HasColumnName("Leased_by_Others")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LeasedByUs)
                    .HasColumnName("Leased_by_Us")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LesseeId).HasColumnName("Lessee_ID");

                entity.Property(e => e.NetAcres)
                    .HasColumnName("Net_Acres")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.OperatorId).HasColumnName("Operator_ID");

                entity.Property(e => e.OtherCosts)
                    .HasColumnName("Other_Costs")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProspectId).HasColumnName("Prospect_ID");

                entity.Property(e => e.RegionId).HasColumnName("Region_ID");

                entity.Property(e => e.SpecialProvisionsNotes).HasColumnName("Special_Provisions_Notes");

                entity.Property(e => e.StateId).HasColumnName("State_ID");

                entity.Property(e => e.StateId2).HasColumnName("State_ID_2");

                entity.Property(e => e.TotalBonus)
                    .HasColumnName("Total_Bonus")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnleasedAndOpen)
                    .HasColumnName("Unleased_and_Open")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<RecordingInformation>(entity =>
            {
                entity.ToTable("Recording_Information");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateOptionToExtendBonuses).HasColumnName("Create_Option_To_Extend_Bonuses");

                entity.Property(e => e.CreatePaymentHistory).HasColumnName("Create_Payment_History");

                entity.Property(e => e.CreateRevenueReceipts).HasColumnName("Create_Revenue_Receipts");

                entity.Property(e => e.FileDate)
                    .HasColumnName("File_Date")
                    .HasColumnType("date");

                entity.Property(e => e.IncludeTractIdsWithLegalDescription).HasColumnName("Include_Tract_IDs_with_Legal_Description");

                entity.Property(e => e.LeaseId).HasColumnName("Lease_ID");

                entity.Property(e => e.MultiPayments).HasColumnName("Multi_Payments");

                entity.Property(e => e.RecordingDate)
                    .HasColumnName("Recording_Date")
                    .HasColumnType("date");

                entity.Property(e => e.TractId).HasColumnName("Tract_ID");
            });

            modelBuilder.Entity<RegionMasterMainForm>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FormationCodes).HasColumnName("Formation_Codes");

                entity.Property(e => e.RegionId).HasColumnName("Region_ID");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<Registration>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Organization)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<RowMainForm>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcquiredDate)
                    .HasColumnName("Acquired_Date")
                    .HasColumnType("date");

                entity.Property(e => e.AcquisitionAmount)
                    .HasColumnName("Acquisition_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.AcquisitionCode).HasColumnName("Acquisition_Code");

                entity.Property(e => e.AcreageNotes).HasColumnName("Acreage_Notes");

                entity.Property(e => e.AddlBankFees)
                    .HasColumnName("Addl_Bank_Fees")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.AdvanceRoyaltyPerAcre)
                    .HasColumnName("Advance_Royalty_Per_Acre")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.AdvancedRoyalty)
                    .HasColumnName("Advanced_Royalty")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.AlternateRowName).HasColumnName("Alternate_ROW_Name");

                entity.Property(e => e.AreaName).HasColumnName("Area_Name");

                entity.Property(e => e.BasinId).HasColumnName("Basin_ID");

                entity.Property(e => e.BonusPerAcre)
                    .HasColumnName("Bonus_Per_Acre")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.BonusPerAcreToExtend)
                    .HasColumnName("Bonus_Per_Acre_to_Extend")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.BonusToExtend)
                    .HasColumnName("Bonus_To_Extend")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.BounsDeferred)
                    .HasColumnName("Bouns_Deferred")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.BrokerCosts)
                    .HasColumnName("Broker_Costs")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.CheckOn)
                    .HasColumnName("Check_On")
                    .HasColumnType("date");

                entity.Property(e => e.ConsiderationAmount)
                    .HasColumnName("Consideration_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.CountyId).HasColumnName("County_ID");

                entity.Property(e => e.CountyId2).HasColumnName("County_ID_2");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Damages)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Developed)
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.DistrictId).HasColumnName("District_ID");

                entity.Property(e => e.Divested).HasColumnType("date");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnName("Effective_Date")
                    .HasColumnType("date");

                entity.Property(e => e.EnityGrossUndev)
                    .HasColumnName("Enity_Gross_Undev")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityExpiredInterest)
                    .HasColumnName("Entity_Expired_Interest")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityGrossAcres)
                    .HasColumnName("Entity_Gross_Acres")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityGrossDeveloped)
                    .HasColumnName("Entity_Gross_Developed")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityGrossHbp)
                    .HasColumnName("Entity_Gross_HBP")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityGrossOther)
                    .HasColumnName("Entity_Gross_Other")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityGrossSurface)
                    .HasColumnName("Entity_Gross_Surface")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityGrossSurfaceDeveloped)
                    .HasColumnName("Entity_Gross_Surface_Developed")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityNetAcres)
                    .HasColumnName("Entity_Net_Acres")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityNetDev)
                    .HasColumnName("Entity_Net_Dev")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityNetHbp)
                    .HasColumnName("Entity_Net_HBP")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityNetSurface)
                    .HasColumnName("Entity_Net_Surface")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityNetSurfaceDeveloped)
                    .HasColumnName("Entity_Net_Surface_Developed")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityNetUndeveloped)
                    .HasColumnName("Entity_Net_Undeveloped")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityNotes).HasColumnName("Entity_Notes");

                entity.Property(e => e.EntityNriGas)
                    .HasColumnName("Entity_NRI_Gas")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityNriOil)
                    .HasColumnName("Entity_NRI_Oil")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityNriOther)
                    .HasColumnName("Entity_NRI_Other")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityOpRights)
                    .HasColumnName("Entity_Op_Rights")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityOrriGas)
                    .HasColumnName("Entity_ORRI_Gas")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityOrriOil)
                    .HasColumnName("Entity_ORRI_Oil")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityOrriOther)
                    .HasColumnName("Entity_ORRI_Other")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityOtherGas)
                    .HasColumnName("Entity_Other_Gas")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityOtherOil)
                    .HasColumnName("Entity_Other_Oil")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityOtherOther)
                    .HasColumnName("Entity_Other_Other")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityRoyaltyGas)
                    .HasColumnName("Entity_Royalty_Gas")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityRoyaltyOil)
                    .HasColumnName("Entity_Royalty_Oil")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityRoyaltyOther)
                    .HasColumnName("Entity_Royalty_Other")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityShareAcquisitionAmount)
                    .HasColumnName("Entity_Share_Acquisition_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareAdvancedRoyalty)
                    .HasColumnName("ENTITY_SHARE_Advanced_Royalty")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareBonusToExtend)
                    .HasColumnName("ENTITY_SHARE_Bonus_To_Extend")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareBrokerCosts)
                    .HasColumnName("ENTITY_SHARE_Broker_Costs")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareDamages)
                    .HasColumnName("ENTITY_SHARE_Damages")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareOfBonus)
                    .HasColumnName("Entity_Share_Of_Bonus")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareOfRentals)
                    .HasColumnName("Entity_Share_Of_Rentals")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareProductionRoyalty)
                    .HasColumnName("ENTITY_SHARE_Production_Royalty")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareProductionRoyaltyAmount)
                    .HasColumnName("Entity_Share_Production_Royalty_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareRentalAmount)
                    .HasColumnName("Entity_Share_Rental_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareShutInAmount)
                    .HasColumnName("Entity_Share_Shut_In_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareShutInCosts)
                    .HasColumnName("ENTITY_SHARE_Shut_In_Costs")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareSurfaceFeeAmount)
                    .HasColumnName("Entity_Share_Surface_Fee_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ExpenseInterest)
                    .HasColumnName("Expense_Interest")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.ExpirationDate)
                    .HasColumnName("Expiration_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ExpireDate)
                    .HasColumnName("Expire_Date")
                    .HasColumnType("date");

                entity.Property(e => e.FedStateLeaseNo).HasColumnName("FedState_Lease_No");

                entity.Property(e => e.FederalLeaseFlag).HasColumnName("Federal_Lease_Flag");

                entity.Property(e => e.FieldBroker).HasColumnName("Field_Broker");

                entity.Property(e => e.FrequencyInMonths).HasColumnName("Frequency_In_Months");

                entity.Property(e => e.GrossAcres)
                    .HasColumnName("Gross_Acres")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.HbpAcres)
                    .HasColumnName("HBP_Acres")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.HbpFlag).HasColumnName("HBP_Flag");

                entity.Property(e => e.IncludeInTotalGrossAcres)
                    .HasColumnName("Include_in_Total_Gross_Acres")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.InputDate)
                    .HasColumnName("Input_Date")
                    .HasColumnType("date");

                entity.Property(e => e.InstrumentCode).HasColumnName("Instrument_Code");

                entity.Property(e => e.InstrumentFlag).HasColumnName("Instrument_Flag");

                entity.Property(e => e.LandType).HasColumnName("Land_Type");

                entity.Property(e => e.LeaseholdInterest)
                    .HasColumnName("Leasehold_Interest")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.LesseeId).HasColumnName("Lessee_ID");

                entity.Property(e => e.LessorId).HasColumnName("Lessor_ID");

                entity.Property(e => e.MaximumShutInDays).HasColumnName("Maximum_Shut_In_Days");

                entity.Property(e => e.MinRoyDue)
                    .HasColumnName("Min_Roy_Due")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.MineralOwnership).HasColumnName("Mineral_Ownership");

                entity.Property(e => e.MineralOwnershipDecimal)
                    .HasColumnName("Mineral_OwnershipDecimal")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.MmsLeaseNo).HasColumnName("MMS_Lease_No");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.NetAcres)
                    .HasColumnName("Net_Acres")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.NetDev)
                    .HasColumnName("Net_Dev")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.NetHbp)
                    .HasColumnName("Net_HBP")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.NetOther)
                    .HasColumnName("Net_Other")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.NetOtherEntity)
                    .HasColumnName("Net_Other_Entity")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.NetOutside)
                    .HasColumnName("Net_Outside")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.NetSurface)
                    .HasColumnName("Net_Surface")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.NetSurfaceDeveloped)
                    .HasColumnName("Net_Surface_Developed")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.NetUndeveloped)
                    .HasColumnName("Net_Undeveloped")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.NextRentalDue)
                    .HasColumnName("Next_Rental_Due")
                    .HasColumnType("date");

                entity.Property(e => e.NotesOnAcreage).HasColumnName("Notes_on_Acreage");

                entity.Property(e => e.Nri)
                    .HasColumnName("NRI")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.ORRI)
                    .HasColumnName("O_R_R_I")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.OkToPay).HasColumnName("OK_to_Pay");

                entity.Property(e => e.OperatingRights)
                    .HasColumnName("Operating_Rights")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.OperatorLeaseNo).HasColumnName("Operator_Lease_No");

                entity.Property(e => e.OptAmountPerAcre)
                    .HasColumnName("Opt_Amount_Per_Acre")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.OptExpireDate)
                    .HasColumnName("Opt_Expire_Date")
                    .HasColumnType("date");

                entity.Property(e => e.OptExpireDays).HasColumnName("Opt_Expire_Days");

                entity.Property(e => e.OptExtAmntPerAcre)
                    .HasColumnName("Opt_Ext_Amnt_Per_Acre")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.OptPeriod).HasColumnName("Opt_Period");

                entity.Property(e => e.OptPrepaidAmountPerAcre)
                    .HasColumnName("Opt_Prepaid_Amount_Per_Acre")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.OptToExtend).HasColumnName("Opt_To_Extend");

                entity.Property(e => e.OptToExtendDays).HasColumnName("Opt_To_Extend_Days");

                entity.Property(e => e.OptionConvBonusPerAcre)
                    .HasColumnName("Option_Conv_Bonus_Per_Acre")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.OriginalRowNo).HasColumnName("Original_ROW_No");

                entity.Property(e => e.Orri1)
                    .HasColumnName("ORRI")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.OrriMemo).HasColumnName("ORRI_Memo");

                entity.Property(e => e.Other)
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.OtherAcreage)
                    .HasColumnName("Other_Acreage")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.OtherDate)
                    .HasColumnName("Other_Date")
                    .HasColumnType("date");

                entity.Property(e => e.OtherLeaseBurdens)
                    .HasColumnName("Other_Lease_Burdens")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.OutsideAcreage)
                    .HasColumnName("Outside_Acreage")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.OwnerId).HasColumnName("Owner_ID");

                entity.Property(e => e.PaidUp).HasColumnName("Paid_Up");

                entity.Property(e => e.PayoutCode).HasColumnName("Payout_Code");

                entity.Property(e => e.PoolingType).HasColumnName("Pooling_Type");

                entity.Property(e => e.PrimaryTerm).HasColumnName("Primary_Term");

                entity.Property(e => e.ProductionRoyalty)
                    .HasColumnName("Production_Royalty")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ProductionRoyaltyPerAcre)
                    .HasColumnName("Production_Royalty_Per_Acre")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ProjectGroupName).HasColumnName("Project_Group_Name");

                entity.Property(e => e.ProspectId).HasColumnName("Prospect_ID");

                entity.Property(e => e.PughHorizon).HasColumnName("Pugh_Horizon");

                entity.Property(e => e.PughHorizonExpDate)
                    .HasColumnName("Pugh_Horizon_Exp_Date")
                    .HasColumnType("date");

                entity.Property(e => e.PughVert).HasColumnName("Pugh_Vert");

                entity.Property(e => e.PughVertExpDate)
                    .HasColumnName("Pugh_Vert_Exp_Date")
                    .HasColumnType("date");

                entity.Property(e => e.RecordTitle)
                    .HasColumnName("Record_Title")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.RecordingInformation).HasColumnName("Recording_Information");

                entity.Property(e => e.RegionId).HasColumnName("Region_ID");

                entity.Property(e => e.RenewalLease).HasColumnName("Renewal_Lease");

                entity.Property(e => e.RentalDueDate)
                    .HasColumnName("Rental_Due_Date")
                    .HasColumnType("date");

                entity.Property(e => e.RentalPerAcre)
                    .HasColumnName("Rental_Per_ACre")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ResponsibleParty).HasColumnName("Responsible_Party");

                entity.Property(e => e.RowDate)
                    .HasColumnName("ROW_Date")
                    .HasColumnType("date");

                entity.Property(e => e.RowForm).HasColumnName("ROW_Form");

                entity.Property(e => e.RowId).HasColumnName("ROW_ID");

                entity.Property(e => e.RowLegalDescription).HasColumnName("ROW_Legal_Description");

                entity.Property(e => e.RowName).HasColumnName("ROW_Name");

                entity.Property(e => e.RowStatus).HasColumnName("ROW_Status");

                entity.Property(e => e.RowType).HasColumnName("ROW_Type");

                entity.Property(e => e.Royalty)
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.RoyaltyIntMemo).HasColumnName("Royalty_Int_Memo");

                entity.Property(e => e.Search1).HasColumnName("Search_1");

                entity.Property(e => e.Search2).HasColumnName("Search_2");

                entity.Property(e => e.Search3).HasColumnName("Search_3");

                entity.Property(e => e.Search4).HasColumnName("Search_4");

                entity.Property(e => e.Search5).HasColumnName("Search_5");

                entity.Property(e => e.Search6).HasColumnName("Search_6");

                entity.Property(e => e.SecondExpDate)
                    .HasColumnName("Second_Exp_Date")
                    .HasColumnType("date");

                entity.Property(e => e.SecondExpirationDate)
                    .HasColumnName("Second_Expiration_Date")
                    .HasColumnType("date");

                entity.Property(e => e.SeismicOptionNotes).HasColumnName("Seismic_Option_Notes");

                entity.Property(e => e.SeismicPermitExpirationDate)
                    .HasColumnName("Seismic_Permit_Expiration_Date")
                    .HasColumnType("date");

                entity.Property(e => e.SeismicPermitExpirationDays).HasColumnName("Seismic_Permit_Expiration_Days");

                entity.Property(e => e.SeismicPermitExtensionDays).HasColumnName("Seismic_Permit_Extension_Days");

                entity.Property(e => e.ShutInAmount)
                    .HasColumnName("Shut_In_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ShutInClause).HasColumnName("Shut_In_Clause");

                entity.Property(e => e.ShutInCosts)
                    .HasColumnName("Shut_In_Costs")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ShutInDays).HasColumnName("Shut_In_Days");

                entity.Property(e => e.ShutInPerAcre)
                    .HasColumnName("Shut_In_Per_Acre")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ShutInProvision).HasColumnName("Shut_In_Provision");

                entity.Property(e => e.ShutInTerm)
                    .HasColumnName("Shut_In_Term")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.SpecialProvisionNotes).HasColumnName("Special_Provision_Notes");

                entity.Property(e => e.StateId).HasColumnName("State_ID");

                entity.Property(e => e.StateId2).HasColumnName("State_ID_2");

                entity.Property(e => e.StatusCode).HasColumnName("Status_Code");

                entity.Property(e => e.SurfaceFeeAmount)
                    .HasColumnName("Surface_Fee_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.SurfaceFeeAmountPerAcre)
                    .HasColumnName("Surface_Fee_Amount_Per_Acre")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.SurfaceOwnership).HasColumnName("Surface_Ownership");

                entity.Property(e => e.SurfaceOwnershipDecimal)
                    .HasColumnName("Surface_OwnershipDecimal")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.SurfacedDeveloped)
                    .HasColumnName("Surfaced_Developed")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.Surrendered).HasColumnType("date");

                entity.Property(e => e.TermMonths).HasColumnName("Term_Months");

                entity.Property(e => e.TermOption).HasColumnName("Term_Option");

                entity.Property(e => e.TopLease).HasColumnName("Top_Lease");

                entity.Property(e => e.TotalAcreage)
                    .HasColumnName("Total_Acreage")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.TotalAmountAdvancedRoyalty)
                    .HasColumnName("TOTAL_AMOUNT_Advanced_Royalty")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalAmountBonusToExtend)
                    .HasColumnName("TOTAL_AMOUNT_Bonus_To_Extend")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalAmountBrokerCosts)
                    .HasColumnName("TOTAL_AMOUNT_Broker_Costs")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalAmountDamages)
                    .HasColumnName("TOTAL_AMOUNT_Damages")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalAmountProductionRoyalty)
                    .HasColumnName("TOTAL_AMOUNT_Production_Royalty")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalAmountShutInCosts)
                    .HasColumnName("TOTAL_AMOUNT_Shut_In_Costs")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalBonusAmount)
                    .HasColumnName("Total_Bonus_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalBonusPaid)
                    .HasColumnName("Total_Bonus_Paid")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalNumberOfPayment).HasColumnName("Total_Number_Of_Payment");

                entity.Property(e => e.TotalRentalAmount)
                    .HasColumnName("Total_Rental_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalSurface)
                    .HasColumnName("Total_Surface")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.TractId).HasColumnName("Tract_ID");

                entity.Property(e => e.TractOwnerPk).HasColumnName("TractOwnerPK");

                entity.Property(e => e.TransferDate)
                    .HasColumnName("Transfer_Date")
                    .HasColumnType("date");

                entity.Property(e => e.Undeveloped)
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.WasTheSeismicPermitExtended).HasColumnName("Was_the_Seismic_Permit_Extended");

                entity.Property(e => e.WellIdNo).HasColumnName("Well_ID_No");

                entity.Property(e => e.WorkingInterest)
                    .HasColumnName("Working_Interest")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");
            });

            modelBuilder.Entity<Royalty>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BurdenId).HasColumnName("Burden_ID");

                entity.Property(e => e.BurdenType).HasColumnName("Burden_Type");

                entity.Property(e => e.BurdensAllWiPartners).HasColumnName("Burdens_All_WI_Partners");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.EasementId).HasColumnName("Easement_ID");

                entity.Property(e => e.EffectiveDate).HasColumnName("Effective_Date");

                entity.Property(e => e.ExpireDate).HasColumnName("Expire_Date");

                entity.Property(e => e.FlatAmount)
                    .HasColumnName("Flat_Amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Interest).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.InterestFormula).HasColumnName("Interest_Formula");

                entity.Property(e => e.InterestType).HasColumnName("Interest_Type");

                entity.Property(e => e.LeaseId).HasColumnName("Lease_ID");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.ModifiedDate).HasColumnName("Modified_Date");

                entity.Property(e => e.OrriReductionType).HasColumnName("ORRI_Reduction_Type");

                entity.Property(e => e.OrriType).HasColumnName("ORRI_Type");

                entity.Property(e => e.OwnerId).HasColumnName("Owner_ID");

                entity.Property(e => e.PayoutCode).HasColumnName("Payout_Code");

                entity.Property(e => e.RowId).HasColumnName("ROW_ID");

                entity.Property(e => e.RoyOwnerId).HasColumnName("Roy_Owner_ID");

                entity.Property(e => e.SuaId).HasColumnName("SUA_ID");

                entity.Property(e => e.SubTractId).HasColumnName("SubTract_ID");

                entity.Property(e => e.SuspenseCode).HasColumnName("Suspense_Code");

                entity.Property(e => e.TractId).HasColumnName("Tract_ID");

                entity.Property(e => e.UnitId).HasColumnName("Unit_ID");

                entity.Property(e => e.WellId).HasColumnName("Well_ID");

                entity.Property(e => e.WiOwnerId).HasColumnName("WI_Owner_ID");
            });

            modelBuilder.Entity<SignInPage>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<SpecialObligations>(entity =>
            {
                entity.ToTable("Special_Obligations");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DescriptionOfObligation).HasColumnName("Description_of_Obligation");

                entity.Property(e => e.EasementId).HasColumnName("Easement_ID");

                entity.Property(e => e.ExpirationDate)
                    .HasColumnName("Expiration_Date")
                    .HasColumnType("date");

                entity.Property(e => e.FormationId).HasColumnName("Formation_ID");

                entity.Property(e => e.LeaseId).HasColumnName("Lease_ID");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.ModifiedDate).HasColumnName("Modified_Date");

                entity.Property(e => e.ObligationAmount)
                    .HasColumnName("Obligation_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.ObligationDate)
                    .HasColumnName("Obligation_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ObligationType).HasColumnName("Obligation_Type");

                entity.Property(e => e.OwnerId).HasColumnName("Owner_ID");

                entity.Property(e => e.RecurringObligation).HasColumnName("Recurring_Obligation");

                entity.Property(e => e.RecurringPeriod).HasColumnName("Recurring_Period");

                entity.Property(e => e.ResponsiblePartyId).HasColumnName("Responsible_Party_ID");

                entity.Property(e => e.RowId).HasColumnName("ROW_ID");

                entity.Property(e => e.SuaId).HasColumnName("SUA_ID");

                entity.Property(e => e.TractId).HasColumnName("Tract_ID");

                entity.Property(e => e.UnitId).HasColumnName("Unit_ID");

                entity.Property(e => e.WellId).HasColumnName("Well_ID");
            });

            modelBuilder.Entity<SpecialProvisions>(entity =>
            {
                entity.ToTable("Special_Provisions");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.EasementId).HasColumnName("Easement_ID");

                entity.Property(e => e.FormationId).HasColumnName("Formation_ID");

                entity.Property(e => e.LeaseId).HasColumnName("Lease_ID");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.ModifiedDate).HasColumnName("Modified_Date");

                entity.Property(e => e.OptionToExtend).HasColumnName("Option_to_Extend");

                entity.Property(e => e.PoolingFlag).HasColumnName("Pooling_Flag");

                entity.Property(e => e.RowId).HasColumnName("ROW_ID");

                entity.Property(e => e.SpecialProvisionNotes).HasColumnName("Special_Provision_Notes");

                entity.Property(e => e.SuaId).HasColumnName("SUA_ID");

                entity.Property(e => e.TractId).HasColumnName("Tract_ID");

                entity.Property(e => e.UnitId).HasColumnName("Unit_ID");

                entity.Property(e => e.WellId).HasColumnName("Well_ID");
            });

            modelBuilder.Entity<StateMainForm>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PostalCode).HasColumnName("Postal_Code");

                entity.Property(e => e.State).HasMaxLength(450);

                entity.Property(e => e.StateId)
                    .HasColumnName("State_ID")
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<StatusOfLeaseDropdown>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<SuamainForm>(entity =>
            {
                entity.ToTable("SUAMainForm");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcquiredDate)
                    .HasColumnName("Acquired_Date")
                    .HasColumnType("date");

                entity.Property(e => e.AcquisitionAmount)
                    .HasColumnName("Acquisition_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.AcquisitionCode).HasColumnName("Acquisition_Code");

                entity.Property(e => e.AcreageNotes).HasColumnName("Acreage_Notes");

                entity.Property(e => e.AddlBankFees)
                    .HasColumnName("Addl_Bank_Fees")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.AdvanceRoyaltyPerAcre)
                    .HasColumnName("Advance_Royalty_Per_Acre")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.AdvancedRoyalty)
                    .HasColumnName("Advanced_Royalty")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.AlternateSuaName).HasColumnName("Alternate_SUA_Name");

                entity.Property(e => e.AreaName).HasColumnName("Area_Name");

                entity.Property(e => e.BasinId).HasColumnName("Basin_ID");

                entity.Property(e => e.BonusPerAcre)
                    .HasColumnName("Bonus_Per_Acre")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.BonusPerAcreToExtend)
                    .HasColumnName("Bonus_Per_Acre_to_Extend")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.BonusToExtend)
                    .HasColumnName("Bonus_To_Extend")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.BounsDeferred)
                    .HasColumnName("Bouns_Deferred")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.BrokerCosts)
                    .HasColumnName("Broker_Costs")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.CheckOn)
                    .HasColumnName("Check_On")
                    .HasColumnType("date");

                entity.Property(e => e.ConsiderationAmount)
                    .HasColumnName("Consideration_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.CountyId).HasColumnName("County_ID");

                entity.Property(e => e.CountyId2).HasColumnName("County_ID_2");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Damages)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Developed)
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.DistrictId).HasColumnName("District_ID");

                entity.Property(e => e.Divested).HasColumnType("date");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnName("Effective_Date")
                    .HasColumnType("date");

                entity.Property(e => e.EnityGrossUndev)
                    .HasColumnName("Enity_Gross_Undev")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityExpiredInterest)
                    .HasColumnName("Entity_Expired_Interest")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityGrossAcres)
                    .HasColumnName("Entity_Gross_Acres")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityGrossDeveloped)
                    .HasColumnName("Entity_Gross_Developed")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityGrossHbp)
                    .HasColumnName("Entity_Gross_HBP")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityGrossOther)
                    .HasColumnName("Entity_Gross_Other")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityGrossSurface)
                    .HasColumnName("Entity_Gross_Surface")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityGrossSurfaceDeveloped)
                    .HasColumnName("Entity_Gross_Surface_Developed")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityNetAcres)
                    .HasColumnName("Entity_Net_Acres")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityNetDev)
                    .HasColumnName("Entity_Net_Dev")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityNetHbp)
                    .HasColumnName("Entity_Net_HBP")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityNetSurface)
                    .HasColumnName("Entity_Net_Surface")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityNetSurfaceDeveloped)
                    .HasColumnName("Entity_Net_Surface_Developed")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityNetUndeveloped)
                    .HasColumnName("Entity_Net_Undeveloped")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityNotes).HasColumnName("Entity_Notes");

                entity.Property(e => e.EntityNriGas)
                    .HasColumnName("Entity_NRI_Gas")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityNriOil)
                    .HasColumnName("Entity_NRI_Oil")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityNriOther)
                    .HasColumnName("Entity_NRI_Other")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityOpRights)
                    .HasColumnName("Entity_Op_Rights")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityOrriGas)
                    .HasColumnName("Entity_ORRI_Gas")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityOrriOil)
                    .HasColumnName("Entity_ORRI_Oil")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityOrriOther)
                    .HasColumnName("Entity_ORRI_Other")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityOtherGas)
                    .HasColumnName("Entity_Other_Gas")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityOtherOil)
                    .HasColumnName("Entity_Other_Oil")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityOtherOther)
                    .HasColumnName("Entity_Other_Other")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityRoyaltyGas)
                    .HasColumnName("Entity_Royalty_Gas")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityRoyaltyOil)
                    .HasColumnName("Entity_Royalty_Oil")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityRoyaltyOther)
                    .HasColumnName("Entity_Royalty_Other")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.EntityShareAcquisitionAmount)
                    .HasColumnName("Entity_Share_Acquisition_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareAdvancedRoyalty)
                    .HasColumnName("ENTITY_SHARE_Advanced_Royalty")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareBonusToExtend)
                    .HasColumnName("ENTITY_SHARE_Bonus_To_Extend")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareBrokerCosts)
                    .HasColumnName("ENTITY_SHARE_Broker_Costs")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareDamages)
                    .HasColumnName("ENTITY_SHARE_Damages")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareOfBonus)
                    .HasColumnName("Entity_Share_Of_Bonus")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareOfRentals)
                    .HasColumnName("Entity_Share_Of_Rentals")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareProductionRoyalty)
                    .HasColumnName("ENTITY_SHARE_Production_Royalty")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareProductionRoyaltyAmount)
                    .HasColumnName("Entity_Share_Production_Royalty_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareRentalAmount)
                    .HasColumnName("Entity_Share_Rental_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareShutInAmount)
                    .HasColumnName("Entity_Share_Shut_In_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareShutInCosts)
                    .HasColumnName("ENTITY_SHARE_Shut_In_Costs")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EntityShareSurfaceFeeAmount)
                    .HasColumnName("Entity_Share_Surface_Fee_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ExpenseInterest)
                    .HasColumnName("Expense_Interest")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.ExpirationDate)
                    .HasColumnName("Expiration_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ExpireDate)
                    .HasColumnName("Expire_Date")
                    .HasColumnType("date");

                entity.Property(e => e.FedStateLeaseNo).HasColumnName("FedState_Lease_No");

                entity.Property(e => e.FederalLeaseFlag).HasColumnName("Federal_Lease_Flag");

                entity.Property(e => e.FieldBroker).HasColumnName("Field_Broker");

                entity.Property(e => e.FrequencyInMonths).HasColumnName("Frequency_In_Months");

                entity.Property(e => e.GrossAcres)
                    .HasColumnName("Gross_Acres")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.HbpAcres)
                    .HasColumnName("HBP_Acres")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.HbpFlag).HasColumnName("HBP_Flag");

                entity.Property(e => e.IncludeInTotalGrossAcres)
                    .HasColumnName("Include_in_Total_Gross_Acres")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.InputDate)
                    .HasColumnName("Input_Date")
                    .HasColumnType("date");

                entity.Property(e => e.InstrumentCode).HasColumnName("Instrument_Code");

                entity.Property(e => e.InstrumentFlag).HasColumnName("Instrument_Flag");

                entity.Property(e => e.LandType).HasColumnName("Land_Type");

                entity.Property(e => e.LeaseholdInterest)
                    .HasColumnName("Leasehold_Interest")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.LesseeId).HasColumnName("Lessee_ID");

                entity.Property(e => e.LessorId).HasColumnName("Lessor_ID");

                entity.Property(e => e.MaximumShutInDays).HasColumnName("Maximum_Shut_In_Days");

                entity.Property(e => e.MinRoyDue)
                    .HasColumnName("Min_Roy_Due")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.MineralOwnership).HasColumnName("Mineral_Ownership");

                entity.Property(e => e.MineralOwnershipDecimal)
                    .HasColumnName("Mineral_OwnershipDecimal")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.MmsLeaseNo).HasColumnName("MMS_Lease_No");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.NetAcres)
                    .HasColumnName("Net_Acres")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.NetDev)
                    .HasColumnName("Net_Dev")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.NetHbp)
                    .HasColumnName("Net_HBP")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.NetOther)
                    .HasColumnName("Net_Other")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.NetOtherEntity)
                    .HasColumnName("Net_Other_Entity")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.NetOutside)
                    .HasColumnName("Net_Outside")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.NetSurface)
                    .HasColumnName("Net_Surface")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.NetSurfaceDeveloped)
                    .HasColumnName("Net_Surface_Developed")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.NetUndeveloped)
                    .HasColumnName("Net_Undeveloped")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.NextRentalDue)
                    .HasColumnName("Next_Rental_Due")
                    .HasColumnType("date");

                entity.Property(e => e.NotesOnAcreage).HasColumnName("Notes_on_Acreage");

                entity.Property(e => e.Nri)
                    .HasColumnName("NRI")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.ORRI)
                    .HasColumnName("O_R_R_I")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.OkToPay).HasColumnName("OK_to_Pay");

                entity.Property(e => e.OperatingRights)
                    .HasColumnName("Operating_Rights")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.OperatorLeaseNo).HasColumnName("Operator_Lease_No");

                entity.Property(e => e.OptAmountPerAcre)
                    .HasColumnName("Opt_Amount_Per_Acre")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.OptExpireDate)
                    .HasColumnName("Opt_Expire_Date")
                    .HasColumnType("date");

                entity.Property(e => e.OptExpireDays).HasColumnName("Opt_Expire_Days");

                entity.Property(e => e.OptExtAmntPerAcre)
                    .HasColumnName("Opt_Ext_Amnt_Per_Acre")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.OptPeriod).HasColumnName("Opt_Period");

                entity.Property(e => e.OptPrepaidAmountPerAcre)
                    .HasColumnName("Opt_Prepaid_Amount_Per_Acre")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.OptToExtend).HasColumnName("Opt_To_Extend");

                entity.Property(e => e.OptToExtendDays).HasColumnName("Opt_To_Extend_Days");

                entity.Property(e => e.OptionConvBonusPerAcre)
                    .HasColumnName("Option_Conv_Bonus_Per_Acre")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.OriginalSuaNo).HasColumnName("Original_SUA_No");

                entity.Property(e => e.Orri1)
                    .HasColumnName("ORRI")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.OrriMemo).HasColumnName("ORRI_Memo");

                entity.Property(e => e.Other)
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.OtherAcreage)
                    .HasColumnName("Other_Acreage")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.OtherDate)
                    .HasColumnName("Other_Date")
                    .HasColumnType("date");

                entity.Property(e => e.OtherLeaseBurdens)
                    .HasColumnName("Other_Lease_Burdens")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.OutsideAcreage)
                    .HasColumnName("Outside_Acreage")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.OwnerId).HasColumnName("Owner_ID");

                entity.Property(e => e.PaidUp).HasColumnName("Paid_Up");

                entity.Property(e => e.PayoutCode).HasColumnName("Payout_Code");

                entity.Property(e => e.PoolingType).HasColumnName("Pooling_Type");

                entity.Property(e => e.PrimaryTerm).HasColumnName("Primary_Term");

                entity.Property(e => e.ProductionRoyalty)
                    .HasColumnName("Production_Royalty")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ProductionRoyaltyPerAcre)
                    .HasColumnName("Production_Royalty_Per_Acre")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ProjectGroupName).HasColumnName("Project_Group_Name");

                entity.Property(e => e.ProspectId).HasColumnName("Prospect_ID");

                entity.Property(e => e.PughHorizon).HasColumnName("Pugh_Horizon");

                entity.Property(e => e.PughHorizonExpDate)
                    .HasColumnName("Pugh_Horizon_Exp_Date")
                    .HasColumnType("date");

                entity.Property(e => e.PughVert).HasColumnName("Pugh_Vert");

                entity.Property(e => e.PughVertExpDate)
                    .HasColumnName("Pugh_Vert_Exp_Date")
                    .HasColumnType("date");

                entity.Property(e => e.RecordTitle)
                    .HasColumnName("Record_Title")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.RecordingInformation).HasColumnName("Recording_Information");

                entity.Property(e => e.RegionId).HasColumnName("Region_ID");

                entity.Property(e => e.RenewalLease).HasColumnName("Renewal_Lease");

                entity.Property(e => e.RentalDueDate)
                    .HasColumnName("Rental_Due_Date")
                    .HasColumnType("date");

                entity.Property(e => e.RentalPerAcre)
                    .HasColumnName("Rental_Per_ACre")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ResponsibleParty).HasColumnName("Responsible_Party");

                entity.Property(e => e.Royalty)
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.RoyaltyIntMemo).HasColumnName("Royalty_Int_Memo");

                entity.Property(e => e.Search1).HasColumnName("Search_1");

                entity.Property(e => e.Search2).HasColumnName("Search_2");

                entity.Property(e => e.Search3).HasColumnName("Search_3");

                entity.Property(e => e.Search4).HasColumnName("Search_4");

                entity.Property(e => e.Search5).HasColumnName("Search_5");

                entity.Property(e => e.Search6).HasColumnName("Search_6");

                entity.Property(e => e.SecondExpDate)
                    .HasColumnName("Second_Exp_Date")
                    .HasColumnType("date");

                entity.Property(e => e.SecondExpirationDate)
                    .HasColumnName("Second_Expiration_Date")
                    .HasColumnType("date");

                entity.Property(e => e.SeismicOptionNotes).HasColumnName("Seismic_Option_Notes");

                entity.Property(e => e.SeismicPermitExpirationDate)
                    .HasColumnName("Seismic_Permit_Expiration_Date")
                    .HasColumnType("date");

                entity.Property(e => e.SeismicPermitExpirationDays).HasColumnName("Seismic_Permit_Expiration_Days");

                entity.Property(e => e.SeismicPermitExtensionDays).HasColumnName("Seismic_Permit_Extension_Days");

                entity.Property(e => e.ShutInAmount)
                    .HasColumnName("Shut_In_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ShutInClause).HasColumnName("Shut_In_Clause");

                entity.Property(e => e.ShutInCosts)
                    .HasColumnName("Shut_In_Costs")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ShutInDays).HasColumnName("Shut_In_Days");

                entity.Property(e => e.ShutInPerAcre)
                    .HasColumnName("Shut_In_Per_Acre")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ShutInProvision).HasColumnName("Shut_In_Provision");

                entity.Property(e => e.ShutInTerm)
                    .HasColumnName("Shut_In_Term")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.SpecialProvisionNotes).HasColumnName("Special_Provision_Notes");

                entity.Property(e => e.StateId).HasColumnName("State_ID");

                entity.Property(e => e.StateId2).HasColumnName("State_ID_2");

                entity.Property(e => e.StatusCode).HasColumnName("Status_Code");

                entity.Property(e => e.SuaDate)
                    .HasColumnName("SUA_Date")
                    .HasColumnType("date");

                entity.Property(e => e.SuaForm).HasColumnName("SUA_Form");

                entity.Property(e => e.SuaId).HasColumnName("SUA_ID");

                entity.Property(e => e.SuaLegalDescription).HasColumnName("SUA_Legal_Description");

                entity.Property(e => e.SuaName).HasColumnName("SUA_Name");

                entity.Property(e => e.SuaStatus).HasColumnName("SUA_Status");

                entity.Property(e => e.SuaType).HasColumnName("SUA_Type");

                entity.Property(e => e.SurfaceFeeAmount)
                    .HasColumnName("Surface_Fee_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.SurfaceFeeAmountPerAcre)
                    .HasColumnName("Surface_Fee_Amount_Per_Acre")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.SurfaceOwnership).HasColumnName("Surface_Ownership");

                entity.Property(e => e.SurfaceOwnershipDecimal)
                    .HasColumnName("Surface_OwnershipDecimal")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.SurfacedDeveloped)
                    .HasColumnName("Surfaced_Developed")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.Surrendered).HasColumnType("date");

                entity.Property(e => e.TermMonths).HasColumnName("Term_Months");

                entity.Property(e => e.TermOption).HasColumnName("Term_Option");

                entity.Property(e => e.TopLease).HasColumnName("Top_Lease");

                entity.Property(e => e.TotalAcreage)
                    .HasColumnName("Total_Acreage")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.TotalAmountAdvancedRoyalty)
                    .HasColumnName("TOTAL_AMOUNT_Advanced_Royalty")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalAmountBonusToExtend)
                    .HasColumnName("TOTAL_AMOUNT_Bonus_To_Extend")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalAmountBrokerCosts)
                    .HasColumnName("TOTAL_AMOUNT_Broker_Costs")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalAmountDamages)
                    .HasColumnName("TOTAL_AMOUNT_Damages")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalAmountProductionRoyalty)
                    .HasColumnName("TOTAL_AMOUNT_Production_Royalty")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalAmountShutInCosts)
                    .HasColumnName("TOTAL_AMOUNT_Shut_In_Costs")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalBonusAmount)
                    .HasColumnName("Total_Bonus_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalBonusPaid)
                    .HasColumnName("Total_Bonus_Paid")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalNumberOfPayment).HasColumnName("Total_Number_Of_Payment");

                entity.Property(e => e.TotalRentalAmount)
                    .HasColumnName("Total_Rental_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalSurface)
                    .HasColumnName("Total_Surface")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.TractId).HasColumnName("Tract_ID");

                entity.Property(e => e.TractOwnerPk).HasColumnName("TractOwnerPK");

                entity.Property(e => e.TransferDate)
                    .HasColumnName("Transfer_Date")
                    .HasColumnType("date");

                entity.Property(e => e.Undeveloped)
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.WasTheSeismicPermitExtended).HasColumnName("Was_the_Seismic_Permit_Extended");

                entity.Property(e => e.WellIdNo).HasColumnName("Well_ID_No");

                entity.Property(e => e.WorkingInterest)
                    .HasColumnName("Working_Interest")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00000000))");
            });

            modelBuilder.Entity<SubTractMaster>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Acreage).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.Active).HasMaxLength(50);

                entity.Property(e => e.BeginningDepth).HasColumnName("Beginning_Depth");

                entity.Property(e => e.Blocks).HasMaxLength(50);

                entity.Property(e => e.DepthNotes).HasColumnName("Depth_Notes");

                entity.Property(e => e.Developed).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.EndingDepth).HasColumnName("Ending_Depth");

                entity.Property(e => e.InclInFormationCalc)
                    .HasColumnName("Incl_in_Formation_Calc")
                    .HasMaxLength(50);

                entity.Property(e => e.InclInSubTractAcresCalc)
                    .HasColumnName("Incl_in_SubTract_Acres_Calc")
                    .HasMaxLength(50);

                entity.Property(e => e.InclInTractAcresCalc)
                    .HasColumnName("Incl_in_Tract_Acres_Calc")
                    .HasMaxLength(50);

                entity.Property(e => e.InclInTwnRngSecCalc)
                    .HasColumnName("Incl_in_TwnRngSec_Calc")
                    .HasMaxLength(50);

                entity.Property(e => e.InclInUnitAcresCalc)
                    .HasColumnName("Incl_in_Unit_Acres_Calc")
                    .HasMaxLength(50);

                entity.Property(e => e.InclInWellAcresCalc)
                    .HasColumnName("Incl_in_Well_Acres_Calc")
                    .HasMaxLength(50);

                entity.Property(e => e.Lot).HasMaxLength(50);

                entity.Property(e => e.OkToPayRentalsOnThisSubTract).HasColumnName("OK_to_Pay_Rentals_on_this_SubTract");

                entity.Property(e => e.Other).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.Outside).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.OwnerId)
                    .HasColumnName("Owner_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.RngAbstract)
                    .HasColumnName("Rng_Abstract")
                    .HasMaxLength(50);

                entity.Property(e => e.ShortDescription).HasColumnName("Short_Description");

                entity.Property(e => e.SubTractId)
                    .HasColumnName("SubTract_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.SubTractLegalDescription).HasColumnName("SubTract_Legal_Description");

                entity.Property(e => e.SubTractType)
                    .HasColumnName("SubTract_Type")
                    .HasMaxLength(50);

                entity.Property(e => e.TractId)
                    .HasColumnName("Tract_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.TwnSurvey).HasColumnName("Twn_Survey");

                entity.Property(e => e.Undeveloped).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.UnitIdNo)
                    .HasColumnName("Unit_ID_No")
                    .HasMaxLength(50);

                entity.Property(e => e.UnitParticipationFactor)
                    .HasColumnName("Unit_Participation_Factor")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.WellIdNo)
                    .HasColumnName("Well_ID_No")
                    .HasMaxLength(50);

                entity.Property(e => e.WellParticipationFactor)
                    .HasColumnName("Well_Participation_Factor")
                    .HasColumnType("decimal(18, 8)");
            });

            modelBuilder.Entity<SubTractTypeDropdown>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.SubTractType).HasColumnName("SubTract_Type");
            });

            modelBuilder.Entity<SurfaceOwnership>(entity =>
            {
                entity.ToTable("Surface_Ownership");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BeginningDepth).HasColumnName("Beginning_Depth");

                entity.Property(e => e.BookPage).HasColumnName("Book_Page");

                entity.Property(e => e.CountyId).HasColumnName("County_ID");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.DepthNotes).HasColumnName("Depth_Notes");

                entity.Property(e => e.Developed).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.EasementId).HasColumnName("Easement_ID");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnName("Effective_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndingDepth).HasColumnName("Ending_Depth");

                entity.Property(e => e.ExpireDate)
                    .HasColumnName("Expire_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FileDate)
                    .HasColumnName("File_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FullName).HasColumnName("Full_Name");

                entity.Property(e => e.LeaseId).HasColumnName("Lease_ID");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.NetAcreage)
                    .HasColumnName("Net_Acreage")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NoExecutiveRights).HasColumnName("NO_Executive_Rights");

                entity.Property(e => e.NonProducing)
                    .HasColumnName("Non_Producing")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NpriGas)
                    .HasColumnName("NPRI_Gas")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NpriOil)
                    .HasColumnName("NPRI_Oil")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.OptionToExtend).HasColumnName("Option_to_Extend");

                entity.Property(e => e.OrriGas)
                    .HasColumnName("ORRI_Gas")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.OrriOil)
                    .HasColumnName("ORRI_Oil")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.Other).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.OtherInterest)
                    .HasColumnName("Other_Interest")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.Outside).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.OwnerId).HasColumnName("Owner_ID");

                entity.Property(e => e.Producing).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.ProspectId).HasColumnName("Prospect_ID");

                entity.Property(e => e.RowId).HasColumnName("ROW_ID");

                entity.Property(e => e.RoyaltyGas)
                    .HasColumnName("Royalty_Gas")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.RoyaltyOil)
                    .HasColumnName("Royalty_Oil")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ShutInPerAcre)
                    .HasColumnName("Shut_In_Per_Acre")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.StateId).HasColumnName("State_ID");

                entity.Property(e => e.StatusOfLease).HasColumnName("Status_Of_Lease");

                entity.Property(e => e.SuaDate)
                    .HasColumnName("SUA_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SuaId).HasColumnName("SUA_ID");

                entity.Property(e => e.SuaLegalDescription).HasColumnName("SUA_Legal_Description");

                entity.Property(e => e.SuaNotes).HasColumnName("SUA_Notes");

                entity.Property(e => e.SuaTotalBonus)
                    .HasColumnName("SUA_Total_Bonus")
                    .HasColumnType("money");

                entity.Property(e => e.SuaTotalRental)
                    .HasColumnName("SUA_Total_Rental")
                    .HasColumnType("money");

                entity.Property(e => e.SubsidenceInterest)
                    .HasColumnName("Subsidence_Interest")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.SurfaceInterest)
                    .HasColumnName("Surface_Interest")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.SuspenseCode).HasColumnName("Suspense_Code");

                entity.Property(e => e.TenureCode).HasColumnName("Tenure_Code");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.TractDeveloped)
                    .HasColumnName("Tract_Developed")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.TractId).HasColumnName("Tract_ID");

                entity.Property(e => e.TractNonProducing)
                    .HasColumnName("Tract_Non_Producing")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.TractOther)
                    .HasColumnName("Tract_Other")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.TractOutside)
                    .HasColumnName("Tract_Outside")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.TractOwnerPk).HasColumnName("TractOwnerPK");

                entity.Property(e => e.TractProducing)
                    .HasColumnName("Tract_Producing")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.TractTotal)
                    .HasColumnName("Tract_Total")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.TractType).HasColumnName("Tract_Type");

                entity.Property(e => e.TractUndeveloped)
                    .HasColumnName("Tract_Undeveloped")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.TwnSurvey).HasColumnName("Twn_Survey");

                entity.Property(e => e.Undeveloped).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.WellIdNo).HasColumnName("Well_ID_No");

                entity.Property(e => e._3rdPartyEffectiveDate)
                    .HasColumnName("3rd_Party_Effective_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e._3rdPartyExpirationDate)
                    .HasColumnName("3rd_Party_Expiration_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e._3rdPartyLesseeId).HasColumnName("3rd_Party_Lessee_ID");
            });

            modelBuilder.Entity<SurveyTwnRngSecMasterMain>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Acreage).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.AreaName).HasColumnName("Area_Name");

                entity.Property(e => e.CountyId).HasColumnName("County_ID");

                entity.Property(e => e.IdNumber).HasColumnName("ID_Number");

                entity.Property(e => e.LotNumber).HasColumnName("Lot_Number");

                entity.Property(e => e.OffshoreBlock).HasColumnName("Offshore_Block");

                entity.Property(e => e.ParcelName).HasColumnName("Parcel_Name");

                entity.Property(e => e.StateId)
                    .HasColumnName("State_ID")
                    .HasMaxLength(450);

                entity.Property(e => e.SurveyName).HasColumnName("Survey_Name");

                entity.Property(e => e.TownshipName).HasColumnName("Township_Name");

                entity.Property(e => e.TypeOfLand).HasColumnName("Type_of_Land");

                entity.Property(e => e.XCoordinate)
                    .HasColumnName("X_Coordinate")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.YCoordinate)
                    .HasColumnName("Y_Coordinate")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ZCoordinate)
                    .HasColumnName("Z_Coordinate")
                    .HasColumnType("decimal(18, 8)");
            });

            modelBuilder.Entity<TractDeedRefForm>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TractLeasedStatus).HasColumnName("Tract_Leased_Status");
            });

            modelBuilder.Entity<TractMainForm>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AllDepths).HasColumnName("All_Depths");

                entity.Property(e => e.BaseLineId).HasColumnName("BaseLine_ID");

                entity.Property(e => e.BasinId).HasColumnName("Basin_ID");

                entity.Property(e => e.BeginningDepth).HasColumnName("Beginning_Depth");

                entity.Property(e => e.CountyId).HasColumnName("County_ID");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeedRef1).HasColumnName("Deed_Ref1");

                entity.Property(e => e.DeedRef2).HasColumnName("Deed_Ref2");

                entity.Property(e => e.DeedRef3).HasColumnName("Deed_Ref3");

                entity.Property(e => e.DeedRef4).HasColumnName("Deed_Ref4");

                entity.Property(e => e.DepthNotes).HasColumnName("Depth_Notes");

                entity.Property(e => e.Developed).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.DistrictId).HasColumnName("District_ID");

                entity.Property(e => e.EndingDepth).HasColumnName("Ending_Depth");

                entity.Property(e => e.Field1).HasColumnName("Field_1");

                entity.Property(e => e.Field2).HasColumnName("Field_2");

                entity.Property(e => e.Field3).HasColumnName("Field_3");

                entity.Property(e => e.Field4).HasColumnName("Field_4");

                entity.Property(e => e.FormationCode).HasColumnName("Formation_Code");

                entity.Property(e => e.FullDescription).HasColumnName("Full_Description");

                entity.Property(e => e.IncludeInDistrictAcreageTotals).HasColumnName("Include_In_District_Acreage_Totals");

                entity.Property(e => e.IncludeInGrandTotals).HasColumnName("Include_In_Grand_Totals");

                entity.Property(e => e.IncludeInLeaseAcreageTotals).HasColumnName("Include_In_Lease_Acreage_Totals");

                entity.Property(e => e.IncludeInPropertyAcreageTotals).HasColumnName("Include_In_Property_Acreage_Totals");

                entity.Property(e => e.IncludeInProspectAcreageTotals).HasColumnName("Include_In_Prospect_Acreage_Totals");

                entity.Property(e => e.IncludeInStateCountyAcreageTotals).HasColumnName("Include_In_State_County_Acreage_Totals");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.NetAcres)
                    .HasColumnName("Net_Acres")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.OkToPay).HasColumnName("OK_to_Pay");

                entity.Property(e => e.Other).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.Outside).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.OwnerId).HasColumnName("Owner_ID");

                entity.Property(e => e.PlatRef1).HasColumnName("Plat_Ref1");

                entity.Property(e => e.PlatRef2).HasColumnName("Plat_Ref2");

                entity.Property(e => e.PlatRef3).HasColumnName("Plat_Ref3");

                entity.Property(e => e.PlatRef4).HasColumnName("Plat_Ref4");

                entity.Property(e => e.ProspectId).HasColumnName("Prospect_ID");

                entity.Property(e => e.RegionId).HasColumnName("Region_ID");

                entity.Property(e => e.SeeAlsoTractId).HasColumnName("See_Also_Tract_ID");

                entity.Property(e => e.ShortDescription).HasColumnName("Short_Description");

                entity.Property(e => e.SpecialProvisionsNotes).HasColumnName("Special_Provisions_Notes");

                entity.Property(e => e.StateId).HasColumnName("State_ID");

                entity.Property(e => e.TaxId).HasColumnName("Tax_ID");

                entity.Property(e => e.TobinId).HasColumnName("Tobin_ID");

                entity.Property(e => e.TotalAcreage)
                    .HasColumnName("Total_Acreage")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.TractId).HasColumnName("Tract_ID");

                entity.Property(e => e.TractLeasedStatus).HasColumnName("Tract_Leased_Status");

                entity.Property(e => e.TractNameMemo).HasColumnName("Tract_Name_Memo");

                entity.Property(e => e.TractNameShort).HasColumnName("Tract_Name_Short");

                entity.Property(e => e.TractOwnerPk).HasColumnName("TractOwnerPK");

                entity.Property(e => e.TractStatus).HasColumnName("Tract_Status");

                entity.Property(e => e.TractType).HasColumnName("Tract_Type");

                entity.Property(e => e.TwnRngSecPk).HasColumnName("TwnRngSecPK");

                entity.Property(e => e.Undeveloped).HasColumnType("decimal(18, 8)");
            });

            modelBuilder.Entity<TractOwnership>(entity =>
            {
                entity.ToTable("Tract_Ownership");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BeginningDepth).HasColumnName("Beginning_Depth");

                entity.Property(e => e.BookPage).HasColumnName("Book_Page");

                entity.Property(e => e.CountyId).HasColumnName("County_ID");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.DepthNotes).HasColumnName("Depth_Notes");

                entity.Property(e => e.Developed).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnName("Effective_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndingDepth).HasColumnName("Ending_Depth");

                entity.Property(e => e.ExpireDate)
                    .HasColumnName("Expire_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FileDate)
                    .HasColumnName("File_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FormationType).HasColumnName("Formation_Type");

                entity.Property(e => e.FullName).HasColumnName("Full_Name");

                entity.Property(e => e.LeaseDate)
                    .HasColumnName("Lease_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LeaseId).HasColumnName("Lease_ID");

                entity.Property(e => e.LeaseNotes).HasColumnName("Lease_Notes");

                entity.Property(e => e.LeaseTotalBonus)
                    .HasColumnName("Lease_Total_Bonus")
                    .HasColumnType("money");

                entity.Property(e => e.LeaseTotalRental)
                    .HasColumnName("Lease_Total_Rental")
                    .HasColumnType("money");

                entity.Property(e => e.LegalDescription).HasColumnName("Legal_Description");

                entity.Property(e => e.MineralInterest)
                    .HasColumnName("Mineral_Interest")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.MoId).HasColumnName("MO_ID");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.NetAcreage)
                    .HasColumnName("Net_Acreage")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NoExecutiveRights).HasColumnName("NO_Executive_Rights");

                entity.Property(e => e.NonProducing)
                    .HasColumnName("Non_Producing")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NpriGas)
                    .HasColumnName("NPRI_Gas")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NpriOil)
                    .HasColumnName("NPRI_Oil")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.OptionToExtend).HasColumnName("Option_to_Extend");

                entity.Property(e => e.OrriGas)
                    .HasColumnName("ORRI_Gas")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.OrriOil)
                    .HasColumnName("ORRI_Oil")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.Other).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.OtherInterest)
                    .HasColumnName("Other_Interest")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.Outside).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.OwnerId).HasColumnName("Owner_ID");

                entity.Property(e => e.Producing).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.ProspectId).HasColumnName("Prospect_ID");

                entity.Property(e => e.RoyaltyGas)
                    .HasColumnName("Royalty_Gas")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.RoyaltyOil)
                    .HasColumnName("Royalty_Oil")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ShutInPerAcre)
                    .HasColumnName("Shut_In_Per_Acre")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.StateId).HasColumnName("State_ID");

                entity.Property(e => e.StatusOfLease).HasColumnName("Status_Of_Lease");

                entity.Property(e => e.SubsidenceInterest)
                    .HasColumnName("Subsidence_Interest")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.SurfaceInterest)
                    .HasColumnName("Surface_Interest")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.SuspenseCode).HasColumnName("Suspense_Code");

                entity.Property(e => e.TenureCode).HasColumnName("Tenure_Code");

                entity.Property(e => e.ToId).HasColumnName("TO_ID");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.TractDeveloped)
                    .HasColumnName("Tract_Developed")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.TractId).HasColumnName("Tract_ID");

                entity.Property(e => e.TractNonProducing)
                    .HasColumnName("Tract_Non_Producing")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.TractOther)
                    .HasColumnName("Tract_Other")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.TractOutside)
                    .HasColumnName("Tract_Outside")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.TractOwnerPk).HasColumnName("TractOwnerPK");

                entity.Property(e => e.TractProducing)
                    .HasColumnName("Tract_Producing")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.TractTotal)
                    .HasColumnName("Tract_Total")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.TractType).HasColumnName("Tract_Type");

                entity.Property(e => e.TractUndeveloped)
                    .HasColumnName("Tract_Undeveloped")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.TwnSurvey).HasColumnName("Twn_Survey");

                entity.Property(e => e.Undeveloped).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.WellIdNo).HasColumnName("Well_ID_No");

                entity.Property(e => e._3rdPartyEffectiveDate)
                    .HasColumnName("3rd_Party_Effective_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e._3rdPartyExpirationDate)
                    .HasColumnName("3rd_Party_Expiration_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e._3rdPartyLesseeId).HasColumnName("3rd_Party_Lessee_ID");
            });

            modelBuilder.Entity<TractsEasementConnection>(entity =>
            {
                entity.ToTable("Tracts_EasementConnection");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.DevTractId).HasColumnName("Dev_Tract_ID");

                entity.Property(e => e.DevelopedAcreage)
                    .HasColumnName("Developed_Acreage")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.EasementId).HasColumnName("Easement_ID");

                entity.Property(e => e.FullDescription).HasColumnName("Full_Description");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.OtherAcreage)
                    .HasColumnName("Other_Acreage")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.OutsideAcreage)
                    .HasColumnName("Outside_Acreage")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ShortDescription).HasColumnName("Short_Description");

                entity.Property(e => e.TotalAcreage)
                    .HasColumnName("Total_Acreage")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.TotalDeveloped)
                    .HasColumnName("Total_Developed")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.TractId).HasColumnName("Tract_ID");

                entity.Property(e => e.TractMainId).HasColumnName("TractMainID");

                entity.Property(e => e.TractOwnerPk).HasColumnName("TractOwnerPK");

                entity.Property(e => e.TractType).HasColumnName("Tract_Type");

                entity.Property(e => e.UndevelopedAcreage)
                    .HasColumnName("Undeveloped_Acreage")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.UnitId).HasColumnName("Unit_ID");

                entity.Property(e => e.WellId).HasColumnName("Well_ID");
            });

            modelBuilder.Entity<TractsLeaseConnection>(entity =>
            {
                entity.ToTable("Tracts_LeaseConnection");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.DevTractId).HasColumnName("Dev_Tract_ID");

                entity.Property(e => e.DevelopedAcreage)
                    .HasColumnName("Developed_Acreage")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.FullDescription).HasColumnName("Full_Description");

                entity.Property(e => e.LeaseId).HasColumnName("Lease_ID");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.OtherAcreage)
                    .HasColumnName("Other_Acreage")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.OutsideAcreage)
                    .HasColumnName("Outside_Acreage")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ShortDescription).HasColumnName("Short_Description");

                entity.Property(e => e.TotalAcreage)
                    .HasColumnName("Total_Acreage")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.TotalDeveloped)
                    .HasColumnName("Total_Developed")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.TractId).HasColumnName("Tract_ID");

                entity.Property(e => e.TractMainId).HasColumnName("TractMainID");

                entity.Property(e => e.TractOwnerPk).HasColumnName("TractOwnerPK");

                entity.Property(e => e.TractType).HasColumnName("Tract_Type");

                entity.Property(e => e.UndevelopedAcreage)
                    .HasColumnName("Undeveloped_Acreage")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.UnitId).HasColumnName("Unit_ID");

                entity.Property(e => e.WellId).HasColumnName("Well_ID");
            });

            modelBuilder.Entity<TractsRowconnection>(entity =>
            {
                entity.ToTable("Tracts_ROWConnection");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.DevTractId).HasColumnName("Dev_Tract_ID");

                entity.Property(e => e.DevelopedAcreage)
                    .HasColumnName("Developed_Acreage")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.FullDescription).HasColumnName("Full_Description");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.OtherAcreage)
                    .HasColumnName("Other_Acreage")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.OutsideAcreage)
                    .HasColumnName("Outside_Acreage")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.RowId).HasColumnName("ROW_ID");

                entity.Property(e => e.ShortDescription).HasColumnName("Short_Description");

                entity.Property(e => e.TotalAcreage)
                    .HasColumnName("Total_Acreage")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.TotalDeveloped)
                    .HasColumnName("Total_Developed")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.TractId).HasColumnName("Tract_ID");

                entity.Property(e => e.TractMainId).HasColumnName("TractMainID");

                entity.Property(e => e.TractOwnerPk).HasColumnName("TractOwnerPK");

                entity.Property(e => e.TractType).HasColumnName("Tract_Type");

                entity.Property(e => e.UndevelopedAcreage)
                    .HasColumnName("Undeveloped_Acreage")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.UnitId).HasColumnName("Unit_ID");

                entity.Property(e => e.WellId).HasColumnName("Well_ID");
            });

            modelBuilder.Entity<TractsSuaconnection>(entity =>
            {
                entity.ToTable("Tracts_SUAConnection");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.DevTractId).HasColumnName("Dev_Tract_ID");

                entity.Property(e => e.DevelopedAcreage)
                    .HasColumnName("Developed_Acreage")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.FullDescription).HasColumnName("Full_Description");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.OtherAcreage)
                    .HasColumnName("Other_Acreage")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.OutsideAcreage)
                    .HasColumnName("Outside_Acreage")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ShortDescription).HasColumnName("Short_Description");

                entity.Property(e => e.SuaId).HasColumnName("SUA_ID");

                entity.Property(e => e.TotalAcreage)
                    .HasColumnName("Total_Acreage")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.TotalDeveloped)
                    .HasColumnName("Total_Developed")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.TractId).HasColumnName("Tract_ID");

                entity.Property(e => e.TractMainId).HasColumnName("TractMainID");

                entity.Property(e => e.TractOwnerPk).HasColumnName("TractOwnerPK");

                entity.Property(e => e.TractType).HasColumnName("Tract_Type");

                entity.Property(e => e.UndevelopedAcreage)
                    .HasColumnName("Undeveloped_Acreage")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.UnitId).HasColumnName("Unit_ID");

                entity.Property(e => e.WellId).HasColumnName("Well_ID");
            });

            modelBuilder.Entity<TwnRngSecCrossRefs>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GrossAcres)
                    .HasColumnName("Gross_Acres")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.GrossDevelop)
                    .HasColumnName("Gross_Develop")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.GrossDevelopOverlap)
                    .HasColumnName("Gross_Develop_OVerlap")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.GrossOverlap)
                    .HasColumnName("Gross_Overlap")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.IncludeInTrsCalc).HasColumnName("Include_in_TRS_Calc");

                entity.Property(e => e.LeaseId).HasColumnName("Lease_ID");

                entity.Property(e => e.NetAcres)
                    .HasColumnName("Net_Acres")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NetDeveloped)
                    .HasColumnName("Net_Developed")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.PropertyType).HasColumnName("Property_Type");

                entity.Property(e => e.ShortComment).HasColumnName("Short_Comment");

                entity.Property(e => e.SubTractId).HasColumnName("SubTract_ID");

                entity.Property(e => e.TractId).HasColumnName("Tract_ID");

                entity.Property(e => e.TwnRngId).HasColumnName("TwnRng_ID");

                entity.Property(e => e.WellId).HasColumnName("Well_ID");
            });

            modelBuilder.Entity<UnitInterestsForm>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcquiredFrom).HasColumnName("Acquired_From");

                entity.Property(e => e.CurrentOperator).HasColumnName("Current_Operator");

                entity.Property(e => e.InterestDescription).HasColumnName("Interest_Description");

                entity.Property(e => e.PreviousOperator).HasColumnName("Previous_Operator");

                entity.Property(e => e.ResponsibleParty).HasColumnName("Responsible_Party");

                entity.Property(e => e.SoldTo).HasColumnName("Sold_To");
            });

            modelBuilder.Entity<UnitLegalForm>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AreaName).HasColumnName("Area_Name");

                entity.Property(e => e.CountyId).HasColumnName("County_ID");

                entity.Property(e => e.CountyId2).HasColumnName("County_ID_2");

                entity.Property(e => e.LocationNotes).HasColumnName("Location_Notes");

                entity.Property(e => e.PerforationInformation).HasColumnName("Perforation_Information");

                entity.Property(e => e.PoolName).HasColumnName("Pool_Name");

                entity.Property(e => e.StateId).HasColumnName("State_ID");

                entity.Property(e => e.StateId2).HasColumnName("State_ID_2");

                entity.Property(e => e.SurveyTwnRng).HasColumnName("Survey_Twn_Rng");

                entity.Property(e => e.UnitLegalDescription).HasColumnName("Unit_Legal_Description");

                entity.Property(e => e.XCoord)
                    .HasColumnName("X_Coord")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.YCoord)
                    .HasColumnName("Y_Coord")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ZCoord)
                    .HasColumnName("Z_Coord")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<UnitMainForm>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcquisitionCode).HasColumnName("Acquisition_Code");

                entity.Property(e => e.Acres).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ApiNumber).HasColumnName("API_Number");

                entity.Property(e => e.DepthInFeet).HasColumnName("Depth_In_Feet");

                entity.Property(e => e.DistrictId).HasColumnName("District_ID");

                entity.Property(e => e.OkToPay).HasColumnName("OK_to_Pay");

                entity.Property(e => e.PayoutCode).HasColumnName("Payout_Code");

                entity.Property(e => e.ProspectId).HasColumnName("Prospect_ID");

                entity.Property(e => e.RegionId).HasColumnName("Region_ID");

                entity.Property(e => e.SplitStream).HasColumnName("Split_Stream");

                entity.Property(e => e.StateUnitId).HasColumnName("State_Unit_ID");

                entity.Property(e => e.UnitId).HasColumnName("Unit_ID");

                entity.Property(e => e.UnitName).HasColumnName("Unit_Name");

                entity.Property(e => e.UnitStatus).HasColumnName("Unit_Status");

                entity.Property(e => e.UnitType).HasColumnName("Unit_Type");
            });

            modelBuilder.Entity<UnitMoreForm>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcquiredDate).HasColumnName("Acquired_Date");

                entity.Property(e => e.CompletionDate).HasColumnName("Completion_Date");

                entity.Property(e => e.DateOnLine).HasColumnName("Date_On_Line");

                entity.Property(e => e.DateSold).HasColumnName("Date_Sold");

                entity.Property(e => e.OtherDate1).HasColumnName("Other_Date_1");

                entity.Property(e => e.OtherDate2).HasColumnName("Other_Date_2");

                entity.Property(e => e.PayoutDate1).HasColumnName("Payout_Date_1");

                entity.Property(e => e.PayoutDate2).HasColumnName("Payout_Date_2");

                entity.Property(e => e.PayoutDate3).HasColumnName("Payout_Date_3");

                entity.Property(e => e.PayoutDate4).HasColumnName("Payout_Date_4");

                entity.Property(e => e.PluggedDate).HasColumnName("Plugged_Date");

                entity.Property(e => e.RecordingInformation).HasColumnName("Recording_Information");

                entity.Property(e => e.ShutInDate).HasColumnName("Shut_In_Date");

                entity.Property(e => e.SpudDate).HasColumnName("Spud_Date");
            });

            modelBuilder.Entity<UnitOtherForm>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Field1).HasColumnName("Field_1");

                entity.Property(e => e.Field2).HasColumnName("Field_2");

                entity.Property(e => e.Field3).HasColumnName("Field_3");

                entity.Property(e => e.Field4).HasColumnName("Field_4");

                entity.Property(e => e.SpecialProvisionNotes).HasColumnName("Special_Provision_Notes");
            });

            modelBuilder.Entity<WellEasementConnection>(entity =>
            {
                entity.ToTable("Well_EasementConnection");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.EasementId).HasColumnName("Easement_ID");

                entity.Property(e => e.EasementLegalDescription).HasColumnName("Easement_Legal_Description");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnName("Effective_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExpirationDate)
                    .HasColumnName("Expiration_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.GrossAcres)
                    .HasColumnName("Gross_Acres")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.NetAcres)
                    .HasColumnName("Net_Acres")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.PrimaryTerm).HasColumnName("Primary_Term");

                entity.Property(e => e.TractOwnerPk).HasColumnName("TractOwnerPK");

                entity.Property(e => e.WellId).HasColumnName("Well_ID");
            });

            modelBuilder.Entity<WellLeaseConnection>(entity =>
            {
                entity.ToTable("Well_LeaseConnection");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnName("Effective_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExpirationDate)
                    .HasColumnName("Expiration_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.GrossAcres)
                    .HasColumnName("Gross_Acres")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.LeaseId).HasColumnName("Lease_ID");

                entity.Property(e => e.LeaseLegalDescription).HasColumnName("Lease_Legal_Description");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.NetAcres)
                    .HasColumnName("Net_Acres")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.PrimaryTerm).HasColumnName("Primary_Term");

                entity.Property(e => e.TractOwnerPk).HasColumnName("TractOwnerPK");

                entity.Property(e => e.WellId).HasColumnName("Well_ID");
            });

            modelBuilder.Entity<WellMainForm2>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcquiredFrom).HasColumnName("Acquired_From");

                entity.Property(e => e.AcquisitionCode).HasColumnName("Acquisition_Code");

                entity.Property(e => e.AcreageStatus).HasColumnName("Acreage_Status");

                entity.Property(e => e.AcreageType).HasColumnName("Acreage_Type");

                entity.Property(e => e.Api).HasColumnName("API");

                entity.Property(e => e.AquiredFrom).HasColumnName("Aquired_From");

                entity.Property(e => e.AreaName).HasColumnName("Area_Name");

                entity.Property(e => e.BasinId).HasColumnName("Basin_ID");

                entity.Property(e => e.CountyId).HasColumnName("County_ID");

                entity.Property(e => e.CountyId2).HasColumnName("County_ID_2");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.CurrentOperator).HasColumnName("Current_Operator");

                entity.Property(e => e.DateAcquired).HasColumnName("Date_Acquired");

                entity.Property(e => e.DateOnLine).HasColumnName("Date_On_Line");

                entity.Property(e => e.DateSold).HasColumnName("Date_Sold");

                entity.Property(e => e.DateTd).HasColumnName("Date_TD");

                entity.Property(e => e.DateTested).HasColumnName("Date_Tested");

                entity.Property(e => e.DistrictId).HasColumnName("District_ID");

                entity.Property(e => e.EntityNri1)
                    .HasColumnName("Entity_NRI_1")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.EntityNri2)
                    .HasColumnName("Entity_NRI_2")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.EntityNri3)
                    .HasColumnName("Entity_NRI_3")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.EntityNri4)
                    .HasColumnName("Entity_NRI_4")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.EntityNri5)
                    .HasColumnName("Entity_NRI_5")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.EntityNri6)
                    .HasColumnName("Entity_NRI_6")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.EntityOrri1)
                    .HasColumnName("Entity_ORRI_1")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.EntityOrri2)
                    .HasColumnName("Entity_ORRI_2")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.EntityOrri3)
                    .HasColumnName("Entity_ORRI_3")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.EntityOrri4)
                    .HasColumnName("Entity_ORRI_4")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.EntityOrri5)
                    .HasColumnName("Entity_ORRI_5")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.EntityOrri6)
                    .HasColumnName("Entity_ORRI_6")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.EntityOther1)
                    .HasColumnName("Entity_Other_1")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.EntityOther2)
                    .HasColumnName("Entity_Other_2")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.EntityOther3)
                    .HasColumnName("Entity_Other_3")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.EntityOther4)
                    .HasColumnName("Entity_Other_4")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.EntityOther5)
                    .HasColumnName("Entity_Other_5")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.EntityOther6)
                    .HasColumnName("Entity_Other_6")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.EntityRoyalty1)
                    .HasColumnName("Entity_Royalty_1")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.EntityRoyalty2)
                    .HasColumnName("Entity_Royalty_2")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.EntityRoyalty3)
                    .HasColumnName("Entity_Royalty_3")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.EntityRoyalty4)
                    .HasColumnName("Entity_Royalty_4")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.EntityRoyalty5)
                    .HasColumnName("Entity_Royalty_5")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.EntityRoyalty6)
                    .HasColumnName("Entity_Royalty_6")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.EntityWi1)
                    .HasColumnName("Entity_WI_1")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.EntityWi2)
                    .HasColumnName("Entity_WI_2")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.EntityWi3)
                    .HasColumnName("Entity_WI_3")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.EntityWi4)
                    .HasColumnName("Entity_WI_4")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.EntityWi5)
                    .HasColumnName("Entity_WI_5")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.EntityWi6)
                    .HasColumnName("Entity_WI_6")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.Field1).HasColumnName("Field_1");

                entity.Property(e => e.Field2).HasColumnName("Field_2");

                entity.Property(e => e.Field3).HasColumnName("Field_3");

                entity.Property(e => e.Field4).HasColumnName("Field_4");

                entity.Property(e => e.FirstSalesDate).HasColumnName("First_Sales_Date");

                entity.Property(e => e.FormationCode).HasColumnName("Formation_Code");

                entity.Property(e => e.FracDate)
                    .HasColumnName("Frac_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Interest1Title).HasColumnName("Interest_1_Title");

                entity.Property(e => e.Interest2Title).HasColumnName("Interest_2_Title");

                entity.Property(e => e.Interest3Title).HasColumnName("Interest_3_Title");

                entity.Property(e => e.Interest4Title).HasColumnName("Interest_4_Title");

                entity.Property(e => e.Interest5Title).HasColumnName("Interest_5_Title");

                entity.Property(e => e.Interest6Title).HasColumnName("Interest_6_Title");

                entity.Property(e => e.InterestDescription).HasColumnName("Interest_Description");

                entity.Property(e => e.LastFracDate).HasColumnName("Last_Frac_Date");

                entity.Property(e => e.LastShutIn).HasColumnName("Last_Shut_In");

                entity.Property(e => e.LegalDescription).HasColumnName("Legal_Description");

                entity.Property(e => e.LocationNotes).HasColumnName("Location_Notes");

                entity.Property(e => e.Meter1).HasColumnName("Meter_1");

                entity.Property(e => e.Meter2).HasColumnName("Meter_2");

                entity.Property(e => e.Meter3).HasColumnName("Meter_3");

                entity.Property(e => e.Meter4).HasColumnName("Meter_4");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.OkToPay).HasColumnName("OK_to_Pay");

                entity.Property(e => e.OperWellId).HasColumnName("Oper_Well_ID");

                entity.Property(e => e.OriginalIdNo).HasColumnName("Original_ID_No");

                entity.Property(e => e.OtherDate).HasColumnName("Other_Date");

                entity.Property(e => e.OtherDate2).HasColumnName("Other_Date_2");

                entity.Property(e => e.Payout1).HasColumnName("Payout_1");

                entity.Property(e => e.Payout2).HasColumnName("Payout_2");

                entity.Property(e => e.Payout3).HasColumnName("Payout_3");

                entity.Property(e => e.Payout4).HasColumnName("Payout_4");

                entity.Property(e => e.PayoutCode).HasColumnName("Payout_Code");

                entity.Property(e => e.PermitEffective).HasColumnName("Permit_Effective");

                entity.Property(e => e.PermitExpire).HasColumnName("Permit_Expire");

                entity.Property(e => e.PermitNo).HasColumnName("Permit_No");

                entity.Property(e => e.PluggedDate).HasColumnName("Plugged_Date");

                entity.Property(e => e.PoolName).HasColumnName("Pool_Name");

                entity.Property(e => e.PreviousOperator).HasColumnName("Previous_Operator");

                entity.Property(e => e.ProducingFrom).HasColumnName("Producing_From");

                entity.Property(e => e.ProspectId).HasColumnName("Prospect_ID");

                entity.Property(e => e.PurchaserNotes).HasColumnName("Purchaser_Notes");

                entity.Property(e => e.PurchasersInformation).HasColumnName("Purchasers_Information");

                entity.Property(e => e.RecordingInformation).HasColumnName("Recording_Information");

                entity.Property(e => e.RegionId).HasColumnName("Region_ID");

                entity.Property(e => e.ResponsibleParty).HasColumnName("Responsible_Party");

                entity.Property(e => e.RigReleased).HasColumnName("Rig_Released");

                entity.Property(e => e.RrcId).HasColumnName("RRC_ID");

                entity.Property(e => e.SoldTo).HasColumnName("Sold_To");

                entity.Property(e => e.SpecialProvisionNotes).HasColumnName("Special_Provision_Notes");

                entity.Property(e => e.SpiltStream).HasColumnName("Spilt_Stream");

                entity.Property(e => e.SpudDate).HasColumnName("Spud_Date");

                entity.Property(e => e.StateId).HasColumnName("State_ID");

                entity.Property(e => e.StateId2).HasColumnName("State_ID_2");

                entity.Property(e => e.SurveyTwnRng).HasColumnName("Survey_Twn_Rng");

                entity.Property(e => e.TankBattery).HasColumnName("Tank_Battery");

                entity.Property(e => e.TotalDepthFeet)
                    .HasColumnName("Total_Depth_Feet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TractId).HasColumnName("Tract_ID");

                entity.Property(e => e.TractOwnerPk)
                    .HasColumnName("TractOwnerPK")
                    .HasMaxLength(1);

                entity.Property(e => e.WellAcreage)
                    .HasColumnName("Well_Acreage")
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.WellIdNo).HasColumnName("Well_ID_No");

                entity.Property(e => e.WellLegalDescription).HasColumnName("Well_Legal_Description");

                entity.Property(e => e.WellName).HasColumnName("Well_Name");

                entity.Property(e => e.WellStatus).HasColumnName("Well_Status");

                entity.Property(e => e.WellType).HasColumnName("Well_Type");

                entity.Property(e => e.XCoord)
                    .HasColumnName("X_Coord")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.YCoord)
                    .HasColumnName("Y_Coord")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ZCoord)
                    .HasColumnName("Z_Coord")
                    .HasColumnType("decimal(18, 8)");
            });

            modelBuilder.Entity<WellRowconnection>(entity =>
            {
                entity.ToTable("Well_ROWConnection");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnName("Effective_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExpirationDate)
                    .HasColumnName("Expiration_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.GrossAcres)
                    .HasColumnName("Gross_Acres")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.NetAcres)
                    .HasColumnName("Net_Acres")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.PrimaryTerm).HasColumnName("Primary_Term");

                entity.Property(e => e.RowId).HasColumnName("ROW_ID");

                entity.Property(e => e.RowLegalDescription).HasColumnName("ROW_LEgal_Description");

                entity.Property(e => e.TractOwnerPk).HasColumnName("TractOwnerPK");

                entity.Property(e => e.WellId).HasColumnName("Well_ID");
            });

            modelBuilder.Entity<WellSuaconnection>(entity =>
            {
                entity.ToTable("Well_SUAConnection");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnName("Effective_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExpirationDate)
                    .HasColumnName("Expiration_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.GrossAcres)
                    .HasColumnName("Gross_Acres")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.NetAcres)
                    .HasColumnName("Net_Acres")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.PrimaryTerm).HasColumnName("Primary_Term");

                entity.Property(e => e.SuaId).HasColumnName("SUA_ID");

                entity.Property(e => e.SuaLegalDescription).HasColumnName("SUA_Legal_Description");

                entity.Property(e => e.TractOwnerPk).HasColumnName("TractOwnerPK");

                entity.Property(e => e.WellId).HasColumnName("Well_ID");
            });

            modelBuilder.Entity<WellTractsConnection>(entity =>
            {
                entity.ToTable("Well_TractsConnection");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.DevTractId).HasColumnName("Dev_Tract_ID");

                entity.Property(e => e.DevelopedAcreage)
                    .HasColumnName("Developed_Acreage")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.FullDescription).HasColumnName("Full_Description");

                entity.Property(e => e.LeaseId).HasColumnName("Lease_ID");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.OtherAcreage)
                    .HasColumnName("Other_Acreage")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.OutsideAcreage)
                    .HasColumnName("Outside_Acreage")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ShortDescription).HasColumnName("Short_Description");

                entity.Property(e => e.TotalAcreage)
                    .HasColumnName("Total_Acreage")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.TotalDeveloped)
                    .HasColumnName("Total_Developed")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.TractId).HasColumnName("Tract_ID");

                entity.Property(e => e.TractMainId).HasColumnName("TractMainID");

                entity.Property(e => e.TractOwnerPk).HasColumnName("TractOwnerPK");

                entity.Property(e => e.TractType).HasColumnName("Tract_Type");

                entity.Property(e => e.UndevelopedAcreage)
                    .HasColumnName("Undeveloped_Acreage")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.UnitId).HasColumnName("Unit_ID");

                entity.Property(e => e.WellId).HasColumnName("Well_ID");
            });

            modelBuilder.Entity<WideckDetails>(entity =>
            {
                entity.ToTable("WIDeckDetails");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Effective).HasColumnType("date");

                entity.Property(e => e.Expire).HasColumnType("date");

                entity.Property(e => e.InterestFormula).HasColumnName("Interest_Formula");

                entity.Property(e => e.InterestType).HasColumnName("Interest_Type");

                entity.Property(e => e.LeaseId).HasColumnName("Lease_ID");

                entity.Property(e => e.OwnerId).HasColumnName("Owner_ID");

                entity.Property(e => e.SendReports).HasColumnName("Send_Reports");

                entity.Property(e => e.TractId).HasColumnName("Tract_ID");

                entity.Property(e => e.WellId).HasColumnName("Well_ID");
            });

            modelBuilder.Entity<WideckInterest>(entity =>
            {
                entity.ToTable("WIDeckInterest");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeckId).HasColumnName("Deck_ID");

                entity.Property(e => e.DeckName).HasColumnName("Deck_Name");

                entity.Property(e => e.EasementId).HasColumnName("Easement_ID");

                entity.Property(e => e.Effective).HasColumnType("date");

                entity.Property(e => e.Expire).HasColumnType("date");

                entity.Property(e => e.Interest).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.InterestFormula).HasColumnName("Interest_Formula");

                entity.Property(e => e.InterestType).HasColumnName("Interest_Type");

                entity.Property(e => e.LeaseId).HasColumnName("Lease_ID");

                entity.Property(e => e.OwnerId).HasColumnName("Owner_ID");

                entity.Property(e => e.RowId).HasColumnName("ROW_ID");

                entity.Property(e => e.SendReports).HasColumnName("Send_Reports");

                entity.Property(e => e.SuaId).HasColumnName("SUA_ID");

                entity.Property(e => e.TractId).HasColumnName("Tract_ID");
            });

            modelBuilder.Entity<WideckMaster>(entity =>
            {
                entity.ToTable("WIDeckMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeckId).HasColumnName("Deck_ID");

                entity.Property(e => e.DeckName).HasColumnName("Deck_Name");

                entity.Property(e => e.DeckPk).HasColumnName("Deck_PK");

                entity.Property(e => e.DeckType).HasColumnName("Deck_Type");

                entity.Property(e => e.EasementId).HasColumnName("Easement_ID");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnName("Effective_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ExpireDate)
                    .HasColumnName("Expire_Date")
                    .HasColumnType("date");

                entity.Property(e => e.LeaseId).HasColumnName("Lease_ID");

                entity.Property(e => e.PayoutCode).HasColumnName("Payout_Code");

                entity.Property(e => e.RowId).HasColumnName("ROW_ID");

                entity.Property(e => e.SuaId).HasColumnName("SUA_ID");

                entity.Property(e => e.SuspenseCode).HasColumnName("Suspense_Code");

                entity.Property(e => e.TractId).HasColumnName("Tract_ID");

                entity.Property(e => e.UseInAcrCalcs).HasColumnName("Use_in_Acr_Calcs");

                entity.Property(e => e.UseInDoiCalcs).HasColumnName("Use_in_DOI_Calcs");

                entity.Property(e => e.UseInPymntCalcs).HasColumnName("Use_in_Pymnt_Calcs");

                entity.Property(e => e.WellId).HasColumnName("Well_ID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
