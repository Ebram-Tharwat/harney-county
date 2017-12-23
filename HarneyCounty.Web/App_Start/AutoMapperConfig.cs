using AutoMapper;
using HarneyCounty.Application.Core.ViewModel;
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

                cfg.CreateMap<ImprovementsFullDetail, ImprovementDetailsViewModel>();

                cfg.CreateMap<LandAssessmentFullDetail, LandAssessmentDetailsViewModel>();

                cfg.CreateMap<LandAssessmentMsav, LandAssessmentMsavViewModel>();

                cfg.CreateMap<AccountLegalComment, AccountLegalCommentViewModel>();

                cfg.CreateMap<FlaggingFullDetail, FlaggingDetailsViewModel>();

                cfg.CreateMap<OwnershipHistory, OwnershipHistoryViewModel>();

                cfg.CreateMap<SalesFullDetail, SalesDetailsViewModel>();
            });
        }
    }
}