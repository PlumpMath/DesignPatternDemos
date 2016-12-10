using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.ConcreteReportDataSources
{
    public class XMLDataSource : ReportDataSource
    {
        public override void InitializeDataSource()
        {
            Console.WriteLine("DATA SOURCE: Initializing XML data source");
        }
    }
}
