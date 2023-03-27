using Abstructs;
using AutoMapper;
using DbContexts;
using Dto;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class RestaurantService : IRestaurantService
    {
        private readonly RestaurantContext restaurantContext;
        private readonly IMapper mapper;

        public RestaurantService(
            RestaurantContext restaurantContext,
            IMapper mapper)
        {
            this.restaurantContext = restaurantContext;
            this.mapper = mapper;
        }
        public CreateRestaurantDto AddRestaurant(CreateRestaurantDto dto)
        {
            var restaurant = mapper.Map<Restaurant>(dto);

            restaurantContext.Restaurants.Add(restaurant);

            restaurantContext.SaveChanges();              
            return dto;

        }

        public void DeleteRestaurant(int id)
        {
            var restaurant = restaurantContext.Restaurants.FirstOrDefault(r => r.Id == id);

            if (restaurant != null)
            {
                restaurantContext.Restaurants.Remove(restaurant);
                restaurantContext.SaveChanges();
            }
        }

        public RestaurantDto GetRestaurant(int id)
        {

            var restaurant = restaurantContext.Restaurants.Include(r => r.Cuisines).FirstOrDefault(r => r.Id == id);

            var result = mapper.Map<RestaurantDto>(restaurant);

            return result;

        }

        public List<RestaurantDto> GetRestaurants()
        {
            Test test = new Test() { Data="testing"};
            var Test = mapper.Map<TestDto>(test);
            var restaurants=restaurantContext.Restaurants.Include(r => r.Cuisines).ToList();
            var restaurantsDtos = mapper.Map<List<RestaurantDto>>(restaurants);
            return restaurantsDtos;
        }

        public void UpdateRestaurant(int id, CreateRestaurantDto updatedRestaurant)
        {
           var restaurant= restaurantContext.Restaurants.FirstOrDefault(r => r.Id == id);

            if (restaurant!=null)
            {
                restaurant.Name = updatedRestaurant.Name;
                restaurant.Adress = updatedRestaurant.Adress;
                restaurant.Description = updatedRestaurant.Description;

                restaurantContext.SaveChanges();
            }

         

        }
    }
}
