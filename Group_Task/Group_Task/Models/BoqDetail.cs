using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("BoqDetail")]
    public partial class BoqDetail
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("boq_no")]
        [StringLength(250)]
        public string? BoqNo { get; set; }
        [Column("project")]
        [StringLength(250)]
        public string? Project { get; set; }
        [Column("zones")]
        [StringLength(50)]
        public string? Zones { get; set; }
        [Column("blocks")]
        [StringLength(50)]
        public string? Blocks { get; set; }
        [Column("building")]
        [StringLength(50)]
        public string? Building { get; set; }
        [Column("house_no")]
        [StringLength(250)]
        public string? HouseNo { get; set; }
        [Column("house_type")]
        [StringLength(250)]
        public string? HouseType { get; set; }
        [Column("main_working_type")]
        [StringLength(250)]
        public string? MainWorkingType { get; set; }
        [Column("working_type")]
        [StringLength(250)]
        public string? WorkingType { get; set; }
        [Column("item_code")]
        [StringLength(250)]
        public string? ItemCode { get; set; }
        [Column("description_kh")]
        [StringLength(250)]
        public string? DescriptionKh { get; set; }
        [Column("description_en")]
        [StringLength(250)]
        public string? DescriptionEn { get; set; }
        [Column("brand")]
        [StringLength(250)]
        public string? Brand { get; set; }
        [Column("boq_qty")]
        [StringLength(250)]
        public string? BoqQty { get; set; }
        [Column("additional_qty")]
        [StringLength(250)]
        public string? AdditionalQty { get; set; }
        [Column("uom")]
        [StringLength(250)]
        public string? Uom { get; set; }
    }
}
