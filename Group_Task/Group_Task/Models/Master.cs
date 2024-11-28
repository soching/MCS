using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("Master")]
    public partial class Master
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("transactions")]
        public int Transactions { get; set; }
        [Column("item")]
        [StringLength(250)]
        public string Item { get; set; } = null!;
        [Column("qty")]
        public int Qty { get; set; }
        [Column("price")]
        public int Price { get; set; }
        [Column("status")]
        [StringLength(250)]
        public string Status { get; set; } = null!;
        [Column("date", TypeName = "date")]
        public DateTime Date { get; set; }
        [Column("description")]
        [StringLength(250)]
        public string? Description { get; set; }
    }
}
