using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    public class ReportEngine
    {
        private readonly ReportDataSource reportDataSource;
        private readonly ReportView reportView;

        public ReportEngine(ReportFactory reportFactory)
        {
            reportDataSource = reportFactory.CreateDataSource();
            reportView = reportFactory.CreateReportView();
        }

        public void GenerateReport()
        {
            reportDataSource.InitializeDataSource();
            reportView.InitializeView();
            reportView.ExportToExcel();
            Console.WriteLine("------------------------------------------------------------\n\n");
        }
    }
}
