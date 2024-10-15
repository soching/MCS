﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using create_test.Models;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("Company")]
    public partial class Company
    {
        [Key]
        [Column("Company_ID")]
        public int CompanyId { get; set; }
        [Column("Company_Name")]
        [StringLength(150)]
        public string? CompanyName { get; set; }
        [Column("Company_Description")]
        [StringLength(500)]
        public string? CompanyDescription { get; set; }
        public string? Note { get; set; }
    }
}