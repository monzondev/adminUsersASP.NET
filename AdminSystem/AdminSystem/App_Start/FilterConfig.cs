using System.Web;
using System.Web.Mvc;
using AdminSystem;


namespace AdminSystem
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new Controllers.Filtros.Verify());

        }
    }
}
