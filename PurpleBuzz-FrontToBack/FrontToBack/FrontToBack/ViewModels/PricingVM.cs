using FrontToBack.Models.About;
using FrontToBack.Models.Pricing;

namespace FrontToBack.ViewModels
{
    public class PricingVM
    {
        public IEnumerable<OfferStandart> OfferStandarts { get; set; }

        public IEnumerable<OfferPremium> OfferPremiums { get; set; }

        public IEnumerable<OfferPlatinum> OfferPlatinums { get; set; }


        public IEnumerable<Package> Packages { get; set; }

    }
}
