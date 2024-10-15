using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("LogRecord")]
    public partial class LogRecord
    {
        [Key]
        [Column("Log_Record_ID")]
        public int LogRecordId { get; set; }
        [Column("Start_Hours")]
        public int? StartHours { get; set; }
        [Column("End_Hours")]
        public int? EndHours { get; set; }
        public int? Day { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? DayOfWeek { get; set; }
    }
}
