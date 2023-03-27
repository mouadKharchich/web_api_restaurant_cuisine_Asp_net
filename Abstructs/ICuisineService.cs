using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstructs
{
    public interface ICuisineService
    {
        List<CuisineDto> GetCuisines(int restaurantId);
        CuisineDto GetCuisine(int restaurantId,int id);

        CreateCuisineDto AddCuisine(int restaurantId,CreateCuisineDto newCuisine);

        void UpdateCuisine(int restaurantId,int id, CreateCuisineDto updatedCuisine);

        void DeleteCuisine(int restaurantId,int id);
    }
}
