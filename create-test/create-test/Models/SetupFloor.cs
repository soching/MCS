using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("Setup_Floor")]
    public partial class SetupFloor
    {
        public SetupFloor()
        {
            SetupTasks = new HashSet<SetupTask>();
        }

        [Key]
        [Column("Setup_Floor_ID")]
        public int SetupFloorId { get; set; }
        [Column("Setup_Master_ID")]
        public int SetupMasterId { get; set; }
        [Column("Task_Name")]
        [StringLength(250)]
        public string? TaskName { get; set; }
        [Column("Floor_ID")]
        public int? FloorId { get; set; }
        [Column("Order_By")]
        public int? OrderBy { get; set; }
        [Column("Is_Require")]
        public int? IsRequire { get; set; }
        [Column("loa_code")]
        [StringLength(150)]
        public string? LoaCode { get; set; }
        [Column("BoQ_ID")]
        public int? BoQId { get; set; }

        [ForeignKey("SetupMasterId")]
        [InverseProperty("SetupFloors")]
        public virtual SetupMaster SetupMaster { get; set; } = null!;
        [InverseProperty("SetupFloor")]
        public virtual ICollection<SetupTask> SetupTasks { get; set; }
    }
}
