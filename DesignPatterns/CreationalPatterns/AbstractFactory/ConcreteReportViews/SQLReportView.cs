using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.ConcreteReportViews
{
    public class SQLReportView : ReportView
    {
        public override void ExportToExcel()
        {
            Console.WriteLine("Exporting SQL View based report to excel document");
        }

        public override void InitializeView()
        {
            Console.WriteLine("Displaying SQL View based Report");
        }
    }
}
