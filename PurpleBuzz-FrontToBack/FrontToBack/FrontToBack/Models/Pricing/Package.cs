namespace FrontToBack.Models.Pricing
{
    public class Package:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        

        public ICollection<OfferStandart> OfferStandarts { get; set; }

        public ICollection<OfferPlatinum> offerPlatinums { get; set; }


        public ICollection<OfferPremium> OfferPremiums { get; set; }



    }
}
