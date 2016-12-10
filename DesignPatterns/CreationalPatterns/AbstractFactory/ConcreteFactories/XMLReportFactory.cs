using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.CreationalPatterns.AbstractFactory.ConcreteReportDataSources;
using DesignPatterns.CreationalPatterns.AbstractFactory.ConcreteReportViews;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.ConcreteFactories
{
    /// <summary>
    /// A factory that creates reports which rely on an XML source/service
    /// </summary>
    public class XMLReportFactory : ReportFactory
    {
        public override ReportDataSource CreateDataSource()
        {
            return new XMLDataSource();
        }

        public override ReportView CreateReportView()
        {
            return new XMLReportView();
        }
    }
}
