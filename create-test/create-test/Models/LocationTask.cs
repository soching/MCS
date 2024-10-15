using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("Location_Task")]
    public partial class LocationTask
    {
        [Key]
        [Column("Location_Task_ID")]
        public int LocationTaskId { get; set; }
        [Column("Location_Task_Code")]
        [StringLength(50)]
        [Unicode(false)]
        public string? LocationTaskCode { get; set; }
        [Column("Location_Task_Desc")]
        [StringLength(500)]
        public string? LocationTaskDesc { get; set; }
    }
}
