using ChallengeBitsion.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeBitsion.Business.Models.Logs
{
    public class LogEditDTO : EntityBase
    {
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
    }
}
