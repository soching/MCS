using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("Task_Type")]
    public partial class TaskType
    {
        [Key]
        [Column("Task_Type_ID")]
        public int TaskTypeId { get; set; }
        [Column("Task_Type_Name")]
        [StringLength(250)]
        public string? TaskTypeName { get; set; }
        [StringLength(500)]
        public string? Remark { get; set; }
    }
}
