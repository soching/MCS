using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("Floor")]
    public partial class Floor
    {
        public Floor()
        {
            Tasks = new HashSet<Task>();
        }

        [Key]
        [Column("Floor_ID")]
        public int FloorId { get; set; }
        [Column("Floor_Name")]
        [StringLength(250)]
        public string? FloorName { get; set; }
        [Column("Task_Master_ID")]
        public int TaskMasterId { get; set; }
        [Column("Floor_Code")]
        [StringLength(50)]
        public string? FloorCode { get; set; }

        [InverseProperty("Floor")]
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
