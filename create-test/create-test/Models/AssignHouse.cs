using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using create_test.Models;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("AssignHouse")]
    public partial class AssignHouse
    {
        [Key]
        [Column("Assign_House_ID")]
        public int AssignHouseId { get; set; }
        [Column("House_ID")]
        public int HouseId { get; set; }
        [Column("Constructor_ID")]
        public int ConstructorId { get; set; }
        [Column("Project_ID")]
        public int? ProjectId { get; set; }
        [Column("Department_ID")]
        public int? DepartmentId { get; set; }
        [Column("Task_Master_ID")]
        public int? TaskMasterId { get; set; }
        [Column("Assign_Date", TypeName = "datetime")]
        public DateTime? AssignDate { get; set; }
        [Column("Start_Date", TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [Column("End_Date", TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? Persentag { get; set; }
        public int? TransferStatus { get; set; }
        [Column("Supervisor_ID2")]
        public int? SupervisorId2 { get; set; }
        [Column("Transfer_Date2", TypeName = "datetime")]
        public DateTime? TransferDate2 { get; set; }
        [Column("Supervisor_ID3")]
        public int? SupervisorId3 { get; set; }
        [Column("Transfer_Date3", TypeName = "datetime")]
        public DateTime? TransferDate3 { get; set; }
        [Column("Supervisor_ID4")]
        public int? SupervisorId4 { get; set; }
        [Column("Transfer_Date4", TypeName = "datetime")]
        public DateTime? TransferDate4 { get; set; }
        [StringLength(500)]
        public string? Remark { get; set; }
        [Column("Bonus_Status")]
        public int? BonusStatus { get; set; }
        [Column("Barrel_Type")]
        public int? BarrelType { get; set; }
        [Column("Complete_House")]
        public int? CompleteHouse { get; set; }
        [Column("Assign_Status")]
        public int? AssignStatus { get; set; }
        [Column("Reference_ID")]
        public int? ReferenceId { get; set; }
    }
}
