using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using create_test.Models;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("GroupTask")]
    public partial class GroupTask
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("task_master_id")]
        public int? TaskMasterId { get; set; }
        [Column("task_type")]
        [StringLength(250)]
        public string? TaskType { get; set; }
        [Column("house_id")]
        public int? HouseId { get; set; }
        [Column("group_name")]
        [StringLength(250)]
        public string? GroupName { get; set; }
    }
}
