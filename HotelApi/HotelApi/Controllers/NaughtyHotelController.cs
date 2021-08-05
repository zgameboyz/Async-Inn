using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HotelApi.Data;
using HotelApi.Models;
using HotelApi.Models.Interfaces;

namespace HotelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NaughtyHotelController : Controller
    {
        private readonly HotelDbContext _context;
        private readonly IHotel _hotel;
        //Dependency Injection will provide me with a suitable DBContext and an instance of that Service that implements the IHotel Interface.
        public NaughtyHotelController(HotelDbContext context, IHotel hotel)
        {
            _context = context;
            _hotel = hotel;
        }

        // GET: Hotels
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Hotels.ToListAsync());
        }

        // GET: Hotels/Details/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hotel = await _context.Hotels
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hotel == null)
            {
                return NotFound();
            }

            return View(hotel);
        }

        

        // POST: Hotels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        
        public async Task<IActionResult> Create([Bind("Id,Name,StreetAddress,City,State,Country,Phone")] Hotel hotel)
        {
            if (ModelState.IsValid)
            {
                await _hotel.Create(hotel);
                return RedirectToAction(nameof(Index));
            }
            return View(hotel);
        }
        private bool HotelExists(int id)
        {
            return _context.Hotels.Any(e => e.Id == id);
        }
    }
}
