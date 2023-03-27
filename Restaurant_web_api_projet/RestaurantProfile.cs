using AutoMapper;
using Dto;
using Models;

namespace Restaurant_web_api_projet
{
    public class RestaurantProfile:Profile
    {

        public RestaurantProfile()
        {
            CreateMap<Cuisine, CuisineDto>();

            CreateMap<CuisineDto, Cuisine>();

            CreateMap<CreateCuisineDto, Cuisine>();

            CreateMap<Cuisine, CreateCuisineDto>();

            CreateMap<Test, TestDto>();
            CreateMap<TestDto, Test>();

            CreateMap<Restaurant, RestaurantDto>();

            CreateMap<RestaurantDto, Restaurant>();

            CreateMap<Restaurant, CreateRestaurantDto>();

            CreateMap<CreateRestaurantDto, Restaurant>();

        }
    }
}
