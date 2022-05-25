﻿using ChallengeBitsion.Business.Models;
using ChallengeBitsion.Business.Models.Logs;
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
    public interface ILogService
    {
        Task<LogDetailDTO> Get(int id);
        Task<List<LogDTO>> GetAll();
        Task<List<LogDTO>> GetAll(ISpecification<Log> spec);
        Task<int> Count();
        Task<int> Count(ISpecification<Log> spec);

        void Insert(LogEditDTO entity);
        void Update(LogEditDTO entity);
        void Delete(int id);
    }
}