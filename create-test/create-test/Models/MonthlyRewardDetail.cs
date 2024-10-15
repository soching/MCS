using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("Monthly_Reward_Detail")]
    public partial class MonthlyRewardDetail
    {
        [Key]
        public int BonDetailAutonum { get; set; }
        public int BonAutonum { get; set; }
        [Column("House_Type_Group")]
        public int? HouseTypeGroup { get; set; }
        [Column("Price_A", TypeName = "decimal(18, 2)")]
        public decimal? PriceA { get; set; }
        [Column("Price_A1", TypeName = "decimal(18, 2)")]
        public decimal? PriceA1 { get; set; }
        [Column("Price_A2", TypeName = "decimal(18, 2)")]
        public decimal? PriceA2 { get; set; }
        [Column("Price_A3", TypeName = "decimal(18, 2)")]
        public decimal? PriceA3 { get; set; }
        [Column("Qty_House", TypeName = "decimal(18, 2)")]
        public decimal? QtyHouse { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Scores { get; set; }
    }
}
