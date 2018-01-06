[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(HarneyCounty.Utilities.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(HarneyCounty.Utilities.App_Start.NinjectWebCommon), "Stop")]

namespace HarneyCounty.Utilities.App_Start
{
    using Domain.Core.Models;
    using Domain.Core.ViewModel;
    using HarneyCounty.Application.Core.Interfaces;
    using HarneyCounty.Application.Core.Services;
    using HarneyCounty.Infrastructure.Core;
    using HarneyCounty.Infrastructure.Core.DAL;
    using HarneyCounty.Infrastructure.Core.Interfaces;
    using HarneyCounty.Infrastructure.Core.Repositories;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;
    using Ninject;
    using Ninject.Web.Common;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;
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

        public static object CurrentDbContext
        {
            get
            {
                if (currentKernal == null)
                {
                    return null;
                }
                return currentKernal.Get(typeof(ApplicationDbContext));
            }
        }

        private static StandardKernel currentKernal = null;

        public static void InitializeMasterUser()
        {
            var currentDbContext = CurrentDbContext as ApplicationDbContext;
            var UserStore = new UserStore<ApplicationUser>(currentDbContext);
            var UserManager = new UserManager<ApplicationUser>(UserStore);

            string[] systemRoles = new string[] { "Admin", "Audit", "Payroll","Assessment" };
            List<string> names = new List<string>();
            names.Add("Admin");
            names.Add("Audit");
            names.Add("Payroll");
            names.Add("Assessment");

            for (int i = 0; i < systemRoles.Count(); i++)
            {
                string sysRoelName = systemRoles[i];
                IdentityRole sysRole = currentDbContext.Roles.Where(m => m.Name == sysRoelName).FirstOrDefault();
                if (sysRole == null)
                {
                    sysRole = new IdentityRole(sysRoelName);
                    currentDbContext.Roles.AddOrUpdate(sysRole);
                    currentDbContext.SaveChanges();
                    sysRole = currentDbContext.Roles.Where(m => m.Name == sysRoelName).FirstOrDefault();

                    string userName = names[i];
                    int deptId = i + 1;
                    if (deptId > 5)
                        deptId += 1;
                    ApplicationUser defaultUsers = new ApplicationUser { UserName = userName, Email = userName + "@harneycounty.com", FullName = "Test Harney county Admin User", PhoneNumber = "054863478", LockoutEnabled = true };
                    var result = UserManager.Create(defaultUsers, "123456");
                    if (result.Succeeded)
                    {
                        var roelResult = UserManager.AddToRoles(defaultUsers.Id, sysRole.Name);
                    }

                }
            }
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
                currentKernal = kernel;
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
            kernel.Bind<ApplicationDbContext>().ToSelf().InRequestScope();
            kernel.Bind<IUnitOfWork>().To<UnitOfWork>();

            kernel.Bind<IAccountMasterRepository>().To<AccountMasterRepository>();
            kernel.Bind<IAccountMasterService>().To<AccountMasterService>();

            kernel.Bind<IPropertyClassRepository>().To<PropertyClassRepository>();
            kernel.Bind<IPropertyClassService>().To<PropertyClassService>();

            kernel.Bind<ICodeAreaRepository>().To<CodeAreaRepository>();
            kernel.Bind<ICodeAreaService>().To<CodeAreaService>();

            kernel.Bind<IZipCodeFileRepository>().To<ZipCodeFileRepository>();
            kernel.Bind<IUtilityDetailRepository>().To<UtilityDetailRepository>();
            kernel.Bind<IImprovementRepository>().To<ImprovementRepository>();
            kernel.Bind<ILandAssessmentRepository>().To<LandAssessmentRepository>();
            kernel.Bind<IFlaggingDetailRepository>().To<FlaggingDetailRepository>();
            kernel.Bind<IAccountLegalCommentRepository>().To<AccountLegalCommentRepository>();
            kernel.Bind<ILandAssessmentMsavRepository>().To<LandAssessmentMsavRepository>();
            kernel.Bind<IOwnershipHistoryRepository>().To<OwnershipHistoryRepository>();
            kernel.Bind<ISalesFullDetailsRepository>().To<SalesFullDetailsRepository>();

            kernel.Bind<IJournalVoucherRepository>().To<JournalVoucherRepository>();
            kernel.Bind<IPersonalPropFullDetailsRepository>().To<PersonalPropFullDetailsRepository>();

            kernel.Bind<IRepository<DailyMaster>>().To<EFRepository<DailyMaster>>();

            #region Employee

            kernel.Bind<IEmployeeMasterRepository>().To<EmployeeMasterRepository>();
            kernel.Bind<IEmployeeMasterCommentRepository>().To<EmployeeMasterCommentRepository>();
            kernel.Bind<IEmployeePayHrsHistoryRepository>().To<EmployeePayHrsHistoryRepository>();
            kernel.Bind<IDeductionHistoryRepository>().To<DeductionHistoryRepository>();
            kernel.Bind<IDeductionMasterRepository>().To<DeductionMasterRepository>();
            kernel.Bind<IEmployeeMasterService>().To<EmployeeMasterService>();
            kernel.Bind<IEmployeePayHrsHistoryService>().To<EmployeePayHrsHistoryService>();
            kernel.Bind<IDeductionHistoryService>().To<DeductionHistoryService>();

            #endregion Employee

            #region Audit

            kernel.Bind<IRepository<AuditFiscalYear>>().To<EFRepository<AuditFiscalYear>>();
            kernel.Bind<IRepository<AuditTurnoverSequence>>().To<EFRepository<AuditTurnoverSequence>>();
            kernel.Bind<IAuditDailyDetailRepository>().To<AuditDailyDetailRepository>();
            kernel.Bind<IFiscalYearBeginningBalanceRepository>().To<FiscalYearBeginningBalanceRepository>();
            kernel.Bind<IFiscalYearBeginningBalanceService>().To<FiscalYearBeginningBalanceService>();
            kernel.Bind<IAuditService>().To<AuditService>();

            #endregion Audit
        }
    }
}