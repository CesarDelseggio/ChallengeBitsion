using ChallengeBitsion.Business.Interfaces;
using ChallengeBitsion.Business.Models.Clients;
using ChallengeBitsion.Common.Interfaces;
using ChallengeBitsion.Common.Models;
using ChallengeBitsion.Common.Specification;
using ChallengeBitsion.DataAccess.Data.Models;
using ChallengeBitsion.DataAccess.Interfaces;
using ChallengeBitsion.DataAccess.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeBitsion.Business.Services
{
    public class ClientService : IClientService
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly IRepository<Client> _repository;
        public ClientService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = unitOfWork.ClientRepository;
        }

        public async Task<int> Count()
        {
            return await _repository.Count();
        }

        public async Task<int> Count(ISpecification<Client> spec)
        {
            return await _repository.Count(spec);
        }

        public async Task<ClientDetailDTO> Get(int id)
        {
            var result = await _repository.Get(id);

            return AutoMapper.Mapper.Map<ClientDetailDTO>(result);
        }

        public async Task<List<ClientDTO>> GetAll()
        {
            var result = await _repository.GetAll().ToListAsync();

            return AutoMapper.Mapper.Map<List<ClientDTO>>(result);
        }

        public async Task<List<ClientDTO>> GetAll(ISpecification<Client> spec)
        {
            var result = await _repository.GetAll(spec).ToListAsync();

            return AutoMapper.Mapper.Map<List<ClientDTO>>(result);
        }

        public void Insert(ClientEditDTO entity)
        {
            var entityModel = AutoMapper.Mapper.Map<Client>(entity);
            
            _repository.Insert(entityModel);
        }

        public void Update(ClientEditDTO entity)
        {
            var entityModel = AutoMapper.Mapper.Map<Client>(entity);

            _repository.Update(entityModel);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public void DeleteAll()
        {
            _repository.DeleteAll();
        }
    }
}
