using Cmms.Data.Models;

namespace Cmms.Dal.Interfaces
{
    public interface IReportDefinitionRepository
    {
        ReportDefinition GetById(int Id);
    }
}
