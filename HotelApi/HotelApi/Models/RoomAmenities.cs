using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApi.Models
{
    public class RoomAmenities
    {

        public int Id { get; set; }

        [Required]

        public string Name { get; set; }

       
        [Required]

        public int Layout { get; set; }
       
        [Required]

        public int Amenities { get; set; }
        
        [Required]

        public int Room { get; set; }

    }
}
