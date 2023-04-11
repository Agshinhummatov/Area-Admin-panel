namespace EntityFramework_Slider.Models
{
    public class TeamExpert:BaseEntity
    {
        public string? Image { get; set; }

        public string? Name { get; set; }

        public string? Position { get; set; }

        public int TitleId   { get; set; }
        public Title Title { get; set; }


    }
}
