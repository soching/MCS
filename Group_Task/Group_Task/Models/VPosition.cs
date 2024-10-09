using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Keyless]
    public partial class VPosition
    {
        [Column("Performance_ID")]
        public int? PerformanceId { get; set; }
        [StringLength(500)]
        public string? Description { get; set; }
        [Column("Description_En")]
        [StringLength(500)]
        public string? DescriptionEn { get; set; }
        public int? Type { get; set; }
        [StringLength(500)]
        public string? Remark { get; set; }
        [Column("Auto_ID")]
        public int AutoId { get; set; }
        [Column("g_position_id")]
        public int? GPositionId { get; set; }
    }
}
