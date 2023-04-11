namespace EntityFramework_Slider.Models
{
    public class Title:BaseEntity
    {
        public string Name { get; set; }
        public string Descripton { get; set; }

        public ICollection<Advance> Advances { get; set; }
    }
}
