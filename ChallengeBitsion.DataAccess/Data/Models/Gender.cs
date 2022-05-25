using ChallengeBitsion.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ChallengeBitsion.DataAccess.Data.Models
{
    [Table("Genders")]
    public class Gender : EntityBase
    {
        [Required]
        [StringLength(25)]
        public string Name { get; set; }
    }
}
