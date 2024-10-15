using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using create_test.Models;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("Expend_house_type")]
    public partial class ExpendHouseType
    {
        [Key]
        [Column("exautonum")]
        public int Exautonum { get; set; }
        [Column("task_id")]
        public int? TaskId { get; set; }
        [Column("task_name")]
        [StringLength(500)]
        public string? TaskName { get; set; }
        [Column("standard_fee", TypeName = "decimal(18, 2)")]
        public decimal? StandardFee { get; set; }
        [Column("standard_persent", TypeName = "decimal(18, 4)")]
        public decimal? StandardPersent { get; set; }
        [Column("money_fee", TypeName = "decimal(18, 2)")]
        public decimal? MoneyFee { get; set; }
        [Column("money_persent", TypeName = "decimal(18, 4)")]
        public decimal? MoneyPersent { get; set; }
        [Column("total_fee", TypeName = "decimal(18, 2)")]
        public decimal? TotalFee { get; set; }
        [Column("total_month", TypeName = "decimal(18, 2)")]
        public decimal? TotalMonth { get; set; }
        [Column("month_persent", TypeName = "decimal(18, 4)")]
        public decimal? MonthPersent { get; set; }
        [Column("total_year", TypeName = "decimal(18, 2)")]
        public decimal? TotalYear { get; set; }
        [Column("year_persent", TypeName = "decimal(18, 4)")]
        public decimal? YearPersent { get; set; }
        [Column("balance_amount", TypeName = "decimal(18, 2)")]
        public decimal? BalanceAmount { get; set; }
        [Column("balance_persent", TypeName = "decimal(18, 4)")]
        public decimal? BalancePersent { get; set; }
        [Column("paid_month")]
        [StringLength(20)]
        [Unicode(false)]
        public string? PaidMonth { get; set; }
    }
}
