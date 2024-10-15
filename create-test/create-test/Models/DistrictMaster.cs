using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using create_test.Models;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
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
