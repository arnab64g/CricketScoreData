using Entities.Enums;

namespace Entities
{
    public class Match : ScoreBord
    {
        public string? MatchName { get; set; }
        public string? TournamentName { get; set; }
        public int? Year { get; set; }
        public Formats? Format { get; set; }
        public MatchStates? MatchState { get; set; }
        public string? Team1Name { get; set; }
        public int? Team1Score { get; set; }
        public int? Team1Wicket { get; set; }
        public int? Team1Extra { get; set; }
        public string? Team1Over { get; set; }
        public string? Team2Name { get; set; }
        public int? Team2Score { get; set; }
        public int? Team2Wicket { get; set; }
        public int? Team2Extra { get; set; }
        public string? Team2Over { get; set; }
        public bool? isdl { get; set; }
        public string? Result { get; set; }
    }

    public class ScoreBord
    {
        public List<Player>? Team1Player { get; set; }
        public List<Player>? Team2Player { get; set; }
    }
}
