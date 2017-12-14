[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(HarneyCounty.Utilities.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(HarneyCounty.Utilities.App_Start.NinjectWebCommon), "Stop")]

namespace HarneyCounty.Utilities.App_Start
{
    using Domain.Core.Models;
    using HarneyCounty.Application.Core.Interfaces;
    using HarneyCounty.Application.Core.Services;
    using HarneyCounty.Infrastructure.Core;
    using HarneyCounty.Infrastructure.Core.DAL;
    using HarneyCounty.Infrastructure.Core.Interfaces;
    using HarneyCounty.Infrastructure.Core.Repositories;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;
    using Ninject;
    using Ninject.Web.Common;
    using System;
    using System.Web;

    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<HarneyCountyDbContext>().ToSelf().InRequestScope();
            kernel.Bind<IUnitOfWork>().To<UnitOfWork>();

            kernel.Bind<IAccountMasterRepository>().To<AccountMasterRepository>();
            kernel.Bind<IAccountMasterService>().To<AccountMasterService>();
            kernel.Bind<IAuditService>().To<AuditService>();

            kernel.Bind<IPropertyClassRepository>().To<PropertyClassRepository>();
            kernel.Bind<IPropertyClassService>().To<PropertyClassService>();

            kernel.Bind<ICodeAreaRepository>().To<CodeAreaRepository>();
            kernel.Bind<ICodeAreaService>().To<CodeAreaService>();

            kernel.Bind<IZipCodeFileRepository>().To<ZipCodeFileRepository>();
            kernel.Bind<IUtilityDetailRepository>().To<UtilityDetailRepository>();
            kernel.Bind<IImprovementRepository>().To<ImprovementRepository>();

            kernel.Bind<IJournalVoucherRepository>().To<JournalVoucherRepository>();
            kernel.Bind<IPersonalPropFullDetailsRepository>().To<PersonalPropFullDetailsRepository>();
            kernel.Bind<IRepository<AuditFiscalYear>>().To<EFRepository<AuditFiscalYear>>();
            kernel.Bind<IRepository<AuditTurnoverSequence>>().To<EFRepository<AuditTurnoverSequence>>();
            kernel.Bind<IRepository<DailyMaster>>().To<EFRepository<DailyMaster>>();
            kernel.Bind<IRepository<AuditDailyDetail>>().To<EFRepository<AuditDailyDetail>>();
        }
    }
}