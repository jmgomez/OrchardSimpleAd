using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Security.Policy;
using System.Web;
using System.Web.Http.Routing;
using Contrib.ImageField.Fields;
using Orchard;
using Orchard.ContentManagement;
using Orchard.Core.Title.Models;
using jmgomez.CustomAds.Models;
using jmgomez.CustomAds.ViewModel;

namespace jmgomez.CustomAds.Services {
    public class AdService : IAdsService {
        private readonly IContentManager _contentManager;
       

        public AdService(IContentManager contentManager) {
            _contentManager = contentManager;
        }

        public void DeactivateAds(int idAd) {
            var activatedAds = _contentManager.List<AdPart>("Ad")
                .Where(ad => ad.Active && ad.Id!=idAd);
            foreach (var ad in activatedAds) {
                ad.Active = false;
            }
        }

        public AdViewModel GetActiveAd() {
            var adPart = _contentManager.List<AdPart>("Ad").SingleOrDefault(ad => ad.Active);
            var imageField = adPart.Fields.OfType<ImageField>().First();
            var imagePath = VirtualPathUtility.ToAbsolute(imageField.FileName); 
            var titlePart = adPart.As<TitlePart>();
            
            
            return new AdViewModel()
            {
                Title = titlePart.Title,
                Url = adPart.Url,
                ImagePath = imagePath
            };
        }
    }
}