using System.Web;
using System.Web.Mvc;

namespace NguyenTung_2011068933
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
