using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace P_Requests.Models
{
    [Table("students")]
    public partial class Student
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string LastName { get; set; } = null!;
        [StringLength(50)]
        public string FirstName { get; set; } = null!;
        [Column(TypeName = "date")]
        public DateTime EnrollmentDate { get; set; }
    }
}
