using ChallengeBitsion.Business.Models;
using ChallengeBitsion.Business.Models.Genders;
using ChallengeBitsion.Common.Interfaces;
using ChallengeBitsion.Common.Models;
using ChallengeBitsion.DataAccess.Data.Models;
using ChallengeBitsion.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeBitsion.Business.Interfaces
{
    public interface IGenderService
    {
        Task<GenderEditDTO> Get(int id);
        Task<List<GenderDTO>> GetAll();
        Task<List<GenderDTO>> GetAll(ISpecification<Gender> spec);
        Task<int> Count();
        Task<int> Count(ISpecification<Gender> spec);

        void Insert(GenderEditDTO entity);
        void Update(GenderEditDTO entity);
        void Delete(int id);
    }
}
