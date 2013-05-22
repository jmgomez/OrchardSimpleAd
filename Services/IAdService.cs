using Orchard;
using Orchard.Data;
using jmgomez.CustomAds.Models;
using jmgomez.CustomAds.ViewModel;

namespace jmgomez.CustomAds.Services {
    public interface IAdsService : IDependency {
        void DeactivateAds(int idAd);
        AdViewModel GetActiveAd();
    }
}