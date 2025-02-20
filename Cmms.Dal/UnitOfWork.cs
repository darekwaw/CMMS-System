using Cmms.Dal.Database;
using Cmms.Dal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmms.Dal
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext context;
        public IReportDefinitionRepository ReportDefinitions { get; }

        public UnitOfWork(AppDbContext context, IReportDefinitionRepository reportDefinitions)
        {
            this.context = context;
            ReportDefinitions = reportDefinitions;
        }

        public int Complete()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            context?.Dispose();
        }
    }
}
