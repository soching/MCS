using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("Week")]
    public partial class Week
    {
        [Key]
        [Column("Week_ID")]
        public int WeekId { get; set; }
        [Column("Week_Desc")]
        [StringLength(150)]
        public string? WeekDesc { get; set; }
    }
}
