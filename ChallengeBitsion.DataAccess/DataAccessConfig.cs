using ChallengeBitsion.DataAccess;
using ChallengeBitsion.DataAccess.Data.Models;
using ChallengeBitsion.DataAccess.Interfaces;
using ChallengeBitsion.DataAccess.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeBitsion.Business
{
    public static class DataAccessConfig
    {
        public static void AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options => 
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
                .UseSqlServer(configuration.GetConnectionString("DefaultConnectionStrings")));

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<AppDbContext>();

            services.AddTransient<UnitOfWork, UnitOfWork>();
            services.AddTransient<IRepository<Log>, Repository<Log>>();
            services.AddTransient<IRepository<Gender>, Repository<Gender>>();
            services.AddTransient<IRepository<Client>, Repository<Client>>();
        }
    }
}
