﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using create_test.Models;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("Condition_Photo")]
    public partial class ConditionPhoto
    {
        [Key]
        [Column("Task_Master_ID")]
        public int TaskMasterId { get; set; }
        [Key]
        [Column("Master_Photo_ID")]
        public int MasterPhotoId { get; set; }
    }
}