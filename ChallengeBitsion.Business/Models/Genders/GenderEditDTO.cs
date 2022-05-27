using ChallengeBitsion.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ChallengeBitsion.Business.Models.Genders
{
    public class GenderEditDTO : EntityBase
    {
        [Required]
        [StringLength(25)]
        public string Name { get; set; }
    }
}
