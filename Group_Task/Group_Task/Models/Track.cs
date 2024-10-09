using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    public partial class Track
    {
        [Key]
        [Column("Track_ID")]
        public long TrackId { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string? Username { get; set; }
        [Column("IP_Address")]
        [StringLength(20)]
        [Unicode(false)]
        public string? IpAddress { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string? Operation { get; set; }
        [Column("Operate_date", TypeName = "datetime")]
        public DateTime? OperateDate { get; set; }
        public string? Description { get; set; }
        [Column("Computer_Name")]
        [StringLength(50)]
        public string? ComputerName { get; set; }
    }
}
