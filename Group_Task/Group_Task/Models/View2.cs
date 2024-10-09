using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Keyless]
    public partial class View2
    {
        [Column("Task_Master_ID")]
        public int TaskMasterId { get; set; }
        [Column("Task_Name")]
        [StringLength(500)]
        public string? TaskName { get; set; }
        public bool? Status { get; set; }
        [Column("Task_Type")]
        [StringLength(500)]
        public string? TaskType { get; set; }
        public int? TaskGroup { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Category { get; set; }
        [Column("Reference_Num")]
        [StringLength(50)]
        public string? ReferenceNum { get; set; }
    }
}
