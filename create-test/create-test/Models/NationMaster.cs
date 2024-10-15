using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("NationMaster")]
    public partial class NationMaster
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(150)]
        public string? NationText { get; set; }
    }
}
