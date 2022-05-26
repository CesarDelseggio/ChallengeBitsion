using ChallengeBitsion.Common.Interfaces;
using ChallengeBitsion.Common.Models;
using ChallengeBitsion.DataAccess.Data.Models;
using ChallengeBitsion.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeBitsion.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        private readonly AppDbContext _context;

        public Repository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<T> Get(int id)
        {
            return await _context.Set<T>()
                .FirstOrDefaultAsync(x=>x.Id==id);
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().AsQueryable();
        }

        public IQueryable<T> GetAll(ISpecification<T> spec)
        {
            return ApplySpecification(spec, _context.Set<T>().AsQueryable());
        }

        public async Task<int> Count()
        {
            return await _context.Set<T>().CountAsync();
        }

        public async Task<int> Count(ISpecification<T> spec)
        {
            return await _context.Set<T>().CountAsync(spec.Criteria);
        }

        public async Task Insert(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public async Task Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
        public async Task Delete(int id)
        {
            var entity = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(entity);
        }
        public async Task DeleteAll()
        {
            var query = _context.Set<T>().AsQueryable();
            _context.Set<T>().RemoveRange(query);
        }

        private IQueryable<T> ApplySpecification(ISpecification<T> spec, IQueryable<T> query)
        {
            if (spec is null) return query;

            if (spec.Criteria != null) query = query.Where(spec.Criteria);

            foreach (var item in spec.Includes)
            {
                query = query.Include(item);
            }

            foreach (var item in spec.IncludeNames)
            {
                query = query.Include(item);
            }

            query = query.Skip(spec.Skip)
                .Take(spec.Take);

            return query;
        }
    }
}
