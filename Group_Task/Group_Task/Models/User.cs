using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    public partial class User
    {
        [Column("User_ID")]
        public int UserId { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string Username { get; set; } = null!;
        [StringLength(60)]
        [Unicode(false)]
        public string? Password { get; set; }
        [Column("Company_ID")]
        public int? CompanyId { get; set; }
        [Column("Profile_ID")]
        public int? ProfileId { get; set; }
        [Key]
        [Column("Constructor_ID")]
        public int ConstructorId { get; set; }
        public bool? Deactivate { get; set; }
        [Column("Expired_Date", TypeName = "datetime")]
        public DateTime? ExpiredDate { get; set; }
        [Column("Login_Status")]
        public bool? LoginStatus { get; set; }
        [Column("IP_Address")]
        [StringLength(150)]
        [Unicode(false)]
        public string? IpAddress { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string? Device { get; set; }
        [Column("Mapping_Account")]
        [StringLength(50)]
        [Unicode(false)]
        public string? MappingAccount { get; set; }
    }
}
