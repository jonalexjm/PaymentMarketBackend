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

            CreateMap<ChargeCard, ChargeCardDto>().ReverseMap();
            
            CreateMap<City, CityDto>()
                .ForMember(dest => dest.City,
                    opt => opt
                        .MapFrom(src => src.City1))
                .ReverseMap();
            CreateMap<Country, CountryDto>()
                .ForMember(dest => dest.Country,
                    opt => opt
                        .MapFrom(src => src.Country1))
                .ReverseMap();
            
            CreateMap<Invoice, InvoiceDto>().ReverseMap();
            
            CreateMap<Market, MarketDto>()
                .ForMember(dest => dest.Market,
                    opt => opt
                        .MapFrom(src => src.Market1))
                .ReverseMap();

            CreateMap<Neighborhood, NeighborhoodDto>()
                .ForMember(dest => dest.Neighborhood,
                    opt => opt
                        .MapFrom(src => src.Neighborhood1))
                .ReverseMap();
            
            CreateMap<Rol, RolDto>().ReverseMap();
            
            CreateMap<State, StateDto>()
                .ForMember(dest => dest.State,
                    opt => opt
                        .MapFrom(src => src.State1))
                .ReverseMap();
            CreateMap<TypeDocument, TypeDocumentDto>()
                .ForMember(dest => dest.TypeDocument,
                    opt => opt
                        .MapFrom(src => src.TypeDocument1))
                .ReverseMap();
            
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<UserRol, UserRolDto>().ReverseMap();
        }
    }
}