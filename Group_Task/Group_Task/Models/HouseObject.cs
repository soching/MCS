using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("house_object")]
    public partial class HouseObject
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("type")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Type { get; set; }
        [Column("label")]
        [StringLength(50)]
        public string? Label { get; set; }
        [Column("fill")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Fill { get; set; }
        [Column("house_id")]
        public int? HouseId { get; set; }
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
    }
}
