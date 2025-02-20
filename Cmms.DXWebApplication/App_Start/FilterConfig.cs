using System.Web;
using System.Web.Mvc;

namespace Cmms.DXWebApplication {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}