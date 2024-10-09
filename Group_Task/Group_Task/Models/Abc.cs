﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Keyless]
    [Table("ABC")]
    public partial class Abc
    {
        [Column("task_id")]
        public int TaskId { get; set; }
        [Column("task_name")]
        [StringLength(500)]
        public string? TaskName { get; set; }
        [Column("standard_fee", TypeName = "decimal(38, 6)")]
        public decimal? StandardFee { get; set; }
        [Column("standard_persent", TypeName = "decimal(38, 6)")]
        public decimal? StandardPersent { get; set; }
        [Column("money_fee", TypeName = "decimal(38, 3)")]
        public decimal? MoneyFee { get; set; }
        [Column("money_persent", TypeName = "decimal(38, 6)")]
        public decimal? MoneyPersent { get; set; }
        [Column("total_fee", TypeName = "decimal(38, 3)")]
        public decimal? TotalFee { get; set; }
        [Column("total_month")]
        public int? TotalMonth { get; set; }
        [Column("month_persent", TypeName = "decimal(38, 25)")]
        public decimal? MonthPersent { get; set; }
        [Column("total_year", TypeName = "decimal(38, 3)")]
        public decimal? TotalYear { get; set; }
        [Column("year_persent", TypeName = "decimal(38, 6)")]
        public decimal? YearPersent { get; set; }
        [Column("balance_amount", TypeName = "decimal(38, 3)")]
        public decimal? BalanceAmount { get; set; }
        [Column("balance_persent", TypeName = "decimal(38, 6)")]
        public decimal? BalancePersent { get; set; }
        [Column("year_B", TypeName = "decimal(38, 3)")]
        public decimal? YearB { get; set; }
        [Column("year_B_persent", TypeName = "decimal(38, 6)")]
        public decimal? YearBPersent { get; set; }
    }
}
