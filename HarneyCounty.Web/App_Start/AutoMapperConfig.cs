using AutoMapper;
using HarneyCounty.Application.Core.ViewModel;
using HarneyCounty.Application.Core.ViewModel.Audit;
using HarneyCounty.Application.Core.ViewModel.Payroll;
using HarneyCounty.Domain.Core.Models;

namespace HarneyCounty.Web.App_Start
{
    public class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<AccountMasterFullDetail, AccountMasterDetailsViewModel>()
                .ForMember(dest => dest.AccountNumber, opt => opt.MapFrom(src => src.AcctNmbr))
                .ForMember(dest => dest.Flg, opt => opt.MapFrom(src => src.CareOfFlag))
                .ForMember(dest => dest.Prop, opt => opt.MapFrom(src => src.PropClassCode))
                .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.CodeAreaCode))
                ;

                cfg.CreateMap<AccountMasterFullDetail, RealPropertyAccountViewModel>()
                .ForMember(dest => dest.AccountNumber, opt => opt.MapFrom(src => src.AcctNmbr))
                .ForMember(dest => dest.Flg, opt => opt.MapFrom(src => src.CareOfFlag))
                .ForMember(dest => dest.Prop, opt => opt.MapFrom(src => src.PropClassCode))
                .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.CodeAreaCode))
                ;

                cfg.CreateMap<AccountMasterFullDetail, UtilityPropertyAccountViewModel>()
                .ForMember(dest => dest.AccountNumber, opt => opt.MapFrom(src => src.AcctNmbr))
                .ForMember(dest => dest.Flg, opt => opt.MapFrom(src => src.CareOfFlag))
                .ForMember(dest => dest.Prop, opt => opt.MapFrom(src => src.PropClassCode))
                .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.CodeAreaCode))
                ;

                cfg.CreateMap<AccountMasterFullDetail, MobileHomePropertyAccountViewModel>()
                .ForMember(dest => dest.AccountNumber, opt => opt.MapFrom(src => src.AcctNmbr))
                .ForMember(dest => dest.Flg, opt => opt.MapFrom(src => src.CareOfFlag))
                .ForMember(dest => dest.Prop, opt => opt.MapFrom(src => src.PropClassCode))
                .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.CodeAreaCode))
                ;

                cfg.CreateMap<PersonalPropFullDetail, PersonalPropertyAccountViewModel>()
                .ForMember(dest => dest.AccountNumber, opt => opt.MapFrom(src => src.AcctNmbr))
                .ForMember(dest => dest.Flg, opt => opt.MapFrom(src => src.CareOfFlag))
                .ForMember(dest => dest.Prop, opt => opt.MapFrom(src => src.PropClassCode))
                .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.CodeAreaCode))
                ;

                #region Tabs

                cfg.CreateMap<ImprovementsFullDetail, ImprovementDetailsViewModel>();

                cfg.CreateMap<LandAssessmentFullDetail, LandAssessmentDetailsViewModel>();

                cfg.CreateMap<LandAssessmentMsav, LandAssessmentMsavViewModel>();

                cfg.CreateMap<AccountLegalComment, AccountLegalCommentViewModel>();

                cfg.CreateMap<FlaggingFullDetail, FlaggingDetailsViewModel>();

                cfg.CreateMap<OwnershipHistory, OwnershipHistoryViewModel>();

                cfg.CreateMap<SalesFullDetail, SalesDetailsViewModel>();

                #endregion Tabs

                #region Employee

                cfg.CreateMap<EmployeeMaster, EmployeeMasterViewModel>();
                cfg.CreateMap<EmployeeMasterComment, EmployeeMasterCommentViewModel>();
                cfg.CreateMap<EmployeePayHrsHistory, PayHrsHistoryViewModel>();
                cfg.CreateMap<EmployeePayHrsHistory, PayDetailsViewModel>();
                cfg.CreateMap<EmployeePayHrsHistory, HourDetailsViewModel>();
                cfg.CreateMap<DeductionFullDetail, DeductionDetailsViewModel>();

                #endregion Employee

                #region Audit

                cfg.CreateMap<FiscalYearBeginningBalance, FiscalYearBeginningBalanceViewModel>()
                .ReverseMap()
                .ForMember(dest => dest.AuditFiscalYear, opt => opt.Ignore());
                cfg.CreateMap<AuditFiscalYear, AuditFiscalYearViewModel>()
                .ReverseMap();

                #endregion Audit
            });
        }
    }
}