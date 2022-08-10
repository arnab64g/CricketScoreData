using Entities.Enums;

namespace Entities
{
    public class Player
    {
        public string? Name { get; set; }
        public Role? Roles { get; set; }
        public int? Run { get; set; }
        public int? BallFaced { get; set; }
        public int? Sixs { get; set; }
        public int? Fours { get; set; }
        public float? SR { get; set; }
        public string? BattingStatus { get; set; }
        public string? Over { get; set; }
        public int? Wicket { get; set; }
        public int? Madain { get; set; }
        public float? Economy { get; set; }
    }
}
