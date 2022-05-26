using ChallengeBitsion.Business.Models.Genders;
using ChallengeBitsion.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ChallengeBitsion.Business.Models.Clients
{
    public class ClientEditDTO : EntityBase
    {
        [Required]
        public string FullName { get; set; }

        [Required]
        public string Identification { get; set; }

        [Required]
        [Range(0, 200)]
        public int Age { get; set; }
        public int Genre_Id { get; set; }
        public GenderDTO Gender { get; set; }
        [Required]
        public bool Status { get; set; }
        public bool Drive { get; set; }
        public bool Glasses { get; set; }
        public bool Diabetic { get; set; }
        [StringLength(300)]
        public string OtherDiseases { get; set; }
    }
}
