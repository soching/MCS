﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using create_test.Models;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Index("RoleId", Name = "IX_AspNetRoleClaims_RoleId")]
    public partial class AspNetRoleClaim
    {
        [Key]
        public int Id { get; set; }
        public string RoleId { get; set; } = null!;
        public string? ClaimType { get; set; }
        public string? ClaimValue { get; set; }

        [ForeignKey("RoleId")]
        [InverseProperty("AspNetRoleClaims")]
        public virtual AspNetRole Role { get; set; } = null!;
    }
}