using ChallengeBitsion.Business.Interfaces;
using ChallengeBitsion.Business.Models.Logs;
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
    public class LogService : ILogService
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly IRepository<Log> _repository;
        public LogService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = unitOfWork.LogRepository;
        }

        public async Task<int> Count()
        {
            return await _repository.Count();
        }

        public async Task<int> Count(ISpecification<Log> spec)
        {
            return await _repository.Count(spec);
        }

        public async Task<LogEditDTO> Get(int id)
        {
            var result = await _repository.Get(id);

            return AutoMapper.Mapper.Map<LogEditDTO>(result);
        }

        public async Task<List<LogDTO>> GetAll()
        {
            var result = await _repository.GetAll().ToListAsync();

            return AutoMapper.Mapper.Map<List<LogDTO>>(result);
        }

        public async Task<List<LogDTO>> GetAll(ISpecification<Log> spec)
        {
            var result = await _repository.GetAll(spec).ToListAsync();

            return AutoMapper.Mapper.Map<List<LogDTO>>(result);
        }

        public void Insert(LogEditDTO entity)
        {
            var entityModel = AutoMapper.Mapper.Map<Log>(entity);
            
            _repository.Insert(entityModel);
        }

        public void Update(LogEditDTO entity)
        {
            var entityModel = AutoMapper.Mapper.Map<Log>(entity);

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
