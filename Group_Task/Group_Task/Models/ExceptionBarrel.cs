﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("Exception_Barrel")]
    public partial class ExceptionBarrel
    {
        [Key]
        [Column("Exception_Barrel_ID")]
        public int ExceptionBarrelId { get; set; }
        [Column("Setup_Master_ID")]
        public int? SetupMasterId { get; set; }
        [Column("House_ID")]
        public int? HouseId { get; set; }
        [Column("BoQ_Master_ID")]
        public int? BoQMasterId { get; set; }
    }
}
