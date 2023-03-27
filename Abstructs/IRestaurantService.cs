using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstructs
{
    public interface IRestaurantService
    {
        List<RestaurantDto> GetRestaurants();
        RestaurantDto GetRestaurant(int id);

        CreateRestaurantDto AddRestaurant(CreateRestaurantDto newRestaurant);

        void UpdateRestaurant(int id,CreateRestaurantDto updatedRestaurant);

        void DeleteRestaurant(int id);

    }
}
