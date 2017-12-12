using SmartStore.Web.Framework.WebApi.Security;
using System.Web.Http;

namespace SmartStore.WebInterface.Controllers.Api
{
	[WebApiAuthenticate]
	public class HomeController : ApiController
	{
	}
}
