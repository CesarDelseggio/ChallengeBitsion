using ChallengeBitsion.Common.Interfaces;
using ChallengeBitsion.Common.Models;
using ChallengeBitsion.Common.Specification;
using ChallengeBitsion.DataAccess.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ChallengeBitsion.Business.Specifications.Logs
{
    public class LogFilterByTitleSpec : Specification<Log>
    {
        public LogFilterByTitleSpec(string title)
        {
            AddCriteria(x => x.Title.Contains(title));
        }
    }
}
