using System;

namespace Cmms.Dal.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IReportDefinitionRepository ReportDefinitions { get; }
        int Complete();
    }
}
