using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("House_Type")]
    public partial class HouseType
    {
        public HouseType()
        {
            HouseInfos = new HashSet<HouseInfo>();
        }

        [Key]
        [Column("House_Type_ID")]
        public int HouseTypeId { get; set; }
        [Column("House_Type_Name")]
        [StringLength(250)]
        public string? HouseTypeName { get; set; }
        [StringLength(50)]
        public string? Abbreviation { get; set; }
        [Column("Order_Number")]
        public int? OrderNumber { get; set; }
        [Column("Standard_Size")]
        [StringLength(500)]
        public string? StandardSize { get; set; }
        public string? Remark { get; set; }
        public int? HouseGroup { get; set; }
        [Column("Other_Code")]
        [StringLength(50)]
        public string? OtherCode { get; set; }
        [Column("Formula_Side", TypeName = "decimal(18, 2)")]
        public decimal? FormulaSide { get; set; }
        [Column("Formula_Mid", TypeName = "decimal(18, 2)")]
        public decimal? FormulaMid { get; set; }

        [InverseProperty("HouseType")]
        public virtual ICollection<HouseInfo> HouseInfos { get; set; }
    }
}
