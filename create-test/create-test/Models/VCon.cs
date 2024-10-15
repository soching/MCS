using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Keyless]
    public partial class VCon
    {
        [Column("Constructor_ID")]
        public int ConstructorId { get; set; }
    }
}
