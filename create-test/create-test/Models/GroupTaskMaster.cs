using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using create_test.Models;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("Group_Task_Master")]
    public partial class GroupTaskMaster
    {
        [Key]
        public int TaskGroup { get; set; }
        [Column("Account_ID")]
        public int? AccountId { get; set; }
        [Column("Account_Name")]
        [StringLength(500)]
        public string? AccountName { get; set; }
        [Column("full_name")]
        [StringLength(250)]
        public string? FullName { get; set; }
        [Column("Class_Code")]
        [StringLength(50)]
        [Unicode(false)]
        public string? ClassCode { get; set; }
        [Column("Group_Name_En")]
        [StringLength(300)]
        public string? GroupNameEn { get; set; }
        [Column("TaskGroup_Name")]
        [StringLength(300)]
        public string? TaskGroupName { get; set; }
        [Column("Account_Type")]
        [StringLength(500)]
        public string? AccountType { get; set; }
        [Column("order_by")]
        public int? OrderBy { get; set; }
        [Column("in_group")]
        public int? InGroup { get; set; }
    }
}
