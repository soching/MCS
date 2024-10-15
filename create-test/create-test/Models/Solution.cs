using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("Solution")]
    public partial class Solution
    {
        [Key]
        [Column("Solution_ID")]
        public int SolutionId { get; set; }
        [Column("Complain_ID")]
        public int ComplainId { get; set; }
        [StringLength(500)]
        public string? Solution1 { get; set; }
        [StringLength(500)]
        public string? ProductModel { get; set; }
        [Column("Solve_Date", TypeName = "datetime")]
        public DateTime? SolveDate { get; set; }
        [StringLength(250)]
        public string? PictureBefore { get; set; }
        [StringLength(250)]
        public string? PictureAfter { get; set; }
        [Column("Complain_Code")]
        [StringLength(50)]
        [Unicode(false)]
        public string? ComplainCode { get; set; }
        [Column("Problem_Detail_ID")]
        public int? ProblemDetailId { get; set; }
        [Column("Solution_Status")]
        public int? SolutionStatus { get; set; }

        [ForeignKey("ComplainId")]
        [InverseProperty("Solutions")]
        public virtual Complain Complain { get; set; } = null!;
    }
}
