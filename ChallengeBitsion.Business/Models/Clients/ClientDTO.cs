using ChallengeBitsion.Business.Models.Genders;
using ChallengeBitsion.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ChallengeBitsion.Business.Models.Clients
{
    public class ClientDTO : EntityBase
    {
        public string FullName { get; set; }
        public string Identification { get; set; }
        public int Age { get; set; }
        public int Gender_Id { get; set; }
        public GenderDTO Gender { get; set; }
        public bool Status { get; set; }
    }
}
