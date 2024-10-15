﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Keyless]
    public partial class View3
    {
        [Column("Setup_Task_ID")]
        public int SetupTaskId { get; set; }
        [Column("Setup_Floor_ID")]
        public int SetupFloorId { get; set; }
        [Column("Task_Name")]
        [StringLength(500)]
        public string? TaskName { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Quantity { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Price { get; set; }
        [StringLength(50)]
        public string? Measure { get; set; }
        [Column("Standard_Date")]
        public int? StandardDate { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? Width { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? Along { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? Height { get; set; }
        [Column("Total_Quantity", TypeName = "decimal(18, 4)")]
        public decimal? TotalQuantity { get; set; }
        [Column("Task_ID")]
        public int? TaskId { get; set; }
        [Column("Total_Amount", TypeName = "decimal(18, 4)")]
        public decimal? TotalAmount { get; set; }
        [Column("Order_by", TypeName = "decimal(18, 2)")]
        public decimal? OrderBy { get; set; }
        [Column("Can_Edit")]
        public bool? CanEdit { get; set; }
        [Column("Is_Require")]
        public int? IsRequire { get; set; }
        [Column("Reference_Num")]
        public int? ReferenceNum { get; set; }
        [Column("Paid_Amount", TypeName = "decimal(18, 4)")]
        public decimal? PaidAmount { get; set; }
    }
}