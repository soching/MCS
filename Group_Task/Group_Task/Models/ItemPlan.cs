﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("item_plan")]
    public partial class ItemPlan
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("plan_file")]
        [StringLength(500)]
        public string? PlanFile { get; set; }
        [Column("location_id")]
        public int? LocationId { get; set; }
        [Column("task_id")]
        public int? TaskId { get; set; }
    }
}
