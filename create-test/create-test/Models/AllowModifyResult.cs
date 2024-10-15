using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using create_test.Models;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("Allow_Modify_Result")]
    public partial class AllowModifyResult
    {
        [Key]
        [Column("Allow_Result_ID")]
        public int AllowResultId { get; set; }
        [Column("Allow_Date", TypeName = "datetime")]
        public DateTime? AllowDate { get; set; }
        [Column("Allow_By")]
        [StringLength(250)]
        public string? AllowBy { get; set; }
        [Column("Is_Default")]
        public bool? IsDefault { get; set; }
        [Column("Is_Allow")]
        public bool? IsAllow { get; set; }
        [Column("Project_ID")]
        public int? ProjectId { get; set; }
        [Column("Constructor_ID")]
        public int? ConstructorId { get; set; }
    }
}
