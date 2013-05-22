using System.ComponentModel.DataAnnotations;

using Orchard.ContentManagement;

namespace jmgomez.CustomAds.Models {
    public class AdPart : ContentPart<AdRecord> {
        
        public bool Active {
            get { return this.Record.Active; }
            set { this.Record.Active = value; }
        }
       
        [Required]
        public string Url {
            get { return this.Record.Url; }
            set { this.Record.Url = value; }
        }
        
    }
}