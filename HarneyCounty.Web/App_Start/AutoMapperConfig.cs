using AutoMapper;
using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Web.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HarneyCounty.Web.App_Start
{
    public class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<AccountMasterFullDetail, Data>()
                .ForMember(dest => dest.OwnerName, opt => opt.MapFrom(src => src.OwnerName))
                .ForMember(dest => dest.AccountNumber, opt => opt.MapFrom(src => src.AcctNmbr))
                .ForMember(dest => dest.Flg , opt => opt.MapFrom(src => src.CareOfFlag))
                .ForMember(dest => dest.Prop, opt => opt.MapFrom(src => src.PropClassCode))
                .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.CodeAreaCode))
                .ForMember(dest => dest.Rl, opt => opt.MapFrom(src => src.RollType)).MaxDepth(1);
            });
        }
    }
}