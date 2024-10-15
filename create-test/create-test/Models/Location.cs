using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("Location")]
    public partial class Location
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        [StringLength(250)]
        public string? Name { get; set; }
    }
}
