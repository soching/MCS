﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using create_test.Models;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("house_plan")]
    public partial class HousePlan
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("plan_file")]
        [StringLength(500)]
        public string? PlanFile { get; set; }
        [Column("floor_id")]
        public int? FloorId { get; set; }
        [Column("task_id")]
        public int? TaskId { get; set; }
    }
}