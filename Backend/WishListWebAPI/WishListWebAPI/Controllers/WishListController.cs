using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using WishListWebAPI.Data;
using WishListWebAPI.Models;

namespace WishListWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WishListController : ControllerBase
    {
        private readonly ILogger<WishListController> _logger;
        private readonly WishListDbContext _context;

        public WishListController(ILogger<WishListController> logger, WishListDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Category>> Get()
        {
            return new List<Category>() 
            { 
                new Category() { Id = 1, Name = "First"}, 
                new Category() { Id = 2, Name = "Second" } 
            };
            //return await _context.Categories.ToListAsync();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Category category)
        {
            try
            {
                _context.Categories.Add(category);
                _context.SaveChanges();

                return Ok(category);
                                
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}