namespace FrontToBack.Models.About
{
    public class Team:BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<TeamMember> TeamMembers { get; set; }
    }
}
