using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Keyless]
    public partial class ConstructorV
    {
        [Column("Constructor_ID")]
        public int ConstructorId { get; set; }
        [Column("Constructor_Name")]
        [StringLength(150)]
        public string? ConstructorName { get; set; }
        [Column("Constructor_Code")]
        [StringLength(100)]
        public string? ConstructorCode { get; set; }
        [StringLength(6)]
        public string? Sex { get; set; }
        [Column("Married_Status")]
        [StringLength(100)]
        public string? MarriedStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Birthday { get; set; }
        public int? Age { get; set; }
        [StringLength(300)]
        public string? Address { get; set; }
        [Column("Current_Address")]
        [StringLength(300)]
        public string? CurrentAddress { get; set; }
        [StringLength(100)]
        public string? Phone { get; set; }
        [Column("Start_Date", TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [Column("Constructor_Number")]
        public int? ConstructorNumber { get; set; }
        [StringLength(500)]
        public string? Photo { get; set; }
        public int? Position { get; set; }
        [Column("Constructor_Type")]
        [StringLength(250)]
        public string? ConstructorType { get; set; }
        [Column("Supervisor_ID")]
        public int? SupervisorId { get; set; }
        [Column("Department_ID")]
        public int? DepartmentId { get; set; }
        [Column("Project_ID")]
        public int? ProjectId { get; set; }
        [Column("Group_ID")]
        public int? GroupId { get; set; }
        public bool? CanApprove1 { get; set; }
        public bool? CanApprove2 { get; set; }
        public bool? CanApprove3 { get; set; }
        public bool? CanApprove4 { get; set; }
        public bool? AccCanApprove1 { get; set; }
        public bool? AccCanApprove2 { get; set; }
        public bool? AccCanApprove3 { get; set; }
        public bool? AccCanApprove4 { get; set; }
        [StringLength(500)]
        public string? Remark1 { get; set; }
        [StringLength(500)]
        public string? Remark2 { get; set; }
        [Column("Constructor_Number_Type")]
        [StringLength(50)]
        public string? ConstructorNumberType { get; set; }
        public byte? Level { get; set; }
        public bool? Deleted { get; set; }
        public bool? CanApprove5 { get; set; }
        [Column("Living_Female")]
        public int? LivingFemale { get; set; }
        [Column("Living_Male")]
        public int? LivingMale { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string? Email { get; set; }
        [Column("SubCon_Position")]
        [StringLength(250)]
        public string? SubConPosition { get; set; }
        [Column("SubCon_Department")]
        [StringLength(250)]
        public string? SubConDepartment { get; set; }
        [Column("Payment_Method")]
        [StringLength(50)]
        public string? PaymentMethod { get; set; }
        [Column("Payment_QR_Image")]
        [StringLength(500)]
        public string? PaymentQrImage { get; set; }
        [Column("Bank_Name")]
        [StringLength(150)]
        public string? BankName { get; set; }
        [Column("Bank_Account")]
        [StringLength(150)]
        public string? BankAccount { get; set; }
        public int Expr1 { get; set; }
    }
}
