using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("Zone")]
    public partial class Zone
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("Zone_Name")]
        [StringLength(150)]
        public string? ZoneName { get; set; }
        public int? Status { get; set; }
    }
}
