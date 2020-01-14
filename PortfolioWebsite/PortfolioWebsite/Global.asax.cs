using System.Web.Mvc;
using System.Web.Routing;

namespace PortfolioWebsite
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // Add database initialization if it should be seeded on app startup?
        }
    }
}
