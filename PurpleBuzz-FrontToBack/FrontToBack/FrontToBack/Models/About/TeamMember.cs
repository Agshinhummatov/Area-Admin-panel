namespace FrontToBack.Models.About
{
    public class TeamMember:BaseEntity
    {

        public string Image { get; set; }
        public string Name { get; set; }

        public string Position { get; set; }

        public int TeamId { get; set; }

        public Team MyProperty { get; set; }
    }
}
