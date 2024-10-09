using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("Group_Position")]
    public partial class GroupPosition
    {
        [Key]
        [Column("g_position_id")]
        public int GPositionId { get; set; }
        [Column("g_name")]
        [StringLength(500)]
        public string? GName { get; set; }
    }
}
