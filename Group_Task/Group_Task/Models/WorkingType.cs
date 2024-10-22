using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("WorkingType")]
    public partial class WorkingType
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("project_name")]
        [StringLength(250)]
        public string? ProjectName { get; set; }
        [Column("names")]
        [StringLength(250)]
        public string? Names { get; set; }
        [Column("parent")]
        [StringLength(250)]
        public string? Parent { get; set; }
        [Column("descriptions")]
        [StringLength(250)]
        public string? Descriptions { get; set; }
        [Column("create_by")]
        [StringLength(50)]
        public string? CreateBy { get; set; }
        [Column("workingtype_status")]
        [StringLength(50)]
        public string? WorkingtypeStatus { get; set; }
    }
}
