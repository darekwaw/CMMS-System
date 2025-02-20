using Cmms.Data.Enums;

namespace Cmms.Data.Models
{
    public partial class ReportDefinition : BaseEntity
    {
        public bool IsActive { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        public string XmlContent { get; set; }
        public string SqlQuery { get; set; }
        public string Parameters { get; set; }
        public ReportTypeEnum ReportType { get; set; }
    }
}
