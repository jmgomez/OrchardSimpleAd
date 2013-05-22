using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using jmgomez.CustomAds.Models;

namespace jmgomez.CustomAds.Handlers {
    public class AdHandler : ContentHandler {

        public AdHandler(IRepository<AdRecord> repository ) {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}