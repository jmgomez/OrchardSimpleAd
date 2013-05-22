using System.ComponentModel.Design;
using System.Security.Policy;
using System.Web.UI.WebControls.WebParts;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
using jmgomez.CustomAds.Models;
using jmgomez.CustomAds.Services;

namespace jmgomez.CustomAds.Drivers {
    public class AdDriver : ContentPartDriver<AdPart> {
        private readonly IAdsService _adsService;
        //Get
        public AdDriver(IAdsService adsService) {
            _adsService = adsService;
        }

        protected override DriverResult Editor(AdPart part, dynamic shapeHelper) {

            return ContentShape("Parts_Ad_Edit",
                () => shapeHelper.EditorTemplate(
                    TemplateName: "Parts/Ad",
                    Model: part,
                    Prefix: Prefix));
        }
        //Post
        protected override DriverResult Editor(AdPart part, IUpdateModel updater, dynamic shapeHelper) {
            updater.TryUpdateModel(part, Prefix, null, null);
            if (part.Active)
                _adsService.DesactivateAds(part.Id);
            return Editor(part, shapeHelper);
        }
    }
}