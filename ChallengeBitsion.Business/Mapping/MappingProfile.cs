using AutoMapper;
using ChallengeBitsion.Business.Models.Logs;
using ChallengeBitsion.DataAccess.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeBitsion.Business.Mapping
{
    internal class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Log, LogDTO>();
            CreateMap<Log, LogDetailDTO>();
            CreateMap<Log, LogEditDTO>();

            CreateMap<LogDTO, Log>();
            CreateMap<LogDetailDTO, Log>();
            CreateMap<LogEditDTO, Log>();
        }
    }
}
