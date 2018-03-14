using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Linq;
using System.Text;
using System.Web;

namespace API
{
    public static class DatabaseEntityCreator
    {
        public static DeskShellEntities CreateDB()
        {
            var originalConnectionString = ConfigurationManager.ConnectionStrings["DeskShellEntities"].ConnectionString;
            var entityBuilder = new EntityConnectionStringBuilder(originalConnectionString);
            var factory = DbProviderFactories.GetFactory(entityBuilder.Provider);
            var providerBuilder = factory.CreateConnectionStringBuilder();

            providerBuilder.ConnectionString = entityBuilder.ProviderConnectionString;

            providerBuilder.Add("Password", Encoding.UTF8.GetString(Convert.FromBase64String(ConfigurationManager.AppSettings["DBPass"])));

            entityBuilder.ProviderConnectionString = providerBuilder.ToString();

            return new DeskShellEntities(entityBuilder.ProviderConnectionString);
        }
    }
}