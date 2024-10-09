using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("CommuneMaster")]
    public partial class CommuneMaster
    {
        [Key]
        [Column("CommuneID")]
        public Guid CommuneId { get; set; }
        [Column("DistrictID")]
        public Guid? DistrictId { get; set; }
        [StringLength(250)]
        public string? Commune { get; set; }
        [Column("ProvinceID")]
        public Guid? ProvinceId { get; set; }
    }
}
