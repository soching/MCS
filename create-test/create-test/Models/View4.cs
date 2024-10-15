using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Keyless]
    public partial class View4
    {
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
        public int Expr1 { get; set; }
    }
}
