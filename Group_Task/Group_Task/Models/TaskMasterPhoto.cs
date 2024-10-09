using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("Task_Master_Photo")]
    public partial class TaskMasterPhoto
    {
        [Key]
        [Column("Master_Photo_ID")]
        public int MasterPhotoId { get; set; }
        [Column("Task_Photo_Name")]
        [StringLength(500)]
        public string? TaskPhotoName { get; set; }
        public int? Status { get; set; }
        [Column("Task_Type")]
        [StringLength(500)]
        public string? TaskType { get; set; }
    }
}
