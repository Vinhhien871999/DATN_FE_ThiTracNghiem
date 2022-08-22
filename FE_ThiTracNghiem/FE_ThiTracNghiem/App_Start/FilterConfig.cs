using System.Web;
using System.Web.Mvc;

namespace FE_ThiTracNghiem
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
