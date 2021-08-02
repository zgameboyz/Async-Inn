using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApi.Models.Interfaces
{
    public interface IHotel
    {
        Task<Hotel> Create(Hotel hotel);
        Task<List<Hotel>> GetAllHotels();
        Task<Hotel> GetHotel(int Id);
    }
}
