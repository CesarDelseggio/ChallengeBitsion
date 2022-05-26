using AutoMapper;
using ChallengeBitsion.Business.Models.Clients;
using ChallengeBitsion.Business.Models.Genders;
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
            #region LogMapping
            CreateMap<Log, LogDTO>();
            CreateMap<Log, LogDetailDTO>();
            CreateMap<Log, LogEditDTO>();

            CreateMap<LogDTO, Log>();
            CreateMap<LogDetailDTO, Log>();
            CreateMap<LogEditDTO, Log>();
            #endregion

            #region ClientMapping
            CreateMap<Client, ClientDTO>();
            CreateMap<Client, ClientDetailDTO>();
            CreateMap<Client, ClientEditDTO>();

            CreateMap<ClientDTO, Client>();
            CreateMap<ClientDetailDTO, Client>();
            CreateMap<ClientEditDTO, Client>();
            #endregion

            #region GenderMapping
            CreateMap<Gender, GenderDTO>();
            CreateMap<Gender, GenderDetailDTO>();
            CreateMap<Gender, GenderEditDTO>();

            CreateMap<GenderDTO, Gender>();
            CreateMap<GenderDetailDTO, Gender>();
            CreateMap<GenderEditDTO, Gender>();
            #endregion
        }
    }
}
