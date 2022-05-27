﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreModels.AdventureWorks
{
    [Table("Contact", Schema = "Person")]
    public partial class Contact
    {
        public int ContactID { get; set; }
        public bool NameStyle { get; set; }
        [StringLength(8)]
        public string Title { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string MiddleName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(10)]
        public string Suffix { get; set; }
        [StringLength(50)]
        public string EmailAddress { get; set; }
        public int EmailPromotion { get; set; }
        [StringLength(25)]
        public string Phone { get; set; }
        [Required]
        [StringLength(128)]
        public string PasswordHash { get; set; }
        [Required]
        [StringLength(10)]
        public string PasswordSalt { get; set; }
        [Column(TypeName = "xml")]
        public string AdditionalContactInfo { get; set; }
        public Guid rowguid { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime ModifiedDate { get; set; }
    }
}