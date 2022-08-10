using Entities.Enums;

namespace Entities
{
    public class Tournament
    {
        public string? Name { get; set; }
        public string? Host { get; set; }
        public int? Year { get; set; }
        public int? NumberOfTeam { get; set; }
        public int? NumberOfGroup { get; set; }
        public Formats Format { get; set; }
        public List<Team>? Teams { get; set; }
    }
}
