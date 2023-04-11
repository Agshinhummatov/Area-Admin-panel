namespace FrontToBack.Models.Pricing
{
    public class OfferPremium:BaseEntity
    {
        public string? Title { get; set; }

        public int Price { get; set; }

        public string? FeatureTheFrist { get; set; }

        public string? FeatureTheSecond { get; set; }

        public string? FeatureTheThird { get; set; }

        public string? FeatureTheForuth { get; set; }


        public string? Description { get; set; }



        public int PackageId { get; set; }

        public Package Package { get; set; }
    }
}
