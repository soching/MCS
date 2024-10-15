using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("Result_House")]
    public partial class ResultHouse
    {
        [Key]
        [Column("Res_HouseAutonum")]
        public int ResHouseAutonum { get; set; }
        [Column("House_ID")]
        public int? HouseId { get; set; }
        [Column("Constructor_ID")]
        public int? ConstructorId { get; set; }
        public int? TaskGroup { get; set; }
        [Column("Res_House_Date", TypeName = "datetime")]
        public DateTime? ResHouseDate { get; set; }
        [Column("Res_House_Transfer_Document")]
        [Unicode(false)]
        public string? ResHouseTransferDocument { get; set; }
        [Column("Res_House_Cleaning")]
        [StringLength(200)]
        public string? ResHouseCleaning { get; set; }
        [Column("Res_House_Photo")]
        [Unicode(false)]
        public string? ResHousePhoto { get; set; }
        [Column("Res_House_Reward", TypeName = "decimal(18, 2)")]
        public decimal? ResHouseReward { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Scores { get; set; }
        public bool? Approve1 { get; set; }
        [Column("Approve1_By")]
        [StringLength(50)]
        public string? Approve1By { get; set; }
        public bool? Approve2 { get; set; }
        [Column("Approve2_By")]
        [StringLength(50)]
        public string? Approve2By { get; set; }
        [Column("Approve2_date", TypeName = "datetime")]
        public DateTime? Approve2Date { get; set; }
        public bool? Approve3 { get; set; }
        [Column("Approve3_By")]
        [StringLength(50)]
        public string? Approve3By { get; set; }
        [Column("Approve3_date", TypeName = "datetime")]
        public DateTime? Approve3Date { get; set; }
        public bool? Approve4 { get; set; }
        [Column("Approve4_By")]
        [StringLength(50)]
        public string? Approve4By { get; set; }
        [Column("Approve4_date", TypeName = "datetime")]
        public DateTime? Approve4Date { get; set; }
        public bool? Approve5 { get; set; }
        [Column("Approve5_By")]
        [StringLength(50)]
        public string? Approve5By { get; set; }
        [Column("Approve5_date", TypeName = "datetime")]
        public DateTime? Approve5Date { get; set; }
        public bool? Approve6 { get; set; }
        [Column("Approve6_By")]
        [StringLength(50)]
        public string? Approve6By { get; set; }
        [Column("Approve6_date", TypeName = "datetime")]
        public DateTime? Approve6Date { get; set; }
        public int? Status { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PayrollDate { get; set; }
    }
}
