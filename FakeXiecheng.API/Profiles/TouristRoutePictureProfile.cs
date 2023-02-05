using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using _03NET___CJ_ASP_Travel3.Dtos;
using _03NET___CJ_ASP_Travel3.Models;

namespace _03NET___CJ_ASP_Travel3.Profiles
{
    public class TouristRoutePictureProfile : Profile
    {
        public TouristRoutePictureProfile()
        {
            CreateMap<TouristRoutePicture, TouristRoutePictureDto>();
            CreateMap<TouristRoutePictureForCreationDto, TouristRoutePicture>();
            CreateMap<TouristRoutePicture, TouristRoutePictureForCreationDto>();
        }
    }
}
