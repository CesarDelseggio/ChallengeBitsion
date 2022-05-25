﻿using ChallengeBitsion.Common.Interfaces;
using ChallengeBitsion.Common.Models;
using ChallengeBitsion.DataAccess.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeBitsion.DataAccess.Interfaces
{
    public interface IRepository<T> where T : EntityBase
    {
        Task<T> Get(int id);
        IQueryable<T> GetAll();
        IQueryable<T> GetAll(ISpecification<T> spec);
        Task<int> Count();
        Task<int> Count(ISpecification<T> spec);

        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
        void DeleteAll();
    }
}
