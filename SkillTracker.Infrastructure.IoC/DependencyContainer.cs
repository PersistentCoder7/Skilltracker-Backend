﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using SkillTracker.Domain.Core.Bus;
using SkillTracker.Infrastructure.Bus;
using SkillTracker.Profile.Application.Interfaces;
using SkillTracker.Profile.Application.Services;
using SkillTracker.Profile.Data.DbContext;
using SkillTracker.Profile.Data.Repository;
using SkillTracker.Profile.Domain.Interfaces;

namespace SkillTracker.Infrastructure.IoC
{
    public  class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();

            //Application Services
            services.AddTransient<IProfileService, ProfileService>();

            //DataSource
            services.AddTransient<IProfileRepository, ProfileRepository>();
            services.AddTransient<ProfileDbContext>();
        }
    }
}
