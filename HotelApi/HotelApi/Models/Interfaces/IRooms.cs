using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApi.Models.Interfaces
{
    public interface IRooms
    {
        // CREATE
        Task<Room> Create(Room student);

        // GET ALL

        Task<List<Room>> GetStudents();

        // GET ONE BY ID
        Task<Room> GetStudent(int id);

        // UPDATE
        Task<Room> UpdateStudent(int id, Room student);

        // DELETE
        Task Delete(int id);
    }
}
