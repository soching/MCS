using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("Permission")]
    public partial class Permission
    {
        [Key]
        [Column("Permission_ID")]
        public int PermissionId { get; set; }
        [Column("Profile_ID")]
        public int? ProfileId { get; set; }
        [Column("User_ID")]
        public int? UserId { get; set; }
        [Column("Module_ID")]
        public int? ModuleId { get; set; }
        public byte? Full { get; set; }
        public byte? Delete { get; set; }
        public byte? Add { get; set; }
        public byte? Edit { get; set; }
        public int? List { get; set; }
        [Column("By_Project")]
        public byte? ByProject { get; set; }
        [Column("All_Project")]
        public byte? AllProject { get; set; }
        [Column("Project_ID")]
        public int? ProjectId { get; set; }
        public int? Level { get; set; }
    }
}
