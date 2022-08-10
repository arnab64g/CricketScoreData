namespace Entities
{
    public class TeamBase
    {
        public string? Country { get; set; }
        public byte[]? Flag { get; set; }
    }

    public class Team : TeamBase
    {
        public string? Group { get; set; }
    }
}