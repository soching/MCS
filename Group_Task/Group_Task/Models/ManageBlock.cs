using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("Manage_Block")]
    public partial class ManageBlock
    {
        [Key]
        [Column("Manage_Block_ID")]
        public int ManageBlockId { get; set; }
        [StringLength(50)]
        public string? Block { get; set; }
        [Column("Constructor_ID")]
        public int? ConstructorId { get; set; }
        [Column("Assign_Date", TypeName = "datetime")]
        public DateTime? AssignDate { get; set; }
        [Column("Assign_By")]
        [StringLength(150)]
        public string? AssignBy { get; set; }
    }
}
