using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("OpenScope")]
    public partial class OpenScope
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("house_code")]
        [StringLength(250)]
        public string? HouseCode { get; set; }
    }
}
