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
    /// A factory that creates reports integrating with the 3rd party crystal reports engine
    /// </summary>
    public class CrystalReportFactory : ReportFactory
    {
        public override ReportDataSource CreateDataSource()
        {
            return new CrystalDataSource();
        }

        public override ReportView CreateReportView()
        {
            return new CrystalReportView();
        }
    }
}
