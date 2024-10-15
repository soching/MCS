using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using create_test.Models;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("item_used")]
    public partial class ItemUsed
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("item_id")]
        public int? ItemId { get; set; }
        [Column("setup_task_detail_id")]
        public int? SetupTaskDetailId { get; set; }
        [Column("Setup_Task_ID")]
        public int? SetupTaskId { get; set; }
        [Column("qty", TypeName = "decimal(18, 2)")]
        public decimal? Qty { get; set; }
        [Column("brench")]
        [StringLength(250)]
        public string? Brench { get; set; }
        [Column("item_description")]
        [StringLength(500)]
        public string? ItemDescription { get; set; }
    }
}
