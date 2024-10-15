using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using create_test.Models;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("Classify")]
    public partial class Classify
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        [StringLength(250)]
        public string? Name { get; set; }
    }
}
