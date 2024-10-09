using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("Warehouse")]
    public partial class Warehouse
    {
        [Key]
        [Column("Id_Warehouse")]
        public int IdWarehouse { get; set; }
        [Column("Name_Warehouse")]
        [StringLength(50)]
        public string NameWarehouse { get; set; } = null!;
        [Column("Use_Control")]
        [StringLength(50)]
        public string UseControl { get; set; } = null!;
        [Column("Tel_Phone")]
        [StringLength(50)]
        public string TelPhone { get; set; } = null!;
        [StringLength(50)]
        public string Status { get; set; } = null!;
        [StringLength(50)]
        public string Address { get; set; } = null!;
    }
}
