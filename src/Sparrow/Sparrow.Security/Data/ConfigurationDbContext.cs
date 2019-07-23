﻿using IdentityServer4.EntityFramework.DbContexts;
using IdentityServer4.EntityFramework.Entities;
using IdentityServer4.EntityFramework.Options;
using Microsoft.EntityFrameworkCore;

namespace Sparrow.Security.Data
{
    public class ConfigurationDbContext: ConfigurationDbContext<ConfigurationDbContext>
    {
        public ConfigurationDbContext(DbContextOptions<ConfigurationDbContext> options, ConfigurationStoreOptions storeOptions) : 
            base(options, storeOptions)
        {
        }

        public DbSet<ApiResourceProperty> ApiResourceProperties { get; private set; }

        public DbSet<IdentityResourceProperty> IdentityResourceProperties { get; private set; }

        public DbSet<ApiSecret> ApiSecrets { get; private set; }

        public DbSet<ApiScope> ApiScopes { get; private set; }

        public DbSet<ApiScopeClaim> ApiScopeClaims { get; private set; }

        public DbSet<IdentityClaim> IdentityClaims { get; private set; }

        public DbSet<ApiResourceClaim> ApiResourceClaims { get; private set; }

        public DbSet<ClientGrantType> ClientGrantTypes { get; private set; }

        public DbSet<ClientScope> ClientScopes { get; private set; }

        public DbSet<ClientSecret> ClientSecrets { get; private set; }

        public DbSet<ClientPostLogoutRedirectUri> ClientPostLogoutRedirectUris { get; private set; }

        public DbSet<ClientCorsOrigin> ClientCorsOrigins { get; private set; }

        public DbSet<ClientIdPRestriction> ClientIdPRestrictions { get; private set; }

        public DbSet<ClientRedirectUri> ClientRedirectUris { get; private set; }

        public DbSet<ClientClaim> ClientClaims { get; private set; }

        public DbSet<ClientProperty> ClientProperties { get; private set; }
    }
}
