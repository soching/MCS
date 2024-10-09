using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("Problem")]
    public partial class Problem
    {
        public Problem()
        {
            ProblemDetails = new HashSet<ProblemDetail>();
        }

        [Key]
        [Column("Problem_ID")]
        public int ProblemId { get; set; }
        [Column("Problem_Name")]
        [StringLength(250)]
        public string? ProblemName { get; set; }
        public bool? Status { get; set; }

        [InverseProperty("Problem")]
        public virtual ICollection<ProblemDetail> ProblemDetails { get; set; }
    }
}
