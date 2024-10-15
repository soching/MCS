using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("RelationMaster")]
    public partial class RelationMaster
    {
        [Key]
        [Column("RelationID")]
        public Guid RelationId { get; set; }
        [StringLength(250)]
        public string? Relation { get; set; }
    }
}
