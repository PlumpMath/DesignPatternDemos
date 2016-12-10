using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.CreationalPatterns.AbstractFactory.ConcreteFactories;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{

    /// <summary>
    /// Demonstrates creating and running 3 different types of reports in an application
    /// </summary>
    public class AbstractFactoryClient : IDesignPatternClient
    {
        public void ExecuteDemo()
        {
            var crystalReportEngine = new ReportEngine(new CrystalReportFactory());
            crystalReportEngine.GenerateReport();

            var sqlReportEngine = new ReportEngine(new SQLViewReportFactory());
            sqlReportEngine.GenerateReport();

            var xmlReportEngine = new ReportEngine(new XMLReportFactory());
            xmlReportEngine.GenerateReport();
        }
    }
}
