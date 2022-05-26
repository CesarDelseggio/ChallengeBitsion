using ChallengeBitsion.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ChallengeBitsion.DataAccess.Data.Models
{
    [Table("Clients")]
    public class Client : EntityBase
    {
        [Required]
        public string FullName { get; set; }
        
        [Required]
        public string Identification { get; set; }
        
        [Required]
        [Range(0,200)]
        public int Age { get; set; }

        [ForeignKey(nameof(Gender))]
        public int Gender_Id { get; set; }
        public Gender Gender { get; set; }
        [Required]
        public bool Status { get; set; }
        public bool Drive { get; set; }
        public bool Glasses { get; set; }
        public bool Diabetic { get; set; }
        [StringLength(300)]
        public string OtherDiseases { get; set; }

    }
}
