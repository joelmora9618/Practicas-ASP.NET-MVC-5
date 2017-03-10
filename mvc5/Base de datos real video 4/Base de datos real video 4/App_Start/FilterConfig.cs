using System.Web;
using System.Web.Mvc;

namespace Base_de_datos_real_video_4
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
