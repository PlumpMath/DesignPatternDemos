using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    /// <summary>
    /// Represents an abstraction of a data source used by a report
    /// </summary>
    public abstract class ReportDataSource
    {
        public abstract void InitializeDataSource();
    }
}
