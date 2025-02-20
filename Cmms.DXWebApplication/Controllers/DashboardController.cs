using Cmms.DXWebApplication.Model;
using DevExpress.DashboardCommon;
using DevExpress.DataAccess.Sql;
using System;
using System.IO;
using System.Text;
using System.Web.Mvc;

namespace Cmms.DXWebApplication.Controllers
{
    public class DashboardController : Controller
    {
        public ActionResult Viewer(Guid id)
        {
            ViewBag.DashboardId = id;
            return View();
        }

        public ActionResult GetDashboard(Guid id)
        {
            var dbDashboard = DataProvider.GetDashboard(id);

            if (dbDashboard == null)
            {
                return HttpNotFound("Dashboard not found.");
            }

            Dashboard dashboard = new Dashboard();

            // Tworzymy strumień na podstawie przechowywanego XML
            using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(dbDashboard.XmlContent)))
            {
                dashboard.LoadFromXml(stream);
                BindDashboardData(dashboard);
            }

            // Tworzymy strumień do zwrócenia dashboardu
            using (var stream = new MemoryStream())
            {
                dashboard.SaveToXml(stream);
                stream.Position = 0;
                return File(stream.ToArray(), "text/xml");
            }
        }

        private void BindDashboardData(Dashboard dashboard)
        {
            foreach (var dataSource in dashboard.DataSources)
            {
                if (dataSource.ComponentName == "MyDataSource")
                {
                    DashboardSqlDataSource sqlDataSource = new DashboardSqlDataSource("MyDataSource", "DashboardDbContext");

                    CustomSqlQuery query = new CustomSqlQuery("MyData", "SELECT TOP 10 * FROM YourTable");
                    sqlDataSource.Queries.Add(query);

                    dashboard.DataSources.Clear();
                    dashboard.DataSources.Add(sqlDataSource);
                }
            }
        }
    }
}