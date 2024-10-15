using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("Complain")]
    public partial class Complain
    {
        public Complain()
        {
            Solutions = new HashSet<Solution>();
        }

        [Key]
        [Column("Complain_ID")]
        public int ComplainId { get; set; }
        [Column("Problem_ID")]
        public int? ProblemId { get; set; }
        public string? Description { get; set; }
        public string? Solution { get; set; }
        [Column("House_ID")]
        public int? HouseId { get; set; }
        [Column("Costumer_Name")]
        [StringLength(250)]
        public string? CostumerName { get; set; }
        [Column("Complain_Date", TypeName = "datetime")]
        public DateTime? ComplainDate { get; set; }
        [StringLength(500)]
        public string? Tel { get; set; }
        [Column("Complain_By")]
        [StringLength(50)]
        public string? ComplainBy { get; set; }
        [Column("Recieved_By")]
        public int? RecievedBy { get; set; }
        [Column("Solve_By")]
        public int? SolveBy { get; set; }
        [Column("Finish_Date", TypeName = "datetime")]
        public DateTime? FinishDate { get; set; }
        [Column("Complain_Status")]
        public int? ComplainStatus { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Progress { get; set; }
        [Column("House_Status")]
        public int? HouseStatus { get; set; }
        [Column("Reference_File")]
        [StringLength(500)]
        public string? ReferenceFile { get; set; }
        [Column("Entry_By")]
        [StringLength(250)]
        [Unicode(false)]
        public string? EntryBy { get; set; }
        [Column("Solve_By1")]
        public int? SolveBy1 { get; set; }
        [Column("Solve_By2")]
        public int? SolveBy2 { get; set; }
        [Column("Solve_By3")]
        public int? SolveBy3 { get; set; }
        [Column("Solve_By4")]
        public int? SolveBy4 { get; set; }
        [Column("Solve_By6")]
        public int? SolveBy6 { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Duration { get; set; }
        [Column("Photo_Path")]
        [StringLength(500)]
        public string? PhotoPath { get; set; }
        [StringLength(250)]
        public string? Phone1 { get; set; }
        [StringLength(250)]
        public string? Phone2 { get; set; }
        public int? TeamLeaderApprove { get; set; }
        [Column("Start_Date", TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [Column("Start_Time")]
        [StringLength(50)]
        [Unicode(false)]
        public string? StartTime { get; set; }
        [Column("Submit_Date", TypeName = "datetime")]
        public DateTime? SubmitDate { get; set; }
        [Column("Is_Delay")]
        public bool? IsDelay { get; set; }
        [Column("Delay_Date", TypeName = "datetime")]
        public DateTime? DelayDate { get; set; }
        [StringLength(500)]
        public string? Note { get; set; }
        [Column("Allow_By")]
        [StringLength(250)]
        public string? AllowBy { get; set; }
        [Column("Is_Allow")]
        public bool? IsAllow { get; set; }
        [Column("Complain_Type")]
        public int? ComplainType { get; set; }
        [Column("Complain_Code")]
        [StringLength(50)]
        [Unicode(false)]
        public string? ComplainCode { get; set; }

        [InverseProperty("Complain")]
        public virtual ICollection<Solution> Solutions { get; set; }
    }
}
