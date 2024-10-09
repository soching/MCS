using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("Problem_Detail")]
    public partial class ProblemDetail
    {
        [Key]
        [Column("Problem_Detail_ID")]
        public int ProblemDetailId { get; set; }
        [Column("Problem_ID")]
        public int ProblemId { get; set; }
        [Column("Problem_Detail_Name")]
        [StringLength(250)]
        public string? ProblemDetailName { get; set; }

        [ForeignKey("ProblemId")]
        [InverseProperty("ProblemDetails")]
        public virtual Problem Problem { get; set; } = null!;
    }
}
