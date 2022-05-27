using ChallengeBitsion.Business.Interfaces;
using ChallengeBitsion.Business.Models.Genders;
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
    public class GenderService : IGenderService
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly IRepository<Gender> _repository;
        public GenderService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = unitOfWork.GenderRepository;
        }

        public async Task<int> Count()
        {
            return await _repository.Count();
        }

        public async Task<int> Count(ISpecification<Gender> spec)
        {
            return await _repository.Count(spec);
        }

        public async Task<GenderEditDTO> Get(int id)
        {
            var result = await _repository.Get(id);

            return AutoMapper.Mapper.Map<GenderEditDTO>(result);
        }

        public async Task<List<GenderDTO>> GetAll()
        {
            var result = await _repository.GetAll().ToListAsync();

            return AutoMapper.Mapper.Map<List<GenderDTO>>(result);
        }

        public async Task<List<GenderDTO>> GetAll(ISpecification<Gender> spec)
        {
            var result = await _repository.GetAll(spec).ToListAsync();

            return AutoMapper.Mapper.Map<List<GenderDTO>>(result);
        }

        public async Task Insert(GenderEditDTO entity)
        {
            var entityModel = AutoMapper.Mapper.Map<Gender>(entity);
            
            await _repository.Insert(entityModel);
            await _unitOfWork.SaveAsync();
        }

        public async Task Update(GenderEditDTO entity)
        {
            var entityModel = AutoMapper.Mapper.Map<Gender>(entity);

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
