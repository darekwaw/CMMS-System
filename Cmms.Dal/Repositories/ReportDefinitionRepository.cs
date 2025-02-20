using Cmms.Dal.Database;
using Cmms.Dal.Interfaces;
using Cmms.Data.Models;
using System.Linq;

namespace Cmms.Dal.Repositories
{
    public class ReportDefinitionRepository : IReportDefinitionRepository
    {
        private readonly AppDbContext _context;

        public ReportDefinition GetById(int Id)
        {
            return _context.ReportDefinitions.FirstOrDefault(d => d.Id == Id);
        }
    }
}
