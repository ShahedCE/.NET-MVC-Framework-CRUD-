using System.Web;
using System.Web.Mvc;

namespace Basic_Project_MVC_Framework_
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
