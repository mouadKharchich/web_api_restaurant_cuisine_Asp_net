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
    public class CuisineService : ICuisineService
    {

        private readonly RestaurantContext restaurantContext;
        private readonly IMapper mapper;

        public CuisineService(
            RestaurantContext restaurantContext,
            IMapper mapper)
        {
            this.restaurantContext = restaurantContext;
            this.mapper = mapper;
        }
        public CreateCuisineDto AddCuisine(int restaurantId,CreateCuisineDto dto)
        {
            var restaurant = GetRestaurantById(restaurantId);
            var cuisinEntity = mapper.Map<Cuisine>(dto);

            //cuisinEntity.Id = restaurantId;
            cuisinEntity.RestaurantId = restaurantId;
            //cuisinEntity.Restaurant = restaurant;
            
            restaurantContext.Cuisines.Add(cuisinEntity);
            
            restaurantContext.SaveChanges();
            
            return dto;
        }

        public void DeleteCuisine(int restaurantId,int id)
        {

            var restaurant = GetRestaurantById(restaurantId);

            var cuisine=restaurant.Cuisines.FirstOrDefault(d => d.Id == id);
            
            restaurantContext.Cuisines.Remove(cuisine);

            restaurantContext.SaveChanges();
            
        }

        public CuisineDto GetCuisine(int restaurantId,int id)
        {


            var restaurant = GetRestaurantById(restaurantId);
            var cuisine = restaurantContext.Cuisines.FirstOrDefault(c => c.Id == id);

          
            var cuisineDto = mapper.Map<CuisineDto>(cuisine);

            return cuisineDto;
        }

        public List<CuisineDto> GetCuisines(int restaurantId)
        {

            var restaurant = GetRestaurantById(restaurantId);

            var cuisineDtos = mapper.Map<List<CuisineDto>>(restaurant.Cuisines);

            return cuisineDtos;
        }

        public void UpdateCuisine(int restaurantId,int id, CreateCuisineDto updatedCuisine)
        {
            var restaurant = GetRestaurantById(restaurantId);
            var cuisine = restaurantContext.Cuisines.FirstOrDefault(c => c.Id == id);
            
            cuisine.Name= updatedCuisine.Name;
            
            cuisine.Description = updatedCuisine.Description;
            
            cuisine.Position = updatedCuisine.Position;

            restaurantContext.SaveChanges();
            
        }


        private Restaurant GetRestaurantById(int restaurantId)
        {
            var restaurant = restaurantContext.Restaurants.Include(r => r.Cuisines).FirstOrDefault(r => r.Id == restaurantId);
            
            return restaurant;
        }
    }
}
