using AutoMapper;
using HarneyCounty.Application.Core.ViewModel;
using HarneyCounty.Domain.Core.ViewModel;

namespace HarneyCounty.Web.App_Start
{
    public class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<AccountMasterAndSummeryData, AccountMasterDetailsViewModel>()
                .ForMember(dest => dest.AccountNumber, opt => opt.MapFrom(src => src.AcctNmbr))
                .ForMember(dest => dest.Flg, opt => opt.MapFrom(src => src.CareOfFlag))
                .ForMember(dest => dest.Prop, opt => opt.MapFrom(src => src.PropClassCode))
                .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.CodeAreaCode))
                //.ForMember(dest => dest.Rl, opt => opt.MapFrom(src => src.RollType)).MaxDepth(1)
                .ForMember(dest => dest.MobileHomeData, opt => opt.MapFrom(src => src.MobileHomeRecords))
                ;

                cfg.CreateMap<AccountMasterAndSummeryData, RealPropertyAccountViewModel>()
                .ForMember(dest => dest.AccountNumber, opt => opt.MapFrom(src => src.AcctNmbr))
                .ForMember(dest => dest.Flg, opt => opt.MapFrom(src => src.CareOfFlag))
                .ForMember(dest => dest.Prop, opt => opt.MapFrom(src => src.PropClassCode))
                .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.CodeAreaCode))
                .ForMember(dest => dest.MobileHomeData, opt => opt.MapFrom(src => src.MobileHomeRecords))
                ;

                cfg.CreateMap<MobileHomeData, MobileHomeViewModel>();
            });
        }
    }
}