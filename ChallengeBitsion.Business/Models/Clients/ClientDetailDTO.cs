using ChallengeBitsion.Business.Models.Genders;
using ChallengeBitsion.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeBitsion.Business.Models.Clients
{
    public class ClientDetailDTO : EntityBase
    {
        public string FullName { get; set; }
        public string Identification { get; set; }
        public int Age { get; set; }
        public GenderDTO Gender { get; set; }
        public bool Status { get; set; }
        public bool Drive { get; set; }
        public bool Glasses { get; set; }
        public bool Diabetic { get; set; }
        public string OtherDiseases { get; set; }
    }
}
