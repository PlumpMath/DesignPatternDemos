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
    /// A factory that creates reports using an external database view exposed by a RDBMS
    /// </summary>
    public class SQLViewReportFactory : ReportFactory
    {
        public override ReportDataSource CreateDataSource()
        {
            return new SQLViewDataSource();
        }

        public override ReportView CreateReportView()
        {
            return new SQLReportView();
        }
    }
}
