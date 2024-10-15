using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("Section")]
    public partial class Section
    {
        [Key]
        [Column("Section_ID")]
        public int SectionId { get; set; }
        [Column("Section_Name")]
        [StringLength(250)]
        public string? SectionName { get; set; }
    }
}
