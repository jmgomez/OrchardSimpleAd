using System.ComponentModel.Design;
using System.Web.Http;
using Orchard;
using Orchard.Localization;
using jmgomez.CustomAds.Models;
using jmgomez.CustomAds.Services;
using jmgomez.CustomAds.ViewModel;

namespace jmgomez.CustomsAds.Controllers {
    public class AdsController : ApiController {
        private readonly IAdsService _adsService;

        public AdsController(IAdsService adsService) {
            _adsService = adsService;
         
        }

        public AdViewModel GetAd() {
            return _adsService.GetActiveAd();
        }

      
    }
}
