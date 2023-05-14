using System.ComponentModel.DataAnnotations.Schema;

namespace TournamentMakerApi.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TournamentId { get; set; }
        [ForeignKey(nameof(TournamentId))]
        public Tournament Tournament { get; set; }
    }
}
