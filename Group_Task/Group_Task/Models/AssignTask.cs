using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("AssignTask")]
    public partial class AssignTask
    {
        [Key]
        [Column("Assign_Task_ID")]
        public int AssignTaskId { get; set; }
        [Column("Constructor_ID")]
        public int? ConstructorId { get; set; }
        [Column("Task_ID")]
        public int? TaskId { get; set; }
        [Column("House_ID")]
        public int? HouseId { get; set; }
        [Column("Is_Block")]
        public bool? IsBlock { get; set; }
        [Column("Project_ID")]
        public int? ProjectId { get; set; }
        [Column("House_Type_ID")]
        public int? HouseTypeId { get; set; }
    }
}
