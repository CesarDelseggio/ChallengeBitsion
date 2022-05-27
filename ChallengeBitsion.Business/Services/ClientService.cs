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

        public async Task<ClientEditDTO> Get(int id)
        {
            var result = await _repository.Get(id);

            return AutoMapper.Mapper.Map<ClientEditDTO>(result);
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

        public async Task Insert(ClientEditDTO entity)
        {
            var entityModel = AutoMapper.Mapper.Map<Client>(entity);
            entityModel.Gender = null;

            await _repository.Insert(entityModel);
            await _unitOfWork.SaveAsync();
        }

        public async Task Update(ClientEditDTO entity)
        {
            var entityModel = AutoMapper.Mapper.Map<Client>(entity);
            entityModel.Gender = null;

            await _repository.Update(entityModel);
            await _unitOfWork.SaveAsync();
        }

        public async Task Delete(int id)
        {
            await _repository.Delete(id);
            await _unitOfWork.SaveAsync();
        }

        public async Task DeleteAll()
        {
            await _repository.DeleteAll();
            await _unitOfWork.SaveAsync();
        }
    }
}
