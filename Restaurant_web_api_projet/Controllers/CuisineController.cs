using Abstructs;
using Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Restaurant_web_api_projet.Controllers
{
    [Route("api/restaurant/{restaurantId}/cuisine")]
    [ApiController]
    public class CuisineController : ControllerBase
    {
        private readonly ICuisineService cuisineService;

        public CuisineController(ICuisineService cuisineService)
        {
            this.cuisineService = cuisineService;
        }

        [HttpGet]
        public IActionResult GetCuisines(int restaurantId)
        {
            var cuisines=cuisineService.GetCuisines(restaurantId);
            return Ok(cuisines);
        }

        [HttpGet("{id}")]
        public IActionResult GetCuisine(int restaurantId, int id)
        {
            var cuisine = cuisineService.GetCuisine(restaurantId,id);
            return Ok(cuisine);
        }

        [HttpPost]
        public IActionResult CreateCuisine(int restaurantId,CreateCuisineDto cuisine)
        {
            
                var newCuisine = cuisineService.AddCuisine(restaurantId,cuisine);
                return Ok(newCuisine);
            
        }


        [HttpPut("{id}")]
        public IActionResult UpdateCuisine(int restaurantId,int id,CreateCuisineDto updatedCuisine)
        {
            cuisineService.UpdateCuisine(restaurantId,id, updatedCuisine);
            return NoContent();

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCuisine(int restaurantId,int id)
        {
            cuisineService.DeleteCuisine(restaurantId, id);   
            return NoContent();
        }
    }
}
