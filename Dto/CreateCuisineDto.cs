using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class CreateCuisineDto
    {
        public string Name { get; set; }
        public string? Description { get; set; } 
        public int Position { get; set; }
        //public int RestaurantId { get; set; }
    }
}
