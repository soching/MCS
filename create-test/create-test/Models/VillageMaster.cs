using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("VillageMaster")]
    public partial class VillageMaster
    {
        [Key]
        [Column("VillageID")]
        public Guid VillageId { get; set; }
        [Column("CommuneID")]
        public Guid? CommuneId { get; set; }
        [StringLength(250)]
        public string? Village { get; set; }
        [Column("ProvinceID")]
        public Guid? ProvinceId { get; set; }
        [Column("DistrictID")]
        public Guid? DistrictId { get; set; }
    }
}
