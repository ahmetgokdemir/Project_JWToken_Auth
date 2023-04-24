using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using AuthServer.Core.DTOs;
using AuthServer.Core.Models;

namespace AuthServer.Service
{
    internal class DtoMapper : Profile
    {
        public DtoMapper()
        {
            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<UserAppDto, UserApp>().ReverseMap();
        }
    }
}