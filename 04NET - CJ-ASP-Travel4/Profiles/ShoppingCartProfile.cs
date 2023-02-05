using AutoMapper;
using _04NET___CJ_ASP_Travel4.Dtos;
using _04NET___CJ_ASP_Travel4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _04NET___CJ_ASP_Travel4.Profiles
{
    public class ShoppingCartProfile : Profile
    {
        public ShoppingCartProfile()
        {
            CreateMap<ShoppingCart, ShoppingCartDto>();
            CreateMap<LineItem, LineItemDto>();
        }
    }
}
