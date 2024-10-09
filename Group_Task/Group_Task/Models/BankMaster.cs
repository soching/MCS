using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("BankMaster")]
    public partial class BankMaster
    {
        [Key]
        [Column("BankID")]
        public Guid BankId { get; set; }
        [StringLength(250)]
        public string? BankName { get; set; }
        [StringLength(250)]
        public string? Branch { get; set; }
        [StringLength(250)]
        public string? Address { get; set; }
    }
}
