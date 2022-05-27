using ChallengeBitsion.Common.Interfaces;
using ChallengeBitsion.Common.Models;
using ChallengeBitsion.Common.Specification;
using ChallengeBitsion.DataAccess.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ChallengeBitsion.Business.Specifications.Clients
{
    public class ClientsWithGenderPagedSpec : Specification<Client>
    {
        public ClientsWithGenderPagedSpec(int page, int pageCount)
        {
            AddIncludeNames("Gender");
            SetPagination(page, pageCount);
        }
    }
}
