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
    public class RestaurantProfile:Profile
    {
        public RestaurantProfile() {

            CreateMap<Test, TestDto>();
            CreateMap<TestDto, Test>();
            
            CreateMap<Restaurant, RestaurantDto>();

            CreateMap<RestaurantDto, Restaurant>();

            CreateMap<Restaurant, CreateRestaurantDto>();

            CreateMap<CreateRestaurantDto, Restaurant>();
        }
    }
}
