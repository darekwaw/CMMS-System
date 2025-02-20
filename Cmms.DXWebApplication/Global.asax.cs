using DevExpress.DashboardWeb;
using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace Cmms.DXWebApplication
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //BundleConfig.RegisterBundles(BundleTable.Bundles); 

            GlobalConfiguration.Configure(WebApiConfig.Register);

            // Rejestracja DevExpress MVC
            ModelBinders.Binders.DefaultBinder = new DevExpressEditorsBinder();

            // Konfiguracja Dashboarda
            DashboardConfigurator.Default.SetDashboardStorage(new DashboardFileStorage(Server.MapPath("~/App_Data/Dashboards")));

            DevExpress.Web.ASPxWebControl.CallbackError += Application_Error;
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Exception exception = System.Web.HttpContext.Current.Server.GetLastError();
            //TODO: Handle Exception
        }
    }
}