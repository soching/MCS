using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("LogTime")]
    public partial class LogTime
    {
        [Key]
        [Column("Time_id")]
        public int TimeId { get; set; }
        [Column("g_position_id")]
        public int? GPositionId { get; set; }
        [Column("Start_Day")]
        public int? StartDay { get; set; }
        [Column("Start_Hour")]
        public int? StartHour { get; set; }
        [Column("Start_Minute")]
        public int? StartMinute { get; set; }
        [Column("End_Day")]
        public int? EndDay { get; set; }
        [Column("End_Hour")]
        public int? EndHour { get; set; }
        [Column("End_Minute")]
        public int? EndMinute { get; set; }
        [Column("department_id")]
        public int? DepartmentId { get; set; }
        [Column("project_id")]
        public int? ProjectId { get; set; }
        [Column("type_log")]
        public int? TypeLog { get; set; }
        [Column("Log_Status")]
        public int? LogStatus { get; set; }
    }
}
