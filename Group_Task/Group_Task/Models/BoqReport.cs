﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Keyless]
    public partial class BoqReport
    {
        [Column("House_ID")]
        public int HouseId { get; set; }
        [Column("House_No")]
        [StringLength(200)]
        public string? HouseNo { get; set; }
        [Column("House_Type_Name")]
        [StringLength(250)]
        public string? HouseTypeName { get; set; }
        [StringLength(200)]
        public string? Label { get; set; }
        [Column("Project_ID")]
        public int? ProjectId { get; set; }
        [Column("Approve5_Date", TypeName = "datetime")]
        public DateTime? Approve5Date { get; set; }
        public int? Approve5 { get; set; }
        public bool? Status { get; set; }
        [Column("Task_Type")]
        [StringLength(500)]
        public string? TaskType { get; set; }
        [Column("Setup_Master_ID")]
        public int? SetupMasterId { get; set; }
        [Column("Task_Master_ID")]
        public int? TaskMasterId { get; set; }
        [Column("Task_Master_Name")]
        [StringLength(500)]
        public string? TaskMasterName { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Unit { get; set; }
        [Column("Barrel_Type")]
        public int? BarrelType { get; set; }
        public int Expr1 { get; set; }
        [Column("House_Type_ID")]
        public int? HouseTypeId { get; set; }
        public int? Expr2 { get; set; }
        [StringLength(8)]
        [Unicode(false)]
        public string Remark { get; set; } = null!;
        [Column("boq_code")]
        [StringLength(500)]
        public string? BoqCode { get; set; }
        [Column("Total_Amount", TypeName = "decimal(18, 3)")]
        public decimal? TotalAmount { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? PaidAmount { get; set; }
    }
}
