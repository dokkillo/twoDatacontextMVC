using System.Web;
using System.Web.Mvc;

namespace Two_Datacontext_One_wEB
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
