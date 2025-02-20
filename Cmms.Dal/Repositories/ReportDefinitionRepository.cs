using Cmms.Dal.Interfaces;
using Cmms.Data.Models;

namespace Cmms.Dal.Repositories
{
    public class ReportDefinitionRepository : IReportDefinitionRepository
    {
        private readonly IUnitOfWork unitOfWork;

        public ReportDefinitionRepository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public ReportDefinition GetById(int Id)
        {
            return unitOfWork.ReportDefinitions.GetById(Id);
        }
    }
}
