using System.ComponentModel.DataAnnotations.Schema;

namespace TournamentMakerApi.Models
{
    public class Tournament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public int SportCategoryId { get; set; }
        [ForeignKey(nameof(SportCategoryId))]
        public SportCategory SportCategory { get; set; }
        public ICollection<Team> Teams { get; set; }
    }
}
