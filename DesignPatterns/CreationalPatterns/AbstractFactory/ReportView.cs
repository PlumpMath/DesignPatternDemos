using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    /// <summary>
    /// Represents an abstraction of a report UI view
    /// </summary>
    public abstract class ReportView
    {
        public abstract void InitializeView();

        public abstract void ExportToExcel();
    }
}
