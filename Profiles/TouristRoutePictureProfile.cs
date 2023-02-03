using _01NET___CJ_ASP_Travel.Dtos;
using _01NET___CJ_ASP_Travel.Models;
using AutoMapper;

namespace _01NET___CJ_ASP_Travel.Profiles
{
    public class TouristRoutePictureProfile : Profile
    {
        public TouristRoutePictureProfile()
        {
            CreateMap<TouristRoutePicture, TouristRoutePictureDto>();
        }
    }
}
