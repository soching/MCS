using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using create_test.Models;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("item_object")]
    public partial class ItemObject
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("type")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Type { get; set; }
        [Column("label")]
        [StringLength(500)]
        public string? Label { get; set; }
        [Column("fill")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Fill { get; set; }
        [Column("setup_task_id")]
        public int? SetupTaskId { get; set; }
        [Column("house_id")]
        public int? HouseId { get; set; }
        [Column("project_id")]
        public int? ProjectId { get; set; }
        [Column("house_type_id")]
        public int? HouseTypeId { get; set; }
        [Column("originX")]
        [StringLength(50)]
        [Unicode(false)]
        public string? OriginX { get; set; }
        [Column("originY")]
        [StringLength(50)]
        [Unicode(false)]
        public string? OriginY { get; set; }
        [Column("stroke")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Stroke { get; set; }
        [Column("strokeWidth")]
        public int? StrokeWidth { get; set; }
        [Column("width")]
        public double? Width { get; set; }
        [Column("height")]
        public double? Height { get; set; }
        [Column("opacity")]
        public double? Opacity { get; set; }
        [Column("fontFamily")]
        [StringLength(100)]
        [Unicode(false)]
        public string? FontFamily { get; set; }
        [Column("textAlign")]
        [StringLength(50)]
        [Unicode(false)]
        public string? TextAlign { get; set; }
        [Column("fontSize")]
        public double? FontSize { get; set; }
        [Column("textDecoration")]
        [StringLength(50)]
        [Unicode(false)]
        public string? TextDecoration { get; set; }
        [Column("lockUniScaling")]
        public bool? LockUniScaling { get; set; }
        [Column("angle")]
        public double? Angle { get; set; }
        [Column("radius")]
        public double? Radius { get; set; }
        [Column("objects")]
        public string? Objects { get; set; }
        [Column("left")]
        public double? Left { get; set; }
        [Column("top")]
        public double? Top { get; set; }
        [Column("scaleY")]
        public double? ScaleY { get; set; }
        [Column("scaleX")]
        public double? ScaleX { get; set; }
        [Column("total_qty", TypeName = "decimal(18, 3)")]
        public decimal? TotalQty { get; set; }
        [Column("total_amount", TypeName = "decimal(18, 10)")]
        public decimal? TotalAmount { get; set; }
        [Column("custom_qty", TypeName = "decimal(18, 3)")]
        public decimal? CustomQty { get; set; }
        [Column("custom_amount", TypeName = "decimal(18, 10)")]
        public decimal? CustomAmount { get; set; }
        [Column("setup_task_detail_id")]
        public int? SetupTaskDetailId { get; set; }
        [Column("location_id")]
        public int? LocationId { get; set; }
        [Column("is_require")]
        public int? IsRequire { get; set; }
    }
}
