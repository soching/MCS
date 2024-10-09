using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("AssignProject")]
    public partial class AssignProject
    {
        [Key]
        [Column("Assign_Project_ID")]
        public int AssignProjectId { get; set; }
        [Column("Project_ID")]
        public int? ProjectId { get; set; }
        [Column("Constructor_ID")]
        public int ConstructorId { get; set; }
        [Column("ToConstructor_ID")]
        public int? ToConstructorId { get; set; }
    }
}
