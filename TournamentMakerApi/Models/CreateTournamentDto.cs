using System.ComponentModel.DataAnnotations.Schema;

namespace TournamentMakerApi.Models
{
    public class CreateTournamentDto
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public int SportsCategoryId { get; set; }
    }
}
