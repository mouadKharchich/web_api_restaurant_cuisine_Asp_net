﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class CreateRestaurantDto
    { 
        public string Name { get; set; }

        public string Adress { get; set; }
        public string? Description { get; set; }
    }
}
