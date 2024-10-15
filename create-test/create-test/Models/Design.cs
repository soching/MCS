using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using create_test.Models;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("design")]
    public partial class Design
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("drawing_decs")]
        [StringLength(500)]
        public string? DrawingDecs { get; set; }
        [Column("remark")]
        [StringLength(500)]
        public string? Remark { get; set; }
        [Column("level")]
        public int? Level { get; set; }
        [Column("tender")]
        [StringLength(150)]
        [Unicode(false)]
        public string? Tender { get; set; }
        [Column("construction")]
        [StringLength(150)]
        [Unicode(false)]
        public string? Construction { get; set; }
        [Column("is_control")]
        public bool? IsControl { get; set; }
        [Column("progress_type")]
        [StringLength(50)]
        public string? ProgressType { get; set; }
        [Column("qs")]
        [StringLength(150)]
        [Unicode(false)]
        public string? Qs { get; set; }
        [Column("committee")]
        [StringLength(150)]
        [Unicode(false)]
        public string? Committee { get; set; }
        [Column("ceo_signed")]
        [StringLength(150)]
        [Unicode(false)]
        public string? CeoSigned { get; set; }
        [Column("status")]
        [StringLength(150)]
        [Unicode(false)]
        public string? Status { get; set; }
        [Column("ordering")]
        public int? Ordering { get; set; }
    }
}
