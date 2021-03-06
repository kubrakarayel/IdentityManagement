﻿using IdentityServer4.EntityFramework.DbContexts;
using IdentityServer4.EntityFramework.Options;
using Microsoft.EntityFrameworkCore;

namespace IdentityManagement.Infrastructure.Persistence
{
    public class AppConfigurationDbContext : ConfigurationDbContext
    {
        public AppConfigurationDbContext(DbContextOptions<ConfigurationDbContext> options, ConfigurationStoreOptions storeOptions) : base(options, storeOptions)
        {
        }
    }
}
