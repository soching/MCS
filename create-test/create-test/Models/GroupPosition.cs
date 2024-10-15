using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using create_test.Models;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
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
