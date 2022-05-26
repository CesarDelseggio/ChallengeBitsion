using ChallengeBitsion.Business.Interfaces;
using ChallengeBitsion.Business.Services;
using ChallengeBitsion.DataAccess.Data.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using ChallengeBitsion.Business.Mapping;

namespace ChallengeBitsion.Business
{
    public static class BusinessConfig
    {
        public static void AddBusinessServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDataAccessServices(configuration);

            services.AddScoped<ILogService, LogService>();
            services.AddScoped<IGenderService, GenderService>();
            services.AddScoped<IClientService, ClientService>();

            //configura automapper with data of MappingProfile
            Mapper.Initialize(cfg => cfg.AddProfile<MappingProfile>());
            services.AddAutoMapper();
        }
    }
}
