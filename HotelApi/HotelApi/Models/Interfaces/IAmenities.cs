using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApi.Models.Interfaces
{
    public interface IAmenities
    {
        // CREATE
        Task<Amenities> Create(Amenities student);

        // GET ALL

        Task<List<Amenities>> GetStudents();

        // GET ONE BY ID
        Task<Amenities> GetStudent(int id);

        // UPDATE
        Task<Amenities> UpdateStudent(int id, Amenities student);

        // DELETE
        Task Delete(int id);
    }
}
