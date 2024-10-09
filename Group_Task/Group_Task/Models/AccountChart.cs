using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("Account_Chart")]
    public partial class AccountChart
    {
        [Key]
        [Column("Account_ID")]
        public int AccountId { get; set; }
        [Column("Account_Code")]
        [StringLength(50)]
        [Unicode(false)]
        public string? AccountCode { get; set; }
        [Column("Account_Name")]
        [StringLength(500)]
        public string? AccountName { get; set; }
        [Column("Account_Type")]
        [StringLength(500)]
        public string? AccountType { get; set; }
        [Column("Account_Name_KH")]
        [StringLength(500)]
        public string? AccountNameKh { get; set; }
        [Column("TBGroup")]
        [StringLength(500)]
        public string? Tbgroup { get; set; }
    }
}
