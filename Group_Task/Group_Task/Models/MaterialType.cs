using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("MaterialType")]
    public partial class MaterialType
    {
        [Key]
        [Column("material_id")]
        public int MaterialId { get; set; }
        [Column("material_name")]
        [StringLength(250)]
        public string? MaterialName { get; set; }
        [Column("material_status")]
        [StringLength(250)]
        public string? MaterialStatus { get; set; }
    }
}
