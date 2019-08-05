﻿using Microsoft.Extensions.Configuration;
using Sparrow.Core.Dependency;
using System;
using System.Configuration;

namespace Sparrow.Core.Data
{
    public class DefaultConnectionStringResolver : IConnectionStringResolver, ITransientDependency
    {
        private readonly IConfiguration _configuration;

        public DefaultConnectionStringResolver(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public virtual string GetConnectionString(ConnectionStringResolveArgs args)
        {
            var defaultConnectionString = _configuration.GetConnectionString("Default");
            if (!string.IsNullOrWhiteSpace(defaultConnectionString))
            {
                return defaultConnectionString;
            }

            if (ConfigurationManager.ConnectionStrings["Default"] != null)
            {
                return ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            }

            if (ConfigurationManager.ConnectionStrings.Count == 1)
            {
                return ConfigurationManager.ConnectionStrings[0].ConnectionString;
            }

            throw new Exception("Could not find a connection string definition for the application. Add a 'Default' connection string to application .config file.");
        }
    }
}
