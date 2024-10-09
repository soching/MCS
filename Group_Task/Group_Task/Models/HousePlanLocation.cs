using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("house_plan_location")]
    public partial class HousePlanLocation
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
