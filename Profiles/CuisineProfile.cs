using AutoMapper;
using Dto;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profiles
{
    public class CuisineProfile:Profile
    {
        public CuisineProfile()
        {
            CreateMap<Cuisine,CuisineDto>();

            CreateMap<CuisineDto, Cuisine>();

            CreateMap<CreateCuisineDto, Cuisine>();

            CreateMap<Cuisine, CreateCuisineDto>();


        }
    }
}
