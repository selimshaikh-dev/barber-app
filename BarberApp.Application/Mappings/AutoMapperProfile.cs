using AutoMapper;
using BarberApp.Application.DTOs.AuthDtos;
using BarberApp.Domain.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BarberApp.Application.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // User Mapping
            CreateMap<User, RegisterRequestDto>().ReverseMap();

            // You can expand later:
            // CreateMap<User, UserDto>().ReverseMap();
            // CreateMap<Shop, ShopDto>().ReverseMap();
            // CreateMap<Booking, BookingDto>().ReverseMap();
        }
    }
}