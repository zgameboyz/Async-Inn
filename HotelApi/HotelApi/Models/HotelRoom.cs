using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApi.Models
{
    public class HotelRoom
    {

        public int Id { get; set; }

        [Required]

        public decimal Rate { get; set; }

       
        [Required]

        public bool PetFriendly { get; set; }
       
        [Required]

        public int Amenities { get; set; }
        
    }
}
