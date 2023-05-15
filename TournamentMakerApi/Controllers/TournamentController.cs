using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TournamentMakerApi.Data;
using TournamentMakerApi.Models;

namespace TournamentMakerApi.Controllers
{
    [Route("api/tournament")]
    [ApiController]
    public class TournamentController : Controller
    {
        private readonly AppDbContext _context;

        public TournamentController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tournament>>> GetTournaments()
        {
            var tournaments = await _context.Tournaments.ToListAsync();
            return Ok(tournaments);
        }
        [HttpGet("{id}", Name = "GetTournamentById")]
        public async Task<ActionResult<Tournament>> GetTournamentById(int id)
        {
            var tournament = await _context.Tournaments.FirstOrDefaultAsync(x=>x.Id == id);
            if(tournament == null)
            {
                return NotFound();
            }
            return Ok(tournament);
        }
        [HttpPost]
        public async Task<ActionResult> CreateTournament(CreateTournamentDto tournament)
        {
            var tournamentModel = new Tournament()
            {
                Id = 0,
                Name = tournament.Name,
                StartDate = tournament.StartDate,
                SportCategoryId = tournament.SportsCategoryId
            };

            _context.Tournaments.Add(tournamentModel);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetTournamentById", new { id = tournamentModel.Id }, tournamentModel);
        }
    }
}
