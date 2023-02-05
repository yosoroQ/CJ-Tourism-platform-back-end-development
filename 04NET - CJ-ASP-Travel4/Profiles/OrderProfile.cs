using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _04NET___CJ_ASP_Travel4.API.Dtos;
using _04NET___CJ_ASP_Travel4.Models;
using AutoMapper;

namespace _04NET___CJ_ASP_Travel4.Profiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<Order, OrderDto>()
                .ForMember(
                    dest => dest.State,
                    opt =>
                    {
                        opt.MapFrom(src => src.State.ToString());
                    }
                );
        }
    }
}
