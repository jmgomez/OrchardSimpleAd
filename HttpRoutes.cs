using System.Collections.Generic;
using Orchard.Mvc.Routes;
using Orchard.WebApi.Routes;

namespace jmgomez.CustomAds {
    public class HttpRoutes : IHttpRouteProvider {
        public IEnumerable<RouteDescriptor> GetRoutes() {
            return new[] {
                new HttpRouteDescriptor() {
                    Name = "Ad",
                    Priority = -10,
                    RouteTemplate = "Ad",
                    Defaults = new {
                        area = "jmgomez.CustomAds",
                        controller = "Ads"

                    }
                }

            };
        }

        public void GetRoutes(ICollection<RouteDescriptor> routes) {
            foreach (var routeDescriptor in this.GetRoutes()) 
                routes.Add(routeDescriptor);    
            
        }
    }
}