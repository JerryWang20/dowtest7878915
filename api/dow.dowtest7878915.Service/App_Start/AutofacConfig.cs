using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using Autofac.Integration.WebApi;
using System.Web.Http;
using System.Reflection;
using dow.dowtest7878915.Service.Controllers;
using System.Web.Compilation;
using dow.dowtest7878915.Data.EF;
using dow.dowtest7878915.Data.Interface;
using Dow.Core.Library.Azure;
using dow.dowtest7878915.Common;

namespace dow.dowtest7878915.Service
{
    public static class AutofacConfig
    {
        private const string ServiceClass = "Service";
        private const string RepositoryClass = "Repository";
        private const string BizAssembly = "dow.dowtest7878915.Biz.Impl";
        private const string DataAssembly = "dow.dowtest7878915.Data.EF";

        public static void RegisterComponents()
        {
            var builder = new ContainerBuilder();

            // Get your HttpConfiguration.
            var config = GlobalConfiguration.Configuration;

            var bizAssembly = Assembly.Load(BizAssembly); 
            var dataAssembly = Assembly.Load(DataAssembly);

            string connection = KeyValutHelper.GetSecret(CommonConfig.DBConnectionSecretUri);
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope().WithParameter("connection", connection);

            builder.RegisterAssemblyTypes(bizAssembly)
                  .Where(x => x.Name.EndsWith(ServiceClass))
                  .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(dataAssembly)
                .Where(x => x.Name.EndsWith(RepositoryClass))
                .AsImplementedInterfaces();

            // Register your Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }


    }
}