using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("booking_detail")]
    public partial class BookingDetail
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("booking_id")]
        public int? BookingId { get; set; }
        [Column("house_id")]
        public int? HouseId { get; set; }
        [Column("total_amount", TypeName = "decimal(18, 2)")]
        public decimal? TotalAmount { get; set; }
    }
}
