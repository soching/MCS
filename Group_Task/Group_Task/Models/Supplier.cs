using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("supplier")]
    public partial class Supplier
    {
        [Key]
        public int Id { get; set; }
        [Column("names")]
        [StringLength(250)]
        public string? Names { get; set; }
        [Column("chequeName")]
        [StringLength(250)]
        public string? ChequeName { get; set; }
        [Column("email")]
        [StringLength(250)]
        public string? Email { get; set; }
        [Column("termpyment")]
        [StringLength(250)]
        public string? Termpyment { get; set; }
        [Column("addresses")]
        [StringLength(250)]
        public string? Addresses { get; set; }
        [Column("statuses")]
        [StringLength(250)]
        public string? Statuses { get; set; }
        [Column("actions")]
        [StringLength(250)]
        public string? Actions { get; set; }
        [Column("tel")]
        public int? Tel { get; set; }
    }
}
