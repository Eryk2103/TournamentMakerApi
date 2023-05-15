using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TournamentMakerApi.Data;
using TournamentMakerApi.Models;

namespace TournamentMakerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SportCategoryController : Controller
    {
        private readonly AppDbContext _context;

        public SportCategoryController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SportCategory>>> GetCategories()
        {
            var categories = await _context.SportCategories.ToListAsync();
            return Ok(categories);
        }
        [HttpGet("{id}", Name ="GetCategoriesById")]
        public async Task<ActionResult<SportCategory>> GetCategoriesById(int id)
        {
            var category = await _context.SportCategories.FirstOrDefaultAsync(x => x.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }
        [HttpPost]
        public async Task<ActionResult> CreateCategory(CreateSportCategoryDto category)
        {
            var categoryModel = new SportCategory()
            {
                Id = 0,
                Name = category.Name,
            };

            _context.SportCategories.Add(categoryModel);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetCategoryById", new { id = categoryModel.Id }, categoryModel);
        }
    }
}
