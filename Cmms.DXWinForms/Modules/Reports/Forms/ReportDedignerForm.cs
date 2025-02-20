using Cmms.Data.Enums;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cmms.DXWinForms.Modules.Reports.Forms
{
    public partial class ReportDedignerForm : XtraForm
    {
        private ReportTypeEnum _reportType;

        public ReportDedignerForm(ReportTypeEnum reportType)
        {
            InitializeComponent();
            _reportType = reportType;
            InitializeDesigner();
        }

        private void InitializeDesigner()
        {
            switch (_reportType)
            {
                case ReportTypeEnum.Dashbooard:
                    LoadDashboardDesigner();
                    break;
                case ReportTypeEnum.ClasicReport:
                    break;
                case ReportTypeEnum.ExcelReport:
                    break;
                case ReportTypeEnum.PivotTable:
                    break;
                case ReportTypeEnum.RequestReport:
                    break;
                case ReportTypeEnum.ExecutionReport:
                    break;
                default:
                    break;
            }
        }

        private void LoadDashboardDesigner()
        {
            DashboardDesigner designer = new DashboardDesigner
            {
                Dock = DockStyle.Fill
            };
            Controls.Add(designer);
        }
    }
}