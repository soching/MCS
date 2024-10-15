using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("Monthly_Reward")]
    public partial class MonthlyReward
    {
        [Key]
        public int BonAutonum { get; set; }
        [StringLength(4000)]
        public string? BonName { get; set; }
        public int? TaskGroup { get; set; }
    }
}
