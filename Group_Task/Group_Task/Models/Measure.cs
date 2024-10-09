using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("Measure")]
    public partial class Measure
    {
        [Key]
        [Column("Measure_ID")]
        public int MeasureId { get; set; }
        [Column("Measure_Name")]
        [StringLength(50)]
        public string? MeasureName { get; set; }
    }
}
