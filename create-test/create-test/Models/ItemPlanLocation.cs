﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using create_test.Models;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("item_plan_location")]
    public partial class ItemPlanLocation
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("plan_location")]
        [StringLength(250)]
        public string? PlanLocation { get; set; }
        [Column("setup_master_id")]
        public int? SetupMasterId { get; set; }
    }
}