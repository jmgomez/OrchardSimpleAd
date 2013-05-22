using System.ComponentModel.DataAnnotations;
using Orchard.ContentManagement.Records;

namespace jmgomez.CustomAds.Models {
    public class AdRecord : ContentPartRecord {
        public virtual bool Active { get; set; }
        public virtual string Url { get; set; }  
    }
}