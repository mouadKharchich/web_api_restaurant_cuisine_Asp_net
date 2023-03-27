using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cuisine
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; } // n 1
                                                 // 
        
        public int Position { get; set; }

        public virtual Restaurant? Restaurant { get; set; }
        public int? RestaurantId { get; set; }

    }
}
