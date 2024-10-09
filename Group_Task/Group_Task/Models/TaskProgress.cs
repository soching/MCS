using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("Task_Progress")]
    public partial class TaskProgress
    {
        [Key]
        [Column("Task_Progress_ID")]
        public int TaskProgressId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Progress { get; set; }
        [Column("Task_ID")]
        public int TaskId { get; set; }
        [Column("Constructor_ID")]
        public int ConstructorId { get; set; }
        [Column("House_ID")]
        public int HouseId { get; set; }
        [Column("Start_Date", TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [Column("End_Date", TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
    }
}
