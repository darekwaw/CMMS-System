using System.ComponentModel.DataAnnotations;

namespace Cmms.Data.Enums
{
    public enum ReportTypeEnum
	{
		[Display(Name ="Dashbooard")] Dashbooard = 10,
		[Display(Name ="Raport Klasyczny")] ClasicReport = 20,
		[Display(Name ="Raport Excel")] ExcelReport = 30,
		[Display(Name ="Tabela przestawna")] PivotTable = 40,
		[Display(Name ="Dokument na bazie zgłoszenia")] RequestReport = 50,
		[Display(Name = "Dokument na bazie realizacji")] ExecutionReport = 60
	}
}
