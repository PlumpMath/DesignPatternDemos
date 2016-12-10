using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.ConcreteReportViews
{
    public class XMLReportView : ReportView
    {
        public override void ExportToExcel()
        {
            Console.WriteLine("Exporting XML data report to excel document");
        }

        public override void InitializeView()
        {
            Console.WriteLine("Displaying XML data Report");
        }
    }
}
