using Cmms.Core.Interfaces;
using Cmms.Dal.Interfaces;
using Cmms.Data.Models;

namespace Cmms.Core.Services
{
    public class ReportDefinitionService : IReportDefinitionService
    {
        private readonly IReportDefinitionRepository reportDefinitionRepository;

        public ReportDefinitionService(IReportDefinitionRepository reportDefinitionRepository)
        {
            this.reportDefinitionRepository = reportDefinitionRepository;
        }

        public ReportDefinition GetReportDefinitionById(int Id)
        {
            return reportDefinitionRepository.GetById(Id);
        }
    }
}
