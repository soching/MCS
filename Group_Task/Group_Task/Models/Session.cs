using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("Session")]
    public partial class Session
    {
        [Key]
        [Column("Session_ID")]
        public int SessionId { get; set; }
        [Column("User_Name")]
        [StringLength(100)]
        [Unicode(false)]
        public string? UserName { get; set; }
        [Column("IP_Address")]
        [StringLength(20)]
        [Unicode(false)]
        public string? IpAddress { get; set; }
        [Column("Login_Date", TypeName = "datetime")]
        public DateTime? LoginDate { get; set; }
        [Column("Logout_Date", TypeName = "datetime")]
        public DateTime? LogoutDate { get; set; }
        [Column("Session_Number")]
        [StringLength(200)]
        [Unicode(false)]
        public string? SessionNumber { get; set; }
        [Column("Session_Status")]
        public int? SessionStatus { get; set; }
        public byte? Received { get; set; }
    }
}
