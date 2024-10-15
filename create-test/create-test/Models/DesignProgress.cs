using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using create_test.Models;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("design_progress")]
    public partial class DesignProgress
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("drawing_id")]
        public int? DrawingId { get; set; }
        [Column("tender")]
        [StringLength(150)]
        [Unicode(false)]
        public string? Tender { get; set; }
        [Column("construction")]
        [StringLength(150)]
        [Unicode(false)]
        public string? Construction { get; set; }
        [Column("entry_by")]
        [StringLength(50)]
        [Unicode(false)]
        public string? EntryBy { get; set; }
        [Column("entry_date", TypeName = "datetime")]
        public DateTime? EntryDate { get; set; }
        [Column("house_id")]
        public int? HouseId { get; set; }
        [Column("house_type_id")]
        public int? HouseTypeId { get; set; }
        [Column("ceo_signed")]
        [StringLength(150)]
        [Unicode(false)]
        public string? CeoSigned { get; set; }
        [Column("qs")]
        [StringLength(150)]
        [Unicode(false)]
        public string? Qs { get; set; }
        [Column("committee")]
        [StringLength(150)]
        [Unicode(false)]
        public string? Committee { get; set; }
        [Column("status")]
        [StringLength(150)]
        [Unicode(false)]
        public string? Status { get; set; }
        [Column("progress_type")]
        [StringLength(50)]
        [Unicode(false)]
        public string? ProgressType { get; set; }
    }
}
