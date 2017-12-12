using System.Web.Mvc;
using System.Web.Routing;
using SmartStore.Web.Framework.Routing;
using SmartStore.Web.Framework.WebApi;

namespace SmartStore.WebInterface
{
	public partial class RouteProvider : IRouteProvider
	{
		public void RegisterRoutes(RouteCollection routes)
		{
            routes.MapRoute("SmartStore.WebInterface.Action",
				"Plugins/SmartStore.WebInterface/{action}", 
				new { controller = "WebApi" }, 
				new[] { "SmartStore.WebInterface.Controllers" }
			)
			.DataTokens["area"] = WebApiGlobal.PluginSystemName;
		}
		public int Priority
		{
			get
			{
				return 0;
			}
		}
	}
}
