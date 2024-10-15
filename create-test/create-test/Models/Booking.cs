using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using create_test.Models;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("booking")]
    public partial class Booking
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("booking_date", TypeName = "datetime")]
        public DateTime? BookingDate { get; set; }
        [Column("seller_id")]
        public int? SellerId { get; set; }
        [Column("customer_id")]
        public int? CustomerId { get; set; }
        [Column("status")]
        [StringLength(50)]
        public string? Status { get; set; }
        [Column("duration")]
        public int? Duration { get; set; }
        [Column("release_date", TypeName = "datetime")]
        public DateTime? ReleaseDate { get; set; }
    }
}
