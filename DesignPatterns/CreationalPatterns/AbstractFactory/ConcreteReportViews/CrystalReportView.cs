using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.ConcreteReportViews
{
    public class CrystalReportView : ReportView
    {
        public override void ExportToExcel()
        {
            Console.WriteLine("Exporting Crystal report to excel document");
        }

        public override void InitializeView()
        {
            Console.WriteLine("Displaying Crystal Report");
        }
    }
}
