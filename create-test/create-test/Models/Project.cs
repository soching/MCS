using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("Project")]
    public partial class Project
    {
        public Project()
        {
            Departments = new HashSet<Department>();
        }

        [Key]
        [Column("Project_ID")]
        public int ProjectId { get; set; }
        [Column("Project_Name")]
        [StringLength(200)]
        public string? ProjectName { get; set; }
        [StringLength(50)]
        public string? Abbreviation { get; set; }
        [Column("Status_Project")]
        public int? StatusProject { get; set; }
        [StringLength(500)]
        public string? Logo { get; set; }
        [Column("Project_Code")]
        [StringLength(50)]
        [Unicode(false)]
        public string? ProjectCode { get; set; }
        public int? Display { get; set; }
        [Column("Master_Plan")]
        [StringLength(250)]
        public string? MasterPlan { get; set; }
        [Column("Other_Code")]
        [StringLength(50)]
        public string? OtherCode { get; set; }
        /// <summary>
        /// Selected in Combo Box
        /// </summary>
        public bool DefaultProject { get; set; }

        [InverseProperty("Project")]
        public virtual ICollection<Department> Departments { get; set; }
    }
}
