using AutoMapper;
using PaymentMarketBackend.Core.DTOs;
using PaymentMarketBackend.Core.Entities;

namespace PaymentMarketBackend.Infrastructure.Mappings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Annio, AnnioDto>()
                .ForMember(dest => dest.Annio,
                            opt => opt
                                .MapFrom(src => src.Annio1))
                .ReverseMap();
        }
    }
}