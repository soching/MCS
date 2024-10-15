using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("set_column")]
    public partial class SetColumn
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("Field_Name")]
        [StringLength(150)]
        public string? FieldName { get; set; }
        [Column("Task_Master_ID")]
        public int? TaskMasterId { get; set; }
        public bool? Visible { get; set; }
    }
}
