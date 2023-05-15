namespace TournamentMakerApi.Models
{
    public class SportCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Tournament> Tournaments { get; set; }
    }
}
