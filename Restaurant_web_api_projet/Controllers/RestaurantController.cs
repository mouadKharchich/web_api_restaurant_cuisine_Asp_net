using Abstructs;
using Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Restaurant_web_api_projet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantService restaurantService;

        public RestaurantController(IRestaurantService restaurantService)
        {
            this.restaurantService = restaurantService;
        }

        [HttpGet]
        public IActionResult GetRestaurants()
        {
            var restaurants=restaurantService.GetRestaurants();

            return Ok(restaurants);
        }

        [HttpGet("{id}")]
        public IActionResult GetRestaurant(int id)
        {
            var restaurant = restaurantService.GetRestaurant(id);

            return Ok(restaurant);
        }

        [HttpPost]
        public IActionResult CreateRestaurant(CreateRestaurantDto restaurant)
        {
           
                var newRestaurant = restaurantService.AddRestaurant(restaurant);

                return Ok(newRestaurant);
       
        }


        [HttpPut("{id}")]
        public IActionResult UpdateRestaurant(int id, CreateRestaurantDto updatedRestaurant)
        {
            restaurantService.UpdateRestaurant(id, updatedRestaurant);

            return NoContent();
            
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRestaurant(int id)
        {
            restaurantService.DeleteRestaurant(id);
            return NoContent();
        }
    }
}
