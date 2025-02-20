using Cmms.Data.Models;

namespace Cmms.Core.Interfaces
{
    public interface IReportDefinitionService
    {
        ReportDefinition GetReportDefinitionById(int Id);
    }
}
