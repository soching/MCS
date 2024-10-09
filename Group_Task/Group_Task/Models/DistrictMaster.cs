using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("DistrictMaster")]
    public partial class DistrictMaster
    {
        [Key]
        [Column("DistrictID")]
        public Guid DistrictId { get; set; }
        [Column("ProvinceID")]
        public Guid? ProvinceId { get; set; }
        [StringLength(250)]
        public string? District { get; set; }
    }
}
