using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("DepartmentSubMaster")]
    public partial class DepartmentSubMaster
    {
        [Key]
        [Column("DepartmentSubID")]
        public Guid DepartmentSubId { get; set; }
        [Column("DepartmentID")]
        public Guid? DepartmentId { get; set; }
        [StringLength(250)]
        public string? DepartmentSub { get; set; }
    }
}
