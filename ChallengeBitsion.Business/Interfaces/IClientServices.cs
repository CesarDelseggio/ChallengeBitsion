using ChallengeBitsion.Business.Models;
using ChallengeBitsion.Business.Models.Clients;
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
    public interface IClientService
    {
        Task<ClientDetailDTO> Get(int id);
        Task<List<ClientDTO>> GetAll();
        Task<List<ClientDTO>> GetAll(ISpecification<Client> spec);
        Task<int> Count();
        Task<int> Count(ISpecification<Client> spec);

        void Insert(ClientEditDTO entity);
        void Update(ClientEditDTO entity);
        void Delete(int id);
    }
}
