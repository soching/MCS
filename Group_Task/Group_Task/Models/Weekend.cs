using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("weekend")]
    public partial class Weekend
    {
        [Key]
        [Column("rowid")]
        public int Rowid { get; set; }
        [Column("weekend")]
        public int? Weekend1 { get; set; }
        [Column("descrition")]
        [StringLength(20)]
        public string? Descrition { get; set; }
        [Column("start_date")]
        [StringLength(20)]
        public string? StartDate { get; set; }
        [Column("end_date")]
        [StringLength(20)]
        public string? EndDate { get; set; }
    }
}
