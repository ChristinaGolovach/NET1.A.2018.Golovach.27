using System.Web;
using System.Web.Mvc;

namespace NET1.A._2018.Golovach._27
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
