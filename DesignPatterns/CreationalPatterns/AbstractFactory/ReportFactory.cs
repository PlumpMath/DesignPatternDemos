using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DesignPatterns.CreationalPatterns.AbstractFactory
{

    /// <summary>
    /// This is our abstract factory which represents a family of reporting products/objects
    /// </summary>
    public abstract class ReportFactory
    {
        public abstract ReportDataSource CreateDataSource();

        public abstract ReportView CreateReportView();

    }
}
