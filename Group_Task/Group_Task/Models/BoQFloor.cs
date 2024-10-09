using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("BoQ_Floor")]
    public partial class BoQFloor
    {
        public BoQFloor()
        {
            BoQTasks = new HashSet<BoQTask>();
        }

        [Key]
        [Column("BoQ_Floor_ID")]
        public int BoQFloorId { get; set; }
        [Column("BoQ_Master_ID")]
        public int BoQMasterId { get; set; }
        [Column("Task_Name")]
        [StringLength(250)]
        public string? TaskName { get; set; }
        [Column("Floor_ID")]
        public int? FloorId { get; set; }
        [Column("Order_By")]
        public int? OrderBy { get; set; }
        [Column("Is_Require")]
        public int? IsRequire { get; set; }
        [Column("Setup_Floor_ID")]
        public int? SetupFloorId { get; set; }

        [ForeignKey("BoQMasterId")]
        [InverseProperty("BoQFloors")]
        public virtual BoQMaster BoQMaster { get; set; } = null!;
        [InverseProperty("BoQFloor")]
        public virtual ICollection<BoQTask> BoQTasks { get; set; }
    }
}
