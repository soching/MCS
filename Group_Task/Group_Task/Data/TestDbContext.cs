using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Group_Task.Models
{
    public partial class TestDbContext : DbContext
    {
        public TestDbContext()
        {
        }

        public TestDbContext(DbContextOptions<TestDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountChart> AccountCharts { get; set; } = null!;
        public virtual DbSet<AllowModifyResult> AllowModifyResults { get; set; } = null!;
        public virtual DbSet<AssignHouse> AssignHouses { get; set; } = null!;
        public virtual DbSet<AssignProject> AssignProjects { get; set; } = null!;
        public virtual DbSet<AssignStaff> AssignStaffs { get; set; } = null!;
        public virtual DbSet<AssignTask> AssignTasks { get; set; } = null!;
        public virtual DbSet<AssignTaskImage> AssignTaskImages { get; set; } = null!;
        public virtual DbSet<Block> Blocks { get; set; } = null!;
        public virtual DbSet<BoQFloor> BoQFloors { get; set; } = null!;
        public virtual DbSet<BoQMaster> BoQMasters { get; set; } = null!;
        public virtual DbSet<BoQTask> BoQTasks { get; set; } = null!;
        public virtual DbSet<BoQTaskDetail> BoQTaskDetails { get; set; } = null!;
        public virtual DbSet<BoQitem> BoQitems { get; set; } = null!;
        public virtual DbSet<Booking> Bookings { get; set; } = null!;
        public virtual DbSet<BookingDetail> BookingDetails { get; set; } = null!;
        public virtual DbSet<BoqDetail> BoqDetails { get; set; } = null!;
        public virtual DbSet<BoqReport> BoqReports { get; set; } = null!;
        public virtual DbSet<BoqWorkingType> BoqWorkingTypes { get; set; } = null!;
        public virtual DbSet<Brand> Brands { get; set; } = null!;
        public virtual DbSet<Building> Buildings { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Classify> Classifies { get; set; } = null!;
        public virtual DbSet<Company> Companies { get; set; } = null!;
        public virtual DbSet<Complain> Complains { get; set; } = null!;
        public virtual DbSet<ConditionBonu> ConditionBonus { get; set; } = null!;
        public virtual DbSet<ConditionPhoto> ConditionPhotos { get; set; } = null!;
        public virtual DbSet<Constructor> Constructors { get; set; } = null!;
        public virtual DbSet<ConstructorV> ConstructorVs { get; set; } = null!;
        public virtual DbSet<Contract> Contracts { get; set; } = null!;
        public virtual DbSet<ContractDetail> ContractDetails { get; set; } = null!;
        public virtual DbSet<CursorTest> CursorTests { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Delay> Delays { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<DepartmentSubMaster> DepartmentSubMasters { get; set; } = null!;
        public virtual DbSet<Design> Designs { get; set; } = null!;
        public virtual DbSet<DesignProgress> DesignProgresses { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<ExceptionBarrel> ExceptionBarrels { get; set; } = null!;
        public virtual DbSet<ExpendHouseType> ExpendHouseTypes { get; set; } = null!;
        public virtual DbSet<Expendmonth> Expendmonths { get; set; } = null!;
        public virtual DbSet<ExpendmonthByWeek> ExpendmonthByWeeks { get; set; } = null!;
        public virtual DbSet<Floor> Floors { get; set; } = null!;
        public virtual DbSet<FollowUp> FollowUps { get; set; } = null!;
        public virtual DbSet<Gldatum> Gldata { get; set; } = null!;
        public virtual DbSet<GroupCon> GroupCons { get; set; } = null!;
        public virtual DbSet<GroupHouseType> GroupHouseTypes { get; set; } = null!;
        public virtual DbSet<GroupPosition> GroupPositions { get; set; } = null!;
        public virtual DbSet<GroupProject> GroupProjects { get; set; } = null!;
        public virtual DbSet<GroupTask> GroupTasks { get; set; } = null!;
        public virtual DbSet<GroupTaskDetail> GroupTaskDetails { get; set; } = null!;
        public virtual DbSet<GroupTaskMaster> GroupTaskMasters { get; set; } = null!;
        public virtual DbSet<HistoryFol> HistoryFols { get; set; } = null!;
        public virtual DbSet<HouseInfo> HouseInfos { get; set; } = null!;
        public virtual DbSet<HouseObject> HouseObjects { get; set; } = null!;
        public virtual DbSet<HousePlan> HousePlans { get; set; } = null!;
        public virtual DbSet<HousePlanLocation> HousePlanLocations { get; set; } = null!;
        public virtual DbSet<HouseType> HouseTypes { get; set; } = null!;
        public virtual DbSet<Invoice> Invoices { get; set; } = null!;
        public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; } = null!;
        public virtual DbSet<Item> Items { get; set; } = null!;
        public virtual DbSet<ItemObject> ItemObjects { get; set; } = null!;
        public virtual DbSet<ItemPlan> ItemPlans { get; set; } = null!;
        public virtual DbSet<ItemPlanLocation> ItemPlanLocations { get; set; } = null!;
        public virtual DbSet<ItemType> ItemTypes { get; set; } = null!;
        public virtual DbSet<ItemUsed> ItemUseds { get; set; } = null!;
        public virtual DbSet<Itemsmaterial> Itemsmaterials { get; set; } = null!;
        public virtual DbSet<Key> Keys { get; set; } = null!;
        public virtual DbSet<Lead> Leads { get; set; } = null!;
        public virtual DbSet<Loa> Loas { get; set; } = null!;
        public virtual DbSet<LoaDetail> LoaDetails { get; set; } = null!;
        public virtual DbSet<LoaReport> LoaReports { get; set; } = null!;
        public virtual DbSet<Loan> Loans { get; set; } = null!;
        public virtual DbSet<LoanDetail> LoanDetails { get; set; } = null!;
        public virtual DbSet<Location> Locations { get; set; } = null!;
        public virtual DbSet<LocationTask> LocationTasks { get; set; } = null!;
        public virtual DbSet<LogRecord> LogRecords { get; set; } = null!;
        public virtual DbSet<LogTime> LogTimes { get; set; } = null!;
        public virtual DbSet<MaterialType> MaterialTypes { get; set; } = null!;
        public virtual DbSet<Measure> Measures { get; set; } = null!;
        public virtual DbSet<Module> Modules { get; set; } = null!;
        public virtual DbSet<MoneyByWeek> MoneyByWeeks { get; set; } = null!;
        public virtual DbSet<MonthlyReward> MonthlyRewards { get; set; } = null!;
        public virtual DbSet<MonthlyRewardDetail> MonthlyRewardDetails { get; set; } = null!;
        public virtual DbSet<OpenScope> OpenScopes { get; set; } = null!;
        public virtual DbSet<PayMonth> PayMonths { get; set; } = null!;
        public virtual DbSet<Payment> Payments { get; set; } = null!;
        public virtual DbSet<PaymentDetail> PaymentDetails { get; set; } = null!;
        public virtual DbSet<PaymentReport> PaymentReports { get; set; } = null!;
        public virtual DbSet<Payroll> Payrolls { get; set; } = null!;
        public virtual DbSet<PayrollBonu> PayrollBonus { get; set; } = null!;
        public virtual DbSet<PenaltyReport> PenaltyReports { get; set; } = null!;
        public virtual DbSet<Performance> Performances { get; set; } = null!;
        public virtual DbSet<Permission> Permissions { get; set; } = null!;
        public virtual DbSet<Pricing> Pricings { get; set; } = null!;
        public virtual DbSet<Problem> Problems { get; set; } = null!;
        public virtual DbSet<ProblemDetail> ProblemDetails { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Profile> Profiles { get; set; } = null!;
        public virtual DbSet<Project> Projects { get; set; } = null!;
        public virtual DbSet<Purchase> Purchases { get; set; } = null!;
        public virtual DbSet<PurchaseDetail> PurchaseDetails { get; set; } = null!;
        public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; } = null!;
        public virtual DbSet<PurchaseOrderList> PurchaseOrderLists { get; set; } = null!;
        public virtual DbSet<PurchaseRequest> PurchaseRequests { get; set; } = null!;
        public virtual DbSet<PurchaseRequestList> PurchaseRequestLists { get; set; } = null!;
        public virtual DbSet<Report> Reports { get; set; } = null!;
        public virtual DbSet<ReportPvcClaim> ReportPvcClaims { get; set; } = null!;
        public virtual DbSet<Result> Results { get; set; } = null!;
        public virtual DbSet<ResultAction> ResultActions { get; set; } = null!;
        public virtual DbSet<ResultHouse> ResultHouses { get; set; } = null!;
        public virtual DbSet<ResultImage> ResultImages { get; set; } = null!;
        public virtual DbSet<ResultMaster> ResultMasters { get; set; } = null!;
        public virtual DbSet<SaleDetail> SaleDetails { get; set; } = null!;
        public virtual DbSet<SaleOrder> SaleOrders { get; set; } = null!;
        public virtual DbSet<Section> Sections { get; set; } = null!;
        public virtual DbSet<Session> Sessions { get; set; } = null!;
        public virtual DbSet<SetColumn> SetColumns { get; set; } = null!;
        public virtual DbSet<SetupFloor> SetupFloors { get; set; } = null!;
        public virtual DbSet<SetupMaster> SetupMasters { get; set; } = null!;
        public virtual DbSet<SetupTask> SetupTasks { get; set; } = null!;
        public virtual DbSet<SetupTaskDetail> SetupTaskDetails { get; set; } = null!;
        public virtual DbSet<Solution> Solutions { get; set; } = null!;
        public virtual DbSet<Subcontractor> Subcontractors { get; set; } = null!;
        public virtual DbSet<Supplier> Suppliers { get; set; } = null!;
        public virtual DbSet<Task> Tasks { get; set; } = null!;
        public virtual DbSet<TaskDetail> TaskDetails { get; set; } = null!;
        public virtual DbSet<TaskMaster> TaskMasters { get; set; } = null!;
        public virtual DbSet<TaskMasterPhoto> TaskMasterPhotos { get; set; } = null!;
        public virtual DbSet<TaskMasterPhotoDetail> TaskMasterPhotoDetails { get; set; } = null!;
        public virtual DbSet<TaskObject> TaskObjects { get; set; } = null!;
        public virtual DbSet<TaskProgress> TaskProgresses { get; set; } = null!;
        public virtual DbSet<TaskType> TaskTypes { get; set; } = null!;
        public virtual DbSet<Track> Tracks { get; set; } = null!;
        public virtual DbSet<Transaction> Transactions { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<VCon> VCons { get; set; } = null!;
        public virtual DbSet<VPosition> VPositions { get; set; } = null!;
        public virtual DbSet<Vendor> Vendors { get; set; } = null!;
        public virtual DbSet<View2> View2s { get; set; } = null!;
        public virtual DbSet<View3> View3s { get; set; } = null!;
        public virtual DbSet<View4> View4s { get; set; } = null!;
        public virtual DbSet<View5> View5s { get; set; } = null!;
        public virtual DbSet<View7> View7s { get; set; } = null!;
        public virtual DbSet<Warehouse> Warehouses { get; set; } = null!;
        public virtual DbSet<Week> Weeks { get; set; } = null!;
        public virtual DbSet<Weekend> Weekends { get; set; } = null!;
        public virtual DbSet<Zone> Zones { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=lb;Database=testdb; user id = soching; pwd=123456789;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AssignTaskImage>(entity =>
            {
                entity.Property(e => e.ImageId).ValueGeneratedNever();

                entity.Property(e => e.Time).IsFixedLength();
            });

            modelBuilder.Entity<BoQFloor>(entity =>
            {
                entity.HasOne(d => d.BoQMaster)
                    .WithMany(p => p.BoQFloors)
                    .HasForeignKey(d => d.BoQMasterId)
                    .HasConstraintName("FK_BoQ_Floor_Setup_Master");
            });

            modelBuilder.Entity<BoQTask>(entity =>
            {
                entity.HasOne(d => d.BoQFloor)
                    .WithMany(p => p.BoQTasks)
                    .HasForeignKey(d => d.BoQFloorId)
                    .HasConstraintName("FK_BoQ_Task_Setup_Floor");
            });

            modelBuilder.Entity<BoQTaskDetail>(entity =>
            {
                entity.HasOne(d => d.BoQTask)
                    .WithMany(p => p.BoQTaskDetails)
                    .HasForeignKey(d => d.BoQTaskId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_BoQ_Task_Detail_Setup_Task");
            });

            modelBuilder.Entity<BoqReport>(entity =>
            {
                entity.ToView("boq_report");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.Property(e => e.CompanyId).ValueGeneratedNever();
            });

            modelBuilder.Entity<ConditionPhoto>(entity =>
            {
                entity.HasKey(e => new { e.TaskMasterId, e.MasterPhotoId });
            });

            modelBuilder.Entity<ConstructorV>(entity =>
            {
                entity.ToView("Constructor_V");
            });

            modelBuilder.Entity<CursorTest>(entity =>
            {
                entity.HasKey(e => e.Autonum)
                    .HasName("PK_CursorTests");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Tel1).IsFixedLength();
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_Departments_Projects");
            });

            modelBuilder.Entity<DepartmentSubMaster>(entity =>
            {
                entity.Property(e => e.DepartmentSubId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Expendmonth>(entity =>
            {
                entity.HasKey(e => e.Autonum)
                    .HasName("PK_Expendmonths");
            });

            modelBuilder.Entity<Gldatum>(entity =>
            {
                entity.HasKey(e => e.GlId)
                    .HasName("PK_GLDatas");
            });

            modelBuilder.Entity<HouseInfo>(entity =>
            {
                entity.HasKey(e => e.HouseId)
                    .HasName("PK_HouseInfoes");

                entity.HasOne(d => d.HouseType)
                    .WithMany(p => p.HouseInfos)
                    .HasForeignKey(d => d.HouseTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HouseInfo_House_Type");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.Property(e => e.TotalAmount).HasComputedColumnSql("(((([sub_total]-coalesce([discount_amount],(0)))-coalesce([bad_debt_amount],(0)))-coalesce([deposit_amount],(0)))-[recieved_amount])", false);
            });

            modelBuilder.Entity<InvoiceDetail>(entity =>
            {
                entity.Property(e => e.Amount).HasComputedColumnSql("([qty]*[unit_price]+[over_qty]*[unit_price])", false);
            });

            modelBuilder.Entity<Itemsmaterial>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__itemsmat__52020FDD61C4B5D6");
            });

            modelBuilder.Entity<Loa>(entity =>
            {
                entity.HasKey(e => e.LoaMasterId)
                    .HasName("PK_LOA_Master");
            });

            modelBuilder.Entity<LoaReport>(entity =>
            {
                entity.ToView("loa_report");
            });

            modelBuilder.Entity<LocationTask>(entity =>
            {
                entity.Property(e => e.LocationTaskId).ValueGeneratedNever();
            });

            modelBuilder.Entity<LogTime>(entity =>
            {
                entity.HasKey(e => e.TimeId)
                    .HasName("PK_LogTimes");
            });

            modelBuilder.Entity<MaterialType>(entity =>
            {
                entity.HasKey(e => e.MaterialId)
                    .HasName("PK__Material__6BFE1D288034F3F9");
            });

            modelBuilder.Entity<PayMonth>(entity =>
            {
                entity.HasKey(e => e.Monid)
                    .HasName("PK_payMonths");
            });

            modelBuilder.Entity<PaymentReport>(entity =>
            {
                entity.ToView("payment_report");
            });

            modelBuilder.Entity<PenaltyReport>(entity =>
            {
                entity.ToView("penalty_report");
            });

            modelBuilder.Entity<Performance>(entity =>
            {
                entity.HasKey(e => e.AutoId)
                    .HasName("PK_Performances");
            });

            modelBuilder.Entity<ProblemDetail>(entity =>
            {
                entity.HasOne(d => d.Problem)
                    .WithMany(p => p.ProblemDetails)
                    .HasForeignKey(d => d.ProblemId)
                    .HasConstraintName("FK_Problem_Detail_Problem");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.Property(e => e.DefaultProject).HasComment("Selected in Combo Box");
            });

            modelBuilder.Entity<PurchaseOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__Purchase__F1E4607BDDBDF006");
            });

            modelBuilder.Entity<PurchaseOrderList>(entity =>
            {
                entity.HasKey(e => e.OrderlistId)
                    .HasName("PK__Purchase__C5257AE77F7A45E3");
            });

            modelBuilder.Entity<PurchaseRequestList>(entity =>
            {
                entity.HasKey(e => e.RequestlistId)
                    .HasName("PK__Purchase__905D41829E128F17");
            });

            modelBuilder.Entity<ReportPvcClaim>(entity =>
            {
                entity.ToView("Report-pvc-claim");
            });

            modelBuilder.Entity<Result>(entity =>
            {
                entity.HasOne(d => d.ResultNavigation)
                    .WithMany(p => p.Results)
                    .HasForeignKey(d => d.ResultId)
                    .HasConstraintName("FK_Result_Result_Master");
            });

            modelBuilder.Entity<SetupFloor>(entity =>
            {
                entity.HasOne(d => d.SetupMaster)
                    .WithMany(p => p.SetupFloors)
                    .HasForeignKey(d => d.SetupMasterId)
                    .HasConstraintName("FK_Setup_Floor_Setup_Master");
            });

            modelBuilder.Entity<SetupTask>(entity =>
            {
                entity.HasOne(d => d.SetupFloor)
                    .WithMany(p => p.SetupTasks)
                    .HasForeignKey(d => d.SetupFloorId)
                    .HasConstraintName("FK_Setup_Task_Setup_Floor");
            });

            modelBuilder.Entity<SetupTaskDetail>(entity =>
            {
                entity.HasOne(d => d.SetupTask)
                    .WithMany(p => p.SetupTaskDetails)
                    .HasForeignKey(d => d.SetupTaskId)
                    .HasConstraintName("FK_Setup_Task_Detail_Setup_Task");
            });

            modelBuilder.Entity<Solution>(entity =>
            {
                entity.HasOne(d => d.Complain)
                    .WithMany(p => p.Solutions)
                    .HasForeignKey(d => d.ComplainId)
                    .HasConstraintName("FK_Solution_Complain");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.HasOne(d => d.Floor)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.FloorId)
                    .HasConstraintName("FK_Tasks_Floor");
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.HasKey(e => e.HhId)
                    .HasName("PK_Transactions");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.ConstructorId).ValueGeneratedNever();

                entity.Property(e => e.UserId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VCon>(entity =>
            {
                entity.ToView("V_CON");

                entity.Property(e => e.ConstructorId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VPosition>(entity =>
            {
                entity.ToView("V_Position");

                entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<View2>(entity =>
            {
                entity.ToView("View_2");

                entity.Property(e => e.TaskMasterId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<View3>(entity =>
            {
                entity.ToView("View_3");

                entity.Property(e => e.SetupTaskId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<View4>(entity =>
            {
                entity.ToView("View_4");

                entity.Property(e => e.SetupFloorId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<View5>(entity =>
            {
                entity.ToView("View_5");

                entity.Property(e => e.SetupMasterId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<View7>(entity =>
            {
                entity.ToView("View_7");

                entity.Property(e => e.HouseId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Warehouse>(entity =>
            {
                entity.HasKey(e => e.IdWarehouse)
                    .HasName("PK__Warehous__7F83F6D58FF261D1");
            });

            modelBuilder.Entity<Weekend>(entity =>
            {
                entity.HasKey(e => e.Rowid)
                    .HasName("PK_weekends");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
