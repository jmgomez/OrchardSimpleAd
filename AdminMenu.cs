using Orchard.Core.Contents;
using Orchard.Localization;
using Orchard.UI.Navigation;

namespace jmgomez.CustomAds {
    public class AdminMenu : INavigationProvider {
        public Localizer T { get; set; }

        public string MenuName
        {
            get { return "admin"; }
        }

        public void GetNavigation(NavigationBuilder builder)
        {
            builder.Add(T("Ad"), "1", BuildMenu);
        }

        private void BuildMenu(NavigationItemBuilder menu)
        {
            menu.Add(T("List"), "1.0", item =>
                item.Action("List", "Admin", new { area = "Contents", id = "Ad" }));

            menu.Add(T("New Ad"), "1.1", item =>
                item.Action("Create", "Admin", new { area = "Contents", id = "Ad" }));

        } 
    }
}