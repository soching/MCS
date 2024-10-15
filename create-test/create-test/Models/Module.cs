using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    public partial class Module
    {
        [Key]
        [Column("Module_ID")]
        public int ModuleId { get; set; }
        [Column("Module_name")]
        [StringLength(150)]
        public string ModuleName { get; set; } = null!;
        public bool Deactivate { get; set; }
        [Column("Form_Name")]
        [StringLength(150)]
        [Unicode(false)]
        public string FormName { get; set; } = null!;
        [StringLength(500)]
        [Unicode(false)]
        public string? Link { get; set; }
        [Column("Order_By")]
        public int? OrderBy { get; set; }
        public int? GroupMenu { get; set; }
        [Column("Menu_Mane")]
        [StringLength(250)]
        public string? MenuMane { get; set; }
    }
}
