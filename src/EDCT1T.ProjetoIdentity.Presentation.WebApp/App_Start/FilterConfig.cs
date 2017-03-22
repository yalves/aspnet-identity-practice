using System.Web;
using System.Web.Mvc;

namespace EDCT1T.ProjetoIdentity.Presentation.WebApp
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
