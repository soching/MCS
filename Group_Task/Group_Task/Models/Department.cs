using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("Department")]
    public partial class Department
    {
        [Key]
        [Column("Department_ID")]
        public int DepartmentId { get; set; }
        [Column("Department_Name")]
        [StringLength(50)]
        public string? DepartmentName { get; set; }
        [Column("Project_ID")]
        public int? ProjectId { get; set; }

        [ForeignKey("ProjectId")]
        [InverseProperty("Departments")]
        public virtual Project? Project { get; set; }
    }
}
